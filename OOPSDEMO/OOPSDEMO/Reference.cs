using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace OOPSDEMO
{
    public class Reference
    {
        public void MethodReference(ref int num)
        {
            num = num * num;
            Console.WriteLine(num);
        }
    }
}
