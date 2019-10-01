using System;

namespace excercises_classes
{
    class Program
    {
        static void Main(string[] args)
        {
            Bongo bongo = new Bongo("Sven", 2, "Brun");
            

            Console.WriteLine("{0} heter min Bongoantilop, han är {1}år och är av rasen {2}.",bongo.Name , bongo.Age, bongo.Race);
            bongo.Bark();
            bongo.Fetch();

        }
    }
}
