using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Lab0_1240319_1132718.Models;
using Microsoft.EntityFrameworkCore;
namespace Lab0_1240319_1132718.Datos
{
    public class ContextoNegocio : DbContext
    {
        public ContextoNegocio(DbContextOptions<ContextoNegocio>options) :base(options)
        {
        }
    //    public DbSet<Producto> Enrollments { get; set; }
    //    public DbSet<Student> Students { get; set; }

    //    protected override void OnModelCreating(ModelBuilder modelBuilder)
    //    {
    //        modelBuilder.Entity<Course>().ToTable("Course");
    //        modelBuilder.Entity<Enrollment>().ToTable("Enrollment");
    //        modelBuilder.Entity<Student>().ToTable("Student");
    //    }
    }
}
