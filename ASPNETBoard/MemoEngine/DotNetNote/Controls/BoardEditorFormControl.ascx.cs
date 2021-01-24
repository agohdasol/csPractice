using System;
using System.IO;
using DotNetNote.Models;
using Dul;

namespace MemoEngine.DotNetNote.Controls
{
  public partial class BoardEditorFormControl : System.Web.UI.UserControl
  {
    public BoardWriteFormType FormType { get; set; }
    private string _Id;
    private string _BaseDir = String.Empty;
    private string _FileName = String.Empty;
    private int _FileSize = 0;
    protected void Page_Load(object sender, EventArgs e)
    {
      _Id = Request.QueryString["Id"];
      if (!Page.IsPostBack)
      {
        switch (FormType)
        {
          case BoardWriteFormType.Write:
            LblTitleDecription.Text = "글쓰기 - 다음 필드들을 채워주세요.";
            break;
          case BoardWriteFormType.Modify:
            LblTitleDecription.Text = "글 수정 - 아래 항목을 수정하세요.";
            DisplayDataForModify();
            break;
          case BoardWriteFormType.Reply:
            LblTitleDecription.Text = "글 답변 - 다음 필드들을 채워주세요.";
            DisplayDataForReply();
            break;
        }
      }
    }
    private void DisplayDataForModify()
    {
      var note = (new NoteRepository()).GetNoteById(Convert.ToInt32(_Id));

      TxtName.Text = note.Name;
      TxtEmail.Text = note.Email;
      TxtHomepage.Text = note.Homepage;
      TxtTitle.Text = note.Title;
      TxtContent.Text = note.Content;

      string strEncoding = note.Encoding;
      if (strEncoding == "Text")
      {
        RdoEncoding.SelectedIndex = 0;
      }
      else if (strEncoding == "Mixed")
      {
        RdoEncoding.SelectedIndex = 2;
      }
      else
      {
        RdoEncoding.SelectedIndex = 1;
      }
      if (note.FileName.Length > 1)
      {
        ViewState["FileName"] = note.FileName;
        ViewState["FileSize"] = note.FileSize;

        PnlFile.Height = 50;
        LblFileNamePrevious.Visible = true;
        LblFileNamePrevious.Text = $"기존에 업로드된 파일명 : {note.FileName}";
      }
      else
      {
        ViewState["FileName"] = "";
        ViewState["FileSize"] = 0;
      }
    }
    private void DisplayDataForReply()
    {
      var note = (new NoteRepository()).GetNoteById(Convert.ToInt32(_Id));

      TxtTitle.Text = $"Re : {note.Title}";
      TxtContent.Text = $"\n\nOn {note.PostDate}, '{note.Name}' wrote:\n----------\n>"
        + $"{note.Content.Replace("\n", "\n>")}\n----------";
    }
    protected void BtnWrite_Click(object sender, EventArgs e)
    {
      if (IsImageTextCorrect())
      {
        UploadProcess();
        Note note = new Note();
        note.Id = Convert.ToInt32(_Id);
        note.Name = TxtName.Text;
        note.Email = HtmlUtility.Encode(TxtEmail.Text);
        note.Homepage = TxtHomepage.Text;
        note.Content = TxtContent.Text;
        note.FileName = _FileName;
        note.FileSize = _FileSize;
        note.Password = TxtPassword.Text;
        note.PostIp = Request.UserHostAddress;
        note.Encoding = RdoEncoding.SelectedValue;

        NoteRepository repository = new NoteRepository();

        switch (FormType)
        {
          case BoardWriteFormType.Write:
            repository.Add(note);
            Response.Redirect("BoardList.aspx");
            break;
          case BoardWriteFormType.Modify:
            note.ModifyIp = Request.UserHostAddress;
            note.FileName = ViewState["FileName"].ToString();
            note.FileSize = Convert.ToInt32(ViewState["FileSize"]);
            int r = repository.UpdateNote(note);
            if (r > 0)
            {
              Response.Redirect($"BoardView.aspx?Id={_Id}");
            }
            else
            {
              LblError.Text = "업데이트가 되지 않았습니다. 암호를 확인하세요.";
            }
            break;
          case BoardWriteFormType.Reply:
            note.ParentNum = Convert.ToInt32(_Id);
            repository.ReplyNote(note);
            Response.Redirect("BoardList.aspx");
            break;
          default:
            repository.Add(note);
            Response.Redirect("BoardList.aspx");
            break;
        }
      }
      else
      {
        LblError.Text = "보안코드가 틀립니다. 다시 입력하세요.";
      }
    }
    private void UploadProcess()
    {
      _BaseDir = Server.MapPath("./MyFiles");
      _FileName = String.Empty;
      _FileSize = 0;
      if (TxtFileName.PostedFile != null)
      {
        if(TxtFileName.PostedFile.FileName.Trim().Length>0 && TxtFileName.PostedFile.ContentLength > 0)
        {
          if (FormType == BoardWriteFormType.Modify)
          {
            ViewState["FileName"] = 
              FileUtility.GetFileNameWithNumbering(_BaseDir, Path.GetFileName(TxtFileName.PostedFile.FileName));
            ViewState["FileSize"] = TxtFileName.PostedFile.ContentLength;
            TxtFileName.PostedFile.SaveAs(Path.Combine(_BaseDir, ViewState["FileName"].ToString()));
          }
          else
          {
            _FileName = FileUtility.GetFileNameWithNumbering(_BaseDir, Path.GetFileName(TxtFileName.PostedFile.FileName));
            _FileSize = TxtFileName.PostedFile.ContentLength;
            TxtFileName.PostedFile.SaveAs(Path.Combine(_BaseDir, _FileName));
          }
        }
      }
    }
    private bool IsImageTextCorrect()
    {
      if (Page.User.Identity.IsAuthenticated)
      {
        return true;
      }
      else
      {
        if (Session["ImageText"] != null)
        {
          return (TxtImageText.Text == Session["ImageText"].ToString());
        }
      }
      return false;
    }
    protected void ChkUpload_CheckedChanged(object sender, EventArgs e)
    {
      PnlFile.Visible = !PnlFile.Visible;
    }
  }
}