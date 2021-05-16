using System;
using System.Collections.Generic;
using System.Text;

namespace MobileFactory
{
    class Huawei : MobileAbstractFactory
    {
        public override SmartPhone CreatePhone()
        {
            return new HuaweiSmartphone();
        }

        public override SmartWatch CreateWatch()
        {
            return new HuaweiWatch();
        }
    }
}
