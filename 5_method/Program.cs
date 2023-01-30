using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace methods{
    class program{
        static void Main(String[] args){
            SayHi(); //call Say HI method void no return
            hellos("keanu"); //call hellos void no return
            plus(20); //call plus method with return
            Console.WriteLine(plus(20)); //call plus method with return inside console writeline
        }


    //      void = no return
        static void SayHi(){//METHOD VOID
            Console.WriteLine("HELLO USER");
        }                
        static void hellos(string name){ //METHOD VOID WITH VALUE
            Console.WriteLine("Hello with input: " + name);
        }

        static int plus(int num){   //METHOD WITH RETURN
    //  static type functionname(type variable)    
            return (num+20);
        }
    }
}