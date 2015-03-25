using ContosoUniversity.Models;
using System.Data.Entity;
using System.Data.Entity.ModelConfiguration.Conventions;
namespace ContosoUniversity.DAL
{
 public class SchoolContext : DbContext
 {
     //Connection string by default is 
     //Context class name:  "SchoolContext"
     public SchoolContext() : base("SchoolContext")
     {}

     public DbSet<Student> Students { get; set; }
     public DbSet<Enrollment> Enrollments { get; set; }
     public DbSet<Course> Courses { get; set; }


     protected override void OnModelCreating(DbModelBuilder modelBuilder)
     {
         //Disable/Remove pluralizing of table names
         modelBuilder.Conventions.Remove<PluralizingTableNameConvention>();
     }
  }
}