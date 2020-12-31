using System;

namespace DevUniclass
{
    class Program
    {
        static void Main(string[] args)
        {
            Car myCar = new Car();
            myCar.Make = "Lexus";
            myCar.Model = "RX350";
            myCar.Year = 2013;
            myCar.Color = "Silver";

           Console.WriteLine("{0} {1} {2} {3}", myCar.Make, myCar.Model, myCar.Year, myCar.Color);
            
            decimal value = DetermineMarketValue(myCar);
            Console.WriteLine("{0:C}", value);          

        }
        private static decimal DetermineMarketValue(Car car)
        {
            decimal carValue = 2000.0M;
            return carValue;
        }
    }
    class Car
     {
         public string Make { get; set; }
         public string Model { get; set; }
         public int Year { get; set; }
         public string Color { get; set;}
         
        
    }
}
