using System;
using System.Collections.Generic;
using System.Text;

namespace MobileFactory
{
    class HuaweiSmartphone : SmartPhone
    {
        public HuaweiSmartphone()
        {
            Price = 30;
            Model = "Huawei A20";
        }
        public int Price { get; set; }
        public string Model { get; set; }
    }
}
