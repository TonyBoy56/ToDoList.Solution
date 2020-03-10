using System.Collections.Generic;

namespace ToDoList.Models
{
  public class Item
  {
    public string Description { get; set; }
    public string Priority { get; set; }
    private static List<Item> _instances = new List<Item> { };

    public Item(string description)
    {
      Description = description;
      _instances.Add(this);
    }

    public Item(string description, string priority)
      : this(description)
    {
      Priority = priority;
    }

    public static List<Item> GetAll()
    {
      return _instances;
    }

    public static void ClearAll()
    {
      _instances.Clear();
    }

    public static void RemoveItem(int index)
    {
      _instances.RemoveAt(index);

    }
    public static void UpdateItem(int index, string input)
    {
      _instances[index].Description = input;

    }
  }
}