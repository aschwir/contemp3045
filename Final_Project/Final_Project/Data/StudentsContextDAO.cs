using Final_Project.Interfaces;
using Final_Project.Models;

namespace Final_Project.Data
{
    public class StudentsContextDAO : IStudentsContextDAO
    {
        private studentDBContext _context;
        public StudentsContextDAO(studentDBContext context)
        {
            _context = context;
        }

        public int? Add(Student student)
        {
            var newStudent = _context.Students.Where(x => x.fName.Equals(student.fName) && x.lName.Equals(student.lName)).FirstOrDefault();

            if (newStudent != null) return null;

            try
            {


                _context.Students.Add(student);
                _context.SaveChanges();
                return 1;

            }
            catch (Exception)
            {
                return 0;
            }

        }

        public List<Student> GetAllStudents()
        {
            return _context.Students.ToList();
        }

        public Student GetStudentById(int id)
        {
            return _context.Students.Where(x => x.id.Equals(id)).FirstOrDefault();
        }

        public int? RemoveStudentById(int id)
        {

            var newStudent = this.GetStudentById(id);

            if (newStudent == null) return null;

            try
            {
                _context.Students.Remove(newStudent);
                _context.SaveChanges();
                return 1;
            }
            catch (Exception ex)
            {
                return 0;
            }

        }

        public int? UpdateStudent(Student student)
        {
            var studentToUpdate = this.GetStudentById(student.id);

            if (studentToUpdate == null) return null;

            studentToUpdate.fName = student.fName;
            studentToUpdate.lName = student.lName;
            studentToUpdate.birthdate = student.birthdate;
            studentToUpdate.college_program = student.college_program;
            studentToUpdate.year_in_program = student.year_in_program;


            try
            {
                _context.Students.Update(studentToUpdate);
                _context.SaveChanges();
                return 1;

            }
            catch (Exception)
            {
                return 0;
            }


        }
    }
}
