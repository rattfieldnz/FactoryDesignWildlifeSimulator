using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Drawing;

namespace AnimalSimulator
{
    /// <summary>
    /// This child class is responsible for 
    /// creating a wolf.
    /// </summary>
    class Wolf:Animal
    {
        /// <summary>
        /// Constructor - initialise datafields in the 
        /// base class with the wolf's details.
        /// </summary>
        public Wolf()
        {
            name = "Wolf";
            family = "Carnivore";
            food = "Moose";
            image = new Bitmap("images/wolf.jpg");
        }
    }
}
