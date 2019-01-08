using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp6
{
    public class School
    {
        public string Name { get; set; }
        public List<Class> Classes { get; set; }
        public School ( string name)
        {
            this.Name = name;
            this.Classes = new List<Class>();
        }
        public void AddClasses (Class newClass )
        {
            Classes.Add(newClass);
        }
       
    }
}
