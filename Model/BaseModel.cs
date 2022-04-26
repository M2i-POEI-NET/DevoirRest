using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Threading.Tasks;

namespace DevoirRest.Model
{
    /// <summary>
    ///     use to make genericity in model
    /// </summary>
    public abstract class BaseModel
    {
        [Key]
        [DatabaseGenerated(DatabaseGeneratedOption.Identity)]
        [Column("id")]
        public int Id { get; set; }

        [Column("code")]
        [MaxLength(50)]
        public virtual string Code { get; set; }

        [Column("name")]
        [MaxLength(50)]
        public virtual string Name { get; set; }

        [Column("created_at")]
        public DateTime CreatedAt { get; set; }

        [Column("update_at")]
        public DateTime UpdatedAt { get; set; }

        [Column("is_active")]
        public bool IsActive { get; set; }

        /// <summary>
        ///      Use to perform all the creations
        /// </summary>
        /// <param name="IsActive"></param>
        public void BaseCreate (bool IsActive)
        {
            this.CreatedAt = DateTime.Now;
            this.UpdatedAt = DateTime.Now;
            this.IsActive = IsActive;
        }

        /// <summary>
        ///     Use to perform all the update and delete actions in DB
        /// </summary>
        /// <param name="IsActive"></param>
        public void BaseUpdate (bool IsActive)
        {
            this.UpdatedAt = DateTime.Now;
            this.IsActive = IsActive;
        }


    }
}
