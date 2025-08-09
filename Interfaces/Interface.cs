using System;

interface IMovable
{
    void Move();
}

class Car:IMovable
{
   public void Move()
   {
    Console.WriteLine("Car is moving");
   }
}

class Bicycle:IMovable
{
    public void Move()
    {
        Console.WriteLine("Bicycle is moving");
    }
}

class Program
{
    public static void Main(string[] args)
    {
        Car myCar = new Car();

        Bicycle myBicycle = new Bicycle();


        myCar.Move();

        myBicycle.Move();

        Console.WriteLine("\n--- Demonstrating with a list of IMovable ---");
        var movables = new IMovable[] { new Car(), new Bicycle() };

        foreach (var item in movables)
        {
            
            item.Move();
        }
    }
}