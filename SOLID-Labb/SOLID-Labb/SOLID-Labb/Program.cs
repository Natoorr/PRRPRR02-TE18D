using System;

namespace SOLID_Labb
{
    class Program
    {
        static void Main(string[] args)
        {
            Animal[] animals = AnimalColor();

            Console.WriteLine("###############");
            Console.WriteLine();
            
            foreach (var animal in animals)
            {
                AnimalText(animal);
            }

            Console.WriteLine("###############");
            Console.WriteLine();

        }

        static Animal[] AnimalColor()
        {
            Animal[] animals = {new Dog("Black"),
                            new Hedgehog("Pink"),
                            new Bird("Yellow")};

            return animals;
        }    

        static void AnimalText(Animal animal)
        {
            if (animal is Dog dog)
            {
                dog.TransferOwnership("Niklas");
            }

            animal.Eat();
            animal.Sleep();
            animal.Speak();
            animal._color = "Grey";
            Console.WriteLine(animal.GetType().Name + " is " + animal._color);
            Console.WriteLine();

        }
    }


}
