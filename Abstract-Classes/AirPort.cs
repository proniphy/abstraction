using System;

namespace Abstract_Classes
{
    class AirPort
    {
        static void Main(string[] args)
        {
            Biplane biplane = new Biplane();
            Console.WriteLine(biplane);
            Console.WriteLine("The {0} can go up to {1} km/h ", biplane.Type, biplane.Speed);

            Console.WriteLine();

            CargoPlane cargoPlane = new CargoPlane();
            Console.WriteLine(cargoPlane);
            Console.WriteLine("The {0} can go up to {1} km/h ", cargoPlane.Type, cargoPlane.Speed);
            cargoPlane.Engines = 2;
            cargoPlane.RunAutopilot();

            ComparePlanes(cargoPlane, biplane);

            Fighter newFighter = new Fighter();
            Console.WriteLine(newFighter);
            newFighter.RunAutopilot();

        }

        static void ComparePlanes(Plane one, Plane two)
        {
            if (one.CompareTo(two) > 0)
            {
                Console.WriteLine($"{one.Type} is faster than {two.Type}");
            }
            else if(one.CompareTo(two) == 0)
            {
                Console.WriteLine("Planes are with equal speed!");
            }
            else
            {
                Console.WriteLine($"{one.Type} is slower than {two.Type}");
            }
        }
    }
}
