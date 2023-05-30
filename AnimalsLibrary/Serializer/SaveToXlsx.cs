using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AnimalsLibrary.Serializer
{
    public class SaveToXlsx : IAnimalSave
    {
        private string fileName;
        public SaveToXlsx(string fileName)
        {
            this.fileName = fileName;
        }

        public void SaveAnimalToFile(IEnumerable<IAnimalEntity> animals)
        {
            using (StreamWriter fs = new StreamWriter($"{fileName}.txt"))
            {
                foreach (var animal in animals)
                {
                    fs.WriteLine($"Семейство {animal.Family}, Имя {animal.Name}, Возраст {animal.Age}, Живой/Неживой {animal.IsAlive}");
                }
            }
        }
    }
}
