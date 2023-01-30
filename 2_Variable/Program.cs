using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Variable{
    class Program{ 
        static void Main(string[] args){
            string Name   = "Keanu P. Berches";
            int Age       = 20;
            int Age2      = 21;
            char Grade    = 'A';
           // float decim   = 20.20; //least precise
            double decimA = 20.20;
           // decimal Decms=  1.12; //most precise decimal value
            bool switchs  = true;
            Console.WriteLine(Name);
            Console.WriteLine(Name.Substring(6));       //print only specific characters of text. Console.WriteLine(Variable.Substring(x,y)) = x is starting index and y HOW MANY index subsequent to print
            Console.WriteLine(Name.Contains("Berches")); //return true or false value; Console.WriteLine(Variable.Contains("Text you want to find"));
            Console.WriteLine(Name[2]);                 //Return what is the index of [x]
            Console.WriteLine(Name.IndexOf("P."));      //return index position of P.
            Console.ReadLine();

            Console.WriteLine("Numbers");
            Console.WriteLine(20+20-20 * 5 / 2);
            Console.WriteLine(20 % 3); //return remainder only
            Console.WriteLine(Math.Abs(-40)); //return positive
            Console.WriteLine(Math.Sqrt(25));
            Console.WriteLine(Math.Max(Age,Age2));
        }
    }
}
