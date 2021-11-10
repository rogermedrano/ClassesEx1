using System;

namespace Car
{
    class Program
    {
        static void Main(string[] args)
           
            //CLASSES EXERCISE:  CARS

            //In the Car class: Create a Make property of type string that is public
                                //Create a Model property of type string that is public
                                //Create a Year property of type int that is public

        {
            var firstCar = new Car();

            //another way to script the above line:  Car firstCar = new Car();
            firstCar.Make = "Ford";
            firstCar.Model = "Explorer";
            firstCar.Year = 2004;
            Console.WriteLine($"Make: {firstCar.Make}");
            Console.WriteLine($"Model: {firstCar.Model}");
            Console.WriteLine($"Year: {firstCar.Year}");
        }
    }
}
