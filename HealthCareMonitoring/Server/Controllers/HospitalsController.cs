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
            var hospitals = await _unitOfWork.Hospitals.GetAll();
            return Ok(hospitals);
        }

        // GET: api/Hospitals/5
        [HttpGet("{id}")]
        public async Task<IActionResult> GetHospitals(int id)
        {
            if (_unitOfWork.Hospitals == null)
            {
                return NotFound();
            }
            var hospital = await _unitOfWork.Hospitals.Get(q => q.Id == id);

            if (hospital == null)
            {
                return NotFound();
            }

            return Ok(hospital);
        }

        // PUT: api/Hospitals/5
        // To protect from overposting attacks, see https://go.microsoft.com/fwlink/?linkid=2123754
        [HttpPut("{id}")]
        public async Task<IActionResult> PutHospital(int id, Hospital hospital)
        {
            if (id != hospital.Id)
            {
                return BadRequest();
            }
            _unitOfWork.Hospitals.Update(hospital);

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
        public async Task<ActionResult<Hospital>> PostHospital(Hospital hospital)
        {
            if (_unitOfWork.Hospitals == null)
            {
                return Problem("Entity set 'ApplicationDbContext.Hospitals'  is null.");
            }
            await _unitOfWork.Hospitals.Insert(hospital);
            await _unitOfWork.Save(HttpContext);
            return CreatedAtAction("GetHospital", new { id = hospital.Id }, hospital);
        }

        // DELETE: api/Hospitals/5
        [HttpDelete("{id}")]
        public async Task<IActionResult> DeleteHospital(int id)
        {
            var hospital = await _unitOfWork.Hospitals.Get(q => q.Id == id);
            if (hospital == null)
            {
                return NotFound();
            }
            await _unitOfWork.Hospitals.Delete(id);
            await _unitOfWork.Save(HttpContext);

            return NoContent();
        }

        private async Task<bool> HospitalExists(int id)
        {
            var hospital = await _unitOfWork.Hospitals.Get(q => q.Id == id);
            return hospital != null;
        }
    }
}
