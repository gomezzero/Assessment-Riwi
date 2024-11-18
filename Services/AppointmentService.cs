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
    public class AppointmentService(MyDbContext context) : IAppointment
    {
        private MyDbContext _context = context;
        // CRUD
        public async Task Add(Appointment appointment)
        {

            if (appointment == null)
            {
                throw new ArgumentNullException(nameof(Appointment), "The Appointment cannot be null");
            }

            try
            {
                await _context.Appointments.AddAsync(appointment);
                await _context.SaveChangesAsync();
            }
            catch (DbUpdateException dbExi)
            {
                throw new Exception("Error when adding Appointment to database", dbExi);
            }
            catch (Exception exi)
            {
                throw new Exception("An unexpected error occurred when entering the Appointment into the database.", exi);
            }
        }

        public async Task Update(Appointment appointment)
        {
            if (appointment == null)
            {
                throw new ArgumentNullException(nameof(appointment), "The Appointment cannot be null and void");
            }

            try
            {
                _context.Entry(appointment).State = EntityState.Modified;
                await _context.SaveChangesAsync();
            }
            catch (DbUpdateException dbExi)
            {
                throw new Exception("Error when updating the Appointment in the database", dbExi);
            }
            catch (Exception ex)
            {
                throw new Exception("An unexpected error occurred while updating Dr", ex);
            }
        }

        public async Task Delete(int id)
        {
            var appointment = await _context.Appointments.FindAsync(id);

            if (appointment == null)
            {
                throw new ArgumentNullException(nameof(Appointment), "The Appointment cannot be null");
            }

            try
            {
                _context.Appointments.Remove(appointment);
                await _context.SaveChangesAsync();
            }
            catch (DbUpdateException dbExi)
            {
                throw new Exception("Error deleting Appointment from database", dbExi);
            }
            catch (Exception exi)
            {
                throw new Exception("An error occurred when removing the Appointment.", exi);
            }
        }

        // GET

        public async Task<IEnumerable<Appointment>> GetAll()
        {
            return await _context.Appointments.ToListAsync();

        }

        public async Task<IEnumerable<Appointment>> GetPatientAddress(string address)
        {
            return await _context.Appointments.Include(a => a.Patient)
                        .Where(a => a.Patient.Address.ToLower().Trim() == address.ToLower().Trim())
                        .ToListAsync();
        }

        public async Task<Appointment> GetAppointmentByDoctorAndDate(int doctorId, DateOnly appointmentDay, TimeOnly appointmentTime)
        {
            return await _context.Appointments
                .FirstOrDefaultAsync(a => a.DoctorId == doctorId && a.AppointmentDay == appointmentDay && a.AppointmentTime == appointmentTime);
        }

        public async Task<IEnumerable<Appointment>> GetDoctorId(int doctorId)
        {
            return await _context.Appointments.Include(a => a.Doctor)
                        .Where(a => a.DoctorId == doctorId)
                        .ToListAsync();
        }


        public async Task<Appointment?> GetById(int id)
        {
            return await _context.Appointments.FindAsync(id);
        }


        //Utils
        public async Task<bool> CheckExistence(int id)
        {
            try
            {
                return await _context.Appointments.AnyAsync(u => u.Id == id);
            }
            catch (Exception exi)
            {
                throw new Exception("An error occurred during Appointment search", exi);
            }
        }

    }
}