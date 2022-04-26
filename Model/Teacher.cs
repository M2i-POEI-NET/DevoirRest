using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Threading.Tasks;

namespace DevoirRest.Model
{
    /// <summary>
    ///     
    /// </summary>
    /// 
    [Table("core_t_teacher")]
    public class Teacher : BaseModel
    {
        [Column("course_id")]
        [ForeignKey("Course")]
        public int CourseId { get; set; }
        public Course Course { get; set; }
        /// <summary>
        ///  Configuration 1 -> * du coté de 1
        /// </summary>
        public ICollection<Comment> Comments { get; set; }
    }
}
