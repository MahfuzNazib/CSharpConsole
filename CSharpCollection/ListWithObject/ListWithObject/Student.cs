﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ListWithObject
{
    public class Student
    {
        public int StudentCode { get; set; }
        public string StudentName { get; set; } = "";
        public string MajorCourse { get; set; } = "";
        public double CGPA { get; set; } = 0.00;
    }
}
