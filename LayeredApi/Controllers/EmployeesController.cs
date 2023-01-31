using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using EmployeeRepositories;

namespace LayeredApi.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class EmployeesController : ControllerBase
    {
        private IEmployeeRepository _empRepo;

        public EmployeesController(IEmployeeRepository empRepo)
        {
            this._empRepo = empRepo;
        }

        [HttpGet]
        public IActionResult Get()
        {
            EmployeeRepository empRepo = new EmployeeRepository();
            var empList = empRepo.GetEmployees();

            return Ok(empList);
        }
    }
}
