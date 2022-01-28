using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace alphaApi.Entities
{
    public record Employee
    {
        public int Id { get; init; }
        public string FullName { get; set; }
        public int Gender { get; set; }
        public string Login { get; set; }
        public string PhoneNumber { get; set; }
        public bool isManager { get; set; }
        public int DepartmentId { get; set; }
        public DateTime DateIn { get; set; }
        public DateTime DateOut { get; set; }
    }
}
