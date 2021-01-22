using System;

namespace SOLID_Labb
{
    class Program
    {
        static void Main(string[] args)
        {
            Animal[] animals = animalColor();

            Console.WriteLine("###############");
            Console.WriteLine();

            Temp(animals);

            Console.WriteLine("###############");
            Console.WriteLine();

        }

        static Animal[] animalColor()
        {
            Animal[] animals = {new Dog("Black"),
                            new Hedgehog("Pink"),
                            new Bird("Yellow")};

            return animals;
        }

        static void Temp(Animal[] animals)
        {
            foreach (var animal in animals)
            {
                if (animal is Dog dog)
                {
                    dog.TransferOwnership("Niklas");
                }
                Text(animal);
            }
        }    

        static void Text(Animal animal)
        {
            animal.Eat();
            animal.Sleep();
            animal.Speak();
            animal._color = "Grey";
            Console.WriteLine(animal.GetType().Name + " is " + animal._color);
            Console.WriteLine();

        }
    }


}
