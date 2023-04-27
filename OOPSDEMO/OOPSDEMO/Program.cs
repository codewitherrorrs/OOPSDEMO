using System.Security.Cryptography.X509Certificates;

namespace OOPSDEMO
{
    public class Program : Abstract
    {
        public static void Main(string[] args)
        {
           Program obj = new Program();
            obj.AbstractMethod();
        }

        //This is Abstract Method.
        //Override : override keyword will override the base class method to the derived class.
        public override void AbstractMethod()
        {
            Console.WriteLine("Hii i am abstract");
        }
    }
}