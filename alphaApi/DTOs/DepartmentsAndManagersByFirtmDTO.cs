using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace alphaApi.DTOs
{
    public class DepartmentsAndManagersByFirtmDTO
    {
        public int FirmId { get; set; }
        public string FirmTitle { get; set; }
        public string Fullname { get; set; }
        public int DepartmentId { get; set; }
        public string DepartmentTitle { get; set; }
    }
}
