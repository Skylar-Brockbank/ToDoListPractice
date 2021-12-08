using Microsoft.VisualStudio.TestTools.UnitTesting;
using ToDoList.Models;

namespace ToDoList.Tests
{
  [TestClass]
  public class ItemTests
  {
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
  }
}