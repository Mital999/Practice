using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace JRPractice.Models
{
    public class Student
    {
       public int ID { get; set; }
        public string StudentName { get; set; }
        public string Address { get; set; }
        public string Class { get; set; }
        public int Age { get; set; }
        public string Hobbies { get; set; }
        public string Gender { get; set; }
        public int State { get; set; }
        public int City { get; set; }
        public long Pincode { get; set; }
        public string Photo { get; set; }

    }
    public class state
    {
       public int Stateid { get; set; }
       public int Statename { get; set; }
    }

    public class city
    {
        public int Cityid { get; set; }
        public string Cityname { get; set; }
        public int Stateid { get; set; }
    }
}