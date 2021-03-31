using System;

namespace AustinsCardGame
{
    class Program
    {
        static void Main(string[] args)
        {
            // 1. Create New Pack
            int[] newPack = new int[52];
            for (int i = 0; i < newPack.Length; i++)
            {
                newPack[i] = i;
            }
            printPack(newPack);

            Console.WriteLine("==================");

            // 2. Shuffle Pack
            Random r = new Random();
            for (int i = 0; i < newPack.Length; i++)
            {
                int rn = r.Next(52);          //Pick a random number between 0 and 51
                int temp = newPack[i];       //swap i for the random number
                newPack[i] = newPack[rn];
                newPack[rn] = temp;
            }
            printPack(newPack);
        }

        // 3. Print Pack X2
        private static void printPack(int[] newPack)
        {
            string[] suits = { "Clubs", "Diamonds", "Hearts", "Spades" };
            string[] values = { "Two", "Three", "Four", "Five", "Six", "Seven", "Eight", "Nine", "Ten", "Jack", "Queen", "King", "Ace" };
            foreach (int i in newPack)
            {
                Console.WriteLine($"{values[i % 13]} of {suits[i / 13]}");
            }
        }
    }
}
