using System.Collections.Generic;
using System;
using System.Linq;
using System.Text;
using System.Threading.Tasks;


namespace ConsoleApp6
{
    public class Class
    {
        public int Id { get; set; }
        public string Group { get; set; }
        public List<Teacher> Teachers { get; set; }
        public List<Student> Students { get;  }
        public Class (int id, string group)
        {
            this.Group = group;
            this.Id = id;
            this.Students = new List<Student>();
            this.Teachers = new List<Teacher>();
        }
        public void AddTeacher ( Teacher teacher)
        {
            Teachers.Add(teacher);
        }
        public void AddStudent ( Student student)
        {
            Students.Add(student);
        }
        
       
    }
}
