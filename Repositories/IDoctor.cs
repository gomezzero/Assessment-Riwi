using Assessment_Riwi.Models;
using Microsoft.AspNetCore.Mvc;

namespace Assessment_Riwi.Repositories
{
    public interface IDoctor
    {
        // CRUD
        Task Add(Doctor doctor);
        Task Delete(int id);
        Task Update(Doctor doctor);

        // GET
        Task<IEnumerable<Doctor>> GetAll();
        Task<IEnumerable<Doctor>> GetAllAvailableDoctors(DateOnly date, TimeOnly time);
        Task<Doctor?> GetById(int id);
        Task<Doctor?> GetByAddressDoct(string address);



        // Util
        Task<bool> CheckExistence(int id);
    }
}