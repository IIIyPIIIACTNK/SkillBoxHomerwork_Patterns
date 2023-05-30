using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using AnimalsLibrary;

namespace SkillBoxHomerwork_18_Patterns
{
    public class Presenter
    {
        public AnimalRepository Repository { get; set; }

        //RelayCommand? addAnimal;

        //public RelayCommand AddAnimal {
        //    get { return addAnimal ??  new RelayCommand(x =>
        //    {

        //    });}}
        
        public void AddAnimal(string Type, string Name, int Age, bool IsAlive)
        {
            Repository.Animals.Add(AnimalFactory.GetAnimal(Type, Name, Age, IsAlive));
        }
        
    }
}
