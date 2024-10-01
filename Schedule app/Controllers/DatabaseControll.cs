using MySql.Data.MySqlClient;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Schedule_app.Controllers
{
    internal class DatabaseControll
    {
        public MySqlConnection conn { get; set; }
        public List<ScheduleAppC969.DModels.DAddress> addressTable { get; set; }
        public List<ScheduleAppC969.DModels.DAppointment> appointmentTable { get; set; }
        public List<ScheduleAppC969.DModels.DCity> cityTable { get; set; }
        public List<ScheduleAppC969.DModels.DCountry> countryTable { get; set; }
        public List<ScheduleAppC969.DModels.DCustomer> customerTable { get; set; }
        public List<ScheduleAppC969.DModels.DUser> userTable { get; set; }

        public DatabaseControll()
        {
        }
    }
}
