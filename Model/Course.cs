using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace DevoirRest.Model
{
    public class Course : BaseModel
    {
        public int TeacherId { get; set; }
        public Teacher Teacher { get; set; }


        /// <summary>
        ///  Configuration 1 -> * du coté de 1
        /// </summary>
        public ICollection<Enrollement> Enrollements { get; set; }
        public ICollection<HomeWork> HomeWorks { get; set; }
    }
}
