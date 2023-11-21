using Final_Project.Interfaces;
using Final_Project.Models;

namespace Final_Project.Data
{
    public class StudentContextDAO : IStudentsContextDAO
    {
        private studentDBContext _context;
        public StudentContextDAO(studentDBContext context)
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

        public List<Student> GetAllTeams()
        {
            return _context.Students.ToList();
        }

        public Student GetTeamById(int id)
        {
            return _context.Students.Where(x => x.id.Equals(id)).FirstOrDefault();
        }

        public int? RemoveTeamById(int id)
        {

            var newStudent = this.GetTeamById(id);

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

        public int? UpdateTeam(Student student)
        {
            var studentToUpdate = this.GetTeamById(student.id);

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
