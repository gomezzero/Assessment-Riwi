using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Assessment_Riwi.Models;

namespace Assessment_Riwi.Repositories
{
    public interface IAppointment
    {
        // CRUD
        Task Add(Appointment appointment);
        Task Delete(int id);
        Task Update(Appointment appointment);

        // GET
        Task<IEnumerable<Appointment>> GetAll();
        Task<IEnumerable<Appointment>> GetPatientAddress(string address);
        Task<IEnumerable<Appointment>> GetDoctorId(int doctorId);
        Task<Appointment?> GetById(int id);


        //Utils
        Task<bool> CheckExistence(int id);


    }
}