using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.Linq;
using System.Threading.Tasks;
using Assessment_Riwi.Repositories;
using Microsoft.AspNetCore.Mvc;
using Microsoft.Extensions.Logging;

namespace Assessment_Riwi.Controllers.V1.DoctorController
{
    [Route("api/v1/doctors")]

    public class DoctorController(IDoctor doctor) : ControllerBase
    {
        protected readonly IDoctor _doct = doctor;
    }
}