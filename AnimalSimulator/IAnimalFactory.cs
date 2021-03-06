﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace AnimalSimulator
{
    /// <summary>
    /// This interface is used to implement key behaviour method/s
    /// for a given animal factory.
    /// </summary>
    public interface IAnimalFactory
    {
        Animal createAnimal(int animalCode);
    }
}
