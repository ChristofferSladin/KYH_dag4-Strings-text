using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace KYH_dag4_Strings_text
{
    internal class PalindromRecon
    {
        public void RunPalindromeRecon()
        {
            Console.WriteLine("Mata in en text");
            string inmatning = Console.ReadLine();
            string reverse = "";

            inmatning = inmatning.Replace(" ", "");
            inmatning = inmatning.ToLower();

            foreach (char c in inmatning)
            {
                reverse = c + reverse ;      // SPELAR ROLL OM MAN HAR (c + reverse / reverse + c)  varför? skriver stringen baklänges?
            }

            if (reverse == inmatning)
            {
                Console.WriteLine("Detta är ett palindrom");
            }
            else
                Console.WriteLine("Det du angivit är inte ett palindrom");
        }
    }
}
