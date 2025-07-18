using Demo.Enums;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Demo
{
    public class Student
    {
        internal int id { get; set; }
        internal string? name { get; set; }
        internal Gender gender { get; set; }
        public Grade grade { get; set; }
        public Branch branch { get; set; }
    }
}
