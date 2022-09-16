using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace KYH_dag4_Strings_text
{
    internal class BlankSpaceToStars
    {
        public void RunBlankSpaceToStars()
        {

            //            Du har en sträng med texten ”Detta är en sträng som du skall ändra”.

            //Ersätt via kod alla blanktecken i strängen med tecknet * .

            //Räkna sedan ut via kod hur många förekomster det finns av tecknet * i strängen.

            string changeableString = "rfrfv rf rfr fr    trgrgr rfvr r";
            string newStringWithoutSpaces = "";
            int antalStjärnor = 0;

            for (int i = 0; i < changeableString.Length; i++) // i == current platsen i stringen 
            {
                if (changeableString[i] == ' ')
                {
                    newStringWithoutSpaces = changeableString.Replace(" ", "*");
                    antalStjärnor++;
                }
            }


            Console.WriteLine($"\nNya strängen: {newStringWithoutSpaces}\nAntal mellanslag i strängen: {antalStjärnor}");

        }
    }
}
