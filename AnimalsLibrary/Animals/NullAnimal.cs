using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AnimalsLibrary.Animals
{
    public class NullAnimal : IAnimalEntity
    {
        public string Name { get ; set ; }
        public int Age { get ; set ; }
        public bool IsAlive { get; set; }

        public NullAnimal()
        {
            Name = "Null";
            Age= 0;
            IsAlive = false;
        }
        public string ReturnFamily()
        {
            return "Null";
        }
    }
}
