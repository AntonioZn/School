using ConsoleApp6;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Runtime.Serialization;
using Newtonsoft.Json;
using System.IO;

namespace MainSchool
{
    class Program
    {
        static void Main()

        { 
                 
        
            Class firstClass = new Class(8, "A");
            var disciplines = new List<Discipline>();

            disciplines.Add(new Discipline("Logic", 5, 10));
            disciplines.Add(new Discipline("Sports", 3, 6));
            disciplines.Add(new Discipline("Fun", 3, 6));
            disciplines.Add(new Discipline("Physics", 2, 4));

            firstClass.AddTeacher(new Teacher("Svetlio", disciplines));
            firstClass.AddTeacher(new Teacher("Antonio" ));
            firstClass.AddStudent(new Student("Yoanna", 13));
            firstClass.AddStudent(new Student("Svetlio", 2));
            firstClass.AddStudent(new Student("Muhlio", 1));
            firstClass.AddStudent(new Student("Zdravkou", 15));
            firstClass.AddStudent(new Student("Zueka", 59));

            var school = new School("Agricultural University of Plovdiv");
            school.AddClasses(firstClass);

            
            
            File.AppendAllText("C:\\Users\\anton\\OneDrive\\Desktop\\School.txt", JsonConvert.SerializeObject(school, Formatting.Indented));

            



        }

    }
}
