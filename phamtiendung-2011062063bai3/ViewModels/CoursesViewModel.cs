﻿using phamtiendung_2011062063bai3.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace phamtiendung_2011062063bai3.ViewModels
{
    public class CoursesViewModel
    {
      public IEnumerable<Course> UpcommingCourses { get; set; } 
        public bool ShowAction { get; set; }
    }
}