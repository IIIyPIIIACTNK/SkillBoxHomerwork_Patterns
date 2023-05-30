using AnimalsLibrary.Animals;
using System;
using System.Collections.Generic;
using System.Collections.ObjectModel;
using System.ComponentModel;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Xml.Linq;

namespace AnimalsLibrary
{
    public class AnimalRepository : IAnimalRepositoryControl
    {
        private ObservableCollection<IAnimalEntity> animals = new ObservableCollection<IAnimalEntity>()
        {
            new Mammal("Корова",6, true),
            new Bird("Голубь",3, true),
            new Reptile("Крокодил",10, false)
        };

        public ObservableCollection<IAnimalEntity> Animals { get { return animals; } set { animals = value; } }


        public void AddAnimal(string Type,string Name, int Age, bool Status)
        {
            animals.Add(AnimalFactory.GetAnimal(Type, Name, Age, Status));
        }

        public void DeleteAnimal(IAnimalEntity animal)
        {
            animals.Remove(animal);
        }
    }
}
