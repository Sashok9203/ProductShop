using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace WinFormsApp1
{
    public class Product
    {
        public string Name { get; set; }
        public string Country { get; set; }
        public double Price { get; set; }
        public double Discount { get; set; }
        public int Count { get; set; }
        public Product(string? name,string? country,double price,double discont,int count)
        {
            Name = name ?? "no name";
            Country = country ?? "no country";
            Price = price;
            Discount = discont;
            Count = count;
        }
        public override string ToString() => $"\"{Name}\" - \"{Country}\" - {Price:C2}";
    }
}
