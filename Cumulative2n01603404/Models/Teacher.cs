﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace Cumulative2n01603404.Models
{
    public class Teacher
    {
        //The following fields define an Teacher
        public int TeacherId;
        public string TeacherFname;
        public string TeacherLname;
        public string EmployeeNumber;
        public DateTime HireDate;
        public decimal Salary;

        //parameter-less constructor function
        public Teacher() { }
    }
}