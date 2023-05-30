using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AnimalsLibrary.Serializer
{
    public interface IAnimalSave
    {
        public void SaveAnimalToFile(IEnumerable<IAnimalEntity> animals);
    }
}
