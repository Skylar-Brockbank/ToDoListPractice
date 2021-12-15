using System.Collections.Generic;

namespace ToDoList.Models
{
  public class Item
  {
    public string Description { get; set; }
    public int Id { get; }
    public static List<Item> _itemList = new List<Item>{};
    public Item(string description){
      Description = description;
      _itemList.Add(this);
      Id = _itemList.Count;
    }
    public static List<Item> GetAll()
    {
      return _itemList;
    }
    public static void ClearAll()
    {
      _itemList.Clear();
    }
    public static Item Find(int ItemId)
    {
      return _itemList[ItemId-1];
    }
    public static void Remove(int ItemId)
    {
      _itemList.RemoveAt(ItemId);
    }
  }
}