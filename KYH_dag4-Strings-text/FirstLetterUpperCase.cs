using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace KYH_dag4_Strings_text
{
    internal class FirstLetterUpperCase
    {
        public void RunFirstLetterUpperCase()
        {
            //Du har strängen string namn = "kurt andersson";

            //Skriv kod så att förnamn och efternamn i variabeln namn börjar med stora bokstäver.

            //Resultatet skall bli så här "Kurt Andersson"

            //Obs ska ju funka med "kurt arne andersson" osv också

            //OBS: ska lösas med loopar osv


            string nameLowerCase = "christoffer hrvoje sladin";
            string nameUpperCase = "";
            bool firstCharInStringIsLetter = true;

            foreach (char letter in nameLowerCase)
            {
                if (firstCharInStringIsLetter == true)  // är sann på första bokstaven men inte i slutet av loopen
                {
                    nameUpperCase = nameUpperCase + char.ToUpper(letter); // char.ToUpper, gör ett string tecken konverterad till char
                }
                else
                    nameUpperCase += letter;

                if (letter == ' ')
                {
                    firstCharInStringIsLetter = true;
                }
                else
                    firstCharInStringIsLetter = false; // här nere blir värdet false från true
            }

            Console.WriteLine($" {nameUpperCase} ");

            //-----------------------------------------------------------------------------------------------------

            //for (int i = 0; i < nameLowerCase.Length; i++)
            //{
            //    if (i == 0)
            //    {
            //        nameUpperCase += char.ToUpper(nameLowerCase[i]);
            //    }
            //    else 
            //        nameUpperCase += nameLowerCase[i];

            //    if (nameLowerCase[i] == ' ')
            //    {
            //        nameUpperCase += char.ToUpper(nameLowerCase[i]);
            //    }
            //    else
            //        nameUpperCase += nameLowerCase;
            //}


        }
    }
}
