using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Threading.Tasks;

namespace DevoirRest.Model
{
    [Table("core_t_student")]
    public class Student : BaseModel
    {
        [Column("matricule")]
        public override string Code { get; set; }

        /// <summary>
        ///  Configuration 1 -> * du coté de 1
        /// </summary>
        public ICollection<Enrollement> Enrollements { get; set; }

        /// <summary>
        ///  Configuration 1 -> * du coté de 1
        /// </summary>
        public ICollection<Comment> Comments { get; set; }
    }
}
