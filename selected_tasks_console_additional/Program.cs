using System;
using System.Collections.Generic;
using System.Linq;
using System.Numerics;
using System.Text;
using System.Threading.Tasks;

namespace console_additional
{
    internal class Program
    {
        static void Main(string[] args)
        {
            /*Aufgabe______Fülle 2-dimensionales Array. Berechne Summe, Mittelwert, Minimum und Maximum
             jeweils einer Reihe und schreibe Ergebnis nach Spalten geordnet in das Array.
            Markiere die Ergebnisspalten rot*/

            Console.WriteLine("ConsoleArray2Random");
            Console.WriteLine();
            int endCounter = 0;
            while (endCounter != 1)
            {
                Console.Write("Bitte die Größe der ersten Dimension für das Array angeben: ");
                int arrayX = Convert.ToInt32(Console.ReadLine());
                Console.WriteLine();
                Console.Write("Bitte die Größe der zweiten Dimension für das Array eingeben: ");
                int arrayY = Convert.ToInt32(Console.ReadLine());
                Console.WriteLine();
                int arrayTempLength = 4 + arrayY;
                Console.WriteLine();
                Console.WriteLine("Zufallswerte zwischen 0 und 100 werden in das Array geschrieben und angezeigt. ");
                Console.WriteLine();
                int[,] array = new int[arrayX, arrayY];
                int[,] arrayTemp = new int[arrayX, arrayTempLength];
                Random random = new Random();
                int arraySumme = 0;
                int arrayMin = 100;
                int arrayMax = 0;
                //Zufallswerte zwischen 0 und 100 werden in das Array geschrieben und angezeigt
                for (int i = 0; i < arrayX; i++)
                {
                    for (int k = 0; k < arrayY; k++)
                    {
                        array[i, k] = random.Next(0, 100);
                        Console.Write(" " + array[i, k].ToString().PadLeft(4));
                    }
                    Console.WriteLine();
                }
                Console.WriteLine();
                Console.WriteLine("Bitte die Eingabe Taste drücken. Ergebnisse der zeilenweisen Berechnung von \n" +
                                  "Summe, Mittelwert, Min, Max werden in dieser Reihenfolge spaltenweise (rot) ausgegeben!");
                Console.ReadLine();
                //Werte von 'array' in ein größeres Array ('arrayTemp') übertragen
                for (int i = 0; i < arrayX; i++)
                {
                    for (int k = 0; k < arrayY; k++)
                    {
                        arrayTemp[i, k] = array[i, k];
                    }
                }
                //Größeren Array ausgeben und Ergebnisse für Summe, Mittelwert, Min, Max einer Reihe berechnen
                //und an das Ende der jeweiligen Reihe in das Array schreiben 
                for (int i = 0; i < arrayX; i++)
                {
                    arraySumme = 0;
                    arrayMin = 100;
                    arrayMax = 0;
                    for (int k = 0; k < arrayY; k++)
                    {
                        if (array[i, k] < arrayMin)
                        {
                            arrayMin = array[i, k];
                        }
                        if (array[i, k] > arrayMax)
                        {
                            arrayMax = array[i, k];
                        }
                        Console.Write(" " + arrayTemp[i, k].ToString().PadLeft(4));
                        arraySumme += arrayTemp[i, k];
                    }
                    Console.ForegroundColor = ConsoleColor.Red;
                    arrayTemp[i, arrayTemp.GetUpperBound(1) - 3] = arraySumme;
                    Console.Write(" " + arrayTemp[i, arrayTemp.GetUpperBound(1) - 3].ToString().PadLeft(4));
                    arrayTemp[i, arrayTemp.GetUpperBound(1) - 2] = (arraySumme / arrayY);
                    Console.Write(" " + arrayTemp[i, arrayTemp.GetUpperBound(1) - 2].ToString().PadLeft(4));
                    arrayTemp[i, arrayTemp.GetUpperBound(1) - 1] = arrayMin;
                    Console.Write(" " + arrayTemp[i, arrayTemp.GetUpperBound(1) - 1].ToString().PadLeft(4));
                    arrayTemp[i, arrayTemp.GetUpperBound(1)] = arrayMax;
                    Console.Write(" " + arrayTemp[i, arrayTemp.GetUpperBound(1)].ToString().PadLeft(4));
                    Console.ForegroundColor = ConsoleColor.White;
                    Console.WriteLine();
                }
                Console.WriteLine();
                Console.WriteLine();

                int j = 0;
                while (j == 0)
                {
                    Console.ForegroundColor = ConsoleColor.White;
                    Console.Write("Programm beenden? Ja / Nein: ");
                    string? str = Console.ReadLine();
                    Console.WriteLine();
                    switch (str?.ToUpper())
                    {
                        case "JA":
                            endCounter = 1;
                            j = 1;
                            break;
                        case "NEIN":
                            endCounter = 0;
                            j = 1;
                            break;
                        default:
                            Console.ForegroundColor = ConsoleColor.White;
                            Console.WriteLine("Falsche Eingabe. Bitte geben Sie Ja oder Nein ein.");
                            j = 0;
                            continue;
                    }
                }
            }



            /*Aufgabe______Berechne die IBAN aus Bankleitzehl und Kontonummer (Auftretende Ausnahmen werden noch nicht abgefangen!)*/

            //Console.WriteLine("ConsoleBerechneIBAN");
            //Console.WriteLine();
            //int endCounter = 0;
            //while (endCounter != 1)
            //{
            //    Console.WriteLine("Das Programm bestimmt die IBAN für ein Konto und Bankleitzahl in Deutschland");
            //    Console.WriteLine();
            //    Console.Write("Bitte geben Sie Ihre Bankleitzahl ein: ");
            //    string strBankleitzahl = Console.ReadLine()!.ToString();
            //    Console.Write("Bitte geben Sie Ihre Kontonummer ein: ");
            //    string strKontoNummer = Console.ReadLine()!.ToString();
            //    string strLandPlusPrüf = "131400";
            //    Console.WriteLine();
            //    //Methode zur IBAN-Ausgabe
            //    Console.WriteLine(BerechneIban(strBankleitzahl, strKontoNummer, strLandPlusPrüf));
            //    Console.WriteLine();
            //    Console.WriteLine();

            //    int j = 0;
            //    while (j == 0)
            //    {
            //        Console.ForegroundColor = ConsoleColor.White;
            //        Console.Write("Programm beenden? Ja / Nein: ");
            //        string str = Console.ReadLine()!.ToString();
            //        Console.WriteLine();
            //        switch (str.ToUpper())
            //        {
            //            case "JA":
            //                endCounter = 1;
            //                j = 1;
            //                break;
            //            case "NEIN":
            //                endCounter = 0;
            //                j = 1;
            //                break;
            //            default:
            //                Console.ForegroundColor = ConsoleColor.White;
            //                Console.WriteLine("Falsche Eingabe. Bitte geben Sie Ja oder Nein ein.");
            //                j = 0;
            //                continue;
            //        }
            //    }
            //}
        }

        /// <summary>
        /// Methode zur IBAN-Berechnung
        /// </summary>
        /// <param name="strBankleitzahl"></param>
        /// <param name="strKontoNummer"></param>
        /// <param name="strLandPlusPrüf"></param>
        /// <returns></returns>
        public static string BerechneIban(string strBankleitzahl, string strKontoNummer, string? strLandPlusPrüf)
        {
            BigInteger bNumber;
            bNumber = new BigInteger();
            string strIban;
            //Prüfe, ob KontoNr weniger als 10 Stellen hat
            if (strKontoNummer.Length < 10)
            {
                int int32Konto = Convert.ToInt32(strKontoNummer);
                strKontoNummer = int32Konto.ToString("D10");
            }
            //Berechne die Prüfsumme
            bNumber = BigInteger.Parse(strBankleitzahl + strKontoNummer + strLandPlusPrüf);
            bNumber = bNumber % 97;
            bNumber = 98 - bNumber;
            //Check, ob Prüfsumme zweistellig, wenn 'nein' fülle vorn eine 0 auf. Setze IBAN zusammen.
            if (bNumber < 10)
            {
                strLandPlusPrüf = bNumber.ToString("D2");
            }
            else
            {
                strLandPlusPrüf = Convert.ToString(bNumber);
            }
            strIban = ("Ihre IBAN lautet: DE" + strLandPlusPrüf + " " + strBankleitzahl.Substring(0, 4) + " " + 
                       strBankleitzahl.Substring(4, 4) + " " + strKontoNummer.Substring(0, 4) + " " + 
                       strKontoNummer.Substring(4, 4) + " " + strKontoNummer.Substring(8, 2));
            return strIban;
        }
    }
}
