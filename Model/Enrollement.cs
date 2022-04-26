using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace DevoirRest.Model
{
    public class Enrollement : BaseModel
    {
        public int CourseId { get; set; }
        public int StudentId { get; set; }




        public Student Student { get; set; }
        public Course Course { get; set; }
    }
}
