using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.Linq;
using System.Threading.Tasks;
using Assessment_Riwi.Controllers.V1.Appointments;
using Assessment_Riwi.DTOs;
using Assessment_Riwi.Repositories;
using Microsoft.AspNetCore.Mvc;
using Microsoft.Extensions.Logging;
using Swashbuckle.AspNetCore.Annotations;

namespace Assessment_Riwi.Controllers.V1.Appointment
{
    [Route("api/v1/appointments")]
    [ApiExplorerSettings(GroupName = "v1")]
    [Tags("appointments")]
    public class AppointmentUpdateController(IAppointment appointment) : AppointmentController(appointment)
    {
        [HttpPut("{id}")]
        [SwaggerOperation(
            Summary = "Updates an existing Event",
            Description = "Updates the Event with the specified ID, if it exists, with the provided new details."
        )]
        [SwaggerResponse(204, "The Event was successfully updated")]
        [SwaggerResponse(400, "If the provided Event data is invalid")]
        [SwaggerResponse(404, "If the Event with the specified ID is not found")]
        public async Task<IActionResult> Update([FromRoute] int id, [FromBody] AppointmentDTO updateAppoint)
        {
            if (!ModelState.IsValid)
            {
                return BadRequest(ModelState);
            }

            var checkEvent = await _appoint.CheckExistence(id);


            if (!checkEvent)
            {
                return NotFound($"la vento N°{id} no existe en la base de datos");
            }

            var aspointment = await _appoint.GetById(id);

            if (aspointment == null)
            {
                return NotFound();
            }


            aspointment.Status = updateAppoint.Status;
            aspointment.Description = updateAppoint.Description;
            aspointment.AppointmentTime = TimeOnly.Parse(updateAppoint.AppointmentTime);
            aspointment.AppointmentDay = updateAppoint.AppointmentDay;
            aspointment.PatientId = updateAppoint.PatientId;
            aspointment.DoctorId = updateAppoint.DoctorId;

            await _appoint.Update(aspointment);
            return NoContent();
        }
    }
}
// Models.Appointment