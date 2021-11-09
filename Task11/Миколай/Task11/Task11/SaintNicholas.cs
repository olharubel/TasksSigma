using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Task11
{
    public struct Children
    {

        public string Name  { get; set; }

        public string Gender { get; set; }

        public int GoodDeeds { get; set; }
        public int BadDeeds { get; set; }

        public Children(string name, string gender, int goodDeeds, int badDeeds)
        {
            Name = name;
            Gender = gender;
            GoodDeeds = goodDeeds;
            BadDeeds = badDeeds;
        }
    }

    class SaintNicholas
    {
        private static SaintNicholas instance;
        private Children children;
        private Storage storage = new Storage();

        private SaintNicholas() { }

        public static SaintNicholas GetInstance()
        {
            if(instance == null)
            {
                instance = new SaintNicholas();
            }
            return instance;
        }


        public void AddBoyToy(Toy toy)
        {
            storage.AddBoyToy(toy);
        }

        public void AddGirlToy(Toy toy)
        {
            storage.AddGirlToy(toy);
        }

        public void GetRequest(string name, string gender, int goodDeeds, int badDeeds)
        {
            children = new Children(name, gender, goodDeeds, badDeeds);
         
        }

        public Present CreateDeservedPresents()
        {
            Present present = new Present();
            PresentsBuilder builder;
         
                if (children.GoodDeeds > children.BadDeeds)
                {
                    Angel angel = new Angel();
                    builder = new PolitePresentBuilder(children.Gender);
                    present = (angel.CreatePresent(builder));

                }
                else
                {
                    Devil devil = new Devil();
                    builder = new ImpolitePresentBuilder();
                    present = (devil.CreatePresent(builder));
                }
            
          
            return present;
        }

        public Present CreatePresent()
        {
            Present present;
            PresentsBuilder builder;
           
                Angel angel = new Angel();
                builder = new AllChildrenPresentBuilder(children.Gender);
                present = angel.CreatePresent(builder);
                return present;
        }

      


    }
}
