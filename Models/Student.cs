using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace quiz_last.Models
{
    internal class Student
    {
        public Student()
        {
            this.Lectures = new List<Lecture>();
        }

        public int StudentId { get; set; }
        public string Name { get; set; }
        public DateTime EnrollmentDate { get; set; }
        public virtual List<Lecture> Lectures { get; set; }
    }
}
