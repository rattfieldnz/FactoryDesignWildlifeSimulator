using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Drawing;

namespace AnimalSimulator
{
    /// <summary>
    /// This child class is responsible for 
    /// creating a platypus.
    /// </summary>
    class Platypus:Animal
    {
        /// <summary>
        /// Constructor - initialise datafields in the 
        /// base class with the platypus's details.
        /// </summary>
        public Platypus()
        {
            name = "Platypus";
            family = "Herbivore";
            food = "Insects";
            image = new Bitmap("images/platypus.jpg");
        }
    }
}
