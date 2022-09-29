using System;

namespace Inheritance
{
    class Program
    {
        static void Main(string[] args)
        {
            // TODO Be sure to follow best practice when creating your classes

            // Create a class Animal
            // give this class 4 members that all Animals have in common


            // Create a class Bird
            // give this class 4 members that are specific to Bird
            // Set this class to inherit from your Animal Class

            // Create a class Reptile
            // give this class 4 members that are specific to Reptile
            // Set this class to inherit from your Animal Class




            /*Create an object of your Bird class
             *  give values to your members using the object of your Bird class
             *  
             * Creatively display the class member values 
             */

            /*Create an object of your Reptile class
             *  give values to your members using the object of your Reptile class
             *  
             * Creatively display the class member values 
             */
            
            Bird bird1 = new Bird()
            {
                Name = "Osprey",
                Vertebrae = true,
                NumberOFLegs = 2,
                Diet = "Mainly fish",
                Feathered = true,
                CanFly = true,
                Habitat = "Anywhere near water",
                EggColor = "Creamy-white to a pinkish-cinnamon, and eggs usually are marked with reddish browns spots"
            };

            Reptile reptile1 = new Reptile();

            reptile1.Name = "Blue iguana, AKA (the Grand Cayman ground iguana, Grand Cayman blue iguana or Cayman Island rock iguana)";
            reptile1.Vertebrae = true;
            reptile1.NumberOFLegs = 4;
            reptile1.Diet = "Primarily herbivorous (occasionally small crustaceans and insects)";
            reptile1.ColdBlooded = true;
            reptile1.Amphibious = false;
            reptile1.Venomous = "mildly";
            reptile1.Scales = "dusky-blue to gray with cross bands that are often barely visible, more vivid during mating season";
        }
    }
}
