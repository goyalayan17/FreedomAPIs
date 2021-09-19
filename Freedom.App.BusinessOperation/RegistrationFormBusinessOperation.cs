using Freedom.App.Contract;
using Freedom.App.DataAccess.Interfaces;
using System;
using System.Collections.Generic;
using System.Threading.Tasks;

namespace Freedom.App.BusinessOperation
{
    public class RegistrationFormBusinessOperation: IRegistrationFormBusinessOperation
    {
        private readonly IRegistrationRepository _registrationRepository;
        public RegistrationFormBusinessOperation(IRegistrationRepository registrationRepository)
        {
            _registrationRepository = registrationRepository;
        }

        public  void AddRegistrationForm(RegistrationForm registrationForm)
        {
           _registrationRepository.AddRegistration(registrationForm);
        }

        public void DeleteRegistrationForm(int id)
        {
            _registrationRepository.DeleteRegistration(id);
        }

        public async Task<List<RegistrationForm>> GetRegistrationForm()
        {
            return await _registrationRepository.GetRegistration();
        }

        public void UpdateRegistrtaionForm(int id, RegistrationForm registrationForm)
        {
            _registrationRepository.UpdateRegistration(id, registrationForm);
        }
    }
}
