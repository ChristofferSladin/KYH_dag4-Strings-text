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

        public void Run()
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
            






            //            Du har en sträng med texten ”Detta är en sträng som du skall ändra”.

            //Ersätt via kod alla blanktecken i strängen med tecknet * .

            //Räkna sedan ut via kod hur många förekomster det finns av tecknet * i strängen.

            //string changeableString = "rfrfv rf rfr fr    trgrgr rfvr r";
            //string newStringWithoutSpaces = "";
            //int antalStjärnor = 0;

            //for (int i = 0; i < changeableString.Length; i++) // i == current platsen i stringen 
            //{
            //    if (changeableString[i] == ' ')
            //    {
            //         newStringWithoutSpaces = changeableString.Replace(" ", "*");
            //        antalStjärnor++;
            //    }
            //}


            //Console.WriteLine($"\nNya strängen: {newStringWithoutSpaces}\nAntal mellanslag i strängen: {antalStjärnor}");








            //            Du har strängen string namn = "kurt andersson";

            //            Skriv kod så att förnamn och efternamn i variabeln namn börjar med stora bokstäver.

            //Resultatet skall bli så här "Kurt Andersson"

            //Obs ska ju funka med "kurt arne andersson" osv också

            //OBS: ska lösas med loopar osv


            //string nameLowerCase = "christoffer hrvoje sladin";
            //string nameUpperCase = "";
            //bool firstCharInStringIsLetter = true;

            //foreach (char letter in nameLowerCase)
            //{
            //    if (firstCharInStringIsLetter == true)  // är sann på första bokstaven men inte i slutet av loopen
            //    {
            //        nameUpperCase = nameUpperCase + char.ToUpper(letter); // char.ToUpper, gör ett string tecken konverterad till char

            //    }
            //    else
            //        nameUpperCase += letter;

            //    if (letter == ' ')
            //    {
            //        firstCharInStringIsLetter = true;
            //    }
            //    else
            //        firstCharInStringIsLetter = false; // här nere blir värdet false från true
            //}

            //Console.WriteLine($" {nameUpperCase} ");



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

            ////            Du har en strängvariabel som innehåller följande text, ”Hello, world”

            ////Ta med hjälp av kod ut första förekomsten av bokstaven w och skriv ut positionen(index)


            //string str1 = "Hello, World";

            //int pos = str1.IndexOf("W");

            //Console.WriteLine(pos);



            ////            Be användaren mata in 3 strängar.

            ////Addera ihop strängarna till EN ny sträng

            ////Skriv ut strängen på skärmen

            //Console.WriteLine("Ange en text");
            //string str1 = Console.ReadLine();
            //Console.WriteLine("Ange en text");
            //string str2 = Console.ReadLine();
            //Console.WriteLine("Ange en text");
            //string str3 = Console.ReadLine();

            //string fullMening = str1 + str2 + str3;

            //Console.WriteLine(fullMening);


            //string eMail = "stefan.holmberg@aaa.se";

            //int numberOfdotsIHaveFoundSoFar = 0;

            //foreach (char letter in eMail)
            //{
            //    if (letter == '.')
            //    {
            //        numberOfdotsIHaveFoundSoFar++;
            //    }
            //}
            //Console.WriteLine($"Det finns {numberOfdotsIHaveFoundSoFar} punkter"); // dollar string

            //string aName = "Chrille";
            //char firstLetter = aName[0];

            //Console.WriteLine(firstLetter);

            //for (int i = 0; i < aName.Length; i++)
            //{
            //    Console.WriteLine(aName[i]);
            //}

            //foreach (char letter in aName) // Skapade char låda i loopen
            //{
            //    Console.WriteLine(letter);
            //}

            //string namnet = Console.ReadLine();

            //if (namnet.StartsWith("Chri")) // EndWith(); 

            //{

            //}



            //namnet = namnet.Trim();
            //if (namnet.Length > 5)
            //{
            //    Console.WriteLine("Du har skrivit för långt namn");
            //}


            //string name = "c:\\temp\\blabla\\hello.jpg";

            //int pos = name.IndexOf("\\");

            // pos = name.LastIndexOf("\\");

            //string fileName = name.Substring(pos + 1);

            //string n2 = "hej hopp chrille";
            //string n3 = n2.Substring(4, 4);

            //Console.WriteLine(n3);

            //Console.WriteLine(pos);


            ////string[] textLista = new string textLista { "dumma", "" };

            //Console.WriteLine("säg nåt");
            //string text = Console.ReadLine();
            //// string lowerText = text.ToLower();           LOWER
            //string upperText = text.ToUpper();         UPPER

            //text = text.ReplaceLineEndings("dumma, *****");

            ////if (lowerText.Contains("dumma"))
            ////{

            //}
        }

    }
}
