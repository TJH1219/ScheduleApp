using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ScheduleAppC969.DModels
{
    internal class DAppointment
    {
        public int appointmentID { get; set; }
        public int customerID { get; set; }
        public int userID { get; set; }
        public string title { get; set; }
        public string description { get; set; }
        public string location { get; set; }
        public string contact { get; set; }
        public string type { get; set; }
        public string url { get; set; }
        public DateTime createDate { get; set; }
        public string createdBy { get; set; }
        public DateTime lastUpdate { get; set; }
        public string lastUpdateBy { get; set; }

        public DAppointment(int appointmentID, int customerID, int userID, string title, string description, string location, string contact, string type, string url, DateTime createDate, string createdBy, DateTime lastUpdate, string lastUpdateBy)
        {
            this.appointmentID = appointmentID;
            this.customerID = customerID;
            this.userID = userID;
            this.title = title;
            this.description = description;
            this.location = location;
            this.contact = contact;
            this.type = type;
            this.url = url;
            this.createDate = createDate;
            this.createdBy = createdBy;
            this.lastUpdate = lastUpdate;
            this.lastUpdateBy = lastUpdateBy;
        }
    }
}
