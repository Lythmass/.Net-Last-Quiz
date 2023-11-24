using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace quiz_last.Models
{
    internal class Lecture
    {
        public Lecture() 
        { 
            this.Students = new List<Student>();
        }
        public int LectureId { get; set; }
        public string Title { get; set; }
        public DateTime Date { get; set; }
        public int Capacity { get; set; }
        public virtual List<Student> Students { get; set; }
    }
}
