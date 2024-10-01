using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ScheduleAppC969.DModels
{
    internal class DCountry
    {
        public int countryID { get; set; }
        public string countryName { get; set; }
        public DateTime createdDate { get; set; }
        public string createdBy { get; set; }
        public DateTime lastUpdate { get; set; }
        public string lastUpdateBy { get; set; }

        public DCountry(int id, string name, DateTime createdate, string createdby, DateTime lastupdate, string lastupdateby)
        {
            this.countryID = id;
            this.countryName = name;
            this.createdDate = createdate;
            this.createdBy = createdby;
            this.lastUpdate = lastupdate;
            this.lastUpdateBy = lastupdateby;
        }
    }
}

