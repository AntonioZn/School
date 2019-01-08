using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp6
{
    public class Teacher : Person
    {
        public List<Discipline> Disciplines { get; set; }
        public Teacher (string name , List<Discipline> disciplines) : base(name)
        {
            this.Name = name;
            this.Disciplines = disciplines;
        }

        public Teacher(string name) : base(name)
        {
        }
        public void AddDiscipline(Discipline discipline)
        {
            Disciplines.Add(discipline);
        }
       
    }
}
