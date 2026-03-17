using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace task3
{
    class Onlineorder:Order
    {
        public double distance;
        public Onlineorder(int id, string name, int Count, double price,double distance):base(id,name,Count,price)
        {
            this.distance = distance; 
        }
    }
}
