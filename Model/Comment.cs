using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Threading.Tasks;

namespace DevoirRest.Model
{
    [Table("core_t_comment")]
    public class Comment : BaseModel
    {
        [Column("home_work_id")]
        [ForeignKey("HomeWork")]
        public int HomeWorkId { get; set; }

        [Column("teacher_id")]
        [ForeignKey("Teacher")]
        public int? TeacherId { get; set; }

        [Column("student_id")]
        [ForeignKey("Student")]
        public int? StudentId { get; set; }


        /// <summary>
        ///     Configuration et migrations de clés
        /// </summary>
        public Teacher Teacher { get; set; }
        public Student Student { get; set; }
        public HomeWork HomeWork { get; set; }

    }
}
