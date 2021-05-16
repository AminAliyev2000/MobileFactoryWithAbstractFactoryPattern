using System;
using System.Collections.Generic;
using System.Text;

namespace MobileFactory
{
    class Samsung : MobileAbstractFactory
    {
        public override SmartPhone CreatePhone()
        {
            return new SamsungSmartphone();
        }

        public override SmartWatch CreateWatch()
        {
            return new SamsungWatch();
        }
    }
}
