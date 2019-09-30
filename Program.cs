using System;

namespace excercises_classes
{
    class Program
    {
        static void Main(string[] args)
        {
            Bongo myBongo = new Bongo();
            myBongo.name = "Sven";
            myBongo.age = 2;
            myBongo.race = "Brun";

            Console.WriteLine("{0} heter min Bongo antilop, han är {1}år och är av rasen {2}.",myBongo.name, myBongo.age, myBongo.race);
            myBongo.bark();
            myBongo.fetch();

        }
    }
}
