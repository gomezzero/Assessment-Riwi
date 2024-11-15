using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.Linq;
using System.Threading.Tasks;
using Assessment_Riwi.Config;
using Assessment_Riwi.Repositories;
using EventsAPI.DTOs.Request;
using EventsAPI.Utils;
using Microsoft.AspNetCore.Mvc;
using Microsoft.Extensions.Logging;

namespace EventsAPI.Controllers.V1.Auth
{
    [Route("api/v1/auth")]
    [ApiExplorerSettings(GroupName = "v1")]
    public class AuthController : ControllerBase
    {
        protected readonly IPatient servicios;
        protected readonly IDoctor doctorservice;

        public AuthController(IPatient patientRepositori, IDoctor doctor)
        {
            servicios = patientRepositori;
            doctorservice = doctor;
        }

        [HttpPost]
        [Route("login")]
        public async Task<IActionResult> Login([FromBody] LoginDTO data)
        {
            var user = await servicios.GetByAddress(data.Address);
            var doctor = await doctorservice.GetByAddressDoct(data.Address);

            if (user != null)
            {
                bool isPasswordValid = PasswordHasher.VerifiPassword(data.Password, user.Password);
                if (!isPasswordValid)
                {
                    return BadRequest("Incorrect password");
                }

                var token = JWT.GenerateJwtToken(user);
                return Ok($"Usu token is : {token}");

            }
            else if (doctor == null)
            {
                return BadRequest("The user does not exist");
            }

            // Verify the hashed password
            bool isPasswordValidDoct = PasswordHasher.VerifiPassword(data.Password, doctor.Password);



            if (!isPasswordValidDoct)
            {
                return BadRequest("Incorrect password");
            }

            var tokenDoctor = JWT.GenerateJwtTokenDoctor(doctor);


            return Ok($"Doct token is : {tokenDoctor}");

        }

    }
}