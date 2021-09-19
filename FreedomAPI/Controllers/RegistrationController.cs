using Freedom.App.BusinessOperation;
using Freedom.App.Contract;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace FreedomAPI.Controllers
{
    [Route("[controller]")]
    [ApiController]
    public class RegistrationController : ControllerBase
    {
        private readonly IRegistrationFormBusinessOperation _registrationFormBusinessOperation;

        public RegistrationController(IRegistrationFormBusinessOperation registrationFormBusinessOperation) {
            _registrationFormBusinessOperation = registrationFormBusinessOperation;
        }

        [HttpGet]
        [Route("get")]
        public async Task<List<RegistrationForm>> GetRegistrationAsync()
        {
            return await _registrationFormBusinessOperation.GetRegistrationForm();
        }

        [HttpPost]
        [Route("add")]
        public IActionResult addData(RegistrationForm registrationForm)
        {
             _registrationFormBusinessOperation.AddRegistrationForm(registrationForm);
            return Ok();
        }

        [HttpDelete]
        [Route("delete")]
        public void deleteData([FromBody] int id)
        {
            _registrationFormBusinessOperation.DeleteRegistrationForm(id);

        }
        [HttpPut]
        [Route("update/{id}")]
        public void updateData([FromBody] RegistrationForm registrationForm, [FromRoute] int id)
        {
            _registrationFormBusinessOperation.UpdateRegistrtaionForm(id, registrationForm);
        }

    }
}
