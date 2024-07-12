using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PalindromWords
{
    internal class Program
    {
        static void Main(string[] args)
        {

            while (true)
            {
                Console.Write("Yazmak istediğiniz metni giriniz = ");
                string metin = Console.ReadLine();
                string tershali = "";

                for (int i = metin.Length -1; 0 <= i; i--)
                {
                    tershali += metin[i];

                }
                if (tershali == metin)
                {
                    Console.WriteLine("Kelime palindromdur. Kelimenizin ters hali = " + tershali );
                }
                else
                {
                    Console.WriteLine("Kelime palindrom değildir. Kelimenizin ters hali =  " + tershali);
                }

            }
        }
    }
}
