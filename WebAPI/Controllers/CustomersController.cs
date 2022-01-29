using Business.Abstract;
using Entities.Concrete;
using Microsoft.AspNetCore.Mvc;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace WebAPI.Controllers
{

    [ApiController]
    [Route("api/[controller]")]
    public class CustomersController : Controller
    {
        private ICustomerService _customerService;

        public CustomersController(ICustomerService customerService)
        {
            _customerService = customerService;
        }

        [HttpGet("getall")]
        public IActionResult GetAll()
        {
            var result = _customerService.GetAll();
            return Ok(result);
        }

        [HttpGet("getbyphonenumber")]
        public IActionResult GetByPhoneNumber(string phoneNumber)
        {
            var result = _customerService.GetByPhoneNumber(phoneNumber);
            return Ok(result);
        }

        [HttpGet("getbyname")]
        public IActionResult GetByName(string name)
        {
            var result = _customerService.GetByName(name);
            return Ok(result);
        }

        [HttpPost("add")]
        public IActionResult Add(Customer customer)

        {
            _customerService.Add(customer);

            return Ok("Kullanıcı eklendi");

        }


        [HttpPut("update")]
        public IActionResult Update(Customer customer)

        {
            _customerService.Update(customer);
            return Ok("Kullanıcı güncellendi");
        }

        [HttpPost("delete")]
        public IActionResult Delete(int id)

        {
            var result = _customerService.GetById(id);
            _customerService.Delete(result);
            return Ok();
        }
        [HttpGet("getbyıd")]
        public IActionResult GetById(int id)

        {
            var result = _customerService.GetById(id);
            return Ok(result);
        }

    }
}
