using Microsoft.VisualStudio.TestTools.UnitTesting;
using ToDoList.Models;
using System.Collections.Generic;
using System;

namespace ToDoList.Tests
{
  [TestClass]
  public class ItemTests : IDisposable
  {
    public void Dispose()
    {
      // Item.ClearAll();
    }
    [TestMethod]
    public void ItemConstructor_DoesMakesItemsFrumClass_Thing()
    {
      Item newItem = new Item("Bannanas");
      Assert.AreEqual(typeof(Item), newItem.GetType());
    }
    [TestMethod]
    public void GetDescription_ReturnsCorrectItemDescription_String()
    {
      string description = "Reverse the polarity of the neutron flow";
      Item newItem = new Item(description);
      string result = newItem.Description;
      Assert.AreEqual(description,result);
    }

    [TestMethod]
    public void SetDescription_ReWriteHistoryToFavorTheVictor_String()
    {
      string description = "Save your father from execution";
      Item newItem = new Item(description);
      string updatedQuest = "Avenge your father";
      newItem.Description = updatedQuest;
      Assert.AreEqual(updatedQuest, newItem.Description);
    }

    [TestMethod]
    public void GetAll_ReturnsEmptyList_ItemList()
    {
      List<Item> newList = new List<Item>{};
      CollectionAssert.AreEqual(newList, Item.GetAll());
    }
    [TestMethod]
    public void GetAll_ReturnsItems_ItemList()
    {
      string d1 = "Storm the Castle";
      string d2 = "Save your father";
      string d3 = "???";
      string d4 = "profit?";
      Item ni1 = new Item(d1);
      Item ni2 = new Item(d2);
      Item ni3 = new Item(d3);
      Item ni4 = new Item(d4);
      List<Item> newList = new List<Item> { ni1,ni2,ni3,ni4 };

      CollectionAssert.AreEqual(newList, Item.GetAll());
    }
    [TestMethod]
    public void GetAll_ReturnstoConsole_ItemList()
    {
      string d1 = "Storm the Castle";
      string d2 = "Save your father";
      string d3 = "???";
      string d4 = "profit?";
      Item ni1 = new Item(d1);
      Item ni2 = new Item(d2);
      Item ni3 = new Item(d3);
      Item ni4 = new Item(d4);
      List<Item> newList = new List<Item> { ni1,ni2,ni3,ni4 };

      Console.WriteLine("Here's your to do list");
      Console.WriteLine("======================");
      foreach(Item thing in newList){
        Console.WriteLine("- " + thing.Description);
      }
      CollectionAssert.AreEqual(newList, Item.GetAll());
    }
  }
}