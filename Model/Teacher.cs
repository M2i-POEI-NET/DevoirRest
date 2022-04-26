using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace DevoirRest.Model
{
    /// <summary>
    ///     
    /// </summary>
    public class Teacher : BaseModel
    {
        public int CourseId { get; set; }
        public Course Course { get; set; }
    }
}
