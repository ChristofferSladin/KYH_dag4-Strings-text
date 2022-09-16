using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace KYH_dag4_Strings_text
{
    internal class AddingStrings
    {

        public void RunAddingStrings()
        {
            //Be användaren mata in 3 strängar.

            //Addera ihop strängarna till EN ny sträng

            //Skriv ut strängen på skärmen

            Console.WriteLine("Ange en text");
            string str1 = Console.ReadLine();
            Console.WriteLine("Ange en text");
            string str2 = Console.ReadLine();
            Console.WriteLine("Ange en text");
            string str3 = Console.ReadLine();

            string fullMening = str1 + str2 + str3;

            Console.WriteLine(fullMening);
        }
        
    }
}
