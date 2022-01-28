using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace alphaApi.Entities
{
    public record Firm
    {
        public int Id { get; init; }
        public string Title { get; set; }
    }
}
