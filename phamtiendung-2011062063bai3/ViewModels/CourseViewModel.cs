
using phamtiendung_2011062063bai3.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace phamtiendung_2011062063bai3.ViewModels
{
    public class CourseViewModel
    {
        public string Place { get; set; }
        public string ngay { get; set; }
        public string thoigiann { get; set; }

        public byte loai { get; set; }
        public IEnumerable<Category> Categories { get; set; }
        public DateTime GetDateTime()
        {
            return DateTime.Parse(string.Format("{0} {1}", ngay, thoigiann));
        }
    }
}