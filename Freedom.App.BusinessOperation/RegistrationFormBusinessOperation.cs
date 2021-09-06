using System;

namespace Freedom.App.BusinessOperation
{
    public class RegistrationFormBusinessOperation
    {
        private readonly IRegistrationFormBusinessOperation _registrationFormBusinessOperation;
        public RegistrationFormBusinessOperation(IRegistrationFormBusinessOperation registrationFormBusinessOperation)
        {
            _registrationFormBusinessOperation = registrationFormBusinessOperation;
        }
    }
}
