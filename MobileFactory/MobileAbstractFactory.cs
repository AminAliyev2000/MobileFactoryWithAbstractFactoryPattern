using System;
using System.Collections.Generic;
using System.Text;

namespace MobileFactory
{
    abstract class MobileAbstractFactory
    {
        public abstract SmartPhone CreatePhone();
        public abstract SmartWatch CreateWatch();
    }
}
