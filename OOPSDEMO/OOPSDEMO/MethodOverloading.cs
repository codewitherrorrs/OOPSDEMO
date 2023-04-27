using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace OOPSDEMO
{
    //Polmorphism : One name Many form.
    //Method Overloading : Compile Time
    //It will Contain many method with different parameter.
    //Method Overriding : Run-Time.
    public class MethodOverloading
    {
        public void Method()
        {
            Console.WriteLine("Method without Parameter");
        }
        public void Method(int a)
        {
            Console.WriteLine("Method with Parameter : "+a);
        }
    }
}
