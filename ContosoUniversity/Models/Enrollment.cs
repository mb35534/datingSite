using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace ContosoUniversity.Models
{
    public enum Grade
    {
        A, B, C, D, F
    }

    public class Enrollment
    {
        public int EnrollmentID { get; set; }

        //FK
        public int CourseID { get; set; }

        //FK
        public int StudentID { get; set; }

        //"?" property can be nullable
        public Grade? Grade { get; set; }

        //Navigation Properties:
        public virtual Course Course { get; set; }
        public virtual Student Student { get; set; }
    }
}