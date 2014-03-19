using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Drawing;

namespace AnimalSimulator
{
    /// <summary>
    /// This child class is responsible for 
    /// creating a kangaroo.
    /// </summary>
    class Kangaroo:Animal
    {
        /// <summary>
        /// Constructor - initialise datafields in the 
        /// base class with the kangaroo's details.
        /// </summary>
        public Kangaroo()
        {
            name = "Kangaroo";
            family = "Herbivore";
            food = "Berries";
            image = new Bitmap("images/kangaroo.jpg");
        }
    }
}
