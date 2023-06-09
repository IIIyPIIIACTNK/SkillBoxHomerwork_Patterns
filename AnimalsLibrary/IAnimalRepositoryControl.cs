﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AnimalsLibrary
{
    public interface IAnimalRepositoryControl
    {
        public void AddAnimal(string Type, string Name, int Age, bool Status);

        public void DeleteAnimal(IAnimalEntity animal);
    }
}
