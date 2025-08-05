using System;

namespace InheritanceMethodOverriding
{
    class Animal 
    {
        public virtual void MakeSound()
        {
            Console.WriteLine("Some Generic Sound");
        }
    }


    class Dog:Animal
    {
        public override void MakeSound()
        {
            Console.WriteLine("Bark");
        }
    }

    class Cat:Animal
    {
        public override void MakeSound()
        {
            Console.WriteLine("Meow");
        }
    }


    class Program
    {
        static void Main(string[] args)
        {
            Animal genericAnimal = new Animal();
            genericAnimal.MakeSound();

            Dog myDog = new Dog();
            myDog.MakeSound();


            Cat myCat = new Cat();
            myCat.MakeSound();
        }
        
    }
} 