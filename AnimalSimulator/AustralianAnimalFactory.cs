using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace AnimalSimulator
{
    /// <summary>
    /// This class is responsible for creating a 
    /// Australian animal factory.
    /// </summary>
    class AustralianAnimalFactory:IAnimalFactory
    {
        public AustralianAnimalFactory()
        {

        }

        /// <summary>
        /// This method creates animals specific to Australia, 
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
                    animal = new Kangaroo();
                    break;
                case 1:
                    animal = new Koala();
                    break;
                case 2:
                    animal = new Platypus();
                    break;
            }

            return animal;

        }
    }
}
