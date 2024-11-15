using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.Linq;
using System.Threading.Tasks;
using Assessment_Riwi.Repositories;
using Microsoft.AspNetCore.Authorization;
using Microsoft.AspNetCore.Mvc;
using Microsoft.Extensions.Logging;

namespace Assessment_Riwi.Controllers.V1.Appointments
{
    [Route("api/v1/appointments")]
    public class AppointmentController(IAppointment appointment) : ControllerBase
    {
        protected readonly IAppointment _appoint = appointment;
    }
}