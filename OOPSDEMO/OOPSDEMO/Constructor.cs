using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace OOPSDEMO
{
    public class Constructor
    {
        //Non Parameter Constructor
        public Constructor() 
        {
            Console.WriteLine("Hii I am non parameterized constructor");
        }
        //Parameter Constructor
        public Constructor(string s)
        {
            Console.WriteLine(s);
        }
    }
}
