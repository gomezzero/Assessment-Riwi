using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Assessment_Riwi.Models;

namespace Assessment_Riwi.Repositories
{
    public interface IPatient
    {
        // CRUD
        Task Add(Patient patient);
        Task Delete(int id);

        // GET
        Task<IEnumerable<Patient>> GetAll();
        Task<Patient?> GetByAddress(string address);
        Task<Patient?> GetById(int id);

        // Util
        Task<bool> CheckExistence(int id);
    }
}