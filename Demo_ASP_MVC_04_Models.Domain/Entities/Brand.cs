using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Demo_ASP_MVC_04_Models.Domain.Entities
{
    public class Brand
    {
        [ScaffoldColumn(false)]
        public int BrandId { get; set; }
        public string Name { get; set; }
        public string? Country { get; set; }
    }
}
