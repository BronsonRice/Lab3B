using System;

class Program {
  public static void Main (string[] args) {
    Console.WriteLine ("Enter salesperson name");
    var input = Console.ReadLine(); 
    string name = Convert.ToString(input);
    Console.WriteLine("Enter sales amount");
    double salesamount;
    salesamount = Convert.ToDouble(Console.ReadLine());
    double salescomission = 200 + (0.09 * salesamount);
    Console.WriteLine("Sales commsion for " + name + " is " + salescomission );
    



    if(salesamount<3000)
  {
    Console.WriteLine("Peformance is poor");
  }
   if(salesamount<5000)
  {
    Console.WriteLine("Peformance is average");
  }
  if(salesamount<15000)
  {
    Console.WriteLine("Peformance is excellent");
  }

  if(salesamount>15000)
  {
    Console.WriteLine("Peformance is outstanding");
  }

 

 }
}


  