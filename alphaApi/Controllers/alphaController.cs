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
        public List<Employee> GetEmployees()
        {
            var employees = repository.GetActiveEmployees();
            return employees;
        }


        // REQ: GET /alpha/firmId/{firmId}
        [HttpGet]
        [Route("managersByFirm/{firmId}")]
        public List<DepartmentsAndManagersByFirtmDTO> GetManagersAndTheirDepartments(int firmId)
        {
            return repository.GetManagersAndDepartmentsByFirmId(firmId); 
        }
    }
}
