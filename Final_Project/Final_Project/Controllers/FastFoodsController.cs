
using Microsoft.AspNetCore.Mvc;
using Final_Project.Models;
using Final_Project.Interfaces;


namespace Final_Project.Controllers
{
    [ApiController]
    [Route("[controller]")]
    public class FastFoodsController : ControllerBase
    {
        //private readonly AppDBContext _Context;
        private readonly ILogger<FastFoodsController> _logger;
        private readonly IStudentsContextDAO _context;

        public FastFoodsController(ILogger<FastFoodsController> logger, IStudentsContextDAO context)
        {
            _logger = logger; 
            _context = context;
        }

        [HttpGet]
        public IActionResult GetFavoriteFoods(int? id)
        {
            var query = _Context.FavoriteFood.AsQueryable();

            if (id != null && id > 0)
            {
                var favoritefood = query.FirstOrDefault(ff => ff.Id == id);
                return Ok(favoritefood);
            }
            else
            {
                var FavoriteFoods = query.Take(5).ToList();
                return Ok(FavoriteFoods);
            }

        }

        [HttpPost]
 





}
