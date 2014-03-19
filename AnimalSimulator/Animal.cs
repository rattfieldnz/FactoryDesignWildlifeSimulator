using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Drawing;

namespace AnimalSimulator
{
    /// <summary>
    /// This is the base class, used by child 
    /// classes to create animals.
    /// </summary>
    public class Animal
    {
        /// <summary>
        /// Declaring data fields necessary for 
        /// animal creation.
        /// </summary>
        protected string name;
        protected string family;
        protected string food;
        protected Bitmap image;
        public Bitmap Image
        {
            get { return image; }
        }

        /// <summary>
        /// Overriding the ToString method to return
        /// text-based information about the animal.
        /// </summary>
        /// <returns></returns>
        public override string ToString()
        {
            StringBuilder sb = new StringBuilder();
            sb.Append("I am a ")
                .Append(name)
                .Append(". I am a ")
                .Append(family)
                .Append(". I eat ")
                .Append(food);

            return sb.ToString();
        }


    }
}
