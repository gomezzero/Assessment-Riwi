using Assessment_Riwi.DTOs;
using Assessment_Riwi.Repositories;
using Microsoft.AspNetCore.Mvc;
using Microsoft.EntityFrameworkCore.Metadata.Internal;

namespace Assessment_Riwi.Controllers.V1.Appointments
{
    [Route("api/v1/appointments")]
    [ApiExplorerSettings(GroupName = "v1")]
    [Tags("appointments")]
    public class AppointmentCreateController(IAppointment appointment) : AppointmentController(appointment)
    {
        [HttpPost]

        public async Task<ActionResult<Models.Appointment>> Create([FromBody] AppointmentDTO inputAppoitment)
        {
            if (!ModelState.IsValid)
            {
                return BadRequest(ModelState);
            }

            var newAppointment = new Models.Appointment(inputAppoitment.Status, inputAppoitment.Description, TimeOnly.Parse(inputAppoitment.AppointmentTime), inputAppoitment.AppointmentDay, inputAppoitment.PatientId, inputAppoitment.DoctorId);
            await _appoint.Add(newAppointment);

            return Ok(newAppointment);
        }
    }
}