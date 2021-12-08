using System;
using System.Collections.Generic;
using ToDoList.Models;

namespace ToDoList
{
  public class Program
  {
    public static void AddEntry()
    {
      Console.WriteLine("=========================");
      Console.WriteLine("Please enter the description for the new item.");
      string listItem = Console.ReadLine();
      new Item(listItem);
      Console.WriteLine("Your entry has been added to the ToDoList.");
      Console.WriteLine("=========================");
      Console.WriteLine(" ");
      Program.Main();
    }

    public static void ViewEntry()
    {
      List<Item> viewList = Item.GetAll();
      Console.WriteLine("=========================");
      foreach(Item adsf in viewList)
      {
        Console.WriteLine(" - " + adsf.Description);
      }
      Console.WriteLine("=========================");
      Console.WriteLine("press any key to continue");
      Console.ReadKey();
      Console.WriteLine("=========================");
      Program.Main();
    }
    public static void Main()
    {
      Console.WriteLine("Welcome to the To Do List");
      Console.WriteLine("Would you like to add an item to your list or view your list? (Add/View)");
      string addView = Console.ReadLine().ToUpper();
      if(addView == "ADD")
      {
        Program.AddEntry();
      } else if(addView == "VIEW")
      {
        Program.ViewEntry();
      } else{
        Console.WriteLine("That wasn't one of the options ya dingbag!");
        Program.Main();
      }

    }
  }
}