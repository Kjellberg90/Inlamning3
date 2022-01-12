using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DAL
{
    public class Product
    {
        public int ProductId { get; set; }
        public string Name { get; set; }
        public float Price { get; set; }
        public float Stock { get; set; }
        public DateTime ExpiryDate { get; set; }
        public Staff Staff { get; set; }
        public Campaign Campaign { get; set; }
        //public List<Department> Departments { get; set; }
        public IList<ProductDepartement> ProductDepartements { get; set; }
    }
}
