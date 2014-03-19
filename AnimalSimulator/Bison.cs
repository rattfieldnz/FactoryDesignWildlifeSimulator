using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Drawing;

namespace AnimalSimulator
{
    /// <summary>
    /// This child class is responsible for 
    /// creating a bison.
    /// </summary>
    class Bison:Animal
    {
        /// <summary>
        /// Constructor - initialise datafields in the 
        /// base class with the bison's details.
        /// </summary>
        public Bison()
        {
            name = "Bison";
            family = "Herbivore";
            food = "Grass";
            image = new Bitmap("images/Bison.jpg");
        }
    }
}
