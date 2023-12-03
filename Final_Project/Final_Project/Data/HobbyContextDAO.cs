using System.Collections.Generic; 
using Final_Project.Interfaces;
using Final_Project.Models;

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
            return _context.Hobbies.ToList();
        }
    }
}
