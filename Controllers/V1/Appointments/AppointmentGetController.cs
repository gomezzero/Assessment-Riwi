using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.Linq;
using System.Threading.Tasks;
using Assessment_Riwi.Models;
using Assessment_Riwi.Repositories;
using Microsoft.AspNetCore.Authorization;
using Microsoft.AspNetCore.Mvc;
using Microsoft.Extensions.Logging;
using Swashbuckle.AspNetCore.Annotations;

namespace Assessment_Riwi.Controllers.V1.Appointments
{
    [Route("api/v1/appointments")]
    [ApiExplorerSettings(GroupName = "v1")]
    [Tags("appointments")]
    public class AppointmentGetController(IAppointment appointment) : AppointmentController(appointment)
    {
        [HttpGet("all")]
        [Authorize(Roles = "doctor")]
        [SwaggerOperation(
           Summary = "Retrieves all Appointment",
           Description = "Returns a list of all Appointment in the system."
       )]
        [SwaggerResponse(200, "A list of Appointment", typeof(IEnumerable<Models.Appointment>))]
        public async Task<ActionResult<IEnumerable<Models.Appointment>>> GetAll()
        {
            var appointment = await _appoint.GetAll();
            return Ok(appointment);
        }

        [HttpGet("patient/{address}")]
        [Authorize]
        [SwaggerOperation(
           Summary = "Retrieves by address Appointment",
           Description = "Returns a list by address Appointment in the system."
       )]
        [SwaggerResponse(200, "A list of Appointment", typeof(IEnumerable<Models.Appointment>))]

        public async Task<ActionResult<IEnumerable<Models.Appointment>>> GetPatientAddress(string address)
        {
            var appointment = await _appoint.GetPatientAddress(address);

            if (appointment == null || !appointment.Any())
            {
                return NotFound($"No appointments were found for the patient with the address: {address}");
            }

            return Ok(appointment);
        }

        [HttpGet("doctor/{doctorId}")]
        [Authorize(Roles = "doctor")]
        [SwaggerOperation(
           Summary = "Retrieves by doctor Id Appointment",
           Description = "Returns a list by doctor Id Appointment in the system."
       )]
        [SwaggerResponse(200, "A list of Appointment", typeof(IEnumerable<Models.Appointment>))]

        public async Task<ActionResult<IEnumerable<Models.Appointment>>> GetDoctorId(int doctorId)
        {
            var appointment = await _appoint.GetDoctorId(doctorId);

            if (appointment == null || !appointment.Any())
            {
                return NotFound($"No appointments found for doctor with ID: {doctorId}");
            }

            return Ok(appointment);
        }

    }
}