using Freedom.App.Contract;
using System;
using System.Collections.Generic;
using System.Text;
using System.Threading.Tasks;

namespace Freedom.App.BusinessOperation
{
    public interface IRegistrationFormBusinessOperation
    {
        void AddRegistrationForm(RegistrationForm registrationForm);

        void DeleteRegistrationForm(int id);

        void UpdateRegistrtaionForm(int id, RegistrationForm registrationForm);

        Task<List<RegistrationForm>> GetRegistrationForm();
    }
}
