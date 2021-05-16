using System;
using System.Collections.Generic;
using System.Text;

namespace MobileFactory
{
    class AppleSmartphone : SmartPhone
    {
        public AppleSmartphone()
        {
            Price = 100;
            Model = "IPhone SE";
        }
        public int Price { get ; set ; }
        public string Model { get; set; }
    }
}
