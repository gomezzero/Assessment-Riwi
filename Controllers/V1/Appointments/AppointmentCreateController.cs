using Assessment_Riwi.DTOs;
using Assessment_Riwi.Repositories;
using Microsoft.AspNetCore.Authorization;
using Microsoft.AspNetCore.Mvc;
using Microsoft.EntityFrameworkCore.Metadata.Internal;
using Swashbuckle.AspNetCore.Annotations;

namespace Assessment_Riwi.Controllers.V1.Appointments
{
    [Route("api/v1/appointments")]
    [ApiExplorerSettings(GroupName = "v1")]
    [Tags("appointments")]
    public class AppointmentCreateController(IAppointment appointment) : AppointmentController(appointment)
    {
        [HttpPost]
        [Authorize]
        [SwaggerOperation(
            Summary = "Creates a new Appointment",
            Description = "Adds a new Appointment to the system with the provided name and description."
        )]
        [SwaggerResponse(201, "The Appointment was successfully created", typeof(Models.Appointment))]
        [SwaggerResponse(400, "If the Appointment data is invalid")]
        public async Task<ActionResult<Models.Appointment>> Create([FromBody] AppointmentDTO inputAppoitment)
        {
            if (!ModelState.IsValid)
            {
                return BadRequest(ModelState);
            }

            var newAppointment = new Models.Appointment(inputAppoitment.Status, inputAppoitment.Description, inputAppoitment.AppointmentTime, inputAppoitment.AppointmentDay, inputAppoitment.PatientId, inputAppoitment.DoctorId);

            var existingAppointment = await _appoint.GetAppointmentByDoctorAndDate(newAppointment.DoctorId, newAppointment.AppointmentDay, newAppointment.AppointmentTime);

            if (existingAppointment != null)
            {
                return BadRequest("The doctor already has an appointment on the selected day.");
            }


            await _appoint.Add(newAppointment);

            return Ok(newAppointment);
        }
    }
}