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

namespace Assessment_Riwi.Controllers.V1.Patients
{
    [Route("api/v1/patients")]
    [ApiExplorerSettings(GroupName = "v1")]
    [Tags("patients")]
    public class PatientGetController(IPatient patient) : PatientController(patient)
    {
        [HttpGet("all")]
        [Authorize(Roles  = "doctor")]
        [SwaggerOperation(
            Summary = "Retrieves all Patient",
            Description = "Returns a list of all Patient in the system."
        )]
        [SwaggerResponse(200, "A list of Patient", typeof(IEnumerable<Patient>))]
        public async Task<ActionResult<IEnumerable<Patient>>> GetAll()
        {
            var patient = await _patient.GetAll();
            return Ok(patient);
        }


        [HttpGet("{address}")]
        [Authorize]
        [SwaggerOperation(
            Summary = "Retrieves by addres Patient",
            Description = "Returns a Patient in the system for addres."
        )]
        [SwaggerResponse(200, "A list of Patient", typeof(IEnumerable<Patient>))]
        public async Task<ActionResult<IEnumerable<Patient>>> GetPatientAddress(string address)
        {
            var patient = await _patient.GetByAddress(address);

            return Ok(patient);
        }

    }
}