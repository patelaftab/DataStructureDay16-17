using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DataStructureDay16_17
{
    internal class Program
    {
        static void Main(string[] args)
        {

            bool flag = true;
            while (flag)
            {
                Console.WriteLine("=*=*=*=*=*Welcome=*=*=*=*=*\n" +
                "Choose 1: To Check Prime Numbers Within Range\n" +
                "Choose 2: To Check Anagram Prgogram\n"+
                "Choose 3L For BUbble ssorting");
                int option = Convert.ToInt32(Console.ReadLine());
                switch (option)
                {
                    case 1:
                        PrimeNumber.PrimeNumbers();
                        break;
                    case 2:
                        Anagram.CheckAnagram();
                        break;
                    case 3:
                        BubbleSort.Sort();
                        break;
                    case 4:
                        flag = false;
                        break;

                }
                Console.ReadLine();
            }
        }
    }
}
