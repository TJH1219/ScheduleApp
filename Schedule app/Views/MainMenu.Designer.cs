namespace Schedule_app.Views
{
    partial class MainMenu
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.btn_AppAdd = new System.Windows.Forms.Button();
            this.btn_AppModify = new System.Windows.Forms.Button();
            this.btn_AppDelete = new System.Windows.Forms.Button();
            this.data_Appointments = new System.Windows.Forms.DataGridView();
            this.data_Customers = new System.Windows.Forms.DataGridView();
            this.btn_CustDelete = new System.Windows.Forms.Button();
            this.btn_CustModify = new System.Windows.Forms.Button();
            this.btn_CustAdd = new System.Windows.Forms.Button();
            this.lbl_Customers = new System.Windows.Forms.Label();
            this.lbl_Appointment = new System.Windows.Forms.Label();
            this.cal_monthCal = new System.Windows.Forms.MonthCalendar();
            this.btn_Sunday = new System.Windows.Forms.Button();
            this.btn_Monday = new System.Windows.Forms.Button();
            this.btn_Tuesday = new System.Windows.Forms.Button();
            this.btn_Wednesday = new System.Windows.Forms.Button();
            this.btn_Thursday = new System.Windows.Forms.Button();
            this.btn_Friday = new System.Windows.Forms.Button();
            this.btn_Saturday = new System.Windows.Forms.Button();
            this.lbl_Sunday = new System.Windows.Forms.Label();
            this.lbl_Monday = new System.Windows.Forms.Label();
            this.lbl_Tuesday = new System.Windows.Forms.Label();
            this.lbl_Wednesday = new System.Windows.Forms.Label();
            this.lbl_Thursday = new System.Windows.Forms.Label();
            this.lbl_Friday = new System.Windows.Forms.Label();
            this.lbl_Saturday = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.data_Appointments)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.data_Customers)).BeginInit();
            this.SuspendLayout();
            // 
            // btn_AppAdd
            // 
            this.btn_AppAdd.Location = new System.Drawing.Point(9, 19);
            this.btn_AppAdd.Name = "btn_AppAdd";
            this.btn_AppAdd.Size = new System.Drawing.Size(91, 23);
            this.btn_AppAdd.TabIndex = 0;
            this.btn_AppAdd.Text = "Add";
            this.btn_AppAdd.UseVisualStyleBackColor = true;
            // 
            // btn_AppModify
            // 
            this.btn_AppModify.Location = new System.Drawing.Point(106, 19);
            this.btn_AppModify.Name = "btn_AppModify";
            this.btn_AppModify.Size = new System.Drawing.Size(96, 23);
            this.btn_AppModify.TabIndex = 1;
            this.btn_AppModify.Text = "Modify";
            this.btn_AppModify.UseVisualStyleBackColor = true;
            // 
            // btn_AppDelete
            // 
            this.btn_AppDelete.Location = new System.Drawing.Point(208, 19);
            this.btn_AppDelete.Name = "btn_AppDelete";
            this.btn_AppDelete.Size = new System.Drawing.Size(89, 23);
            this.btn_AppDelete.TabIndex = 2;
            this.btn_AppDelete.Text = "Delete";
            this.btn_AppDelete.UseVisualStyleBackColor = true;
            // 
            // data_Appointments
            // 
            this.data_Appointments.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.data_Appointments.Location = new System.Drawing.Point(9, 48);
            this.data_Appointments.Name = "data_Appointments";
            this.data_Appointments.RowTemplate.Height = 25;
            this.data_Appointments.Size = new System.Drawing.Size(285, 170);
            this.data_Appointments.TabIndex = 3;
            // 
            // data_Customers
            // 
            this.data_Customers.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.data_Customers.Location = new System.Drawing.Point(12, 268);
            this.data_Customers.Name = "data_Customers";
            this.data_Customers.RowTemplate.Height = 25;
            this.data_Customers.Size = new System.Drawing.Size(285, 170);
            this.data_Customers.TabIndex = 7;
            // 
            // btn_CustDelete
            // 
            this.btn_CustDelete.Location = new System.Drawing.Point(199, 239);
            this.btn_CustDelete.Name = "btn_CustDelete";
            this.btn_CustDelete.Size = new System.Drawing.Size(95, 23);
            this.btn_CustDelete.TabIndex = 6;
            this.btn_CustDelete.Text = "Delete";
            this.btn_CustDelete.UseVisualStyleBackColor = true;
            // 
            // btn_CustModify
            // 
            this.btn_CustModify.Location = new System.Drawing.Point(106, 239);
            this.btn_CustModify.Name = "btn_CustModify";
            this.btn_CustModify.Size = new System.Drawing.Size(87, 23);
            this.btn_CustModify.TabIndex = 5;
            this.btn_CustModify.Text = "Modify";
            this.btn_CustModify.UseVisualStyleBackColor = true;
            // 
            // btn_CustAdd
            // 
            this.btn_CustAdd.Location = new System.Drawing.Point(12, 239);
            this.btn_CustAdd.Name = "btn_CustAdd";
            this.btn_CustAdd.Size = new System.Drawing.Size(88, 23);
            this.btn_CustAdd.TabIndex = 4;
            this.btn_CustAdd.Text = "Add";
            this.btn_CustAdd.UseVisualStyleBackColor = true;
            // 
            // lbl_Customers
            // 
            this.lbl_Customers.AutoSize = true;
            this.lbl_Customers.Location = new System.Drawing.Point(12, 221);
            this.lbl_Customers.Name = "lbl_Customers";
            this.lbl_Customers.Size = new System.Drawing.Size(64, 15);
            this.lbl_Customers.TabIndex = 8;
            this.lbl_Customers.Text = "Customers";
            // 
            // lbl_Appointment
            // 
            this.lbl_Appointment.AutoSize = true;
            this.lbl_Appointment.Location = new System.Drawing.Point(12, 1);
            this.lbl_Appointment.Name = "lbl_Appointment";
            this.lbl_Appointment.Size = new System.Drawing.Size(64, 15);
            this.lbl_Appointment.TabIndex = 9;
            this.lbl_Appointment.Text = "Customers";
            // 
            // cal_monthCal
            // 
            this.cal_monthCal.Location = new System.Drawing.Point(417, 221);
            this.cal_monthCal.MaxSelectionCount = 1;
            this.cal_monthCal.Name = "cal_monthCal";
            this.cal_monthCal.TabIndex = 10;
            this.cal_monthCal.DateChanged += new System.Windows.Forms.DateRangeEventHandler(this.cal_monthCal_DateChanged);
            // 
            // btn_Sunday
            // 
            this.btn_Sunday.Location = new System.Drawing.Point(326, 19);
            this.btn_Sunday.Name = "btn_Sunday";
            this.btn_Sunday.Size = new System.Drawing.Size(75, 88);
            this.btn_Sunday.TabIndex = 11;
            this.btn_Sunday.Text = "Sunday";
            this.btn_Sunday.UseVisualStyleBackColor = true;
            // 
            // btn_Monday
            // 
            this.btn_Monday.Location = new System.Drawing.Point(407, 19);
            this.btn_Monday.Name = "btn_Monday";
            this.btn_Monday.Size = new System.Drawing.Size(75, 88);
            this.btn_Monday.TabIndex = 12;
            this.btn_Monday.Text = "Monday";
            this.btn_Monday.UseVisualStyleBackColor = true;
            // 
            // btn_Tuesday
            // 
            this.btn_Tuesday.Location = new System.Drawing.Point(488, 19);
            this.btn_Tuesday.Name = "btn_Tuesday";
            this.btn_Tuesday.Size = new System.Drawing.Size(75, 88);
            this.btn_Tuesday.TabIndex = 13;
            this.btn_Tuesday.Text = "Tuesday";
            this.btn_Tuesday.UseVisualStyleBackColor = true;
            // 
            // btn_Wednesday
            // 
            this.btn_Wednesday.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.btn_Wednesday.Location = new System.Drawing.Point(569, 19);
            this.btn_Wednesday.Name = "btn_Wednesday";
            this.btn_Wednesday.Size = new System.Drawing.Size(75, 88);
            this.btn_Wednesday.TabIndex = 14;
            this.btn_Wednesday.Text = "Wednesday";
            this.btn_Wednesday.UseVisualStyleBackColor = true;
            // 
            // btn_Thursday
            // 
            this.btn_Thursday.Location = new System.Drawing.Point(650, 19);
            this.btn_Thursday.Name = "btn_Thursday";
            this.btn_Thursday.Size = new System.Drawing.Size(75, 88);
            this.btn_Thursday.TabIndex = 15;
            this.btn_Thursday.Text = "Thursday";
            this.btn_Thursday.UseVisualStyleBackColor = true;
            // 
            // btn_Friday
            // 
            this.btn_Friday.Location = new System.Drawing.Point(448, 113);
            this.btn_Friday.Name = "btn_Friday";
            this.btn_Friday.RightToLeft = System.Windows.Forms.RightToLeft.No;
            this.btn_Friday.Size = new System.Drawing.Size(75, 88);
            this.btn_Friday.TabIndex = 16;
            this.btn_Friday.Text = "Friday";
            this.btn_Friday.UseVisualStyleBackColor = true;
            // 
            // btn_Saturday
            // 
            this.btn_Saturday.Location = new System.Drawing.Point(529, 113);
            this.btn_Saturday.Name = "btn_Saturday";
            this.btn_Saturday.Size = new System.Drawing.Size(75, 88);
            this.btn_Saturday.TabIndex = 17;
            this.btn_Saturday.Text = "Saturday";
            this.btn_Saturday.UseVisualStyleBackColor = true;
            // 
            // lbl_Sunday
            // 
            this.lbl_Sunday.AutoSize = true;
            this.lbl_Sunday.Location = new System.Drawing.Point(343, 80);
            this.lbl_Sunday.Name = "lbl_Sunday";
            this.lbl_Sunday.Size = new System.Drawing.Size(38, 15);
            this.lbl_Sunday.TabIndex = 18;
            this.lbl_Sunday.Text = "label1";
            // 
            // lbl_Monday
            // 
            this.lbl_Monday.AutoSize = true;
            this.lbl_Monday.Location = new System.Drawing.Point(426, 80);
            this.lbl_Monday.Name = "lbl_Monday";
            this.lbl_Monday.Size = new System.Drawing.Size(38, 15);
            this.lbl_Monday.TabIndex = 19;
            this.lbl_Monday.Text = "label2";
            // 
            // lbl_Tuesday
            // 
            this.lbl_Tuesday.AutoSize = true;
            this.lbl_Tuesday.Location = new System.Drawing.Point(504, 80);
            this.lbl_Tuesday.Name = "lbl_Tuesday";
            this.lbl_Tuesday.Size = new System.Drawing.Size(38, 15);
            this.lbl_Tuesday.TabIndex = 20;
            this.lbl_Tuesday.Text = "label3";
            // 
            // lbl_Wednesday
            // 
            this.lbl_Wednesday.AutoSize = true;
            this.lbl_Wednesday.Location = new System.Drawing.Point(588, 80);
            this.lbl_Wednesday.Name = "lbl_Wednesday";
            this.lbl_Wednesday.Size = new System.Drawing.Size(38, 15);
            this.lbl_Wednesday.TabIndex = 21;
            this.lbl_Wednesday.Text = "label4";
            // 
            // lbl_Thursday
            // 
            this.lbl_Thursday.AutoSize = true;
            this.lbl_Thursday.Location = new System.Drawing.Point(668, 80);
            this.lbl_Thursday.Name = "lbl_Thursday";
            this.lbl_Thursday.Size = new System.Drawing.Size(38, 15);
            this.lbl_Thursday.TabIndex = 22;
            this.lbl_Thursday.Text = "label5";
            // 
            // lbl_Friday
            // 
            this.lbl_Friday.AutoSize = true;
            this.lbl_Friday.Location = new System.Drawing.Point(467, 171);
            this.lbl_Friday.Name = "lbl_Friday";
            this.lbl_Friday.Size = new System.Drawing.Size(38, 15);
            this.lbl_Friday.TabIndex = 23;
            this.lbl_Friday.Text = "label6";
            // 
            // lbl_Saturday
            // 
            this.lbl_Saturday.AutoSize = true;
            this.lbl_Saturday.Location = new System.Drawing.Point(546, 171);
            this.lbl_Saturday.Name = "lbl_Saturday";
            this.lbl_Saturday.Size = new System.Drawing.Size(38, 15);
            this.lbl_Saturday.TabIndex = 24;
            this.lbl_Saturday.Text = "label7";
            // 
            // MainMenu
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.lbl_Saturday);
            this.Controls.Add(this.lbl_Friday);
            this.Controls.Add(this.lbl_Thursday);
            this.Controls.Add(this.lbl_Wednesday);
            this.Controls.Add(this.lbl_Tuesday);
            this.Controls.Add(this.lbl_Monday);
            this.Controls.Add(this.lbl_Sunday);
            this.Controls.Add(this.btn_Saturday);
            this.Controls.Add(this.btn_Friday);
            this.Controls.Add(this.btn_Thursday);
            this.Controls.Add(this.btn_Wednesday);
            this.Controls.Add(this.btn_Tuesday);
            this.Controls.Add(this.btn_Monday);
            this.Controls.Add(this.btn_Sunday);
            this.Controls.Add(this.cal_monthCal);
            this.Controls.Add(this.lbl_Appointment);
            this.Controls.Add(this.lbl_Customers);
            this.Controls.Add(this.data_Customers);
            this.Controls.Add(this.btn_CustDelete);
            this.Controls.Add(this.btn_CustModify);
            this.Controls.Add(this.btn_CustAdd);
            this.Controls.Add(this.data_Appointments);
            this.Controls.Add(this.btn_AppDelete);
            this.Controls.Add(this.btn_AppModify);
            this.Controls.Add(this.btn_AppAdd);
            this.Name = "MainMenu";
            this.Text = "MainMenu";
            ((System.ComponentModel.ISupportInitialize)(this.data_Appointments)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.data_Customers)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private Button btn_AppAdd;
        private Button btn_AppModify;
        private Button btn_AppDelete;
        private DataGridView data_Appointments;
        private DataGridView data_Customers;
        private Button btn_CustDelete;
        private Button btn_CustModify;
        private Button btn_CustAdd;
        private Label lbl_Customers;
        private Label lbl_Appointment;
        private MonthCalendar cal_monthCal;
        private Button btn_Sunday;
        private Button btn_Monday;
        private Button btn_Tuesday;
        private Button btn_Wednesday;
        private Button btn_Thursday;
        private Button btn_Friday;
        private Button btn_Saturday;
        private Label lbl_Sunday;
        private Label lbl_Monday;
        private Label lbl_Tuesday;
        private Label lbl_Wednesday;
        private Label lbl_Thursday;
        private Label lbl_Friday;
        private Label lbl_Saturday;
    }
}