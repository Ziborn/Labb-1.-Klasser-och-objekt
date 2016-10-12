using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Labb_1___Klasser_och_objekt
{
    class Program
    {
        //hej
        static void Main(string[] args)
        {
            MainMenu();

            Dog dog1 = new Dog();
            dog1.Name = "Teddy";
            dog1.Age = 2;
            dog1.Breed = "Pit Bull";

            Dog dog2 = new Dog();
            dog2.Name = "Freddy";
            dog2.Age = 3;
            dog2.Breed = "German Shepard";

            Dog dog3 = new Dog();
            dog3.Name = "Cerberus";
            dog3.Age = 4;
            dog3.Breed = "Hell Hound";
            
        }


        private static void MainMenu()
        {
            Console.WriteLine("Dogs");
            Console.WriteLine("1. Add New:");
            Console.WriteLine("2. Remove:");
            Console.WriteLine("3. Show Info:");
            Console.WriteLine("4. Exit:");

            int menuchoice = int.Parse(Console.ReadLine());

            switch (menuchoice)
            {
                case 1:AddNew();
                    break;
                case 2:Remove();
                    break;
                case 3: ShowInfo();
                    break;
                case 4: Exit();
                    break;
                default:
                    Console.WriteLine("Sorry, invalid selection");
                    break;

            }
        }

        private static void AddNew()
        {

        }

        private static void Remove()
        {

        }

        private static void ShowInfo()
        {
            Console.WriteLine("Dog Info");
            Console.WriteLine();
        }

        private static void Exit()
        {
            Environment.Exit(0);
        }
    }
}
