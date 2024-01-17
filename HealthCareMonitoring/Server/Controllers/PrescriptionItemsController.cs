using Microsoft.AspNetCore.Mvc;
using Microsoft.EntityFrameworkCore;
using HealthCareMonitoring.Server.IRepository;
using HealthCareMonitoring.Shared.Domain;

namespace HealthCareMonitoring.Server.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class PrescriptionItemssController : ControllerBase
    {
        private readonly IUnitOfWork _unitOfWork;
        public PrescriptionItemssController(IUnitOfWork unitOfWork)
        {
            _unitOfWork = unitOfWork;
        }

        // GET: api/PrescriptionItemss
        [HttpGet]
        public async Task<IActionResult> GetPrescriptionItemss()
        {
            if (_unitOfWork.PrescriptionItems == null)
            {
                return NotFound();
            }
            var prescriptionitemss = await _unitOfWork.PrescriptionItems.GetAll();
            return Ok(prescriptionitemss);
        }

        // GET: api/PrescriptionItemss/5
        [HttpGet("{id}")]
        public async Task<IActionResult> GetPrescriptionItemss(int id)
        {
            if (_unitOfWork.PrescriptionItems == null)
            {
                return NotFound();
            }
            var prescriptionitems = await _unitOfWork.PrescriptionItems.Get(q => q.Id == id);

            if (prescriptionitems == null)
            {
                return NotFound();
            }

            return Ok(prescriptionitems);
        }

        // PUT: api/PrescriptionItemss/5
        // To protect from overposting attacks, see https://go.microsoft.com/fwlink/?linkid=2123754
        [HttpPut("{id}")]
        public async Task<IActionResult> PutPrescriptionItems(int id, PrescriptionItem prescriptionitems)
        {
            if (id != prescriptionitems.Id)
            {
                return BadRequest();
            }
            _unitOfWork.PrescriptionItems.Update(prescriptionitems);

            try
            {
                ;
                await _unitOfWork.Save(HttpContext);
            }
            catch (DbUpdateConcurrencyException)
            {
                if (!await PrescriptionItemsExists(id))
                {
                    return NotFound();
                }
                else
                {
                    throw;
                }
            }

            return NoContent();
        }

        // POST: api/PrescriptionItemss
        // To protect from overposting attacks, see https://go.microsoft.com/fwlink/?linkid=2123754
        [HttpPost]
        public async Task<ActionResult<PrescriptionItem>> PostPrescriptionItems(PrescriptionItem prescriptionitems)
        {
            if (_unitOfWork.PrescriptionItems == null)
            {
                return Problem("Entity set 'ApplicationDbContext.PrescriptionItemss'  is null.");
            }
            await _unitOfWork.PrescriptionItems.Insert(prescriptionitems);
            await _unitOfWork.Save(HttpContext);
            return CreatedAtAction("GetPrescriptionItems", new { id = prescriptionitems.Id }, prescriptionitems);
        }

        // DELETE: api/PrescriptionItemss/5
        [HttpDelete("{id}")]
        public async Task<IActionResult> DeletePrescriptionItems(int id)
        {
            var prescriptionitems = await _unitOfWork.PrescriptionItems.Get(q => q.Id == id);
            if (prescriptionitems == null)
            {
                return NotFound();
            }
            await _unitOfWork.PrescriptionItems.Delete(id);
            await _unitOfWork.Save(HttpContext);

            return NoContent();
        }

        private async Task<bool> PrescriptionItemsExists(int id)
        {
            var prescriptionitems = await _unitOfWork.PrescriptionItems.Get(q => q.Id == id);
            return prescriptionitems != null;
        }
    }
}
