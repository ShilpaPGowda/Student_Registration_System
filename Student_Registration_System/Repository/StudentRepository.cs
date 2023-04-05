using Student_Registration_System.Models;

namespace Student_Registration_System.Repository
{
    public class StudentRepository : IStudentRepository
    {
        private StudentContext _context;

        public StudentRepository(StudentContext context)
        {
            _context = context;
        }
        public IEnumerable<Student> GetAllStudents()
        {
            var result = new List<Student>();
            result = _context.Students.ToList();
            return result;
        }
        public Student AddStudent(Student student)
        {

            _context.Students.Add(student);
            _context.SaveChanges();
            var stud = _context.Students.FirstOrDefault(x => x.StudentID == student.StudentID);
            stud.Age = (int)((DateTime.Now - student.DateOfBirth).TotalDays / 365.242199);
            _context.SaveChanges();
            return student;
        }

        public bool DeleteStudent(int studid)
        {
            var student = _context.Students.SingleOrDefault(x => x.StudentID == studid);
            if (student != null)
            {
                _context.Students.Remove(student);
                _context.SaveChanges();
                return true;
            }
            return false;
            throw new NotImplementedException();
        }
        public bool Update(Student student)
        {
            var stud = _context.Students.SingleOrDefault(x => x.StudentID == student.StudentID);
            if (stud != null)
            {
                stud.FirstName = student.FirstName;
                stud.LastName = student.LastName;
                stud.DateOfBirth = student.DateOfBirth;
                stud.CourseName = student.CourseName;
                stud.HobbiesName = student.HobbiesName;
                _context.SaveChanges();
                return true;
            }
            return false;
        }
        public Student GetStudent(int id)
        {
            return _context.Students.SingleOrDefault(x => x.StudentID == id);
        }
    }
}
