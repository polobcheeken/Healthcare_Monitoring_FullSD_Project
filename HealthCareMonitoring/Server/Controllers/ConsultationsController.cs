using Microsoft.AspNetCore.Mvc;
using Microsoft.EntityFrameworkCore;
using HealthCareMonitoring.Server.IRepository;
using HealthCareMonitoring.Shared.Domain;

namespace HealthCareMonitoring.Server.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class ConsultationsController : ControllerBase
    {
        private readonly IUnitOfWork _unitOfWork;
        public ConsultationsController(IUnitOfWork unitOfWork)
        {
            _unitOfWork = unitOfWork;
        }

        // GET: api/Consultations
        [HttpGet]
        public async Task<IActionResult> GetConsultations()
        {
            if (_unitOfWork.Consultations == null)
            {
                return NotFound();
            }
            var Consultations = await _unitOfWork.Consultations.GetAll();
            return Ok(Consultations);
        }

        // GET: api/Consultations/5
        [HttpGet("{id}")]
        public async Task<IActionResult> GetConsultations(int id)
        {
            if (_unitOfWork.Consultations == null)
            {
                return NotFound();
            }
            var Consultation = await _unitOfWork.Consultations.Get(q => q.Id == id);

            if (Consultation == null)
            {
                return NotFound();
            }

            return Ok(Consultation);
        }

        // PUT: api/Consultations/5
        // To protect from overposting attacks, see https://go.microsoft.com/fwlink/?linkid=2123754
        [HttpPut("{id}")]
        public async Task<IActionResult> PutConsultation(int id, Consultation Consultation)
        {
            if (id != Consultation.Id)
            {
                return BadRequest();
            }
            _unitOfWork.Consultations.Update(Consultation);

            try
            {
                
                await _unitOfWork.Save(HttpContext);
            }
            catch (DbUpdateConcurrencyException)
            {
                if (!await ConsultationExists(id))
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

        // POST: api/Consultations
        // To protect from overposting attacks, see https://go.microsoft.com/fwlink/?linkid=2123754
        [HttpPost]
        public async Task<ActionResult<Consultation>> PostConsultation(Consultation Consultation)
        {
            if (_unitOfWork.Consultations == null)
            {
                return Problem("Entity set 'ApplicationDbContext.Consultations'  is null.");
            }
            await _unitOfWork.Consultations.Insert(Consultation);
            await _unitOfWork.Save(HttpContext);
            return CreatedAtAction("GetConsultation", new { id = Consultation.Id }, Consultation);
        }

        // DELETE: api/Consultations/5
        [HttpDelete("{id}")]
        public async Task<IActionResult> DeleteConsultation(int id)
        {
            var Consultation = await _unitOfWork.Consultations.Get(q => q.Id == id);
            if (Consultation == null)
            {
                return NotFound();
            }
            await _unitOfWork.Consultations.Delete(id);
            await _unitOfWork.Save(HttpContext);

            return NoContent();
        }

        private async Task<bool> ConsultationExists(int id)
        {
            var Consultation = await _unitOfWork.Consultations.Get(q => q.Id == id);
            return Consultation != null;
        }
    }
}
