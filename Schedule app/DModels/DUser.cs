using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ScheduleAppC969.DModels
{
    internal class DUser
    {
        public int userID { get; set; }
        public string userName { get; set; }
        public string password { get; set; }
        public bool active { get; set; }
        public DateTime createDate { get; set; }
        public string createdBy { get; set; }
        public DateTime lastUpdated { get; set; }
        public string lastUpdateBy { get; set; }

        public DUser(int userID, string userName, string password, bool active, DateTime createDate, string createdBy, DateTime lastUpdated, string lastUpdateBy)
        {
            this.userID = userID;
            this.userName = userName;
            this.password = password;
            this.active = active;
            this.createDate = createDate;
            this.createdBy = createdBy;
            this.lastUpdated = lastUpdated;
            this.lastUpdateBy = lastUpdateBy;
        }
    }
}
