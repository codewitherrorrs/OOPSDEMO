using System.Security.Cryptography.X509Certificates;

namespace OOPSDEMO
{
    public class Program : Reference
    {
        public static void Main(string[] args)
        {
            Program obj = new Program();
            int value = 10;
            obj.MethodReference(ref value);  
        }
    }
}