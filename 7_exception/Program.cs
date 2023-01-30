using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;


namespace excepting{
    class Program{
        static void Main(string[] args){
        bool switchs = true;
        int num;
        while (switchs){
            Console.Write("enternumber: ");

            //ERROR HANDLER EXCEPTION - incase there is a bug, this will handle it incase of outputing random text. 

            try{//TRY put ALL code that can run but can cause error if not run properly. for example entering string in a int variable
                num = Convert.ToInt32(Console.ReadLine());
                num = num + 20;
                Console.WriteLine(num);
                switchs = false;
            }catch(Exception e){ ////this code will be run if there is an error detected
                //exception e. will output what is the error technical explanation.
                Console.WriteLine("YOU DID NOT ENTER NUMBER");
                //use exception e here.
                Console.WriteLine(e.Message); 
                
           // }catch(FormatException e){
           //     Console.WriteLine(e.Message); //incase the error is related to format
           // }catch{ //without exception e.(default)

            }finally{ //this will be execute no matter what. if you want to execute something even if there is an error
                Console.WriteLine("Hello!");
            }
        }    
            
        }
    }

}