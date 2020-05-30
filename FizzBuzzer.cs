using System;
using System.Collections.Generic;
using NUnit.Framework;

namespace FizzBuzzer
{
       
 
    public class FizzBuzzer
    {

        public bool Provjera(string rijec)
        {
            if (string.IsNullOrEmpty(rijec)) throw new ArgumentException();


            bool palindrom = false;
            bool razmak = false;
            bool velikoSlovo = false;
            bool maloSlovo = false;
            //1. zad
            for (int i = 0; i < rijec.Length / 2; i++)
            {
                if (rijec[i] != rijec[rijec.Length - 1 - i])
                {
                    palindrom = false;
                }
                else
                {
                    palindrom = true;
                }

            }

            //3. zad 
            foreach (char c in rijec)
            {
                if (char.IsUpper(c)) char.ToLower(c);
                if (char.IsPunctuation(c)) char.Parse(" ");
                if (char.IsSymbol(c)) char.Parse("x");
            }

            //2. zad
            foreach (char c in rijec)
            {
                if (char.IsUpper(c)) velikoSlovo = true;
                if (char.IsLower(c)) maloSlovo = true;
                if (char.IsWhiteSpace(c)) razmak = true;
            }
                                 
            return palindrom && velikoSlovo && maloSlovo && razmak;

           
        }
    }
}
//prolaze testovi kojima su sva 4 boolean-a tocna
//u prvom zadatku poslije for petlje bilo je return palindrom; i za rijesenje je davalo
//bilo koji palindorm bez obzira na veliko i malo slovo, razmak itd