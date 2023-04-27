using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace OOPSDEMO
{
    // TypeCasting is used to assign a value of one datatype to another datatype.
    //There are two types of casting implicit and explicit.
    //Implicit : implicitily mean automatically convert a small type to a large type.
    //char => int => long => float => double.
    //Explicit : Explicit casting is should be manually.
    //Reverse of the implicit convert large to small.
    //double => float => long => int => char.
    public class Typecasting
    {
        public void Method() 
        {
            int value = 10;
            double valueOne = value;
            int valueTwo = 20;
           // long add = valueOne + valueTwo;
            Console.WriteLine(value);
            Console.WriteLine(valueOne);
            double valueThree = 10.05;
            int valueFour = (int)valueThree;
            Console.WriteLine(valueFour);
        }
    }
}
