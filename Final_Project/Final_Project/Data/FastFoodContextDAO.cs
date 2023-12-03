using Final_Project.Interfaces;
using Final_Project.Models;

namespace Final_Project.Data
{
    public class FastFoodContextDAO : IFastFoodContextDAO
    {
        private studentDBContext _context;
        public FastFoodContextDAO(studentDBContext context)
        {
            _context = context;
        }


        //fuctions for fastfood 
        public List<FavoriteFood> getAllFavoriteFoods()
        {
            return _context.FavoriteFood.ToList();
        }
        

        }
    }
}
