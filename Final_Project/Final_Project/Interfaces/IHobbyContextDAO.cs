using System.Collections.Generic;
using Final_Project.Models;

namespace Final_Project.Interfaces
{
    public interface IHobbyContextDAO
    {
      
        List<Hobby> GetHobbies();
    }
}
