using Microsoft.AspNetCore.Mvc;
using ToDoList.Models;

namespace ToDoList.Controllers
{
  public class HomeController : Controller
  {
    [Route("/")]
    public ActionResult Index()
    {
      Item startItem = new Item("Add first item to To Do List");
      return View(startItem);
    }

    [Route("/items/new")]
    public ActionResult CreateForm()
    {
      return View();
    }
    // Tells our controller what to do when the user submits the form. //
    // View method is using overloaded constructors under the hood. This makes it capable of accepting as many arguments as we need. //
    [Route("/items")]
    public ActionResult Create(string description)
    {
      Items myItem = new Item(description);
      return View("Index", myItem);
    }
  }
}