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

        // Post Request Starts
        
        [HttpPost]
        [Route("[action]")]
        public async Task<Dishes> PostDish(Dishes newDish)
        {
            _context.Dishes.Add(newDish);
            await _context.SaveChangesAsync();
            return newDish;
        }
        [HttpPost]
        [Route("[action]")]
        public async Task<Appertizer> PostAppertizer(Appertizer newDish)
        {
            _context.Appertizer.Add(newDish);
            await _context.SaveChangesAsync();
            return newDish;
        }
        [HttpPost]
        [Route("[action]")]
        public async Task<Drinks> PostDrink(Drinks newDish)
        {
            _context.Drinks.Add(newDish);
            await _context.SaveChangesAsync();
            return newDish;
        }
        // Post Request Ends

        // Get Requests Start
        [HttpGet("{id}")]
        [Route("[action]/{id}")]
        public async Task<Dishes> GetDish(int id)
        {
            Dishes chosenDish = await _context.Dishes.FirstOrDefaultAsync(dishes => dishes.Id == id);
            return chosenDish;
        }
        [HttpGet("{id}")]
        [Route("[action]/{id}")]
        public async Task<Drinks> GetDrink(int id)
        {
            Drinks chosenDrink = await _context.Drinks.FirstOrDefaultAsync(drinks => drinks.Id == id);
            return chosenDrink;
        }
        [HttpGet("{id}")]
        [Route("[action]/{id}")]
        public async Task<Appertizer> GetAppertizer(int id)
        {
            Appertizer chosenAppertizer = await _context.Appertizer.FirstOrDefaultAsync(appertizer => appertizer.Id == id);
            return chosenAppertizer;
        }
// Get request Ends

// Put request Starts
        
        [HttpPut]
        [Route("[action]")]
        public async Task<Dishes> PutDish(Dishes changeDish)
        {
            _context.Update(changeDish);
            await _context.SaveChangesAsync();
            return changeDish;
        }
        [HttpPut]
        [Route("[action]")]
        public async Task<Drinks> PutDrink(Drinks changeDrink)
        {
            _context.Update(changeDrink);
            await _context.SaveChangesAsync();
            return changeDrink;
        }

        [HttpPut]
        [Route("[action]")]
        public async Task<Appertizer> PutAppertizer(Appertizer changeAppertizer)
        {
            _context.Update(changeAppertizer);
            await _context.SaveChangesAsync();
            return changeAppertizer;
        }
//Put request ends

// delete request starts
        
        [HttpDelete("{id}")]
        [Route("[action]/{id}")]
        public async Task<Dishes> DeleteDish(int id)
        {
            Dishes deleteDish = await _context.Dishes.FirstOrDefaultAsync(dishes => dishes.Id == id);
            _context.Dishes.Remove(deleteDish);
             await _context.SaveChangesAsync();
            return deleteDish;
        }
        
        [HttpDelete("{id}")]
        [Route("[action]/{id}")]
        public async Task<Drinks> DeleteDrink(int id)
        {
            Drinks deleteDrink = await _context.Drinks.FirstOrDefaultAsync(drinks => drinks.Id == id);
            _context.Drinks.Remove(deleteDrink);
             await _context.SaveChangesAsync();
            return deleteDrink;
        }
        [HttpDelete("{id}")]
        [Route("[action]/{id}")]
        public async Task<Appertizer> DeleteAppertizer(int id)
        {
            Appertizer deleteAppertizer = await _context.Appertizer.FirstOrDefaultAsync(appertizer => appertizer.Id == id);
            _context.Appertizer.Remove(deleteAppertizer);
             await _context.SaveChangesAsync();
            return deleteAppertizer;
        }

//Delete request ends

        // GET, POST, DELETE og ADD Start bruk "id" for get. 
    


    }
}