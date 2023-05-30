using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AnimalsLibrary
{
    public interface IAnimalEntity
    {
        public string Name { get; set; }
        public int Age { get; set; }
        public bool IsAlive { get; set; }

        public string ReturnFamily();
    }
}
