using System.Security.Cryptography.X509Certificates;

namespace OOPSDEMO
{
    public class Program : MethodOverloading
    {
        public static void Main(string[] args)
        {
           Program obj = new Program();
            obj.Method();
            obj.Method(5);
        }
    }
}