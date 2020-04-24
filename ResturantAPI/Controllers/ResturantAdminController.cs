using System.IO;
using Microsoft.AspNetCore.Hosting;
using Microsoft.AspNetCore.Http;
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

        [HttpPost]
        [Route("[action]")]
        public void UploadImage(IFormFile file){
            string webRootPath = _hosting.WebRootPath;
            string absolutePath = Path.Combine($"{webRootPath}/images/{file.FileName}");
            using(var fileStream = new FileStream( absolutePath, FileMode.Create)){
                file.CopyTo( fileStream);
            }
        }
    }
}