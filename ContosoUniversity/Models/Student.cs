using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace ContosoUniversity.Models
{
    public class Student
    {
        //classNameID or ID member is interpreted by EF as PK.
        public int ID { get; set; }
        public string LastName { get; set; }
        public string FirstMidName { get; set; }
       
        public DateTime EnrollmentDate { get; set; }

        //Navigation Property: Holds other entities related to this entity 
        //"virtual" to take advantage of EF functionalities such as lazy loading
        //if 1 to many or many to many, has to be list type such as ICollection.
        public virtual ICollection<Enrollment> Enrollments { get; set; }
    }
}