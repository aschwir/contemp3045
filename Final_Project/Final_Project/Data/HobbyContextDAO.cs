using Final_Project.Interfaces;
using Final_Project.Models;
using System;
using System.Collections.Generic;
using System.Linq;

namespace Final_Project.Data
{
    public class HobbyContextDAO : IHobbyContextDAO
    {
        private studentDBContext _context;

        public HobbyContextDAO(studentDBContext context)
        {
            _context = context;
        }

        public List<Hobby> GetHobbies()
        {
            return _context.Hobby.ToList();
        }

        public Hobby GethobbyById(int id)
        {
            return _context.Hobby.Find(id);
        }

        public Hobby AddHobby(Hobby hobby)
        {
            if (hobby == null)
            {
                throw new ArgumentNullException(nameof(hobby));
            }

            _context.Hobby.Add(hobby);
            _context.SaveChanges();
            return hobby;
        }

        public Hobby UpdateHobby(int id, Hobby updatedHobby)
        {
            var existingHobby = _context.Hobby.Find(id);

            if (existingHobby != null)
            {
                existingHobby.Name = updatedHobby.Name;
                existingHobby.Description = updatedHobby.Description;
               

                _context.SaveChanges();
                return existingHobby;
            }
            else
            {
                throw new InvalidOperationException("Hobby not found");
            }
        }

        public Hobby DeleteHobby(int id)
        {
            var hobbyToDelete = _context.Hobby.Find(id);

            if (hobbyToDelete != null)
            {
                _context.Hobby.Remove(hobbyToDelete);
                _context.SaveChanges();
                return hobbyToDelete;
            }
            else
            {
                throw new InvalidOperationException("Hobby not found");
            }
        }
    }
}
