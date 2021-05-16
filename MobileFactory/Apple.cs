using System;
using System.Collections.Generic;
using System.Text;

namespace MobileFactory
{
    class Apple : MobileAbstractFactory
    {
        public override SmartPhone CreatePhone()
        {
            return new AppleSmartphone();
        }

        public override SmartWatch CreateWatch()
        {
            return new AppleWatch();
        }
    }
}
