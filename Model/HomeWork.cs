using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Threading.Tasks;

namespace DevoirRest.Model
{
    [Table("core_t_home_work")]
    public class HomeWork : BaseModel
    {
        [Column("course_id")]
        [ForeignKey("Course")]
        public int CourseId { get; set; }

        /// <summary>
        ///  Configuration 1 -> * du coté de *
        /// </summary>
        public Course Course { get; set; }
        /// <summary>
        ///  Configuration 1 -> * du coté de 1
        /// </summary>
        public ICollection<Comment> Comments { get; set; }
    }
}
