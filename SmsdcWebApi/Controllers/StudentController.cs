using Microsoft.AspNetCore.Mvc;
using Microsoft.EntityFrameworkCore;

using SmsdcWebApi.Model;

using System.Diagnostics;
namespace SmsdcWebApi.Controllers
{
    [Route("api/student")]
    [ApiController]
    public class StudentController : ControllerBase
    {
        private readonly SmsContext _context;

        public StudentController(SmsContext context)
        {
            _context = context;
        }
        [HttpGet]
        public async Task<ActionResult<IEnumerable<Student>>> GetStudent()
        {

            if (_context.Students == null)
            {
                return NotFound();
            }
            return await _context.Students.ToListAsync();
        }

        [HttpPost]
        public async Task<ActionResult<Student>> Post(Student student)
        {

            await _context.Students.AddAsync(student);
            await _context.SaveChangesAsync();
            return Ok(student);
        }

        [HttpPut]
        public async Task<IActionResult> Put(Student student)
        {

            try
            {
                if (student.Id == Guid.Empty || student.Id == null)
                {
                    return BadRequest();
                }

                //_context.Entry(student).State = EntityState.Modified;
                //_context.Entry(student).Property(x => x.RollNumber).IsModified = false;
                _context.Update(student);
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
        private bool StudentExists(Guid id)
        {

            return (_context.Students?.Any(x => x.Id == id)).GetValueOrDefault();
        }


        [HttpDelete("{Id}")]
        public async Task<ActionResult<Student>> Delete(Guid Id)
        {

            var baStudent = await _context.Students.FindAsync(Id);
            if (baStudent == null)
            {
                return NotFound();
            }

            _context.Students.Remove(baStudent);
            await _context.SaveChangesAsync();

            return baStudent;
        }
    }
}
