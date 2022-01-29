using alphaApi.DTOs;
using alphaApi.Entities;
using Microsoft.AspNetCore.Mvc;
using System.Collections.Generic;

namespace alphaApi.Repository
{
    public interface Irepository
    {
        public List<Employee> GetActiveEmployees();
        public List<Employee> GetActiveEmployees(int departmentId);
        public void GetDepartmentSubDepartmentsList(int id);
        public string GetDepartmentTitleById(int id, List<Department> departments);
        public string GetFirmTitleById(int id, List<Firm> Firms);
        public List<DepartmentsAndManagersByFirtmDTO> GetManagersAndDepartmentsByFirmId(int id);
        public ActionResult<List<Employee>> GetManagerSubordinates(int id);
    }
}