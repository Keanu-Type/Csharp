using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;


namespace inputs{
    class program{
        static void Main(string[] args){
            string name ;
            int age;
            double decim = 20;
            Console.Write("Enter Name: "); //no Enter
            name = Console.ReadLine(); //GET VALUE/INPUT and declare it
            Console.WriteLine("your name is: "+ name + "."); //output text+input
            Console.Write("Enter Age: ");
            age  = Convert.ToInt32(Console.ReadLine()); //Convert.ToInt32(variable/input) convert string to int
            Console.Write("Enter Decimal: ");
            decim =Convert.ToDouble(Console.ReadLine());
            Console.WriteLine(age+32);
            Console.WriteLine(decim+20.5);
        }
    }
}