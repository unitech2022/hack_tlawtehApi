using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace HackTlawtehApi.Models
{
    public class SubCategory
    {
         public int Id { get; set; }

           public int CategoryId { get; set; }
        public string? Name { get; set; }

        public string? Desc { get; set; }
        public string? Image { get; set; }

        public string? Color { get; set; }
    }
}