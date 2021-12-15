using Microsoft.AspNetCore.Mvc;
using ToDoList.Models;
using System.Collections.Generic;

namespace ToDoList.Controllers
{
  public class ItemsController : Controller
  {

    [HttpGet("/items")]
    public ActionResult Index()
    {
      List<Item> allItems = Item.GetAll();
      return View(allItems);
    }

    [HttpGet("/items/new")]
    public ActionResult New()
    {
      return View();
    }

    [HttpPost("/items")]
    public ActionResult Create(string description)
    {
      Item myItem = new Item(description);
      return RedirectToAction("Index");
    }
    [HttpPost("/items/delete")]
    public ActionResult DeleteEVERYTHING()
    {
      Item.ClearAll();
      return View();
    }
    [HttpGet("items/{id}")]
    public ActionResult Show(int id)
    {
      Item FoundItem = Item.Find(id);
      return View(FoundItem);
    }
    [HttpPost("items/{id}")]
    public ActionResult Destroy(int id)
    {
      Item.Remove(id-1);
      return View();
    }
  }
}