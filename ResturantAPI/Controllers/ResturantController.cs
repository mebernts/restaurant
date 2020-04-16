using Microsoft.AspNetCore.Mvc;
using System.Collections.Generic;
using resturantAPI.Models;
using System.Threading.Tasks;
using Microsoft.EntityFrameworkCore;
using System.Linq;
using Microsoft.AspNetCore.Hosting;

namespace ResturantAPI.Controllers
{
    [ApiController]
    [Route("[controller]")]

    public class ResturantController : ControllerBase
    {
       private readonly DishesContext _context;
        
        private readonly IWebHostEnvironment _hosting;
        
        public ResturantController(DishesContext context,IWebHostEnvironment hosting)
        {
            _context = context;
            _hosting = hosting;
        }

        //Start på Route til de forskjellige tabellene i databasen

        [HttpGet]
        [Route("[action]")]
        public async Task<IEnumerable<Dishes>> Dishes()
        {
            List<Dishes> dishesList = await _context.Dishes.ToListAsync();

            return dishesList;
        }
        [HttpGet]
        [Route("[action]")]
        public async Task<IEnumerable<Appertizer>> Appertizer()
        {
            List<Appertizer> appetizerList = await _context.Appertizer.ToListAsync();

            return appetizerList;
        }
        [HttpGet]
        [Route("[action]")]
        public async Task<IEnumerable<Drinks>> Drinks()
        {
            List<Drinks> drinksList = await _context.Drinks.ToListAsync();

            return drinksList;
        }
        // Slutt på Route for database

        [HttpGet("{category}")] //filtering av kategorier 
        public async Task<IEnumerable<Dishes>> Get(string category)
        {
            List<Dishes> dishesList = await _context.Dishes
            .Where(dishes => dishes.category.Contains(category))
            .ToListAsync();

            return dishesList;
        }

        // GET, POST, DELETE og ADD Start bruk "id" for get. 
    


    }
}