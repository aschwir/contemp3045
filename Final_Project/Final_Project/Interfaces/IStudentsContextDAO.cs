using Final_Project.Models;

namespace Final_Project.Interfaces
{
    public interface IStudentsContextDAO
    {
        List<Student> GetAllStudents();
        public Student GetStudentById(int studentId);
        int? RemoveStudentById(int id);
        int? UpdateStudent(int id, Student updatedStudent);

        int? AddStudent(Student student);

    }
}
