using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.Linq;
using System.Threading.Tasks;
using Assessment_Riwi.Repositories;
using Microsoft.AspNetCore.Mvc;
using Microsoft.Extensions.Logging;

namespace Assessment_Riwi.Controllers.V1.Patients
{
    [Route("api/v1/patients")]
    public class PatientController(IPatient patient) : ControllerBase
    {
        protected readonly IPatient _patient = patient;
    }
}