using System;
namespace Zmywara; // Note: actual namespace depends on the project name.


    public class Sink // class for activities with sink
    {
        public class FillWithHotWater()
        {
            int waterHot = 1;
            int waterCold = 1;
            static FillWithHotWater()
            {
                
            }
        }
        public class AddDishSoap()
        {
            static AddDishSoap()
            {
                    string soap = "Podaj ile ci potrzeba kropel płynu ? ";
                    Console.WriteLine(soap);
            
            }
        public class WashingSink()
        {
            static WashingSink()
            {
                Console.WriteLine("Na koniec zmywania wyczyść zlew");
            }
        }
    }
public class Dishes // class for activities with dishes
{
    public class PlaceInSink()
    {
        static PlaceInSink()
        {
            
            void WhichChamber(string chamber)
            {
                if (chamber == "Prawa")
                {
                    Console.WriteLine("Wybrałeś prawą komorę do brudnych naczyń");
                }
                else
                {
                    Console.WriteLine("Wybrałeś lewą komorę do bru0dnych naczyń");
                }
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
    static void RinseWithWater() 
    {
       

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


    
