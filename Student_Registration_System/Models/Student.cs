using System.ComponentModel.DataAnnotations.Schema;
using System.ComponentModel.DataAnnotations;
using System.Xml.Linq;
using test.Models;

namespace Student_Registration_System.Models
{
    public class Student
    {
        [Key]
        public int StudentID { get; set; }
        [Required]
        [StringLength(50)]
        public string FirstName { get; set; }
        [Required]
        [StringLength(50)]
        public string LastName { get; set; }
        [Required]
        [DataType(DataType.Date), DisplayFormat(DataFormatString = "{0:dd/MM/yyyy}", ApplyFormatInEditMode = true)]
        [MinimumAge(18, ErrorMessage = "Minimum required age should be 18")]
        [Display(Name = "Date of Birth")]
        public DateTime DateOfBirth { get; set; }
        public int Age { get; set; }

        [Display(Name = "Course")]
        public string CourseName { get; set; }

        [ForeignKey("CourseName")]
        public Course Courses { get; set; }


        [Display(Name = "Hobbies")]
        public string HobbiesName { get; set; }

        [ForeignKey("HobbiesName")]
        public Hobbies Hobbie { get; set; }
    }
}
