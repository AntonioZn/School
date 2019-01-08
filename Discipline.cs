﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp6
{
    public class Discipline
    {
        
        public string Name { get; set; }
        public int NumberOfLectures { get; set; }
        public int NumberOfExercises { get; set; }

        public Discipline ( string name , int numberOfLectures, int numberOfExercises)
        {
            this.Name = name;
            this.NumberOfExercises = numberOfExercises;
            this.NumberOfLectures = numberOfLectures;
        }
    }
}
