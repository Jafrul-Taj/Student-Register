using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Threading.Tasks;

namespace SchollRegister.Data.Entity
{
    public class Course
    {
        [Key,Required]
        public int Id { get; set; }
        [Required]
        public string Name { get; set; }

        public IList<StudentCourse> StudentCourses { get; set; }
    }
}
