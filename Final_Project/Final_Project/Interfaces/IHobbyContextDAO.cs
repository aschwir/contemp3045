
using Final_Project.Models;

namespace Final_Project.Interfaces
{
    public interface IHobbyContextDAO
    {

        List<Hobby> GetHobbies();

        Hobby GethobbyById(int id);
        Hobby AddHobby(Hobby hobby);
        Hobby UpdateHobby(int id, Hobby updatedhobby);
        Hobby DeleteHobby(int id);
    }
}
