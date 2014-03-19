using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace AnimalSimulator
{
    /// <summary>
    /// This class is responsible for creating a 
    /// North American animal factory.
    /// </summary>
    class NorthAmericanAnimalFactory:IAnimalFactory
    {
        public NorthAmericanAnimalFactory()
        {
        }

        /// <summary>
        /// This method creates animals specific to North America, 
        /// using a given integer code as defined.
        /// </summary>
        /// <param name="animalCode">The animal code to create a given animal.</param>
        /// <returns></returns>
        public Animal createAnimal(int animalCode)
        {
            Animal animal = null;
            switch (animalCode)
            {
                case 0:
                    animal = new Bison();
                    break;
                case 1:
                    animal = new Eagle();
                    break;
                case 2:
                    animal = new Wolf();
                    break;
            }

            return animal;

        }
    }
}
