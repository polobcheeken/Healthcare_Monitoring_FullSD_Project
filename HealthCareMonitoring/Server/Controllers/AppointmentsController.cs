﻿using Microsoft.AspNetCore.Mvc;
using Microsoft.EntityFrameworkCore;
using HealthCareMonitoring.Server.IRepository;
using HealthCareMonitoring.Shared.Domain;

namespace HealthCareMonitoring.Server.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class AppointmentsController : ControllerBase
    {
        private readonly IUnitOfWork _unitOfWork;
        public AppointmentsController(IUnitOfWork unitOfWork)
        {
            _unitOfWork = unitOfWork;
        }

        // GET: api/Appointments
        [HttpGet]
        public async Task<IActionResult> GetAppointments()
        {
            if (_unitOfWork.Appointments == null)
            {
                return NotFound();
            }
            var Appointments = await _unitOfWork.Appointments.GetAll();
            return Ok(Appointments);
        }

        // GET: api/Appointments/5
        [HttpGet("{id}")]
        public async Task<IActionResult> GetAppointments(int id)
        {
            if (_unitOfWork.Appointments == null)
            {
                return NotFound();
            }
            var Appointment = await _unitOfWork.Appointments.Get(q => q.Id == id);

            if (Appointment == null)
            {
                return NotFound();
            }

            return Ok(Appointment);
        }

        // PUT: api/Appointments/5
        // To protect from overposting attacks, see https://go.microsoft.com/fwlink/?linkid=2123754
        [HttpPut("{id}")]
        public async Task<IActionResult> PutAppointment(int id, Appointment Appointment)
        {
            if (id != Appointment.Id)
            {
                return BadRequest();
            }
            _unitOfWork.Appointments.Update(Appointment);

            try
            {
                await _unitOfWork.Save(HttpContext);
            }
            catch (DbUpdateConcurrencyException)
            {
                if (!await AppointmentExists(id))
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

        // POST: api/Appointments
        // To protect from overposting attacks, see https://go.microsoft.com/fwlink/?linkid=2123754
        [HttpPost]
        public async Task<ActionResult<Appointment>> PostAppointment(Appointment Appointment)
        {
            if (_unitOfWork.Appointments == null)
            {
                return Problem("Entity set 'ApplicationDbContext.Appointments'  is null.");
            }
            await _unitOfWork.Appointments.Insert(Appointment);
            await _unitOfWork.Save(HttpContext);
            return CreatedAtAction("GetAppointment", new { id = Appointment.Id }, Appointment);
        }

        // DELETE: api/Appointments/5
        [HttpDelete("{id}")]
        public async Task<IActionResult> DeleteAppointment(int id)
        {
            var Appointment = await _unitOfWork.Appointments.Get(q => q.Id == id);
            if (Appointment == null)
            {
                return NotFound();
            }
            await _unitOfWork.Appointments.Delete(id);
            await _unitOfWork.Save(HttpContext);

            return NoContent();
        }

        private async Task<bool> AppointmentExists(int id)
        {
            var Appointment = await _unitOfWork.Appointments.Get(q => q.Id == id);
            return Appointment != null;
        }
    }
}
