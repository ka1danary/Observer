using System;
using System.Collections.Generic;
using System.Text;

namespace Observer_1.Interfaces
{
    internal interface Observe
    {
       public void update(double temperature, double pressure, double humidity);
    }
}
