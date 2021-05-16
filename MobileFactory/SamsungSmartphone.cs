using System;
using System.Collections.Generic;
using System.Text;

namespace MobileFactory
{
    class SamsungSmartphone : SmartPhone
    {
        public SamsungSmartphone()
        {
            Price = 80;
            Model = "Samsung A3";
        }
        public int Price { get; set; }
        public string Model { get; set; }
    }
}
