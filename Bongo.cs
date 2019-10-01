using System;

namespace excercises_classes
{
    class Bongo
    {
        string name = "";
        int age = 0;
        string race = "";
        public Bongo(string name, int age, string race)
        {
            this.name = name;
            this.age = age;
            this.race = race;
        }
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

        public void Bark()
        {
            Console.WriteLine("NÖFF");
        }
        public void Fetch()
        {
            Console.WriteLine("Jag har min egen vilja och tänker inte styras av dig!");
        }


        
    }
}