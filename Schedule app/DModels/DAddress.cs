using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ScheduleAppC969.DModels
{
    internal class DAddress
    {
        public int addressID { get; set; }
        public string address { get; set; }
        public string address2 { get; set; }
        public int cityID { get; set; }
        public string postalCode { get; set; }
        public string phone { get; set; }
        public DateTime createDate { get; set; }
        public string createdby { get; set; }
        public DateTime lastUpdate { get; set; }
        public string lastUpdateBy { get; set; }

        public DAddress(int addressID, string address, string address2, int cityID, string postalCode, string phone, DateTime createDate, string createdby, DateTime lastUpdate, string lastUpdateBy)
        {
            this.addressID = addressID;
            this.address = address;
            this.address2 = address2;
            this.cityID = cityID;
            this.postalCode = postalCode;
            this.phone = phone;
            this.createDate = createDate;
            this.createdby = createdby;
            this.lastUpdate = lastUpdate;
            this.lastUpdateBy = lastUpdateBy;
        }
    }
}
