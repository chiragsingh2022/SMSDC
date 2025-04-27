using Microsoft.AspNetCore.Mvc;
using Microsoft.EntityFrameworkCore;

using SmsdcWebApi.Model;

using System.Diagnostics;
namespace SmsdcWebApi.Controllers
{
    [Route("api/list")]
    [ApiController]
    public class ListController : ControllerBase
    {
        private readonly SmsContext _context;

        public ListController(SmsContext context)
        {
            _context = context;
        }
        [HttpGet("listclasses")]
        public async Task<ActionResult<IEnumerable<ListClass>>> GetListClasses()
        {
            var list = await _context.ListClasses.Where(c => c.IsActive).ToListAsync();
            return Ok(list);
        }

        [HttpPost]
        public async Task<ActionResult<ListClass>> Post(ListClass listClass)
        {
            await _context.ListClasses.AddAsync(listClass);
            await _context.SaveChangesAsync();
            return Ok(listClass);
        }

        [HttpPut]
        public async Task<IActionResult> Put(ListClass listClass)
        {
            try
            {
                if (listClass.Id == Guid.Empty)
                {
                    return BadRequest();
                }

                //smsdcContext.Entry(student).State = EntityState.Modified;
                //smsdcContext.Entry(student).Property(x => x.RollNumber).IsModified = false;
                _context.Update(listClass);
                try
                {
                    await _context.SaveChangesAsync();
                }
                catch (DbUpdateConcurrencyException ex)
                {
                    Debug.WriteLine(ex);
                }
                return Ok();
            }
            catch (Exception ex)
            {
                return BadRequest(ex.Message);
            }

        }
        private bool ListClassExists(Guid id)
        {
            return (_context.ListClasses?.Any(x => x.Id == id)).GetValueOrDefault();
        }


        [HttpDelete("{Id}")]
        public async Task<ActionResult> Delete(Guid Id)
        {
            var rem = await _context.ListClasses.FindAsync(Id);
            if (rem == null)
            {
                return NotFound();
            }

            _context.ListClasses.Remove(rem);
            await _context.SaveChangesAsync();

            return NoContent();
        }
    }
}
