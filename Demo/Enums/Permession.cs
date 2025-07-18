using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Demo.Enums
{
    [Flags]
    public enum Permession : byte
    {
        Delete = 1,
        Execute = 2, 
        Read = 4,
        Write = 8
    }
}
