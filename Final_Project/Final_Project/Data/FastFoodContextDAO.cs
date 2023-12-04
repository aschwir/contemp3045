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
        public FavoriteFood getFavoriteFoodById(int id)
        {
            return _context.FavoriteFood.Find(id);
        } 

        public FavoriteFood AddFavoriteFood(FavoriteFood food)
        {
            _context.FavoriteFood.Add(food);
            _context.SaveChanges();
            return food;
        }

        public FavoriteFood UpdateFavoriteFood(int id, FavoriteFood updatedFood)
        {
            var existingFood = _context.FavoriteFood.Find(id);

            if (existingFood != null)
            {
                existingFood.Name = updatedFood.Name;
                existingFood.Cuisine = updatedFood.Cuisine;
                existingFood.Description = updatedFood.Description;

                _context.FavoriteFood.Update(existingFood);
                _context.SaveChanges();
            }

            return existingFood;
        }

        public FavoriteFood DeleteFavoriteFood(int id)
        {
            var food = _context.FavoriteFood.Find(id);
            if (food != null)
            {
                _context.FavoriteFood.Remove(food);
                _context.SaveChanges();
            }
            return food;
        }
       

        }
    
}
