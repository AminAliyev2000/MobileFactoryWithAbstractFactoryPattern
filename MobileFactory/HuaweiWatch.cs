using System;
using System.Collections.Generic;
using System.Text;

namespace MobileFactory
{
    class HuaweiWatch : SmartWatch
    {
        public HuaweiWatch()
        {
            Price = 25;
            Model = "Huawei Watch 1";
        }
        public int Price { get; set; }
        public string Model { get; set; }
    }
}
