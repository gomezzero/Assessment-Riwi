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
    public class AppointmentDeleteController(IAppointment appointment) : AppointmentController(appointment)
    {

        [HttpDelete("{id}")]
        [Authorize(Roles = "doctor" )]
        [SwaggerOperation(
            Summary = "Deletes a appoint by ID",
            Description = "Removes the specified appoint from the system."
        )]
        [SwaggerResponse(204, "The appoint was successfully deleted")]
        [SwaggerResponse(404, "If the appoint with the specified ID is not found")]
        public async Task<IActionResult> Delete([FromRoute] int id)
        {
            var exist = await _appoint.CheckExistence(id);

            if (!exist)
            {
                return NotFound($"Citation N° {id} was found");
            }

            await _appoint.Delete(id);
            return Ok($"Citation N° {id} was deleted");
        }
    }
}