using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace alphaApi.Entities
{
    public record Department
    {
        public int Id { get; init; }
        //nullable int, потому что у головного подразделения нет род. подразделения
        public int? ParentId { get; set; }
        public DateTime BeginDate { get; set; }
        public DateTime DisbandDate { get; set; }
        public int? ManagerId { get; set; }
        public string Title { get; set; }
        public int? FirmId { get; set; }
    }
}
