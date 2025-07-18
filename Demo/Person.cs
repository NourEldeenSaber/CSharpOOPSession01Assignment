using Demo.Enums;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Demo
{
    public class Person
    {
        internal int Id { get; set; }
        internal string? Name { get; set; }
        public Gender gender { get; set; }
    }
}
