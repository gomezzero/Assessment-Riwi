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

namespace Assessment_Riwi.Controllers.V1.DoctorController
{
    [Route("api/v1/doctors")]
    [ApiExplorerSettings(GroupName = "v1")]
    [Tags("doctors")]
    public class DoctorGetController(IDoctor doctor) : DoctorController(doctor)
    {
        [HttpGet("{id}")]
        [Authorize(Roles = "doctor")]
        [SwaggerOperation(
            Summary = "Retrieves a Doctor by ID",
            Description = "Returns the Doctor details for the specified ID."
        )]
        [SwaggerResponse(200, "The Doctor with the specified ID", typeof(Doctor))]
        [SwaggerResponse(404, "If the Doctor with the specified ID is not found")]
        public async Task<ActionResult<Doctor>> GetById([FromRoute] int id)
        {
            var doctor = await _doct.GetById(id);

            if (doctor == null)
            {
                return NotFound();
            }
            return doctor;
        }

        [HttpGet("all")]
        [Authorize(Roles = "doctor")]
        [SwaggerOperation(
            Summary = "Retrieves all Doctor",
            Description = "Returns a list of all Doctor in the system."
        )]
        [SwaggerResponse(200, "A list of Doctor", typeof(IEnumerable<Doctor>))]
        public async Task<ActionResult<IEnumerable<Doctor>>> GetAll()
        {
            var doctor = await _doct.GetAll();
            return Ok(doctor);
        }

        [HttpGet("available")]
        [Authorize(Roles = "doctor")]
        [SwaggerOperation(
            Summary = "Retrieves all available Doctor",
            Description = "Returns a list of all available Doctor in the system."
        )]
        [SwaggerResponse(200, "A list of Doctor", typeof(IEnumerable<Doctor>))]
        public async Task<ActionResult<IEnumerable<Doctor>>> GetAvailableDoctors([FromQuery] DateOnly date, [FromQuery] TimeOnly time)
        {
            var doctors = await _doct.GetAllAvailableDoctors(date, time);

            if (doctors == null || !doctors.Any())
            {
                return NotFound("There are no doctors available for the date and time requested.");
            }

            return Ok(doctors);
        }
    }
}