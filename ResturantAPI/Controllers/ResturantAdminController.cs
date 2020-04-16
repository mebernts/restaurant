using Microsoft.AspNetCore.Hosting;
using Microsoft.AspNetCore.Mvc;
using resturantAPI.Models;

namespace ResturantAPI
{
    public class ResturantAdminController : ControllerBase{
        private readonly DishesContext _context;
        
        private readonly IWebHostEnvironment _hosting;
        
        public ResturantAdminController(DishesContext context,IWebHostEnvironment hosting)
        {
            _context = context;
            _hosting = hosting;
        }
    }
}