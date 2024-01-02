using Domain;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Application.Dtos
{
    internal class ProductDto
    {
        public string Name { get; set; }
        public string Description { get; set; }
        public Category Category { get; set; }
        public int Stock { get; set; } = 0;
    }
}
