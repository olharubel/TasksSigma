using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Task11
{
    class Program
    {
        static void Main(string[] args)
        {
            SaintNicholas nicholas = SaintNicholas.GetInstance();

            nicholas.GetRequest("Ola", "girl", 20, 10);
            var present = nicholas.CreateDeservedPresents();
            Console.WriteLine(present.ToString());

            nicholas.GetRequest("Mark", "boy", 0, 10);
            var present2 = nicholas.CreateDeservedPresents();
            Console.WriteLine(present2.ToString());

            nicholas.GetRequest("Oleh", "boy", 20, 10);
            var present3 = nicholas.CreatePresent();
            Console.WriteLine(present3.ToString());

            nicholas.GetRequest("Artem", "boy", 15, 2);
            var present4 = nicholas.CreatePresent();
            Console.WriteLine(present4.ToString());

            nicholas.GetRequest("Sofia", "girl", 20, 0);
            var present5 = nicholas.CreatePresent();
            Console.WriteLine(present5.ToString());



            nicholas.GetRequest("Maria", "girl", 20, 0);
            var present7 = nicholas.CreatePresent();
            Console.WriteLine(present7.ToString());

            nicholas.AddBoyToy(new Toy(new BoysGiftFactory(), "Dog"));

            nicholas.GetRequest("David", "boy", 15, 2);
            var present6 = nicholas.CreatePresent();
            Console.WriteLine(present6.ToString());




            Console.ReadLine();
        }
    }
}
