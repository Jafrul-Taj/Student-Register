using Microsoft.EntityFrameworkCore;
using SchollRegister.Data.Entity;

namespace SchollRegister
{
    public class SchoolContext : DbContext
    {
        public DbSet<Student> Students { get; set; }

        public DbSet<Course> Courses { get; set; }

        public DbSet<StudentCourse> StudentCourses { get; set; }
        public SchoolContext(DbContextOptions options) :
            base(options)
        {

        }

        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {

            modelBuilder.Entity<StudentCourse>()
                .HasKey(cc => new { cc.CourseId, cc.StudentId });


            modelBuilder.Entity<StudentCourse>()
                .HasOne(SC => SC.Student)
                .WithMany(S => S.StudentCourses).HasForeignKey(SC => SC.StudentId);

            modelBuilder.Entity<StudentCourse>()
                .HasOne(SC => SC.Course)
                .WithMany(S => S.StudentCourses).HasForeignKey(SC => SC.CourseId);



            base.OnModelCreating(modelBuilder);

        }

    }
}