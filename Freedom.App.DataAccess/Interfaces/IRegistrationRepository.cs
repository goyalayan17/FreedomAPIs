using Freedom.App.Contract;
using Freedom.App.DataAccess.DTO;
using System;
using System.Collections.Generic;
using System.Text;
using System.Threading.Tasks;

namespace Freedom.App.DataAccess.Interfaces
{
    public interface IRegistrationRepository
    {
        void AddRegistration(RegistrationForm registrationForm);
        void DeleteRegistration(int id);

        void UpdateRegistration(int id, RegistrationForm registrationForm);

        Task<List<RegistrationForm>> GetRegistration();
    }
}
