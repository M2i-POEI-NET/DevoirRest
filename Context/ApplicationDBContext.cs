using DevoirRest.Model;
using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace DevoirRest.Context
{
    public class ApplicationDBContext : DbContext
    {
        /// <summary>
        ///  overwrite the super constructor
        /// </summary>
        /// <param name="options"></param>
        public ApplicationDBContext(DbContextOptions<ApplicationDBContext> options) : base(options)
        {

        }


        public DbSet<Comment> Comments { get; set; }
        public DbSet<Course> Courses { get; set; }
        public DbSet<Enrollement> Enrollements { get; set; }
        public DbSet<HomeWork> HomeWorks { get; set; }
        public DbSet<Student> Students { get; set; }
        public DbSet<Teacher> Teachers { get; set; }


        protected override void OnModelCreating(ModelBuilder modelbuilder)
        {
            base.OnModelCreating(modelbuilder);
        }

    }
}
