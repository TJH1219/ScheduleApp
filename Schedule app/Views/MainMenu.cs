using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Windows.Forms.VisualStyles;

namespace Schedule_app.Views
{
    public partial class MainMenu : Form
    {
        internal Controllers.DatabaseControll dbcontrol;
        public string cr_Month { get; set; }
        public string cr_Dayofweek { get; set; }
        public int cr_day { get; set; }
        public List<Label> weeklabels { get; set; }
        public List<Button> weekbuttons { get; set; }
        public DateTime sl_Date { get; set; }
        internal Controllers.CalendarController calControl { get; set; }
        public MainMenu()
        {
            InitializeComponent();
            this.dbcontrol = new Controllers.DatabaseControll();
            this.sl_Date = cal_monthCal.SelectionStart;
            this.calControl = new Controllers.CalendarController(sl_Date);
            this.weeklabels = new List<Label>();
            this.weekbuttons = new List<Button>();
            string startstring = this.calControl.cr_week.startDate.ToLongDateString();
            //["Wednesday"," May 16","2020"]
            string[] temp1 = startstring.Split(",");
            //[" ","May","16"]
            string[] temp2 = temp1[1].Split(" ");
            this.cr_Month = temp2[1];
            this._buildWeekButtons();
            this._buildWeekLabels();
            this._getDayOfWeek(sl_Date.ToLongDateString());
            this.setButtonColors();
            this._setWeekLabels();
        }

        private Controllers.Type _getMonthType()
        {
            for (int i = 0; i <= 11; i++)
            {
                if(i == 0)
                {
                    return this.calControl.Months[11].type;
                }
                if (this.calControl.Months[i].name == this.cr_Month)
                {
                    return this.calControl.Months[i-1].type;
                }
            }
            return Controllers.Type.fail;
        }

        private Controllers.Type _GetNextMonthType()
        {
            for (int i = 0; i <= 11; i++)
            {
                if (this.calControl.Months[i].name == this.cr_Month)
                {
                    return calControl.Months[i].type;
                }
            }
            return Controllers.Type.fail;
        }

        private bool CrossoverNext()
        {
            string startstring = this.calControl.cr_week.startDate.ToLongDateString();
            //["Wednesday"," May 16","2020"]
            string[] temp1 = startstring.Split(",");
            //[" ","May","16"]
            string[] temp2 = temp1[1].Split(" ");
            string month = temp2[1];
            if(this.cr_Month == month)
            {
                return true;
            }
            return false;
        }
            
        private void _SetNoCrossOver()
        {
            int newstart = 1;
            int maxnum = 0;
            Controllers.Type prevtype = this._GetNextMonthType();
            if (prevtype == Controllers.Type.Long)
            {
                maxnum = 31;
            }
            else if (prevtype == Controllers.Type.Short)
            {
                maxnum = 30;
            }
            else if (prevtype == Controllers.Type.Feb)
            {
                maxnum = 28;
            }
            else if (prevtype == Controllers.Type.Leap)
            {
                maxnum = 29;
            }
            string startstring = this.calControl.cr_week.startDate.ToLongDateString();
            //["Wednesday"," May 16","2020"]
            string[] temp1 = startstring.Split(",");
            //[" ","May","16"]
            string[] temp2 = temp1[1].Split(" ");
            int start = Convert.ToInt32(temp2[2]);
            //Sunday
            if (start <= maxnum)
            {
                this.lbl_Sunday.Text = Convert.ToString(start);
                start += 1;
            }
            else if (start > maxnum)
            {
                this.lbl_Sunday.Text = Convert.ToString(newstart);
                newstart += 1;
            }
            //Monday
            if (start <= maxnum)
            {
                this.lbl_Monday.Text = Convert.ToString(start);
                start += 1;
            }
            else if (start > maxnum)
            {
                this.lbl_Monday.Text = Convert.ToString(newstart);
                newstart += 1;
            }
            //Tuesday
            if (start <= maxnum)
            {
                this.lbl_Tuesday.Text = Convert.ToString(start);
                start += 1;
            }
            else if (start > maxnum)
            {
                this.lbl_Tuesday.Text = Convert.ToString(newstart);
                newstart += 1;
            }
            //Wednesday
            if (start <= maxnum)
            {
                this.lbl_Wednesday.Text = Convert.ToString(start);
                start += 1;
            }
            else if (start > maxnum)
            {
                this.lbl_Wednesday.Text = Convert.ToString(newstart);
                newstart += 1;
            }
            //Thursday
            if (start <= maxnum)
            {
                this.lbl_Thursday.Text = Convert.ToString(start);
                start += 1;
            }
            else if (start > maxnum)
            {
                this.lbl_Thursday.Text = Convert.ToString(newstart);
                newstart += 1;
            }
            //Friday
            if (start <= maxnum)
            {
                this.lbl_Friday.Text = Convert.ToString(start);
                start += 1;
            }
            else if (start > maxnum)
            {
                this.lbl_Friday.Text = Convert.ToString(newstart);
                newstart += 1;
            }
            //Saturday
            if (start <= maxnum)
            {
                this.lbl_Saturday.Text = Convert.ToString(start);
                start += 1;
            }
            else if (start > maxnum)
            {
                this.lbl_Saturday.Text = Convert.ToString(newstart);
                newstart += 1;
            }
        }
    
        private void _SetCrossover()
        {
            int newstart = 1;
            int maxnum = 0;
            Controllers.Type prevtype = this._getMonthType();
            if (prevtype == Controllers.Type.Long)
            {
                maxnum = 31;
            }
            else if (prevtype == Controllers.Type.Short)
            {
                maxnum = 30;
            }
            else if (prevtype == Controllers.Type.Feb)
            {
                maxnum = 28;
            }
            else if (prevtype == Controllers.Type.Leap)
            {
                maxnum = 29;
            }
            string startstring = this.calControl.cr_week.startDate.ToLongDateString();
            //["Wednesday"," May 16","2020"]
            string[] temp1 = startstring.Split(",");
            //[" ","May","16"]
            string[] temp2 = temp1[1].Split(" ");
            int start = Convert.ToInt32(temp2[2]);
            //Sunday
            if (start <= maxnum)
            {
                this.lbl_Sunday.Text = Convert.ToString(start);
                start += 1;
            }
            else if (start > maxnum)
            {
                this.lbl_Sunday.Text = Convert.ToString(newstart);
                newstart += 1;
            }
            //Monday
            if (start <= maxnum)
            {
                this.lbl_Monday.Text = Convert.ToString(start);
                start += 1;
            }
            else if (start > maxnum)
            {
                this.lbl_Monday.Text = Convert.ToString(newstart);
                newstart += 1;
            }
            //Tuesday
            if (start <= maxnum)
            {
                this.lbl_Tuesday.Text = Convert.ToString(start);
                start += 1;
            }
            else if (start > maxnum)
            {
                this.lbl_Tuesday.Text = Convert.ToString(newstart);
                newstart += 1;
            }
            //Wednesday
            if (start <= maxnum)
            {
                this.lbl_Wednesday.Text = Convert.ToString(start);
                start += 1;
            }
            else if (start > maxnum)
            {
                this.lbl_Wednesday.Text = Convert.ToString(newstart);
                newstart += 1;
            }
            //Thursday
            if (start <= maxnum)
            {
                this.lbl_Thursday.Text = Convert.ToString(start);
                start += 1;
            }
            else if (start > maxnum)
            {
                this.lbl_Thursday.Text = Convert.ToString(newstart);
                newstart += 1;
            }
            //Friday
            if (start <= maxnum)
            {
                this.lbl_Friday.Text = Convert.ToString(start);
                start += 1;
            }
            else if (start > maxnum)
            {
                this.lbl_Friday.Text = Convert.ToString(newstart);
                newstart += 1;
            }
            //Saturday
            if (start <= maxnum)
            {
                this.lbl_Saturday.Text = Convert.ToString(start);
                start += 1;
            }
            else if (start > maxnum)
            {
                this.lbl_Saturday.Text = Convert.ToString(newstart);
                newstart += 1;
            }
        }

        private void _setWeekLabels()
        {
            bool cross = this.CrossoverNext();
            if(cross == true)
            {
                this._SetNoCrossOver();
            }
            else if(cross == false)
            {
                this._SetCrossover();
            }
        }

        private void _buildWeekLabels()
        {
            this.weeklabels.Add(lbl_Sunday);
            this.weeklabels.Add(lbl_Monday);
            this.weeklabels.Add(lbl_Tuesday);
            this.weeklabels.Add(lbl_Wednesday);
            this.weeklabels.Add(lbl_Thursday);
            this.weeklabels.Add(lbl_Friday);
            this.weeklabels.Add(lbl_Saturday);
        }

        private void _buildWeekButtons()
        {
            this.weekbuttons.Add(btn_Sunday);
            this.weekbuttons.Add(btn_Monday);
            this.weekbuttons.Add(btn_Tuesday);
            this.weekbuttons.Add(btn_Wednesday);
            this.weekbuttons.Add(btn_Thursday);
            this.weekbuttons.Add(btn_Friday);
            this.weekbuttons.Add(btn_Saturday);
        }

        public void setButtonColors()
        {
            foreach(Button btn in this.weekbuttons)
            {
                btn.BackColor = Color.White;
            }
            Color color = Color.BlueViolet;
            switch (this.cr_Dayofweek)
            {
                case "Sunday":
                    btn_Sunday.BackColor = color;
                    break;
                case "Monday":
                    btn_Monday.BackColor = color;
                    break;
                case "Tuesday":
                    btn_Tuesday.BackColor = color;
                    break;
                case "Wednesday":
                    btn_Wednesday.BackColor = color;
                    break;
                case "Thursday":
                    btn_Thursday.BackColor = color;
                    break;
                case "Friday":
                    btn_Friday.BackColor = color;
                    break;
                case "Saturday":
                    btn_Saturday.BackColor = color;
                    break;
            }
        }

        private void _getDayOfWeek(string datestring)
        {
            //["Wednesday"," May 16","2020"]
            string[] temp1 = datestring.Split(",");
            //[" ","May","16"]
            string[] temp2 = temp1[1].Split(" ");
            this.cr_Month = temp2[1];
            this.cr_Dayofweek = temp1[0];
            this.cr_day = Convert.ToInt32(temp2[2]);
        }

        private void cal_monthCal_DateChanged(object sender, DateRangeEventArgs e)
        {
            this.sl_Date = cal_monthCal.SelectionStart;
            this.calControl.setNewDates(cal_monthCal.SelectionStart);
            this._getDayOfWeek(sl_Date.ToLongDateString());
            string startstring = this.sl_Date.ToLongDateString();
            //["Wednesday"," May 16","2020"]
            string[] temp1 = startstring.Split(",");
            //[" ","May","16"]
            string[] temp2 = temp1[1].Split(" ");
            this.cr_Month = temp2[1];
            this.cr_Dayofweek = temp1[0];
            this.setButtonColors();
            this._setWeekLabels();
        }
    }
}
