using AnimalsLibrary.Animals;
using System;
using System.Collections.Generic;
using System.Collections.ObjectModel;
using System.ComponentModel;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AnimalsLibrary
{
    public class AnimalRepository
    {
        private ObservableCollection<IAnimalEntity> animals = new ObservableCollection<IAnimalEntity>()
        {
            new Mammal("Корова",6, true),
            new Bird("Голубь",3, true),
            new Reptile("Крокодил",10, false)
        };

        public ObservableCollection<IAnimalEntity> Animals { get { return animals; } set { animals = value; } }

        public void Add(IAnimalEntity animalEntity)
        {
            animals.Add(animalEntity);
        }
    }
}
