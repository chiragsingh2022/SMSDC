using Microsoft.AspNetCore.Mvc;
using Microsoft.EntityFrameworkCore;

using SmsdcWebApi.Model;
namespace SmsdcWebApi.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class BaController : Controller
    {
        [HttpGet]
        public async Task<ActionResult<IEnumerable<Ba>>> GetBaStudents()
        {
            SmsdcContext smsdcContext = new SmsdcContext();
            if (smsdcContext.BaStudents == null)
            {
                return NotFound();
            }
            return await smsdcContext.BaStudents.ToListAsync();
        }

        [HttpPost]
        public async Task<ActionResult<Ba>> PostBaStudent(Ba student)
        {
            SmsdcContext smsdcContext = new SmsdcContext();
            await smsdcContext.BaStudents.AddAsync(student);
            await smsdcContext.SaveChangesAsync();
            return Ok(student);
        }

        [HttpPut]
        public async Task<IActionResult> PutBaStudent(Guid id, Ba student)
        {
            SmsdcContext smsdcContext = new SmsdcContext();
            try
            {
                if (id != student.Id)
                {
                    return BadRequest();
                }

                smsdcContext.Entry(student).State = EntityState.Modified;
                smsdcContext.Entry(student).Property(x => x.RollNumber).IsModified = false;

                try
                {
                    await smsdcContext.SaveChangesAsync();
                }
                catch (DbUpdateConcurrencyException)
                {
                    if (!StudentExists(id))
                    {
                        return NotFound();
                    }
                    else
                    {
                        throw;
                    }
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
            SmsdcContext smsdcContext = new SmsdcContext();
            return (smsdcContext.BaStudents?.Any(x => x.Id == id)).GetValueOrDefault();
        }


        [HttpDelete("{Id}")]
        public async Task<ActionResult<Ba>> DeleteBaStudent(Guid Id)
        {
            SmsdcContext smsdcContext = new SmsdcContext();
            var baStudent = await smsdcContext.BaStudents.FindAsync(Id);
            if (baStudent == null)
            {
                return NotFound();
            }

            smsdcContext.BaStudents.Remove(baStudent);
            await smsdcContext.SaveChangesAsync();

            return baStudent;
        }
    }
}
