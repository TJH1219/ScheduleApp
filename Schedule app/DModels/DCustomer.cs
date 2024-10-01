using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ScheduleAppC969.DModels
{
    internal class DCustomer
    {
        public int customerID { get; set; }
        public string customerName { get; set; }
        public int addressID { get; set; }
        public bool active { get; set; }
        public DateTime createdDate { get; set; }
        public string createdBy { get; set; }
        public DateTime lastUpdate { get; set; }
        public string lastUpdatedBy { get; set; }

        public DCustomer(int customerID, string customerName, int addressID, bool active, DateTime createdDate, string createdBy, DateTime lastUpdate, string lastUpdatedBy)
        {
            this.customerID = customerID;
            this.customerName = customerName;
            this.addressID = addressID;
            this.active = active;
            this.createdDate = createdDate;
            this.createdBy = createdBy;
            this.lastUpdate = lastUpdate;
            this.lastUpdatedBy = lastUpdatedBy;
        }
    }
}
