using Microsoft.AspNetCore.Mvc;
using Microsoft.EntityFrameworkCore;

using SmsdcWebApi.Model;

using System.Diagnostics;
namespace SmsdcWebApi.Controllers
{
    [Route("api/teacher")]
    [ApiController]
    public class TeacherController : ControllerBase
    {
        private readonly SmsContext _context;

        public TeacherController(SmsContext context)
        {
            _context = context;
        }
        [HttpGet]
        public async Task<ActionResult<IEnumerable<Teacher>>> GetTeacher()
        {

            if (_context.Teachers == null)
            {
                return NotFound();
            }
            return await _context.Teachers.ToListAsync();
        }

        [HttpPost]
        public async Task<ActionResult<Teacher>> Post(Teacher Teacher)
        {

            await _context.Teachers.AddAsync(Teacher);
            await _context.SaveChangesAsync();
            return Ok(Teacher);
        }

        [HttpPut]
        public async Task<IActionResult> Put(Teacher Teacher)
        {

            try
            {
                if (Teacher.Id == Guid.Empty || Teacher.Id == null)
                {
                    return BadRequest();
                }

                //_context.Entry(Teacher).State = EntityState.Modified;
                //_context.Entry(Teacher).Property(x => x.RollNumber).IsModified = false;
                _context.Update(Teacher);
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
        private bool TeacherExists(Guid id)
        {

            return (_context.Teachers?.Any(x => x.Id == id)).GetValueOrDefault();
        }


        [HttpDelete("{Id}")]
        public async Task<ActionResult<Teacher>> Delete(Guid Id)
        {

            var baTeacher = await _context.Teachers.FindAsync(Id);
            if (baTeacher == null)
            {
                return NotFound();
            }

            _context.Teachers.Remove(baTeacher);
            await _context.SaveChangesAsync();

            return baTeacher;
        }
    }
}
