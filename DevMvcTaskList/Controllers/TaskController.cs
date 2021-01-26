using DevMvcTaskList.Models;
using System.Web.Mvc;

namespace DevMvcTaskList.Controllers
{
  public class TaskController : Controller
  {
    private TaskRepository repo = new TaskRepository();
    // GET: Task
    public ActionResult Index()
    {
      var r = repo.GetTasks();
      return View(r);
    }
    public ActionResult Create()
    {
      return View();
    }

    [HttpPost]
    public ActionResult CreateProcess(string title)
    {
      repo.AddTask(new TaskModel { Title = title });
      return RedirectToAction("Index");
    }

    public ActionResult Complete(int id)
    {
      repo.CompleteTask(id);
      return RedirectToAction("Index");
    }
  }
}