using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CompleteGuitarApp.Model
{
    internal class Guitar
    {
        public string serialNumber { get; }
        public double price { get; set; }

        public GuitarSpec spec { get; }


       
        public Guitar(string serialNumber,
                        double price,
                        GuitarSpec spec)
        {
            this.serialNumber = serialNumber;
            this.price = price;
            this.spec = spec;
        }
    }
}
