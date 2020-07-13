using System;

class GroceryList
{
  static void Main()
  {
    string[] myGroceryList = {"eggs", "milk", "bread", "bananas", "cereal", "rice", "yogurt"};

    Console.WriteLine("My grocery list:");

    foreach (string groceryItem in myGroceryList)
    {
      Console.WriteLine(groceryItem);
    }
  }
}