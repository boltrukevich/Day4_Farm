using System;
using System.Collections;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Day4_Farm
{
    class Product
    {
        string name;
        int weight;
        public Product(string name, int weight) { name = "" ; weight = 0; }
        public static Product product = new Product("", 0);
        public static Product milk = new Product("Milk", 8);
        public static Product meat = new Product("Meat", 73);
        public static Product wool = new Product("Wool", 12);
    }
}       