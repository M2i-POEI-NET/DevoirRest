using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Threading.Tasks;

namespace DevoirRest.Model
{
    [Table("core_t_course")]
    public class Course : BaseModel
    {
        [Column("teacher_id")]
        [ForeignKey("teacher")]
        public int TeacherId { get; set; }
        public Teacher Teacher { get; set; }


        /// <summary>
        ///  Configuration 1 -> * du coté de 1
        /// </summary>
        public ICollection<Enrollement> Enrollements { get; set; }
        public ICollection<HomeWork> HomeWorks { get; set; }
    }
}
