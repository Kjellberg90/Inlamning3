using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DAL
{
    public class Staff
    {
        public int StaffId { get; set; }
        public string Name { get; set; }
        public int? MentorID { get; set; }
        public int Ssn { get; set; }
        public string PhoneNumber { get; set; }
        public string EMail { get; set; }
        public DateTime MentorShipEndDate { get; set; }
        public List<Staff> Pupil { get; set; }
        public Staff Mentor { get; set; }

        public List<Product> Product { get; set; }
        public List<Department> Department { get; set; }
    }
}
