using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp6
{
    public class Student : Person
    {
        public int Number { get; set; }
        public Student(string name, int number) : base(name)
        {
            this.Name = name;
            this.Number = number;
        }

    }
}
