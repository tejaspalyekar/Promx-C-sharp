using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

//Abstraction can be achieved with either abstract classes or interfaces
//it is not pure abstraction bcos we can also define non abstract methods within abstract classes 

namespace Tejas
{
    //The abstract keyword is used for abstract classes and abstract methods
    //you cannot create object of abstract class
    abstract class Demo {  //abstract class

        //you can only define abstract methods but cant write abstract method body within abstract class it has to be done in child class
        public abstract void AreaOfCircle(int radius); // abstract method
        public abstract void PerimeterOfCircle(int radius); //abstract method

        public void display()  //non abstract method thats why it is possible to write body here
        {
            Console.WriteLine("non abstract method called");
        }

    }

    class Abstraction : Demo  //inherited abstract class demo inside abstraction class which is the name of the file Abstraction.cs(main class)
    {
        public override void AreaOfCircle(int radius) //writting body of abstract method (making abstract method public is necessay and using override keyword to
                                                      //to override the base class method.)
        {
            Console.WriteLine("Area of Circle is: "+3.14*radius*radius);
        }

        public override void PerimeterOfCircle(int radius)  //abstract method
        {
            Console.WriteLine("perimeter of Circle is "+2*(3.14*radius));
        }
        int TakeInput() //normal method of abstraction class
        {
            Console.WriteLine("Enter radius");
            int r = Convert.ToInt32(Console.ReadLine());
            return r;
        }
        public static void Main()
        {
            int radius;
            Abstraction ab = new Abstraction();
            radius = ab.TakeInput();  //calling takeiput normal method to take input radius and store in radius variable
            ab.AreaOfCircle(radius); // cal area of circle
            radius = ab.TakeInput();  //input of radius
            ab.PerimeterOfCircle(radius); //calculate perimeter
            ab.display();  //calling non abstract method from abstract class
            Console.ReadLine();
        }
    }
   
}
