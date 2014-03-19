using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Drawing;

namespace AnimalSimulator
{
    /// <summary>
    /// This child class is responsible for 
    /// creating a crocodile.
    /// </summary>
    class Crocodile:Animal
    {
        /// <summary>
        /// Constructor - initialise datafields in the 
        /// base class with the crocodile's details.
        /// </summary>
        public Crocodile()
        {
            name = "Crocodile";
            family = "Carnivore";
            food = "Chickens";
            image = new Bitmap("images/crocodile.jpg");
        }
    }
}
