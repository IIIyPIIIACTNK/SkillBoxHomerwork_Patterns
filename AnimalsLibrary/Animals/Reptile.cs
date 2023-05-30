using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AnimalsLibrary.Animals
{
    public class Reptile : IAnimalEntity
    {
        public string Name { get ; set ; }
        public int Age { get; set; }
        public bool IsAlive { get; set; }

        public Reptile(string name, int age, bool isAlive)
        {
            Name = name;
            Age = age;
            IsAlive = isAlive;
        }

        public string ReturnFamily()
        {
            return "Рептилия";
        }
    }
}
