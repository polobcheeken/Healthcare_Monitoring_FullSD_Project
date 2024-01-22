using Microsoft.AspNetCore.Mvc;
using Microsoft.EntityFrameworkCore;
using HealthCareMonitoring.Server.IRepository;
using HealthCareMonitoring.Shared.Domain;

namespace HealthCareMonitoring.Server.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class MedicinesController : ControllerBase
    {
        private readonly IUnitOfWork _unitOfWork;
        public MedicinesController(IUnitOfWork unitOfWork)
        {
            _unitOfWork = unitOfWork;
        }

        // GET: api/Medicines
        [HttpGet]
        public async Task<IActionResult> GetMedicines()
        {
            if (_unitOfWork.Medicines == null)
            {
                return NotFound();
            }
            var Medicines = await _unitOfWork.Medicines.GetAll();
            return Ok(Medicines);
        }

        // GET: api/Medicines/5
        [HttpGet("{id}")]
        public async Task<IActionResult> GetMedicines(int id)
        {
            if (_unitOfWork.Medicines == null)
            {
                return NotFound();
            }
            var Medicine = await _unitOfWork.Medicines.Get(q => q.Id == id);

            if (Medicine == null)
            {
                return NotFound();
            }

            return Ok(Medicine);
        }

        // PUT: api/Medicines/5
        // To protect from overposting attacks, see https://go.microsoft.com/fwlink/?linkid=2123754
        [HttpPut("{id}")]
        public async Task<IActionResult> PutMedicine(int id, Medicine Medicine)
        {
            if (id != Medicine.Id)
            {
                return BadRequest();
            }
            _unitOfWork.Medicines.Update(Medicine);

            try
            {
                
                await _unitOfWork.Save(HttpContext);
            }
            catch (DbUpdateConcurrencyException)
            {
                if (!await MedicineExists(id))
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

        // POST: api/Medicines
        // To protect from overposting attacks, see https://go.microsoft.com/fwlink/?linkid=2123754
        [HttpPost]
        public async Task<ActionResult<Medicine>> PostMedicine(Medicine Medicine)
        {
            if (_unitOfWork.Medicines == null)
            {
                return Problem("Entity set 'ApplicationDbContext.Medicines'  is null.");
            }
            await _unitOfWork.Medicines.Insert(Medicine);
            await _unitOfWork.Save(HttpContext);
            return CreatedAtAction("GetMedicine", new { id = Medicine.Id }, Medicine);
        }

        // DELETE: api/Medicines/5
        [HttpDelete("{id}")]
        public async Task<IActionResult> DeleteMedicine(int id)
        {
            var Medicine = await _unitOfWork.Medicines.Get(q => q.Id == id);
            if (Medicine == null)
            {
                return NotFound();
            }
            await _unitOfWork.Medicines.Delete(id);
            await _unitOfWork.Save(HttpContext);

            return NoContent();
        }

        private async Task<bool> MedicineExists(int id)
        {
            var Medicine = await _unitOfWork.Medicines.Get(q => q.Id == id);
            return Medicine != null;
        }
    }
}
