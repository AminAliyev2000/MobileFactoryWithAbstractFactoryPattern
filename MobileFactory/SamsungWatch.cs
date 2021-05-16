using System;
using System.Collections.Generic;
using System.Text;

namespace MobileFactory
{
    class SamsungWatch : SmartWatch
    {
        public SamsungWatch()
        {
            Price = 25;
            Model = "Samsung Watch 2";
        }
        public int Price { get; set; }
        public string Model { get; set; }
    }
}
