using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Drawing;

namespace AnimalSimulator
{
    /// <summary>
    /// This child class is responsible for 
    /// creating an eagle.
    /// </summary>
    class Eagle:Animal
    {
        /// <summary>
        /// Constructor - initialise datafields in the 
        /// base class with the eagle's details.
        /// </summary>
        public Eagle()
        {
            name = "Eagle";
            family = "Omnivore";
            food = "Small birds";
            image = new Bitmap("images/eagle.jpg");
        }
    }
}
