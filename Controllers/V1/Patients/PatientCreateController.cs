using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.Linq;
using System.Threading.Tasks;
using Assessment_Riwi.DTOs;
using Assessment_Riwi.Models;
using Assessment_Riwi.Repositories;
using EventsAPI.Utils;
using Microsoft.AspNetCore.Mvc;
using Microsoft.Extensions.Logging;
using Swashbuckle.AspNetCore.Annotations;

namespace Assessment_Riwi.Controllers.V1.Patients
{
    [Route("api/v1/patients")]
    [ApiExplorerSettings(GroupName = "v1")]
    [Tags("patients")]
    public class PatienteCreatController(IPatient patient) : PatientController(patient)
    {
        [HttpPost]
        [SwaggerOperation(
            Summary = "Creates a new Patient",
            Description = "Adds a new Patient to the system with the provided name and description."
        )]
        [SwaggerResponse(201, "The Patient was successfully created", typeof(Patient))]
        [SwaggerResponse(400, "If the Patient data is invalid")]

        public async Task<ActionResult<Patient>> Create([FromBody] PatientDTO inputPatient)
        {
            if (!ModelState.IsValid)
            {
                return BadRequest(ModelState);
            }

            var hasPassword = PasswordHasher.HashPassword(inputPatient.Password);

            var newPatient = new Patient(inputPatient.Name, inputPatient.Address, hasPassword, inputPatient.Role);

            await _patient.Add(newPatient);

            return Ok(newPatient);
        }
    }
}