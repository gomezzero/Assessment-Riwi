using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.Linq;
using System.Threading.Tasks;
using Assessment_Riwi.Repositories;
using Microsoft.AspNetCore.Authorization;
using Microsoft.AspNetCore.Mvc;
using Microsoft.Extensions.Logging;
using Swashbuckle.AspNetCore.Annotations;

namespace Assessment_Riwi.Controllers.V1.DoctorController
{
    [Route("api/v1/doctors")]
    [ApiExplorerSettings(GroupName = "v1")]
    [Tags("doctors")]
    public class DoctorDeleteController(IDoctor doctor) : DoctorController(doctor)
    {
        [HttpDelete("{id}")]
        [Authorize(Roles = "doctor")]
        [SwaggerOperation(
            Summary = "Deletes a doctor by ID",
            Description = "Removes the specified doctor from the system."
        )]
        [SwaggerResponse(204, "The doctor was successfully deleted")]
        [SwaggerResponse(404, "If the doctor with the specified ID is not found")]
        public async Task<IActionResult> Delete([FromRoute] int id)
        {
            var exist = await _doct.CheckExistence(id);

            if (!exist)
            {
                return NotFound($"Doctor N° {id} does not exist in the database");
            }

            await _doct.Delete(id);
            return Ok($"Doctor N°{id} was eliminated");
        }
    }
}