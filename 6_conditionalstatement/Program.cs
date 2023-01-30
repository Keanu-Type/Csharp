using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;


namespace statements{
    class program{
        static void Main(string[] args){
            bool isMale = true;
            bool isTall = true;

            //conditional signs: && (and), ||(or), == equal, <> or != not equal, >=
            
            
            //IF STATEMENT
            //if (true)

            Console.WriteLine("YOUR GENDER");
            string gender = isIf(isMale,isTall);
            Console.WriteLine(gender);

            Console.WriteLine("Enter Day Number");
            int num = Convert.ToInt32(Console.ReadLine());
            Console.WriteLine(sDay(num));

            Console.WriteLine("Enter Number to While");
            int nums = Convert.ToInt32(Console.ReadLine());
            Console.WriteLine(isWhile(nums));

            Console.WriteLine("Enter for ForLoop");
            int nums3 = Convert.ToInt32(Console.ReadLine());
            Console.WriteLine(isFor(nums3));

        }

        //IF STATEMENT
        static string isIf(bool condi, bool condi2){
            string gender;
            if(condi || condi2){
                gender = "you are Male";
            }else{
                gender = "you are not Male";
            }
            return gender;
        }

        //SWITCH STATEMENT       
        static string sDay(int daynumber){
            string dayName;
            switch(daynumber){
                case 0:
                    dayName = "Sunday";
                    break;
                case 1:
                    dayName = "Monday";
                    break;
                case 2:
                    dayName = "Tuesday";
                    break;
                case 3:
                    dayName = "Wednesday";
                    break;
                case 4:
                    dayName = "Thursday";
                    break;
                default:
                    dayName = "NO SCHEDULE";
                    break;
            }
            return dayName;
        }

        //While Statement
        static int isWhile(int nums){
            int total = nums + 5;
        //while(condition){};
            while(nums <= total){
                nums++;
            }
            return nums;
        }

        static int isFor(int nums){
            int total = nums+5;
            int returntotal = 0;
        // for(int i = 0; i <= limit; i++){condition}
            for(int i = nums; i <=total; i++){
                //condition here
                returntotal = i;
            }
            return returntotal;
        }
    }
}