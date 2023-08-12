using System;
using System.Runtime.CompilerServices;
using System.Reflection.Metadata;

namespace Zmywara // Note: actual namespace depends on the project name.
{
    public class Sink // class for activities in sink
    {
        public void FillWithHotWater()
        {
            int water1 = 1;
            int water2 = 1;
            Console.WriteLine(water1);
            Console.WriteLine(water2);
        }
        public void AddDishSoap()
        {
            string soap = "Podaj ile ci potrzeba kropel płynu ? ";
            Console.WriteLine(soap);

        }
    }

    public class Dishes // class for activities with dishes
    {
        public void PlaceInSink()
        {
            Console.WriteLine("W której komorze zmywasz?");
            void WhichChamber(string chamber)
            {
                if (chamber == "Prawa")
                {
                    Console.WriteLine("Wybrałeś prawą komorę do brudnych naczyń");
                }
                else
                {
                    Console.WriteLine("Wybrałeś lewą komorę do burdnych naczyń");
                }
                

        }
        public void ScrubWithSponge()
        {
            Console.WriteLine("Czy masz tłuste naczynia");
            string sponge1;
            string sponge2;
            bool fatDishes;

        }
        public void RinseWithWater()
        {

                bool hotWater;            

        }
        public void DryWithTowel()
        {
            bool dryDishes;
        }
        public void PutAway()
        {
            bool broken;
        }
    }
}