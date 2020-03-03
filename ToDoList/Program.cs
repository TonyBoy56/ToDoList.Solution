using System;
using System.Collections.Generic;
using ToDoList.Models;
using ToDoList.Views;

namespace ToDoList
{
  class Program
  {
    public static void Main()
    {
      Console.WriteLine("Welcome to To Do.");
      Console.WriteLine("A list app just for you.");
      Console.WriteLine("Would you like to [A] add or [V] view?");
      Console.Write("Enter : ");
      string input = Console.ReadLine().ToLower();

      if (input == "a")
      {
        //add to list
        AddItem();
      }
      else if (input == "v")
      {
        //show list
        ShowList();
      }
      else if (input == "q")
      {
        Console.WriteLine("Good Bye");
      }
      else
      {
        Console.WriteLine("That was not an option");
        Main();
      }

    }

    private static void AddItem()
    {
      Console.Clear();
      ListView.AddListMenu();
      string input = Console.ReadLine();
      Item item = new Item(input); //Create New List Item

      Console.WriteLine();
      ListView.Show();

      MenuOptions();

    }
    private static void ShowList()
    {
      ListView.Show();
      MenuOptions();
    }

    private static void RemoveItem()
    {

      ListView.Show();
      Console.WriteLine("Which number would you like to remove?");
      int number = int.Parse(Console.ReadLine());
      Item.RemoveItem(number);
      Console.WriteLine($"Item {number} was removed!");

      MenuOptions();


    }

    private static void UpdateItems()
    {
      ListView.Show();
      Console.WriteLine("What Item would you like to update?");
      int number = int.Parse(Console.ReadLine());

      Console.WriteLine("Enter your new Item Detail?");
      string detail = Console.ReadLine();
      List<Item> list = Item.GetAll();

      Item.UpdateItem((number - 1), detail);
      Console.WriteLine($"Your Item at {number} has neen updated to {list[number - 1].Description}");

      MenuOptions();
    }
    private static void MenuOptions()
    {
      ListView.ListMenu();
      string option = Console.ReadLine().ToLower();

      if (option == "a")
      {
        AddItem();
      }
      else if (option == "m")
      {
        Main();
      }
      else if (option == "r")
      {
        RemoveItem();
      }
      else if (option == "u")
      {
        UpdateItems();
      }
      else if (option == "v")
      {
        ShowList();
      }
      else
      {
        Main();
      }

    }


  }
}