using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace DevoirRest.Model
{
    public class Comment : BaseModel
    {
        public int HomeWorkId { get; set; }
        public int? TeacherId { get; set; }
        public int? StudentId { get; set; }


        /// <summary>
        ///     Configuration et migrations de clés
        /// </summary>
        public Teacher Teacher { get; set; }
        public Student Student { get; set; }
        public HomeWork HomeWork { get; set; }
    }
}
