using Demo.UserDefiendDataTypes;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Test
{
    internal class ClassC : ClassA
    {
        public ClassC()
        {
            SetX(12);
            // z = 1; // not allowed
            // w =2; // not allowed

            //  ClassA classA = new ClassA();
            //  classA.n = 12; // not allowed
            n = 3;
        }

    }
}
