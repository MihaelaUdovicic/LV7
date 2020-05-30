
using NUnit.Framework;
using System;

namespace FizzBuzz.Test
{
    [TestFixture]
    public class FizzBuzzTests
    {
        //arrange
        FizzBuzzer.FizzBuzzer fizz = new FizzBuzzer.FizzBuzzer();
        //samo na ovaj nacin mi zeli dati objekt


        [TestCase("dovod")]
        [TestCase("palindrom")]
        [TestCase()]
        [TestCase("Evo sada sove")]
        [TestCase("evosadasove")]
        [TestCase(" Ivi - Ivi.")]
        [TestCase("x Dovod #")]
        public void Convert_Palindrom(string input)
        {
            bool expected = true;
            //act
            bool actual = fizz.Provjera(input);
            //assrt
            Assert.AreEqual(expected, actual);

        }

        
    }
}
