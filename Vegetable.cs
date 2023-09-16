using System;
using System.Collections.Generic;
using System.Data.SqlClient;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Tejas
{
    internal class Vegetable
    {
        static double calculate(int kg, double total, int veg)
        {
            switch (veg) {
                case 1:
                    return total = 50 * kg; ;
                case 2:
                    return total = 60 * kg; ;
                case 3:
                    return total = 20 * kg; ;

            }

           /* if (veg == "carrot")
            {
                return total = 50 * kg;
               
            } else if (veg == "potato") {
                return total = 60 * kg;

            } else if (veg == "onion")
            {
                return total = 20 * kg;
            }*/

            return 0;
        }



            public static void Main()
        {
            var run = true;
            double total = 0;
            while (run == true)
            {
                Console.WriteLine("Select vegetable");
                Console.WriteLine("1. for carrot");
                Console.WriteLine("2. for potato");
                Console.WriteLine("3. for onion");
                Console.WriteLine("4. for exit");
                int veg = Convert.ToInt32(Console.ReadLine());
                Console.WriteLine(veg);
                if (veg == 4)
                {
                    Console.WriteLine("total before discount is " + total);

                    if (total>0 && total<100)
                    {
                        total = total - (total * 0.5);
                    }else if (total <= 400 && total > 100)
                    {
                        total = total - total*0.015;
                    }else if (total <= 900 && total > 400)
                    {
                        total = total - total * 0.17;

                    }
                    else{
                        total = total - total * 0.20;
                    }
                    Console.WriteLine("total after discount" + total);
                    run = false;
                    break;
                }                              
                else
                {
                    Console.WriteLine("enter kg");
                    String input = Console.ReadLine();
                    int kg = Convert.ToInt32(input);
                    total = total+ calculate(kg,total,veg);
                }
            }
            Console.ReadLine();
            
        }
    }
}
