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

        public Prodotto(string name, decimal price)
        {
            this.code = new Random().Next(0, 100000000);
            this.name = name;
            this.price = price;
        }

        public decimal getPriceWIva ()
        {
            decimal finalPrice = this.price + (this.price * this.iva / 100);
            return finalPrice;
        }

        public string getExtendedName ()
        {
            return $"{this.code} {this.name}";
        }

        public string formattedCode ()
        {
            string stringCode = Convert.ToString(this.code, 10);
            while (stringCode.Length<8)
            {
                stringCode = 0 + stringCode;
            }
            return stringCode;
        }
    }
}
