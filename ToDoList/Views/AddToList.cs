using System;
using ToDoList.Models;
using System.Collections.Generic;

namespace ToDoList.Views
{
  public class ListView
  {
    public static void Show()
    {
      List<Item> toDoList = Item.GetAll();
      for (int i = 0; i < toDoList.Count; i++)
      {
        Console.WriteLine($" {i + 1}. {toDoList[i].Description}  ");
      }

    }

    public static void AddListMenu()
    {
      Console.WriteLine("Enter A thing you want to do!");
      Console.Write("Enter : ");
    }

    public static void ListMenu()
    {
      Console.WriteLine(@"

      Add another Item [A] 
      Main menu [M]
      Update [U]
      View [V]
      Remove [R]

        ");
      Console.Write("Enter : ");
    }
  }

}