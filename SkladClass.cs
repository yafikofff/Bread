using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Bread
{
    public class SkladClass
    {

        public BreadWClass bread { get; set; }
        public int available { get; set; }

        public bool Available(OrderClass order)
        {

            return order.amount <= available;
        }

    }
}
