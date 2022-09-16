using System;
using System.Collections.Generic;
using System.Diagnostics.Metrics;
using System.Linq;
using System.Reflection;
using System.Text;
using System.Threading.Tasks;
using Microsoft.VisualBasic;

namespace KYH_dag4_Strings_text
{
    internal class Applications
    {

        public void Run() // DOODLES
        {

            string eMail = "stefan.holmberg@aaa.se";

            int numberOfdotsIHaveFoundSoFar = 0;

            foreach (char letter in eMail)
            {
                if (letter == '.')
                {
                    numberOfdotsIHaveFoundSoFar++;
                }
            }
            Console.WriteLine($"Det finns {numberOfdotsIHaveFoundSoFar} punkter"); // dollar string

            string aName = "Chrille";
            char firstLetter = aName[0];

            Console.WriteLine(firstLetter);

            for (int i = 0; i < aName.Length; i++)
            {
                Console.WriteLine(aName[i]);
            }

            foreach (char letter in aName) // Skapade char låda i loopen
            {
                Console.WriteLine(letter);
            }

            string namnet = Console.ReadLine();

            if (namnet.StartsWith("Chri")) // EndWith(); 

            {

            }



            namnet = namnet.Trim();
            if (namnet.Length > 5)
            {
                Console.WriteLine("Du har skrivit för långt namn");
            }


            string name = "c:\\temp\\blabla\\hello.jpg";

            int pos = name.IndexOf("\\");

            pos = name.LastIndexOf("\\");

            string fileName = name.Substring(pos + 1);

            string n2 = "hej hopp chrille";
            string n3 = n2.Substring(4, 4);

            Console.WriteLine(n3);

            Console.WriteLine(pos);


            //string[] textLista = new string textLista { "dumma", "" };

            Console.WriteLine("säg nåt");
            string text = Console.ReadLine();
            // string lowerText = text.ToLower();           LOWER
            string upperText = text.ToUpper();     // UPPER

            text = text.ReplaceLineEndings("dumma, *****");

            //if (lowerText.Contains("dumma"))
            //{

        }
    }

}

