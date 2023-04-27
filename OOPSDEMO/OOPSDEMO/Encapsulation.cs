using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace OOPSDEMO
{
    //It will Hide a sensitive data from the user.
    //Declare field and variable should be in private.
    //get is only readonly and set is only writeonly.
    public class Encapsulation
    {
        //Define field and variable is in private.
        private string name = "sagar";
        public string Name // Properties
        {
            get { return name; } 
            set { name = value; } //It will assign a value to the name.
        }
        //Automatically.
        public int Roll
        {
            get; set;
        }
    }
}
