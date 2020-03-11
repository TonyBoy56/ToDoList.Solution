using System;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using System.Collections.Generic;
using ToDoList.Models;

namespace ToDoList.Tests
{
  [TestClass]
  public class ItemTests : IDisposable
  {
    public void Dispose()
    {
      Item.ClearAll();
    }
    [TestMethod]
    public void ItemConstructor_CreatesInstanceOfItem_Item()
    {
      Item newItem = new Item("test");
      Assert.AreEqual(typeof(Item), newItem.GetType());
    }
    [TestMethod]
    public void GetDescription_ReturnsDescription_String()
    {
      string description = "Walk the dog.";
      Item newItem = new Item(description);
      string result = newItem.Description;
      Assert.AreEqual(description, result);
    }
    [TestMethod]
    public void SetDescription_SetDescription_String()
    {
      string description = "Walk the dog.";
      Item newItem = new Item(description);
      string updatedDescription = "Do Dishes";
      newItem.Description = updatedDescription;
      string result = newItem.Description;
      Assert.AreEqual(updatedDescription, result);
    }
    [TestMethod]
    public void GetAll_ReturnsEmptyList_ItemList()
    {
      List<Item> newList = new List<Item> { };
      List<Item> result = Item.GetAll();
      foreach (Item thisItem in result)
      {
        Console.WriteLine("Output from empty list GetAll test: " + thisItem.Description);
      }
      CollectionAssert.AreEqual(newList, result);
    }
    [TestMethod]
    public void GetAll_ReturnsItems_ItemList()
    {
      string description01 = "Walk the dog";
      string description02 = "Wash the dishes";
      Item newItem1 = new Item(description01);
      Item newItem2 = new Item(description02);
      List<Item> newList = new List<Item> { newItem1, newItem2 };
      List<Item> result = Item.GetAll();
      foreach (Item thisItem in result)
      {
        Console.WriteLine("Output from second GetAll test: " + thisItem.Description);
      }
      CollectionAssert.AreEqual(newList, result);
    }
    [TestMethod]
    public void RemoveItem()
    {
      string description01 = "Walk the dog";
      string description02 = "Wash the dishes";
      Item newItem1 = new Item(description01);
      Item newItem2 = new Item(description02);
      Item.RemoveItem(0);

      List<Item> newList = new List<Item> { newItem2 };

      List<Item> result = Item.GetAll();



      CollectionAssert.AreEqual(newList, result);
    }

    [TestMethod]
    public void UpdateItem_UpdatesItems_ItemList()
    {
      string description01 = "Walk the dog";

      Item newItem1 = new Item(description01);

      Item.UpdateItem(0, "Hello there.");


      List<Item> result = Item.GetAll();



      Assert.AreEqual("Hello there.", result[0].Description);
    }

    [TestMethod]
    public void GetId_ItemsInstantiateWithAnIdAndGetterReturns_()
    {
      // Arrange //
      string description = "Walk the dog.";
      Item newItem = new Item(description);
      // Act //
      int result = newItem.Id;
      // Assert //
      Assert.AreEqual(1, result);
    }

    [TestMethod]
    public void Find_ReturnsCorrectItem_Item()
    {
      // Arrange //
      string description01 = "Walk the dog";
      string description02 = "Wash the dishes";
      Item newItem1 = new Item(description01);
      Item newItem2 = new Item(description02);
      // Act //
      Item result = Item.Find(2);
      // Assert //
      Assert.AreEqual(newItem2, result);
    }


  }
}