using Microsoft.AspNetCore.Mvc;
using System.Collections.Generic;
using Microsoft.EntityFrameworkCore;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Hosting;
using Microsoft.AspNetCore.Http;
using System.IO;
using resturantAPI.Models;

namespace ResturantAPI.Controllers
{
    [ApiController]
    [Route("[controller]")]

    public class ResturantAdminController : ControllerBase
    {
        private readonly DishesContext _context;
        private readonly IWebHostEnvironment _hosting;

        public ResturantAdminController(DishesContext context, IWebHostEnvironment hosting)
        {
            _context = context;
            _hosting = hosting;
        }

        [HttpPost]
        [Route("[action]")]
        public void UploadImage(IFormFile file)
        {
            string webRootPath = _hosting.WebRootPath;
            string absolutePath = Path.Combine($"{webRootPath}/images/{file.FileName}");
            using (var fileStream = new FileStream(absolutePath, FileMode.Create))
            {
                file.CopyTo(fileStream);
            }
        }

    }
}