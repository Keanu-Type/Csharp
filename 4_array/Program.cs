using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace arrays{
    class program{
        static void Main(string[] args){
       //ARRAY
       //  type[] variable = {0,1,2,3,4,5};   
            int[] lucknum = {1,2,3,4,5}; //Array with fixed value inside
            string[] friends = new string[5]; //Array with telling how many fixed element it has. this one has 5 limit
            friends[0] = "haya"; 
            Console.WriteLine(lucknum[0]);

       //2DAY ARRAY
       //  type[,] variable   = {{element,for,x},{element,for,y}};
            int[,] numberGrid = {{1,2,3,4,5},{6,7,8,9,10}};
        //actual Map:
        //  int[,] numberGrid = {
        //      {1,2,3,4,5},
        //      {6,7,8,9,10}
        //}
                Console.WriteLine(numberGrid[1,2]);//8 IS OUTPUT
        }
    }
}