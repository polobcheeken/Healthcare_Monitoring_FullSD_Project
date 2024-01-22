using Microsoft.AspNetCore.Mvc;
using Microsoft.EntityFrameworkCore;
using HealthCareMonitoring.Server.IRepository;
using HealthCareMonitoring.Shared.Domain;

namespace HealthCareMonitoring.Server.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class HospitalsController : ControllerBase
    {
        private readonly IUnitOfWork _unitOfWork;
        public HospitalsController(IUnitOfWork unitOfWork)
        {
            _unitOfWork = unitOfWork;
        }

        // GET: api/Hospitals
        [HttpGet]
        public async Task<IActionResult> GetHospitals()
        {
            if (_unitOfWork.Hospitals == null)
            {
                return NotFound();
            }
            var Hospitals = await _unitOfWork.Hospitals.GetAll();
            return Ok(Hospitals);
        }

        // GET: api/Hospitals/5
        [HttpGet("{id}")]
        public async Task<IActionResult> GetHospitals(int id)
        {
            if (_unitOfWork.Hospitals == null)
            {
                return NotFound();
            }
            var Hospital = await _unitOfWork.Hospitals.Get(q => q.Id == id);

            if (Hospital == null)
            {
                return NotFound();
            }

            return Ok(Hospital);
        }

        // PUT: api/Hospitals/5
        // To protect from overposting attacks, see https://go.microsoft.com/fwlink/?linkid=2123754
        [HttpPut("{id}")]
        public async Task<IActionResult> PutHospital(int id, Hospital Hospital)
        {
            if (id != Hospital.Id)
            {
                return BadRequest();
            }
            _unitOfWork.Hospitals.Update(Hospital);

            try
            {
                
                await _unitOfWork.Save(HttpContext);
            }
            catch (DbUpdateConcurrencyException)
            {
                if (!await HospitalExists(id))
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

        // POST: api/Hospitals
        // To protect from overposting attacks, see https://go.microsoft.com/fwlink/?linkid=2123754
        [HttpPost]
        public async Task<ActionResult<Hospital>> PostHospital(Hospital Hospital)
        {
            if (_unitOfWork.Hospitals == null)
            {
                return Problem("Entity set 'ApplicationDbContext.Hospitals'  is null.");
            }
            await _unitOfWork.Hospitals.Insert(Hospital);
            await _unitOfWork.Save(HttpContext);
            return CreatedAtAction("GetHospital", new { id = Hospital.Id }, Hospital);
        }

        // DELETE: api/Hospitals/5
        [HttpDelete("{id}")]
        public async Task<IActionResult> DeleteHospital(int id)
        {
            var Hospital = await _unitOfWork.Hospitals.Get(q => q.Id == id);
            if (Hospital == null)
            {
                return NotFound();
            }
            await _unitOfWork.Hospitals.Delete(id);
            await _unitOfWork.Save(HttpContext);

            return NoContent();
        }

        private async Task<bool> HospitalExists(int id)
        {
            var Hospital = await _unitOfWork.Hospitals.Get(q => q.Id == id);
            return Hospital != null;
        }
    }
}
