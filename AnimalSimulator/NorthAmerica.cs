using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Windows.Forms;
using System.Drawing;

namespace AnimalSimulator
{
    /// <summary>
    /// This class is responsible for creating the North American continent,
    /// with the Continent base class.
    /// </summary>
    class NorthAmerica:Continent
    {
        /// <summary>
        /// Constructor - initialises data fields in the base class, to be used in 
        /// creating this continent.
        /// </summary>
        /// <param name="displayBox">The listbox to add text-based animal information to.</param>
        /// <param name="rGen">A random generator to randomise the animals (text + image) displayed.</param>
        /// <param name="animalTypes">The number of animals to assign to the continent.</param>
        /// <param name="canvas">The canvas to draw animals' images to.</param>
        public NorthAmerica(ListBox displayBox, Random rGen, int animalTypes, Graphics canvas)
            :base(displayBox, rGen, animalTypes, canvas)
        {
            ///<summary>
            ///Assigning a North American animal factory to the North American continent object.
            ///</summary>
            animalFactory = new NorthAmericanAnimalFactory();
        }
    }
}
