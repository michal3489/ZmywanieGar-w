using System;
using System.Runtime.CompilerServices;
using System.Reflection.Metadata;


namespace Zmywara // Note: actual namespace depends on the project name.
{
    public class Sink // class for activities with sink
    {
        public class FillWithHotWater()
        {
            int waterHot = 1;
            int waterCold = 1;
            public static FillWithHotWater()
            {
                Console.WriteLine(waterHot);
                Console.WriteLine(waterCold);
            }
        }
        public class AddDishSoap()
        {
            public void AddDishSoap()
            {
                string soap = "Podaj ile ci potrzeba kropel płynu ? ";
                Console.WriteLine(soap);
            }
        }
        public class WashingSink()
        {
            public static WashingSink()
            {
                Console.WriteLine("Na koniec zmywania wyczyść zlew");
            }
        }
    }
    public class Dishes // class for activities with dishes
    {
        public class PlaceInSink()
        {
            public static PlaceInSink() { 
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
                void scaldedHands(string bigBrainPain)
                {
                    if(bool Sink.waterHot == 1)
                        {
                            
                        }
                }                            

        }
        void DryWithTowel()
        {        
            Console.WriteLine("Wysusz dokładnie:)");
            bool wetDishes;
        }
        public void PutAway()
        {
                void putzAway(bool broken)
                {
                    if (broken)
                    { 
                        Console.WriteLine("Dobrze odłożyłeś :)");
                    }
                    else 
                    {
                        Console.WriteLine("Potłukłeś gary! Jak tak można!?"); 
                    }
                }            
        }        
    }
