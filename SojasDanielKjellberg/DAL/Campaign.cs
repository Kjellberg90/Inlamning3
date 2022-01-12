using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DAL
{
    public class Campaign
    {
        public int CampaignId { get; set; }
        public string Name { get; set; }
        public int Discount { get; set; }
        public List<Product> Product { get; set; }
    }
}
