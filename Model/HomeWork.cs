using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace DevoirRest.Model
{
    public class HomeWork : BaseModel
    {
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
