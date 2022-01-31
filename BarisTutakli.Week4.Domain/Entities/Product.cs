using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BarisTutakli.Week4.Domain.Entities
{
    public class Product:BaseEntity
    {
        public int CategoryId { get; set; }
        public Category Category { get; set; }
        public string Name { get; set; }
        public DateTime PublishDate { get; set; }
    }
}
