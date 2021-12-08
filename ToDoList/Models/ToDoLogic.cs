using System.Collections.Generic;

namespace ToDoList.Models
{
  public class Item
  {
    public string Description { get; set; }
    public static List<Item> _itemList = new List<Item>{};
    public Item(string description){
      Description = description;
      _itemList.Add(this);
    }
    public static List<Item> GetAll()
    {
      return _itemList;
    }
    public static void ClearAll()
    {
      _itemList.Clear();
    }
  }
}