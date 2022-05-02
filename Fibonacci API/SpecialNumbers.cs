using System;

namespace Fibonacci_API
{
    public static class SpecialNumbers
    {

        /// <summary>
        /// Functie die eerst de meegegeven parameter absolute maakt en vervolgens in de recursieve functie gooit om
        /// te controleren of het getal in de Fibonacci reeks zit
        /// </summary>
        /// <param name="number">Het getal dat gecontroleerd moet worden</param>
        /// <returns>returned een string die beschrijft of het getal wel of niet in de reeks zit</returns>
        public static string InFibonacci(long number)
        {
            number = Math.Abs(number);   

            if (Fibonacci(number)) return "Getal zit in de eerste 52 getallen van de Fibonacci reeks";
            
            return "Getal zit niet in de eerste 52 getallen van de Fibonacci reeks";
        }

        /// <summary>
        /// Recursieve functie die tot 52 preimgetallen kan checken
        /// </summary>
        /// <param name="number">Het te controleren getal</param>
        /// <param name="count">De index van de Fibonacci reeks</param>
        /// <param name="prev">het vorige getal in de reeks</param>
        /// <param name="current">het huidige getal in de reeks</param>
        /// <returns>returned een bool die aangeeft of het getal wel off niet in de reeks zit</returns>
        public static bool Fibonacci(long number,int count = 0,long prev = 0, long current = 1)
        {
            if(count < 52)
            {
                if (number < prev) return false;
                if (number == prev) return true;
                
                return Fibonacci(number, count + 1, current, prev + current);
            }
            return false;
        }

        /// <summary>
        /// functie die kijkt of een getal een priemgetal is tot een maximale waarde
        /// </summary>
        /// <param name="number">het te controleren getal</param>
        /// <returns>returned een string met daarin de informatie over de uitkomst van de controle</returns>

        public static string IsPrime(long number)
        {
            if (number < 2) return "Getal is niet een Priemgetal";
            if (number == 2) return "Getal is een Priemgetal";

            long maxnumber = 10000000;
            if (number > maxnumber) return "Getal is te groot, pak een getal onder: " + maxnumber;

          
            double root = Math.Sqrt(number);

            if (number % 2 == 0) return "Getal is niet een Priemgetal";
            

            for (int i = 3; i < root; i = i + 2)
            {
                if (number % i == 0) return "Getal is niet een Priemgetal";
            }

            return "getal is een Priemgetal";
        }

        

      
    }
}