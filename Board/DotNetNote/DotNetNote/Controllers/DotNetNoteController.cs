using DotNetNote.Models;
using Microsoft.AspNetCore.Authorization;
using Microsoft.AspNetCore.Hosting;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using System;
using System.Collections.Generic;
using System.IO;
using System.Net.Http.Headers;
using System.Threading.Tasks;

namespace DotNetNote.Controllers
{
  public class DotNetNoteController : Controller
  {
    private IHostingEnvironment _environment;
    private INoteRepository _repository;
    private INoteCommentRepository _commentRepository;

    public DotNetNoteController(IHostingEnvironment environment,
      INoteRepository repository,
      INoteCommentRepository commentRepository)
    {
      _environment = environment;
      _repository = repository;
      _commentRepository = commentRepository;
    }
    public bool SearchMode { get; set; } = false;
    public string SearchField { get; set; }
    public string SearchQuery { get; set; }
    public int PageIndex { get; set; } = 0;
    public int TotalRecordCount { get; set; } = 0;

    public IActionResult Index()
    {
      SearchMode = (
        !string.IsNullOrEmpty(Request.Query["SearchField"]) &&
        !string.IsNullOrEmpty(Request.Query["SearchQuery"])
      );

      if (SearchMode)
      {
        SearchField = Request.Query["SearchField"].ToString();
        SearchQuery = Request.Query["SearchQuery"].ToString();
      }

      if (!string.IsNullOrEmpty(Request.Query["Page"].ToString()))
      {
        PageIndex = Convert.ToInt32(Request.Query["Page"]) - 1;
      }

      if (!string.IsNullOrEmpty(Request.Cookies["DotNetNotePageNum"]))
      {
        PageIndex = Convert.ToInt32(Request.Cookies["DotNetNotePageNum"]);
      }
      else
      {
        PageIndex = 0;
      }

      IEnumerable<Note> notes;
      if (!SearchMode)
      {
        TotalRecordCount = _repository.GetCountAll();
        notes = _repository.GetAll(PageIndex);
      }
      else
      {
        TotalRecordCount = _repository.GetCountBySearch(SearchField, SearchQuery);
        notes = _repository.GetSearchAll(PageIndex, SearchField, SearchQuery);
      }

      ViewBag.TotalRecord = TotalRecordCount;
      ViewBag.SearchMode = SearchMode;
      ViewBag.SearchField = SearchField;
      ViewBag.SearchQuery = SearchQuery;

      return View(notes);
    }

    [HttpGet]
    public IActionResult Create()
    {
      ViewBag.FormType = BoardWriteFormType.Write;
      ViewBag.TitleDescription = "글 쓰기 - 다음 필드들을 채워주세요.";
      ViewBag.SaveButtonText = "저장";

      return View();
    }

    [HttpPost]
    public async Task<IActionResult> Create(Note model, ICollection<IFormFile> files)
    {
      string fileName = string.Empty;
      int fileSize = 0;

      var uploadFolder = Path.Combine(_environment.WebRootPath, "files");

      foreach (var file in files)
      {
        if (file.Length > 0)
        {
          fileSize = Convert.ToInt32(file.Length);
          fileName = Dul.FileUtility.GetFileNameWithNumbering(
            uploadFolder, Path.GetFileName(
              ContentDispositionHeaderValue.Parse(
                file.ContentDisposition).FileName.Trim('"')));

          using (var fileStream = new FileStream(Path.Combine(uploadFolder, fileName), FileMode.Create))
          {
            await file.CopyToAsync(fileStream);
          }
        }
      }

      Note note = new Note();

      note.Name = model.Name;
      note.Email = Dul.HtmlUtility.Encode(model.Email);
      note.Homepage = model.Homepage;
      note.Title = Dul.HtmlUtility.Encode(model.Title);
      note.Content = model.Content;
      note.FileName = fileName;
      note.FileSize = fileSize;
      note.Password = model.Password;
      note.PostIp = HttpContext.Connection.RemoteIpAddress.ToString();
      note.Encoding = model.Encoding;

      _repository.Add(note);

      TempData["Message"] = "데이터가 저장되었습니다.";

      return RedirectToAction("Index");
    }

    public FileResult BoardDown(int id)
    {
      string fileName = "";
      fileName = _repository.GetFileNameById(id);
      if (fileName == null)
      {
        return null;
      }
      else
      {
        _repository.UpdateDownCountById(id);
        byte[] fileBytes = System.IO.File.ReadAllBytes(Path.Combine(
          _environment.WebRootPath, "files") + "\\" + fileName);

        return File(fileBytes, "application/octet-stream", fileName);
      }
    }

    public IActionResult Details(int id)
    {
      var note = _repository.GetNoteById(id);

      ContentEncodingType encoding = (ContentEncodingType)Enum.Parse(typeof(ContentEncodingType), note.Encoding);
      string encodedContent = "";
      switch (encoding)
      {
        case ContentEncodingType.Text:
          encodedContent = Dul.HtmlUtility.EncodeWithTabAndSpace(note.Content);
          break;
        case ContentEncodingType.Html:
          encodedContent = note.Content;
          break;
        case ContentEncodingType.Mixed:
          encodedContent = note.Content.Replace("\r\n", "<br />");
          break;
        default:
          encodedContent = note.Content;
          break;
      }
      ViewBag.Content = encodedContent;

      if (note.FileName.Length > 1)
      {
        ViewBag.FileName = string.Format(
          "<a href='/DotNetNote/BoardDown?Id={0}'>" +
          "{1}{2} / 전송수 : {3}</a>", note.Id
          , "<img src=\"/images/ext/ext_zip.gif\" border=\"0\">"
          , note.FileName, note.DownCount);

        if (Dul.BoardLibrary.IsPhoto(note.FileName))
        {
          ViewBag.ImageDown = $"<img src='/DotNetNote/ImageDown/{note.Id}'><br />";
        }
      }
      else
      {
        ViewBag.FileName = "업로드된 파일이 없습니다.";
      }

      NoteCommentViewModel vm = new NoteCommentViewModel();
      vm.NoteCommentList = _commentRepository.GetNoteComments(note.Id);
      vm.BoardId = note.Id;
      ViewBag.CommentListAndId = vm;

      return View(note);
    }

    [HttpGet]
    public IActionResult Delete(int id)
    {
      ViewBag.Id = id;
      return View();
    }

    [HttpPost]
    public IActionResult Delete(int id, string password)
    {
      if (_repository.DeleteNote(id, password) > 0)
      {
        TempData["Message"] = "데이터가 삭제되었습니다.";

        //return RedirectToAction("DeleteCompleted");
        return RedirectToAction("Index");
      }
      else
      {
        ViewBag.Message = "삭제되지 않았습니다. 비밀번호를 확인하세요.";
      }

      ViewBag.Id = id;
      return View();
    }

    public IActionResult DeleteCompleted()
    {
      //게시글 삭제 후 추가처리 구현부분
      return View();
    }

    [HttpGet]
    public IActionResult Edit(int id)
    {
      ViewBag.FormType = BoardWriteFormType.Modify;
      ViewBag.TitleDescription = "글 수정 - 아래 항목을 수정하세요.";
      ViewBag.SaveButtonText = "수정";

      var note = _repository.GetNoteById(id);

      if (note.FileName.Length > 1)
      {
        ViewBag.FileName = note.FileName;
        ViewBag.FileSize = note.FileSize;
        ViewBag.FileNamePrevious = $"기존에 업로드된 파일명 : {note.FileName}";
      }
      else
      {
        ViewBag.FileName = "";
        ViewBag.FileSize = 0;
      }

      return View(note);
    }

    [HttpPost]
    public async Task<IActionResult> Edit(Note model, ICollection<IFormFile> files,
      int id, string previousFileName = "", int previousFileSize = 0)
    {
      ViewBag.FormType = BoardWriteFormType.Modify;
      ViewBag.TitleDescription = "글 수정 - 아래 항목을 수정하세요.";
      ViewBag.SaveButtonText = "수정";
      string fileName = "";
      int fileSize = 0;

      if (previousFileName != null)
      {
        fileName = previousFileName;
        fileSize = previousFileSize;
      }

      var uploadFolder = Path.Combine(_environment.WebRootPath, "files");

      foreach (var file in files)
      {
        if (file.Length > 0)
        {
          fileSize = Convert.ToInt32(file.Length);
          fileName = Dul.FileUtility.GetFileNameWithNumbering(
            uploadFolder, Path.GetFileName(
              ContentDispositionHeaderValue.Parse(
                file.ContentDisposition).FileName.Trim('"')));
          using (var fileStream = new FileStream(Path.Combine(uploadFolder, fileName), FileMode.Create))
          {
            await file.CopyToAsync(fileStream);
          }
        }
      }

      Note note = new Note();
      note.Id = id;
      note.Name = model.Name;
      note.Email = Dul.HtmlUtility.Encode(model.Email);
      note.Homepage = model.Homepage;
      note.Title = Dul.HtmlUtility.Encode(model.Title);
      note.Content = model.Content;
      note.FileName = fileName;
      note.FileSize = fileSize;
      note.Password = model.Password;
      note.ModifyIp = HttpContext.Connection.RemoteIpAddress.ToString();
      note.Encoding = model.Encoding;

      int r = _repository.UpdateNote(note);
      if (r > 0)
      {
        TempData["Message"] = "수정되었습니다.";
        return RedirectToAction("Details", new { Id = id });
      }
      else
      {
        ViewBag.ErrorMessage = "업데이트가 되지 않았습니다. 암호를 확인하세요.";
        return View(note);
      }
    }

    [HttpGet]
    public IActionResult Reply(int id)
    {
      ViewBag.FormType = BoardWriteFormType.Reply;
      ViewBag.TitleDescription = "글 답변 - 다음 필드들을 채워주세요.";
      ViewBag.SaveButtonText = "답변";

      var note = _repository.GetNoteById(id);

      var newNote = new Note();

      newNote.Title = $"Re : {note.Title}";
      newNote.Content = $"\n\nOn {note.PostDate}, '{note.Name}' wrote:\n----------\n>" +
        $"{note.Content.Replace("\n", "\n>")}\n----------";

      return View(newNote);
    }

    [HttpPost]
    public async Task<IActionResult> Reply(Note model, ICollection<IFormFile> files, int id)
    {
      string fileName = string.Empty;
      int fileSize = 0;

      var uploadFolder = Path.Combine(_environment.WebRootPath, "files");
      foreach (var file in files)
      {
        if (file.Length > 0)
        {
          fileSize = Convert.ToInt32(file.Length);
          fileName = Dul.FileUtility.GetFileNameWithNumbering(
            uploadFolder, Path.GetFileName(
              ContentDispositionHeaderValue.Parse(
                file.ContentDisposition).FileName.Trim('"')));

          using (var fileStream = new FileStream(Path.Combine(uploadFolder, fileName), FileMode.Create))
          {
            await file.CopyToAsync(fileStream);
          }
        }
      }

      Note note = new Note();
      note.Id = note.ParentNum = Convert.ToInt32(id);
      note.Name = model.Name;
      note.Email = Dul.HtmlUtility.Encode(model.Email);
      note.Homepage = model.Homepage;
      note.Title = Dul.HtmlUtility.Encode(model.Title);
      note.Content = model.Content;
      note.FileName = fileName;
      note.FileSize = fileSize;
      note.Password = model.Password;
      note.PostIp = HttpContext.Connection.RemoteIpAddress.ToString();
      note.Encoding = model.Encoding;

      _repository.Add(note);

      TempData["Message"] = "데이터가 저장되었습니다.";

      return RedirectToAction("Index");
    }

    public FileResult ImageDown(int id)
    {
      string fileName = "";
      
      fileName = _repository.GetFileNameById(id);

      if (fileName == null)
      {
        return null;
      }
      else
      {
        string strFileName = fileName;
        string strFileExt = Path.GetExtension(strFileName);
        string strContentType = "";
        switch (strFileExt)
        {
          case ".gif":
            strContentType = "image/gif";
            break;
          case ".jpg":
            strContentType = "image/jpeg";
            break;
          case ".jpeg":
            strContentType = "image/jpeg";
            break;
          case ".png":
            strContentType = "image/png";
            break;
          default:
            strContentType = "";
            break;
        }

        _repository.UpdateDownCount(fileName);
        byte[] fileBytes = System.IO.File.ReadAllBytes(Path.Combine(_environment.WebRootPath, "files") + "\\" + fileName);

        return File(fileBytes, strContentType, fileName);
      }
    }

    [HttpPost]
    public IActionResult CommentAdd(int boardId, string txtName, string txtPassword, string txtOpinion)
    {
      NoteComment comment = new NoteComment();
      comment.BoardId = boardId;
      comment.Name = txtName;
      comment.Password = txtPassword;
      comment.Opinion = txtOpinion;

      _commentRepository.AddNoteComment(comment);

      return RedirectToAction("Details", new { Id = boardId });
    }

    [HttpGet]
    public IActionResult CommentDelete(string boardId, string id)
    {
      ViewBag.BoardId = boardId;
      ViewBag.Id = id;

      return ViewBag();
    }

    [HttpPost]
    public IActionResult CommentDelete(string boardId, string id, string txtPassword)
    {
      if (_commentRepository.GetCountBy(Convert.ToInt32(boardId), Convert.ToInt32(id), txtPassword) > 0)
      {
        _commentRepository.DeleteNoteComment(Convert.ToInt32(boardId), Convert.ToInt32(id), txtPassword);

        return RedirectToAction("Details", new { Id = boardId });
      }

      ViewBag.BoardId = boardId;
      ViewBag.Id = id;
      ViewBag.ErrorMessage = "암호가 틀립니다. 다시 입력해주세요.";

      return View();
    }

    [HttpGet]
    //[Authorize("Administrators")]
    public IActionResult Pinned(int id)
    {
      _repository.Pinned(id);

      return RedirectToAction("Details", new { Id = id });
    }

    public IActionResult NoteServiceDemo()
    {
      return View();
    }
    public IActionResult NoteCommentServiceDemo()
    {
      return View();
    }
  }
}
