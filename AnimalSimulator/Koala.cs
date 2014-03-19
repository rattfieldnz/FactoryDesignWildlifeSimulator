using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Drawing;

namespace AnimalSimulator
{
    /// <summary>
    /// This child class is responsible for 
    /// creating a koala.
    /// </summary>
    class Koala:Animal
    {
        /// <summary>
        /// Constructor - initialise datafields in the 
        /// base class with the koala's details.
        /// </summary>
        public Koala()
        {
            name = "Koala";
            family = "Herbivore";
            food = "Eucalyptus Leaves";
            image = new Bitmap("images/koala.jpg");
        }
    }
}
