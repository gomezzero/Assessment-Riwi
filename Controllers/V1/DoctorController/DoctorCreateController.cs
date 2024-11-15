using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.Linq;
using System.Threading.Tasks;
using Assessment_Riwi.Controllers.V1.DoctorController;
using Assessment_Riwi.DTOs;
using Assessment_Riwi.Models;
using Assessment_Riwi.Repositories;
using EventsAPI.Utils;
using Microsoft.AspNetCore.Authorization;
using Microsoft.AspNetCore.Http.HttpResults;
using Microsoft.AspNetCore.Identity;
using Microsoft.AspNetCore.Mvc;
using Microsoft.Extensions.Logging;
using Swashbuckle.AspNetCore.Annotations;

namespace essment_Riwi.Controllers.V1.DoctorCreateController
{
    [Route("api/v1/doctors")]
    [ApiExplorerSettings(GroupName = "v1")]
    [Tags("doctors")]
    public class DoctorCreateController(IDoctor doctor) : DoctorController(doctor)
    {
        [HttpPost]
        [Authorize(Roles = "doctor")]
        [SwaggerOperation(
            Summary = "Creates a new Doctor",
            Description = "Adds a new Doctor to the system with the provided name and description."
        )]
        [SwaggerResponse(201, "The Doctor was successfully created", typeof(Doctor))]
        [SwaggerResponse(400, "If the Doctor data is invalid")]

        public async Task<ActionResult<Doctor>> Create([FromBody] DoctorDTO inputDoctor)
        {
            if (!ModelState.IsValid)
            {
                return BadRequest(ModelState);
            }

            var hasPassword = PasswordHasher.HashPassword(inputDoctor.Password);

            var newDoctor = new Doctor(inputDoctor.Name, hasPassword, inputDoctor.Address, TimeOnly.Parse(inputDoctor.EntryTime), TimeOnly.Parse(inputDoctor.DepartureTime), inputDoctor.Role);

            await _doct.Add(newDoctor);

            return Ok(newDoctor);
        }
    }
}