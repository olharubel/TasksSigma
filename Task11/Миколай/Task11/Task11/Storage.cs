using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Task11
{
    class Storage
    {
        static List<Toy> boysToys;
        static List<Toy> girlsToys;
        static List<Wish> wishes;
        static List<EatableGift> gifts;
        static int indexGirl = 0;
        static int indexBoy = 0;
        static int indexWish = 0;
        static int indexGift = 0;

        public Storage()
        {
            boysToys = new List<Toy>
            {
                new Toy(new BoysGiftFactory(), "Car"),
                new Toy(new BoysGiftFactory(), "Tools"),
                new Toy(new BoysGiftFactory(), "Constructor")
            };

            girlsToys = new List<Toy>();
            girlsToys.Add(new Toy(new GirlsGiftFactory(), "Doll"));
            girlsToys.Add(new Toy(new GirlsGiftFactory(), "Cosmetics"));
            girlsToys.Add(new Toy(new GirlsGiftFactory(), "Dress"));

            wishes = new List<Wish>();
            wishes.Add(new Wish("I wish you to be happy!"));
            wishes.Add(new Wish("I wish you to be healthy!"));
            wishes.Add(new Wish("I wish your dreams to come true!"));
            wishes.Add(new Wish("I wish you good luck!"));
            wishes.Add(new Wish("I wish you to study well!"));


            gifts = new List<EatableGift>();
            gifts.Add(new EatableGift("Candy"));
            gifts.Add(new EatableGift("Chocolate"));
            gifts.Add(new EatableGift("Banana"));
            gifts.Add(new EatableGift("Mango"));
            gifts.Add(new EatableGift("Cookies"));
        }

        public void AddBoyToy(Toy toy)
        {
            boysToys.Add(toy);
        }

        public void AddGirlToy(Toy toy)
        {
            girlsToys.Add(toy);
        }

        private static Toy GetGirlToy()
        {
            if (indexGirl > girlsToys.Count)
            {
                indexGirl = 0;
            }

            return girlsToys[indexGirl++];
        }

        private static Toy GetBoyToy()
        {
            if (indexBoy >= boysToys.Count)
            {
                indexBoy = 0;
            }
            return boysToys[indexBoy++];
        }

        public static Toy GetToy(string gender)
        {
            if (gender == "girl")
            {
                return GetGirlToy();
            }

            return GetBoyToy();

        }

        public static Wish GetWish()
        {

            if (indexWish >= wishes.Count)
            {
                indexWish = 0;
            }
            return wishes[indexWish++];

        }

        public static EatableGift GeGift()
        {

            if (indexGift >= gifts.Count)
            {
                indexGift = 0;
            }
            return gifts[indexGift++];

        }

        public static Toy GetRandomToy(string gender)
        {
           
            Random random = new Random();
            int number = random.Next(0, boysToys.Count-1);
            if (gender == "girl")
            {
                return girlsToys[number];
            }
            return boysToys[number];

        }

        public static Wish GetRandomWish()
        { 
            Random random = new Random();
            int number = random.Next(0, wishes.Count-1);
            return wishes[number];
        }

        public static EatableGift GetRandomEatableGift()
        {
            Random random = new Random();
            int number = random.Next(0, gifts.Count-1);
            return gifts[number];
        }

        public static Toy GetRandomBoyToy()
        {
            
            Random random = new Random();
            int number = random.Next(0, boysToys.Count-1);
            return boysToys[number];
          
        }

        public static Toy GetRandomGirlToy()
        {
            Random random = new Random();
            int number = random.Next(0, girlsToys.Count-1);
            return girlsToys[number];
        }

    }
}
