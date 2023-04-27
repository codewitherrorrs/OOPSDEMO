using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace OOPSDEMO
{
    public class TypeReference
    {
        public void Method()
        {
            int value = 10;
            int valueOne = value;
            valueOne++;
            Console.WriteLine(value);
            Console.WriteLine(valueOne);
        }
    }
}
