using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ScheduleAppC969.DModels
{
    internal class DCity
    {
        public int cityID { get; set; }
        public string cityName { get; set; }
        public string countyID { get; set; }
        public DateTime createDate { get; set; }
        public string createdBy { get; set; }
        public DateTime lastUpdated { get; set; }
        public string lastUpdatedBy { get; set; }

        public DCity(int cityid, string city, string countryid, DateTime createddate, string createdby, DateTime LastUpdated, string lastupdatedby)
        {
            this.cityID = cityid;
            this.cityName = city;
            this.countyID = countryid;
            this.createDate = createddate;
            this.createdBy = createdby;
            this.lastUpdatedBy = lastupdatedby;
            this.lastUpdatedBy = lastupdatedby;
        }
    }
}
