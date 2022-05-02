using alphaApi.DTOs;
using alphaApi.Entities;
using alphaApi.Repository;
using Microsoft.AspNetCore.Mvc;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace alphaApi.Controllers
{
    [ApiController]
    [Route("alpha")]
    public class alphaController : ControllerBase
    {
        private readonly Irepository repository;
        public alphaController(Irepository irepository_)
        {
            repository = irepository_;
        }

        // REQ: GET address: /alpha
        [HttpGet]
        [Route("getAllWorkers")]
        public List<Employee> GetEmployees()
        {
            var employees = repository.GetActiveEmployees();
            return employees;
        }


        // REQ: GET /managersByFirm/{firmId}
        [HttpGet]
        [Route("managersByFirm")]
        public List<DepartmentsAndManagersByFirtmDTO> GetManagersAndTheirDepartments(int firmId)
        {
            return repository.GetManagersAndDepartmentsByFirmId(firmId); 
        }


        // REQ: GET /managerSubordinates/{managerId}
        [HttpGet]
        [Route("managerSubordinates")]
        public ActionResult<List<Employee>> GetManagerSubordinatesEmployees(int managerId)
        {
            return repository.GetManagerSubordinates(managerId);
        }
    }
}
