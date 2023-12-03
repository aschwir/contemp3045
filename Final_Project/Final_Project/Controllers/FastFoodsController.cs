
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


        //run the functions for fastfood
        [HttpGet]
        public IActionResult Get()
        {
            return Ok();

        }

        [HttpPost]

        



    }

}
