using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace KYH_dag4_Strings_text
{
    internal class SearchingForCharInString
    {
        public void RunSearchingForCharInString()
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
        }
    }
}
