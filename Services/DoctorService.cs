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
    public class DoctorService(MyDbContext context) : IDoctor
    {
        // CRUD
        private readonly MyDbContext _context = context;
        public async Task Add(Doctor doctor)
        {
            if (doctor == null)
            {
                throw new ArgumentNullException(nameof(Doctor), "The doctor cannot be null");
            }

            try
            {
                await _context.Doctors.AddAsync(doctor);
                await _context.SaveChangesAsync();
            }
            catch (DbUpdateException dbExi)
            {
                throw new Exception("Error when adding doctor to database", dbExi);
            }
            catch (Exception exi)
            {
                throw new Exception("An unexpected error occurred when entering the doctor into the database.", exi);
            }
        }

        public async Task Delete(int id)
        {
            var doctor = await _context.Doctors.FindAsync(id);

            if (doctor == null)
            {
                throw new ArgumentNullException(nameof(Doctor), "The doctor cannot be null");
            }

            try
            {
                _context.Doctors.Remove(doctor);
                await _context.SaveChangesAsync();
            }
            catch (DbUpdateException dbExi)
            {
                throw new Exception("Error deleting doctor from database", dbExi);
            }
            catch (Exception exi)
            {
                throw new Exception("An error occurred when removing the doctor.", exi);
            }
        }

        public async Task Update(Doctor doctor)
        {
            if (doctor == null)
            {
                throw new ArgumentNullException(nameof(doctor), "The doctor cannot be null and void");
            }

            try
            {
                _context.Entry(doctor).State = EntityState.Modified;
                await _context.SaveChangesAsync();
            }
            catch (DbUpdateException dbExi)
            {
                throw new Exception("Error when updating the doctor in the database", dbExi);
            }
            catch (Exception ex)
            {
                throw new Exception("An unexpected error occurred while updating Dr", ex);
            }
        }

        public async Task<IEnumerable<Doctor>> GetAll()
        {
            return await _context.Doctors.ToListAsync();
        }

        public async Task<IEnumerable<Doctor>> GetAllAvailableDoctors(DateOnly date, TimeOnly time)
        {
            return await _context.Doctors
                .Where(d => d.EntryTime <= time && d.DepartureTime >= time && !_context.Appointments
                .Any(a => a.DoctorId == d.Id && a.AppointmentDay == date && a.AppointmentTime == time))
                .ToListAsync();
        }

        public async Task<Doctor?> GetByAddressDoct(string address)
        {
            try
            {
                return await _context.Doctors.FirstOrDefaultAsync(u => u.Address == address);
            }
            catch (Exception exi)
            {
                throw new Exception("An error occurred during patient search", exi);
            }
        }

        public async Task<Doctor?> GetById(int id)
        {
            return await _context.Doctors.FindAsync(id);
        }

        // Utils
        public async Task<bool> CheckExistence(int id)
        {
            try
            {
                return await _context.Doctors.AnyAsync(u => u.Id == id);
            }
            catch (Exception exi)
            {
                throw new Exception("An error occurred during doctor search", exi);
            }
        }
    }
}