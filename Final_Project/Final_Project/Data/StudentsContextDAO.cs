using Final_Project.Interfaces;
using Final_Project.Models;
using System;
using System.Collections.Generic;
using System.Linq;

namespace Final_Project.Data
{

    public class StudentsContextDAO : IStudentsContextDAO
    {
        private readonly studentDBContext _context;

        public StudentsContextDAO(studentDBContext context)
        {
            _context = context;
        }

        public int? AddStudent(Student student)
        {
            if (student == null)
            {
                throw new ArgumentNullException(nameof(student));
            }



            var existingStudent = _context.Students.FirstOrDefault(x => x.fName.Equals(student.fName) && x.lName.Equals(student.lName));

            if (existingStudent != null)
            {

                return null;
            }

            try
            {
                _context.Students.Add(student);
                _context.SaveChanges();
                return student.id;
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
            return _context.Students.FirstOrDefault(x => x.id == id);
        }

        public int? RemoveStudentById(int id)
        {
            var studentToRemove = _context.Students.Find(id);

            if (studentToRemove == null)
            {

                return -1;
            }

            try
            {
                _context.Students.Remove(studentToRemove);
                _context.SaveChanges();
                return 1;
            }
            catch (Exception)
            {
                return 0;
            }
        }

        public int? UpdateStudent(int id, Student updatedStudent)
        {
            var studentToUpdate = _context.Students.Find(updatedStudent.id);

            if (studentToUpdate == null)
            {

                return -1;
            }

            studentToUpdate.fName = updatedStudent.fName;
            studentToUpdate.lName = updatedStudent.lName;
            studentToUpdate.birthdate = updatedStudent.birthdate;
            studentToUpdate.college_program = updatedStudent.college_program;
            studentToUpdate.year_in_program = updatedStudent.year_in_program;

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

