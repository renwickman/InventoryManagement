using System;
using System.Collections.Generic;


public class InventoryManagement
{
  public static void Main(string[] args){
    // Your code goes here
    List<string> inventoryList = new List<string>();
    inventoryList.Add("Printer");
    inventoryList.Add("Laptop");
    inventoryList.Add("Desk Chair");
    inventoryList.Add("Monitor");
    inventoryList.Add("Keyboard");

    Console.WriteLine(inventoryList.Count);

    Console.WriteLine("");

    bool hasDeskChair = inventoryList.Contains("Desk Chair");

    Console.WriteLine("");

    Console.WriteLine(hasDeskChair);

    Console.WriteLine("");

    inventoryList.Remove("Printer");

    foreach (string s in inventoryList){
      Console.WriteLine(s);
    }


    Console.WriteLine("");

    List<string> newItems = new List<string>{ "Mouse", "Desk Lamp" };
    inventoryList.AddRange(newItems);
    Console.WriteLine(inventoryList.Count);
    inventoryList.RemoveRange(4, 2);

    Console.WriteLine("");

    foreach (string s in inventoryList){
      Console.WriteLine(s);
    }

    Console.WriteLine("");
    
    List<string> topInventory = inventoryList.GetRange(0, 3);
    foreach (string t in topInventory){
      Console.WriteLine(t);
    }

  } 
}