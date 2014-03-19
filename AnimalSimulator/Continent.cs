using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Windows.Forms;
using System.Drawing;

namespace AnimalSimulator
{
    /// <summary>
    /// This class is responsible for the creation of 
    /// continents.
    /// </summary>
    public abstract class Continent : IContinent
    {
        /// <summary>
        /// Constants defining initial x and y 
        /// coordinates of an animal's picture.
        /// </summary>
        public const int IMAGE_LOCATION_X = 13;
        public const int IMAGE_LOCATION_Y = 23;

        /// <summary>
        /// Declaring data fields to be used
        /// for creation of a continent.
        /// </summary>
        protected ListBox displayBox;
        protected Random rGen;
        protected int animalTypes;
        protected Graphics canvas;
        protected IAnimalFactory animalFactory;

        /// <summary>
        /// Constructor - initialises the datafields with the 
        /// necessary data to create a continent.
        /// </summary>
        /// <param name="displayBox">The listbox to add text-based animal information to.</param>
        /// <param name="rGen">A random generator to randomise the animals (text + image) displayed.</param>
        /// <param name="animalTypes">The number of animals to assign to the continent.</param>
        /// <param name="canvas">The canvas to draw animals' images to.</param>
        public Continent(ListBox displayBox, Random rGen, int animalTypes, Graphics canvas)
        {
            this.displayBox = displayBox;
            this.rGen = rGen;
            this.animalTypes = animalTypes;
            this.canvas = canvas;
        }

        /// <summary>
        /// This is the key method of the application.
        /// It is used to create animals (using a factory), 
        /// displaying their image, and adding text-based 
        /// information to the form listbox.
        /// </summary>
        public void runSimulation()
        {
            int animalTypeNumber = 0;
            for (int i = 0; i < animalTypes + 1; i++)
            {
                animalTypeNumber = rGen.Next(animalTypes);
                Animal newAnimal = animalFactory.createAnimal(animalTypeNumber);
                displayBox.Items.Add(newAnimal.ToString());
                canvas.DrawImage(newAnimal.Image, IMAGE_LOCATION_X, IMAGE_LOCATION_Y + i * 120);
            }
        }
    }
}
