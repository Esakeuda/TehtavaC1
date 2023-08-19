using System;

namespace TehtavaC1
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.Write("Syötä ensimmäinen kokonaisluku: ");
            int luku1 = int.Parse(Console.ReadLine());

            Console.Write("Syötä toinen kokonaisluku: ");
            int luku2 = int.Parse(Console.ReadLine());

            if (luku1 > luku2)
            {
                int temp = luku1;
                luku1 = luku2;
                luku2 = temp;
                Console.WriteLine("Luvut vaihdettu paikkaa. Suuruusjärjestys: " + luku1 + ", " + luku2);
            }
            else
            {
                Console.WriteLine("Lukujen suuruusjärjestys on jo oikein: " + luku1 + ", " + luku2);
            }
        }
    }
}
