using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace OOPSDEMO
{
    //Abstraction : Show the essential features and Hide the complexity.
    //It will Achieve with the help of abstract class and abstact method.
    public abstract class Abstract
    {
        //First use abstract keyword to create the abstract class.
        //We cannot able to create object for the abstract class.
        //Abstract and Non Abstract methods are present in the abstract class.
        public abstract void AbstractMethod();//This is abstract method and does not contain any body.
        //Regular Method.
        public void Method()
        {
            Console.WriteLine("Hii i am method");
        }
    }
}
