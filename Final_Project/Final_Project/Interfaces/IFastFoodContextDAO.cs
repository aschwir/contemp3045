using Final_Project.Models;

namespace Final_Project.Interfaces
{
    public interface IFastFoodContextDAO
    {

        //all the required functions for fastfood

        List<FavoriteFood> getAllFavoriteFoods();
        FavoriteFood getFavoriteFoodById(int id);
        FavoriteFood AddFavoriteFood(FavoriteFood food);
        FavoriteFood UpdateFavoriteFood(int id, FavoriteFood updatedFood);
        FavoriteFood DeleteFavoriteFood(int id);
    }
}
