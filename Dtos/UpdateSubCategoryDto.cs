using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace HackTlawtehApi.Dtos
{
    public class UpdateSubCategoryDto
    {


           public int CategoryId { get; set; }
            public string? Name { get; set; }
          public string? ImageUrl { get; set; }

        public int Status { get; set; }

         public string? Color { get; set; }
    }
}