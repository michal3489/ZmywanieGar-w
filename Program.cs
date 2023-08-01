using System;
using System.Runtime.CompilerServices;
using System.Reflection.Metadata;

namespace Zmywara // Note: actual namespace depends on the project name.
{
    public class Sink
    {
        public void FillWithHotWater()
        {
            int water1 = 100;
            int water2 = 1;

            Console.WriteLine(water1);
            Console.WriteLine(water2);
        }
        public void AddDishSoap()
        {
            string soap = "Podaj ile kropel płynu ci potrzeba";
            int soapLoaded;
            Console.WriteLine(soap);

            Console.ReadLine(soapLoaded);
        }
    }

    public class Dishes
    {
        public void PlaceInSink()
        {

        }
        public void ScrubWithSponge()
        {

        }
        public void RinseWithWater()
        {

        }
        public void DryWithTowel()
        {

        }
        public void PutAway()
        {

        }
    }
}