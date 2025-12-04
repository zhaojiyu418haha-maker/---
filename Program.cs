using System;
using System;
namespace game
{
    class Pro
    {
        static void DisplayInfo()
        {
            Console.WriteLine("пишите называнте вашего здания");
            string namefangzi = Console.ReadLine();

            Console.WriteLine("пишиет стоимость");
            string buildcost = Console.ReadLine();
            int numbuildcost = int.Parse(buildcost);

            Console.WriteLine("пишиет количество ресурсов производное за минуту");
            string production = Console.ReadLine();
            int numproduction = int.Parse(production);

            Console.WriteLine("Название:"+ namefangzi+"Стоимость:"+ numbuildcost+ "Производство:"+ numproduction+"в минуту");

        }


        static void Main ()
        {
            int[] array = { 1, 2 };
            for (int i = 0; i < array.Length; i++)
            {
                DisplayInfo();
               
            }

            Console.ReadKey();




        }
    }
}
