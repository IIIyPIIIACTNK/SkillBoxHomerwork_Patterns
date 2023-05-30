using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using AnimalsLibrary;
using AnimalsLibrary.Serializer;

namespace SkillBoxHomerwork_18_Patterns
{
    public class Presenter
    {
        public AnimalRepository? Repository { get; set; } = new AnimalRepository();
        DataSerializer ds;
        public IAddAnimal AddAnimalInterface;

        public Presenter()
        {
            AddAnimalInterface = Repository;
        }
        public void AddAnimal(string Type, string Name, int Age, bool IsAlive)
        {
            Repository.Animals.Add(AnimalFactory.GetAnimal(Type, Name, Age, IsAlive));
        }

        public void UpdateTxt()
        {
            var TxTSave = new SaveToTxt("animals");
            ds = new DataSerializer(TxTSave);
            ds.Serialize(Repository.Animals);
        }

        public void UpdateXlsx()
        {
            var XlsxSave = new SaveToTxt("animals");
            ds = new DataSerializer(XlsxSave);
            ds.Serialize(Repository.Animals);
        }
        
    }
}
