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

namespace Assessment_Riwi.Controllers.V1.Patients
{
    [Route("api/v1/patients")]
    [ApiExplorerSettings(GroupName = "v1")]
    [Tags("patients")]
    public class PatienteDeletController(IPatient patient) : PatientController(patient)
    {

        [HttpDelete("{id}")]
        [Authorize]
        [SwaggerOperation(
            Summary = "Deletes a patient by ID",
            Description = "Removes the specified patient from the system."
        )]
        [SwaggerResponse(204, "The patient was successfully deleted")]
        [SwaggerResponse(404, "If the patient with the specified ID is not found")]
        public async Task<IActionResult> Delete([FromRoute] int id)
        {
            var exist = await _patient.CheckExistence(id);

            if (!exist)
            {
                return NotFound($"patient N° {id} does not exist in the database");
            }

            await _patient.Delete(id);
            return Ok($"patient N°{id} was eliminated");
        }
    }
}