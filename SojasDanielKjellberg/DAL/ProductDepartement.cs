using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DAL
{
    public class ProductDepartement
    {
        public int ProductId { get; set; }
        public Product Product { get; set; }

        public int DepartmentId { get; set; }
        public Department Department { get; set; }
    }
}
