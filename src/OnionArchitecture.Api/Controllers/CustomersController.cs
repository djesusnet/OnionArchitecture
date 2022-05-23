using DomainLayer.Model;
using DomainServiceLayer.Interface;
using Microsoft.AspNetCore.Mvc;

namespace OnionArchitecture.Api.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class CustomersController : ControllerBase
    {
        private readonly ICustomerService _customerService;

        public CustomersController(ICustomerService customerService)
        {
            _customerService = customerService;
        }

        [HttpGet]
        [Route("/customer/{id}")]
        public IActionResult GetCustomer(int id)
        {
            var result = _customerService.GetCustomer(id);
            if (result is not null)
            {
                return Ok(result);
            }
            return BadRequest("No records found");
        }

        [HttpGet]
        public IActionResult GetAllCustomer()
        {
            var result = _customerService.GetAllCustomers();
            if (result is not null)
            {
                return Ok(result);
            }
            return BadRequest("No records found");
        }

        [HttpPost]
        [Route("/customer")]
        public IActionResult InsertCustomer(Customer customer)
        {
            _customerService.InsertCustomer(customer);
            return Ok("Data inserted");
        }

        [HttpPut]
        [Route("/customer")]
        public IActionResult UpdateCustomer(Customer customer)
        {
            _customerService.UpdateCustomer(customer);
            return Ok("Updation done");
        }

        [HttpDelete]
        [Route("/customer")]
        public IActionResult DeleteCustomer(int Id)
        {
            _customerService.DeleteCustomer(Id);
            return Ok("Data Deleted");
        }

    }
}
