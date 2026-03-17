using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace task3
{
    class Order
    {
        public int id;
        public string name;
        public int Count;
        public double price;

        public Order(int id, string name, int Count, double price)
        {
            this.id = id;
            this.name = name;
            this.Count = Count;
            this.price = price;
        }
        public Order(int id, string name, double price)
        {
            this.id = id;
            this.name = name;
            this.Count = 1;
            this.price = price;
        }
        public double TotalPrice()
        {
            return Count * price;
        }
        public void Incrise(int n)
        {
            Count += n;
        }
        public void ShowInfo()
        {
            Console.WriteLine($"adi:{name}, Qiymet{price}, Miqdar{Count}, UmumiQiymet{TotalPrice()}");
        }
    }; 
}
