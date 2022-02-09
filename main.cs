using System;

class Program {

  public static void Main (string[] args) {
    
    Console.WriteLine("Enter the name of item:");
    var name = Console.ReadLine();
    
    Console.WriteLine("Quantity of item?:");
    var item = Console.ReadLine();

    Console.WriteLine("Enter price?:");
    var price = Console.ReadLine();
    
    Console.WriteLine("Total price of your"); 
    Console.WriteLine(name);
    
    int x1 = Convert.ToInt32(item);
    int y1 = Convert.ToInt32(price);

    Console.WriteLine(x1*y1);

    }
}