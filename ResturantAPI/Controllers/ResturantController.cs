using Microsoft.AspNetCore.Mvc;
using System.Collections.Generic;
using resturantAPI.Models;
using System.Threading.Tasks;
using Microsoft.EntityFrameworkCore;
using System.Linq;

namespace ResturantAPI.Controllers{
    [ApiController]
    [Route("[controller]")]
    
    public class ResturantController : ControllerBase{
        private readonly DishesContext _context;
        public DishesController(DishesContext context){
            _context = context;
        }

        [HttpGet]

        public async Task<IEnumerable<Dishes>> Get(){
            List<Dishes> dishesList = await _context.Dishes.ToListAsync();
            
            return dishesList;
        }
        [HttpGet("{category}")] //filtering av kategorier 
        public async Task<IEnumerable<Dishes>> Get(string category){
            List<Dishes> dishesList = await _context.Dishes
            .Where(dishes => dishes.category.Contains(category))
            .ToListAsync();

            return dishesList;
        }
        
        [HttpGet]
        [Route("[action]")]
        public async Task <IEnumerable<Appertizer>> GetAppertizer(){}  
    }
}