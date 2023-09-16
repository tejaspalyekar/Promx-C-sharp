using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Tejas
{
    //another way os achiving abstraction we can say pure abstraction is achived using interfaces for that we use interface keyword
    //An interface is a completely "abstract class", which can only contain abstract methods and properties (with empty bodies):

    //Note that you do not have to use the override keyword when implementing an interface:

    interface Idemo
    {
        //By default, members of an interface are abstract and public.
        void display(); 
        int add();
        int sub();
        int mul();

        /*void error()  cannot write body inside interface class bcos it supports pure abstraction       
        {
            Console.WriteLine();
        }*/
    }

    class Interface : Idemo
    {
        int x, y;
        public void takeinput() //normal method
        {
            Console.WriteLine("enter value for no1");
            x = Convert.ToInt32(Console.ReadLine());
            Console.WriteLine("enter value for no1");
            y = Convert.ToInt32(Console.ReadLine());
            
        }
        public void display() //normal class method
        {
            Console.WriteLine("Addition is "+add());
            Console.WriteLine("Subraction is "+sub());
            Console.WriteLine("Multiplication is "+mul());
        }

        public int add()  //abstract method
        {
            Console.WriteLine("performing addition");
            int ans = x + y;
            return ans;
        }
        public int sub() //abstract method
        {
            Console.WriteLine("performing subrraction");
            int ans = x - y;
            return ans;
        }
        public int mul() //abstract method
        {
            Console.WriteLine("performing multiplication");
            int ans = x * y;
            return ans;
        }
        public static void Main()
        {
            //Idemo i = new Idemo(); // cannot create object of interface class
            Interface i = new Interface();
            i.takeinput();
            i.display();
            Console.ReadLine();
        }
    }
}
