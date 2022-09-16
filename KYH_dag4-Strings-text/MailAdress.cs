using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace KYH_dag4_Strings_text
{
    internal class MailAdress
    {
        public void RunMailAdress()
        {
            //            Be användaren mata in en mailadress.

            //Programmet skall kontrollera att inmatningen är rätt

            //dvs att det finns ett @ tecken och

            //att det finns en . med 2 eller 3 tecken efter.

            //Meddela användaren om det är rätt eller felaktig adress

            //ex a @a.se = ok a @a.hejsan = fel a @a = fel


            Console.Write("Ange din email adress:");
            string email = Console.ReadLine();

            bool ok = true;



            if (email.Contains("@") == false)
            {
                ok = false; // om email contains (@) dont run this line
            }

            int index = email.LastIndexOf("."); // index är platsen som (.) är på      (siffra)
            if (index == -1)
            {
                ok = false; // om (.) finns i email, dont run this line
            }
            else                             // ex: hfh@gmail.com     index för punkt == 9      Length == 12
            {
                // a@a.c Kontrollera
                if (index < email.Length - 4)
                {
                    ok = false; // om det är mindre än 3 tecken skillnad efter punkt dont run this line
                }
            }

            if (ok == true)

                Console.WriteLine("Din email är riktig");

            else
                Console.WriteLine("Din email är inte korrekt inmatad");

        }
    }
}
