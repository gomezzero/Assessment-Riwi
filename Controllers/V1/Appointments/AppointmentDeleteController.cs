using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.Linq;
using System.Threading.Tasks;
using Assessment_Riwi.Models;
using Assessment_Riwi.Repositories;
using Microsoft.AspNetCore.Mvc;
using Microsoft.Extensions.Logging;

namespace Assessment_Riwi.Controllers.V1.Appointments
{
    [Route("api/v1/appointments")]
    [ApiExplorerSettings(GroupName = "v1")]
    [Tags("appointments")]
    public class AppointmentDeleteController(IAppointment appointment) : AppointmentController(appointment)
    {

        [HttpDelete("{id}")]
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