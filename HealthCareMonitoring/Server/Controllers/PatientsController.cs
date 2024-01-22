using Microsoft.AspNetCore.Mvc;
using Microsoft.EntityFrameworkCore;
using HealthCareMonitoring.Server.IRepository;
using HealthCareMonitoring.Shared.Domain;

namespace HealthCareMonitoring.Server.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class PatientsController : ControllerBase
    {
        private readonly IUnitOfWork _unitOfWork;
        public PatientsController(IUnitOfWork unitOfWork)
        {
            _unitOfWork = unitOfWork;
        }

        // GET: api/Patients
        [HttpGet]
        public async Task<IActionResult> GetPatients()
        {
            if (_unitOfWork.Patients == null)
            {
                return NotFound();
            }
            var Patients = await _unitOfWork.Patients.GetAll();
            return Ok(Patients);
        }

        // GET: api/Patients/5
        [HttpGet("{id}")]
        public async Task<IActionResult> GetPatients(int id)
        {
            if (_unitOfWork.Patients == null)
            {
                return NotFound();
            }
            var Patient = await _unitOfWork.Patients.Get(q => q.Id == id);

            if (Patient == null)
            {
                return NotFound();
            }

            return Ok(Patient);
        }

        // PUT: api/Patients/5
        // To protect from overposting attacks, see https://go.microsoft.com/fwlink/?linkid=2123754
        [HttpPut("{id}")]
        public async Task<IActionResult> PutPatient(int id, Patient Patient)
        {
            if (id != Patient.Id)
            {
                return BadRequest();
            }
            _unitOfWork.Patients.Update(Patient);

            try
            {
                
                await _unitOfWork.Save(HttpContext);
            }
            catch (DbUpdateConcurrencyException)
            {
                if (!await PatientExists(id))
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

        // POST: api/Patients
        // To protect from overposting attacks, see https://go.microsoft.com/fwlink/?linkid=2123754
        [HttpPost]
        public async Task<ActionResult<Patient>> PostPatient(Patient Patient)
        {
            if (_unitOfWork.Patients == null)
            {
                return Problem("Entity set 'ApplicationDbContext.Patients'  is null.");
            }
            await _unitOfWork.Patients.Insert(Patient);
            await _unitOfWork.Save(HttpContext);
            return CreatedAtAction("GetPatient", new { id = Patient.Id }, Patient);
        }

        // DELETE: api/Patients/5
        [HttpDelete("{id}")]
        public async Task<IActionResult> DeletePatient(int id)
        {
            var Patient = await _unitOfWork.Patients.Get(q => q.Id == id);
            if (Patient == null)
            {
                return NotFound();
            }
            await _unitOfWork.Patients.Delete(id);
            await _unitOfWork.Save(HttpContext);

            return NoContent();
        }

        private async Task<bool> PatientExists(int id)
        {
            var Patient = await _unitOfWork.Patients.Get(q => q.Id == id);
            return Patient != null;
        }
    }
}
