using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.Remoting;
using System.Security.Cryptography.X509Certificates;
using System.Text;
using System.Threading.Tasks;

namespace Bread
{
    public class BreadWClass
    {

            public double weight { get; set; } 
            
            public double cost { get; set; }
       
            public string name { get; set; }
        

        public double Price()
        {
            return weight * cost;
        }
    }
}
