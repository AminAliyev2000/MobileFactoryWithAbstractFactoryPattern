using System;
using System.Collections.Generic;
using System.Text;

namespace MobileFactory
{
    class AppleWatch : SmartWatch
    {
        public AppleWatch()
        {
            Price = 45;
            Model = "IWatch 4";
        }
        public int Price { get; set; }
        public string Model { get; set; }
    }
}
