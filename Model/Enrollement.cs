using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Threading.Tasks;

namespace DevoirRest.Model
{
    /// <summary>
    ///     Join table between courses and students
    /// </summary>
    /// 
    [Table("core_tj_enrollement")]
    public class Enrollement : BaseModel
    {
        [Column("course_id")]
        [ForeignKey("Course")]
        public int CourseId { get; set; }

        [Column("student_id")]
        [ForeignKey("Student")]
        public int StudentId { get; set; }




        public Student Student { get; set; }
        public Course Course { get; set; }
    }
}
