using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace KYH_dag4_Strings_text
{
    internal class FindLetterInString
    {
        public void RunFindLetterInString()
        {
            //Du har en strängvariabel som innehåller följande text, ”Hello, world”

            //Ta med hjälp av kod ut första förekomsten av bokstaven w och skriv ut positionen(index)


            string str1 = "Hello, World";

            int pos = str1.IndexOf("W");

            Console.WriteLine(pos);
        }
    }
}
