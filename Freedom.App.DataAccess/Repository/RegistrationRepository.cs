using Freedom.App.Contract;
using Freedom.App.DataAccess.DTO;
using Freedom.App.DataAccess.Interfaces;
using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Freedom.App.DataAccess.Repository
{
    public class RegistrationRepository: IRegistrationRepository
    {
        private readonly DbContextOptions<RegistrationDbContext> _dbContext;

        public RegistrationRepository(DbContextOptions<RegistrationDbContext> dbContext) {
            _dbContext = dbContext;
        }

        public async void AddRegistration(RegistrationForm registrationForm)
        {
            using (var db = new RegistrationDbContext(_dbContext)) {
                db.RegistrationFormMap.Add(new DTO.RegistrationFormDto() {
                    FirstName = registrationForm.FirstName,
                    LastName = registrationForm.LastName,
                    Gender = registrationForm.Gender,
                    MiddleName = registrationForm.MiddleName,
                    Claass = registrationForm.Claass
                
                });

                await db.SaveChangesAsync();
            }
        }

        public async void DeleteRegistration(int id)
        {
            using(var db = new RegistrationDbContext(_dbContext))
            {
                RegistrationFormDto obj =await db.RegistrationFormMap.SingleAsync(t => t.Id == id);
                db.RegistrationFormMap.Remove(obj);

                await db.SaveChangesAsync();
            }
        }

        public async void UpdateRegistration(int id, RegistrationForm registrationForm)
        {
            using (var db = new RegistrationDbContext(_dbContext))
            {
                RegistrationFormDto obj = await db.RegistrationFormMap.SingleAsync(t => t.Id == id);
                obj.FirstName = registrationForm.FirstName;
                obj.LastName = registrationForm.LastName;
                obj.Claass = registrationForm.Claass;
                obj.MiddleName = registrationForm.MiddleName;
                obj.Gender = registrationForm.Gender;

                await db.SaveChangesAsync();
            }
        }

        public async Task<List<RegistrationForm>> GetRegistration()
        {
            using (var db = new RegistrationDbContext(_dbContext))
            {
                List<RegistrationForm> registrationForms = await db.RegistrationFormMap.Select(x => new RegistrationForm { 
                    Id = x.Id,
                    FirstName =x.FirstName,
                    MiddleName = x.MiddleName,
                    LastName =x.LastName,
                    Gender = x.Gender,
                    Claass =x.Claass
                }).ToListAsync();
                return registrationForms;
            }

        }
    }
}
