using AnimalsLibrary.Animals;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AnimalsLibrary
{
    public static class AnimalFactory
    {
        public static IAnimalEntity GetAnimal(string AnimalType,string Name,int Age, bool IsAlive)
        {
            switch(AnimalType)
            {
                case "Млекопитающие": return new Mammal(Name, Age, IsAlive);
                case "Птица": return new Bird(Name, Age, IsAlive);
                case "Рептилия": return new Reptile(Name, Age, IsAlive);
                default: return new NullAnimal();
            }
        }
    }
}
