using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace overridingtostring
{
    class product3
    {
        string name;
        double price;
        public product(string name, float price)
        {
            this.name = name;
            this.price = price;
        }
        public override string ToString()
        {
            string s = string.Format("{0}", price);
            return "Product details:\n\t\t " + name + " " + s+" INR";
        }
    }
}
