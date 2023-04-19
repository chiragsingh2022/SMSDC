using Microsoft.AspNetCore.Mvc;
using Microsoft.EntityFrameworkCore;

using SmsdcWebApi.Model;

namespace SmsdcWebApi.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class CityController : Controller
    {
        [HttpGet]
        public async Task<ActionResult<IEnumerable<City>>> GetCities()
        {
            SmsdcContext smsdcContext = new SmsdcContext();
            if (smsdcContext.Cities == null)
            {
                return NotFound();
            }
            return await smsdcContext.Cities.ToListAsync();
        }

        [HttpPost]
        public async Task<ActionResult<City>> PostState(City city)
        {
            SmsdcContext smsdcContext = new SmsdcContext();
            await smsdcContext.Cities.AddAsync(city);
            await smsdcContext.SaveChangesAsync();
            return Ok(city);
        }
    }
}
