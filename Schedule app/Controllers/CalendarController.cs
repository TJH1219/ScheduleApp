using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Schedule_app.Controllers
{
    internal enum Type
    {
        Long = 0,
        Short = 1,
        Feb = 2,
        Leap = 3,
        fail = 4
    }

    internal class Month
    {
        public Type type { get; set; }
        public string name { get; set; }

        public Month(Type type, string name)
        {
            this.type = type;
            this.name = name;
        }
    }

    internal class Week
    {
        public DateTime startDate { get; set; }
        public DateTime endDate { get; set; }
    }
    internal class CalendarController
    {
        public List<Month> Months { get; set; }
        public DateTime sl_Date { get; set; }
        public Type startMonthType { get; set; }
        public Week cr_week { get; set; }

        public CalendarController(DateTime sl_Date)
        {
            this.Months = new List<Month>();
            this.cr_week = new Week();
            this.sl_Date = sl_Date;
            this._set_Week();
            this._setMonths();
        }

        private void _setMonths()
        {
            this.Months.Add(new Month(Type.Long, "January"));
            this.Months.Add(new Month(Type.Feb, "Februaru"));
            this.Months.Add(new Month(Type.Long, "March"));
            this.Months.Add(new Month(Type.Short, "April"));
            this.Months.Add(new Month(Type.Long, "May"));
            this.Months.Add(new Month(Type.Short, "June"));
            this.Months.Add(new Month(Type.Long, "July"));
            this.Months.Add(new Month(Type.Long, "August"));
            this.Months.Add(new Month(Type.Short, "September"));
            this.Months.Add(new Month(Type.Long, "October"));
            this.Months.Add(new Month(Type.Short, "November"));
            this.Months.Add(new Month(Type.Long, "January"));
        }

        public void setNewDates(DateTime newdate)
        {
            this.sl_Date = newdate;
            this._set_Week();
        }

        private void _set_Week()
        {
            DayOfWeek Day = sl_Date.DayOfWeek;
            if(Day == DayOfWeek.Sunday)
            {
                this.cr_week.startDate = this.sl_Date;
                this.cr_week.endDate = this.sl_Date.AddDays(6);
            }
            else if(Day == DayOfWeek.Monday)
            {
                this.cr_week.startDate = this.sl_Date.AddDays(-1);
                this.cr_week.endDate = this.sl_Date.AddDays(5);
            }
            else if (Day == DayOfWeek.Tuesday)
            {
                this.cr_week.startDate = this.sl_Date.AddDays(-2);
                this.cr_week.endDate = this.sl_Date.AddDays(4);
            }
            else if (Day == DayOfWeek.Wednesday)
            {
                this.cr_week.startDate = this.sl_Date.AddDays(-3);
                this.cr_week.endDate = this.sl_Date.AddDays(3);
            }
            else if (Day == DayOfWeek.Thursday)
            {
                this.cr_week.startDate = this.sl_Date.AddDays(-4);
                this.cr_week.endDate = this.sl_Date.AddDays(2);
            }
            else if (Day == DayOfWeek.Friday)
            {
                this.cr_week.startDate = this.sl_Date.AddDays(-5);
                this.cr_week.endDate = this.sl_Date.AddDays(2);
            }
            else if (Day == DayOfWeek.Saturday)
            {
                this.cr_week.startDate = this.sl_Date.AddDays(-6);
                this.cr_week.endDate = this.sl_Date;
            }
        }
    }
}
