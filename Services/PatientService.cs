using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Assessment_Riwi.Data;
using Assessment_Riwi.Models;
using Assessment_Riwi.Repositories;
using Microsoft.EntityFrameworkCore;

namespace Assessment_Riwi.Services
{
    public class PatientService(MyDbContext context) : IPatient
    {
        private readonly MyDbContext _context = context;

        // CRUD
        public async Task Add(Patient patient)
        {

            if (patient == null)
            {
                throw new ArgumentNullException(nameof(Patient), "The patient cannot be null");
            }

            try
            {
                await _context.Patients.AddAsync(patient);
                await _context.SaveChangesAsync();
            }
            catch (DbUpdateException dbExi)
            {
                throw new Exception("Error when adding patient to database", dbExi);
            }
            catch (Exception exi)
            {
                throw new Exception("An unexpected error occurred when entering the patient into the database.", exi);
            }
        }

        public async Task Delete(int id)
        {

            var patient = await _context.Patients.FindAsync(id);

            if (patient == null)
            {
                throw new ArgumentNullException(nameof(Patient), "The patient cannot be null");
            }

            try
            {
                _context.Patients.Remove(patient);
                await _context.SaveChangesAsync();
            }
            catch (DbUpdateException dbExi)
            {
                throw new Exception("Error deleting patient from database", dbExi);
            }
            catch (Exception exi)
            {
                throw new Exception("An error occurred when removing the patient.", exi);
            }
        }

        // GET
        public async Task<IEnumerable<Patient>> GetAll()
        {
            return await _context.Patients.ToListAsync();
        }

        public async Task<Patient?> GetByAddress(string address)
        {
            try
            {
                return await _context.Patients.FirstOrDefaultAsync(u => u.Address == address);
            }
            catch (Exception exi)
            {
                throw new Exception("An error occurred during patient search", exi);
            }
        }

        public async Task<Patient?> GetById(int id)
        {
            return await _context.Patients.FindAsync(id);
        }

        //Utils
        public async Task<bool> CheckExistence(int id)
        {
            try
            {
                return await _context.Patients.AnyAsync(u => u.Id == id);
            }
            catch (Exception exi)
            {
                throw new Exception("An error occurred during patient search", exi);
            }
        }
    }
}