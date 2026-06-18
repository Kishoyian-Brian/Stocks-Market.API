using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Threading.Tasks;

namespace api.Models
{
    public record Stocks
    {
        public int Id { get; set; }

        public string Symbol { get; set; } = string.Empty;

        public string CompanyName { get; set; } =string.Empty;

        [Column(TypeName ="decimal(18,20)")]
        public decimal Price { get; set; }

        public decimal Purchase { get; set; }

        [Column(TypeName ="decimal(18,20)")]
        public decimal LastDiv { get; set; }

        public string Industry { get; set; }= string.Empty;

        public long Myproperty { get; set; }

        public List<Comments> Comments { get; set; }= new List<Comments>();
}     
    
}