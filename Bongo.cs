using System;

namespace excercises_classes
{
    class Bongo
    {
        string name = "";
        public string Name
        {
            get
            {
                return name;
            }
            set
            {
                name = value;
            }
        }
        int age = 0;
        public int Age
        {
            get
            {
                return age;
            }
            set
            {
                age = value;
            }
        }
        string race = "";
        public string Race
        {
            get
            {
            return race;
            }
            set
            {
                race = value;
            }
        }

        public void bark()
        {
            Console.WriteLine("NÖFF");
        }
        public void fetch()
        {
            Console.WriteLine("Jag har min egen vilja och tänker inte styras av dig!");
        }


        
    }
}