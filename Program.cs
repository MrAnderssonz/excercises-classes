using System;

namespace excercises_classes
{
    class Program
    {
        static void Main(string[] args)
        {
            Bongo myBongo = new Bongo();
            myBongo.Name = "Sven";
            myBongo.Age = 2;
            myBongo.Race = "Brun";

            Console.WriteLine("{0} heter min Bongoantilop, han är {1}år och är av rasen {2}.",myBongo.Name, myBongo.Age, myBongo.Race);
            myBongo.bark();
            myBongo.fetch();

        }
    }
}
