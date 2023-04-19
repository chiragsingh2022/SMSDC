using Microsoft.AspNetCore.Mvc;
using Microsoft.EntityFrameworkCore;

using SmsdcWebApi.Model;

namespace SmsdcWebApi.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class StateController : Controller
    {
        [HttpGet]
        public async Task<ActionResult<IEnumerable<State>>> GetState()
        {
            SmsdcContext smsdcContext = new SmsdcContext();
            if (smsdcContext.States == null)
            {
                return NotFound();
            }
            return await smsdcContext.States.ToListAsync();
        }

        [HttpPost]
        public async Task<ActionResult<State>> PostState(State state)
        {
            SmsdcContext smsdcContext = new SmsdcContext();
            await smsdcContext.States.AddAsync(state);
            await smsdcContext.SaveChangesAsync();
            return Ok(state);
        }
    }
}
