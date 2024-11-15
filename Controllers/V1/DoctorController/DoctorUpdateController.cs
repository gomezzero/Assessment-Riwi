using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.Linq;
using System.Threading.Tasks;
using Assessment_Riwi.DTOs;
using Assessment_Riwi.Repositories;
using EventsAPI.Utils;
using Microsoft.AspNetCore.Mvc;
using Microsoft.Extensions.Logging;
using Swashbuckle.AspNetCore.Annotations;

namespace Assessment_Riwi.Controllers.V1.DoctorController
{
    [Route("api/v1/doctors")]
    [ApiExplorerSettings(GroupName = "v1")]
    [Tags("doctors")]
    public class DoctorUpdateController(IDoctor doctor) : DoctorController(doctor)
    {
        [HttpPut("{id}")]
        [SwaggerOperation(
            Summary = "Updates an existing Event",
            Description = "Updates the Event with the specified ID, if it exists, with the provided new details."
        )]
        [SwaggerResponse(204, "The Event was successfully updated")]
        [SwaggerResponse(400, "If the provided Event data is invalid")]
        [SwaggerResponse(404, "If the Event with the specified ID is not found")]
        public async Task<IActionResult> Update([FromRoute] int id, [FromBody] DoctorDTO updateDoctor)
        {
            if (!ModelState.IsValid)
            {
                return BadRequest(ModelState);
            }

            var checkEvent = await _doct.CheckExistence(id);


            if (!checkEvent)
            {
                return NotFound($"la vento N°{id} no existe en la base de datos");
            }

            var doctor = await _doct.GetById(id);

            if (doctor == null)
            {
                return NotFound();
            }

            doctor.Name = updateDoctor.Name;
            doctor.Address = updateDoctor.Address;
            doctor.EntryTime = TimeOnly.Parse(updateDoctor.EntryTime);
            doctor.DepartureTime = TimeOnly.Parse(updateDoctor.DepartureTime); ;
            doctor.Role = updateDoctor.Role;

            if (!string.IsNullOrWhiteSpace(updateDoctor.Password))
            {
                doctor.Password = PasswordHasher.HashPassword(updateDoctor.Password);
            }

            await _doct.Update(doctor);
            return NoContent();
        }
    }
}