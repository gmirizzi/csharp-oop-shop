using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace csharp_oop_shop
{
    internal class Prodotto
    {
        public int code { get; }
        public string name { get; set; }
        public string description {get; set;}
        public decimal price {get; set;}
        public decimal iva {get; set;}

        public Prodotto(string name, double price)
        {
            this.code = new Random().Next();
            this.name = name;
            this.price = price;
        }
    }
}
