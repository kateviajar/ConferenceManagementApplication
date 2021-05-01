
namespace ConferenceManagement
{
    partial class CreateBookingForm
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
            this.panel1 = new System.Windows.Forms.Panel();
            this.BookingLabel = new System.Windows.Forms.Label();
            this.DateLabel = new System.Windows.Forms.Label();
            this.TimeLabel = new System.Windows.Forms.Label();
            this.BookingDateTimePicker = new System.Windows.Forms.DateTimePicker();
            this.TimeComboBox = new System.Windows.Forms.ComboBox();
            this.RoomInfoLabel = new System.Windows.Forms.Label();
            this.NameLabel = new System.Windows.Forms.Label();
            this.CompanyLabel = new System.Windows.Forms.Label();
            this.EmailLabel = new System.Windows.Forms.Label();
            this.RoomDataGridView = new System.Windows.Forms.DataGridView();
            this.RoomGroupBox = new System.Windows.Forms.GroupBox();
            this.Room206CheckBox = new System.Windows.Forms.CheckBox();
            this.Room205CheckBox = new System.Windows.Forms.CheckBox();
            this.Room204CheckBox = new System.Windows.Forms.CheckBox();
            this.Room203CheckBox = new System.Windows.Forms.CheckBox();
            this.Room202CheckBox = new System.Windows.Forms.CheckBox();
            this.Room201CheckBox = new System.Windows.Forms.CheckBox();
            this.ViewBookingButton = new System.Windows.Forms.Button();
            this.CreateButton = new System.Windows.Forms.Button();
            this.HelloLabel = new System.Windows.Forms.Label();
            this.ExitButton = new System.Windows.Forms.Button();
            this.LogoutButton = new System.Windows.Forms.Button();
            this.panel1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.RoomDataGridView)).BeginInit();
            this.RoomGroupBox.SuspendLayout();
            this.SuspendLayout();
            // 
            // panel1
            // 
            this.panel1.BackColor = System.Drawing.SystemColors.GradientActiveCaption;
            this.panel1.Controls.Add(this.BookingLabel);
            this.panel1.Dock = System.Windows.Forms.DockStyle.Top;
            this.panel1.Location = new System.Drawing.Point(0, 0);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(889, 100);
            this.panel1.TabIndex = 0;
            // 
            // BookingLabel
            // 
            this.BookingLabel.AutoSize = true;
            this.BookingLabel.Font = new System.Drawing.Font("Century Gothic", 21.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.BookingLabel.Location = new System.Drawing.Point(238, 31);
            this.BookingLabel.Name = "BookingLabel";
            this.BookingLabel.Size = new System.Drawing.Size(397, 36);
            this.BookingLabel.TabIndex = 0;
            this.BookingLabel.Text = "Conference Room Booking";
            // 
            // DateLabel
            // 
            this.DateLabel.AutoSize = true;
            this.DateLabel.Font = new System.Drawing.Font("Century Gothic", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.DateLabel.Location = new System.Drawing.Point(59, 275);
            this.DateLabel.Name = "DateLabel";
            this.DateLabel.Size = new System.Drawing.Size(50, 21);
            this.DateLabel.TabIndex = 5;
            this.DateLabel.Text = "Date";
            // 
            // TimeLabel
            // 
            this.TimeLabel.AutoSize = true;
            this.TimeLabel.Font = new System.Drawing.Font("Century Gothic", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.TimeLabel.Location = new System.Drawing.Point(59, 315);
            this.TimeLabel.Name = "TimeLabel";
            this.TimeLabel.Size = new System.Drawing.Size(46, 21);
            this.TimeLabel.TabIndex = 7;
            this.TimeLabel.Text = "Time";
            // 
            // BookingDateTimePicker
            // 
            this.BookingDateTimePicker.CustomFormat = "yyyy/MM/dd";
            this.BookingDateTimePicker.Font = new System.Drawing.Font("Century Gothic", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.BookingDateTimePicker.Format = System.Windows.Forms.DateTimePickerFormat.Custom;
            this.BookingDateTimePicker.Location = new System.Drawing.Point(116, 273);
            this.BookingDateTimePicker.Name = "BookingDateTimePicker";
            this.BookingDateTimePicker.Size = new System.Drawing.Size(151, 27);
            this.BookingDateTimePicker.TabIndex = 6;
            this.BookingDateTimePicker.ValueChanged += new System.EventHandler(this.BookingDateTimePicker_ValueChanged);
            // 
            // TimeComboBox
            // 
            this.TimeComboBox.Font = new System.Drawing.Font("Century Gothic", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.TimeComboBox.FormattingEnabled = true;
            this.TimeComboBox.Location = new System.Drawing.Point(116, 312);
            this.TimeComboBox.Name = "TimeComboBox";
            this.TimeComboBox.Size = new System.Drawing.Size(151, 29);
            this.TimeComboBox.TabIndex = 8;
            this.TimeComboBox.SelectedIndexChanged += new System.EventHandler(this.TimeComboBox_SelectedIndexChanged);
            // 
            // RoomInfoLabel
            // 
            this.RoomInfoLabel.Font = new System.Drawing.Font("Century Gothic", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.RoomInfoLabel.Location = new System.Drawing.Point(569, 116);
            this.RoomInfoLabel.Name = "RoomInfoLabel";
            this.RoomInfoLabel.Size = new System.Drawing.Size(241, 30);
            this.RoomInfoLabel.TabIndex = 14;
            this.RoomInfoLabel.Text = "Conference Room Information";
            this.RoomInfoLabel.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            // 
            // NameLabel
            // 
            this.NameLabel.Font = new System.Drawing.Font("Century Gothic", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.NameLabel.Location = new System.Drawing.Point(59, 149);
            this.NameLabel.Name = "NameLabel";
            this.NameLabel.Size = new System.Drawing.Size(208, 30);
            this.NameLabel.TabIndex = 2;
            this.NameLabel.Text = "Name";
            this.NameLabel.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            // 
            // CompanyLabel
            // 
            this.CompanyLabel.Font = new System.Drawing.Font("Century Gothic", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.CompanyLabel.Location = new System.Drawing.Point(59, 188);
            this.CompanyLabel.Name = "CompanyLabel";
            this.CompanyLabel.Size = new System.Drawing.Size(208, 30);
            this.CompanyLabel.TabIndex = 3;
            this.CompanyLabel.Text = "Company Name";
            this.CompanyLabel.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            // 
            // EmailLabel
            // 
            this.EmailLabel.Font = new System.Drawing.Font("Century Gothic", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.EmailLabel.Location = new System.Drawing.Point(59, 227);
            this.EmailLabel.Name = "EmailLabel";
            this.EmailLabel.Size = new System.Drawing.Size(208, 30);
            this.EmailLabel.TabIndex = 4;
            this.EmailLabel.Text = "Email";
            this.EmailLabel.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            // 
            // RoomDataGridView
            // 
            this.RoomDataGridView.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.RoomDataGridView.Location = new System.Drawing.Point(517, 149);
            this.RoomDataGridView.Name = "RoomDataGridView";
            this.RoomDataGridView.RowHeadersWidth = 82;
            this.RoomDataGridView.RowTemplate.Height = 24;
            this.RoomDataGridView.Size = new System.Drawing.Size(343, 300);
            this.RoomDataGridView.TabIndex = 15;
            // 
            // RoomGroupBox
            // 
            this.RoomGroupBox.Controls.Add(this.Room206CheckBox);
            this.RoomGroupBox.Controls.Add(this.Room205CheckBox);
            this.RoomGroupBox.Controls.Add(this.Room204CheckBox);
            this.RoomGroupBox.Controls.Add(this.Room203CheckBox);
            this.RoomGroupBox.Controls.Add(this.Room202CheckBox);
            this.RoomGroupBox.Controls.Add(this.Room201CheckBox);
            this.RoomGroupBox.Font = new System.Drawing.Font("Century Gothic", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.RoomGroupBox.Location = new System.Drawing.Point(292, 149);
            this.RoomGroupBox.Name = "RoomGroupBox";
            this.RoomGroupBox.Size = new System.Drawing.Size(200, 300);
            this.RoomGroupBox.TabIndex = 9;
            this.RoomGroupBox.TabStop = false;
            this.RoomGroupBox.Text = "Select a Room";
            // 
            // Room206CheckBox
            // 
            this.Room206CheckBox.AutoSize = true;
            this.Room206CheckBox.Location = new System.Drawing.Point(42, 249);
            this.Room206CheckBox.Name = "Room206CheckBox";
            this.Room206CheckBox.Size = new System.Drawing.Size(105, 25);
            this.Room206CheckBox.TabIndex = 5;
            this.Room206CheckBox.Text = "Room 206";
            this.Room206CheckBox.UseVisualStyleBackColor = true;
            this.Room206CheckBox.CheckedChanged += new System.EventHandler(this.Room206CheckBox_CheckedChanged);
            // 
            // Room205CheckBox
            // 
            this.Room205CheckBox.AutoSize = true;
            this.Room205CheckBox.Location = new System.Drawing.Point(42, 206);
            this.Room205CheckBox.Name = "Room205CheckBox";
            this.Room205CheckBox.Size = new System.Drawing.Size(105, 25);
            this.Room205CheckBox.TabIndex = 4;
            this.Room205CheckBox.Text = "Room 205";
            this.Room205CheckBox.UseVisualStyleBackColor = true;
            this.Room205CheckBox.CheckedChanged += new System.EventHandler(this.Room205CheckBox_CheckedChanged);
            // 
            // Room204CheckBox
            // 
            this.Room204CheckBox.AutoSize = true;
            this.Room204CheckBox.Location = new System.Drawing.Point(42, 165);
            this.Room204CheckBox.Name = "Room204CheckBox";
            this.Room204CheckBox.Size = new System.Drawing.Size(105, 25);
            this.Room204CheckBox.TabIndex = 3;
            this.Room204CheckBox.Text = "Room 204";
            this.Room204CheckBox.UseVisualStyleBackColor = true;
            this.Room204CheckBox.CheckedChanged += new System.EventHandler(this.Room204CheckBox_CheckedChanged);
            // 
            // Room203CheckBox
            // 
            this.Room203CheckBox.AutoSize = true;
            this.Room203CheckBox.Location = new System.Drawing.Point(42, 122);
            this.Room203CheckBox.Name = "Room203CheckBox";
            this.Room203CheckBox.Size = new System.Drawing.Size(105, 25);
            this.Room203CheckBox.TabIndex = 2;
            this.Room203CheckBox.Text = "Room 203";
            this.Room203CheckBox.UseVisualStyleBackColor = true;
            this.Room203CheckBox.CheckedChanged += new System.EventHandler(this.Room203CheckBox_CheckedChanged);
            // 
            // Room202CheckBox
            // 
            this.Room202CheckBox.AutoSize = true;
            this.Room202CheckBox.Location = new System.Drawing.Point(42, 78);
            this.Room202CheckBox.Name = "Room202CheckBox";
            this.Room202CheckBox.Size = new System.Drawing.Size(105, 25);
            this.Room202CheckBox.TabIndex = 1;
            this.Room202CheckBox.Text = "Room 202";
            this.Room202CheckBox.UseVisualStyleBackColor = true;
            this.Room202CheckBox.CheckedChanged += new System.EventHandler(this.Room202CheckBox_CheckedChanged);
            // 
            // Room201CheckBox
            // 
            this.Room201CheckBox.AutoSize = true;
            this.Room201CheckBox.Location = new System.Drawing.Point(42, 39);
            this.Room201CheckBox.Name = "Room201CheckBox";
            this.Room201CheckBox.Size = new System.Drawing.Size(105, 25);
            this.Room201CheckBox.TabIndex = 0;
            this.Room201CheckBox.Text = "Room 201";
            this.Room201CheckBox.UseVisualStyleBackColor = true;
            this.Room201CheckBox.CheckedChanged += new System.EventHandler(this.Room201CheckBox_CheckedChanged);
            // 
            // ViewBookingButton
            // 
            this.ViewBookingButton.Font = new System.Drawing.Font("Century Gothic", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.ViewBookingButton.Location = new System.Drawing.Point(160, 378);
            this.ViewBookingButton.Name = "ViewBookingButton";
            this.ViewBookingButton.Size = new System.Drawing.Size(126, 32);
            this.ViewBookingButton.TabIndex = 11;
            this.ViewBookingButton.Text = " &View Booking";
            this.ViewBookingButton.UseVisualStyleBackColor = true;
            this.ViewBookingButton.Click += new System.EventHandler(this.ViewBookingButton_Click);
            // 
            // CreateButton
            // 
            this.CreateButton.Font = new System.Drawing.Font("Century Gothic", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.CreateButton.Location = new System.Drawing.Point(28, 378);
            this.CreateButton.Name = "CreateButton";
            this.CreateButton.Size = new System.Drawing.Size(126, 32);
            this.CreateButton.TabIndex = 10;
            this.CreateButton.Text = "C&reate";
            this.CreateButton.UseVisualStyleBackColor = true;
            this.CreateButton.Click += new System.EventHandler(this.CreateButton_Click);
            // 
            // HelloLabel
            // 
            this.HelloLabel.Font = new System.Drawing.Font("Century Gothic", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.HelloLabel.Location = new System.Drawing.Point(60, 116);
            this.HelloLabel.Name = "HelloLabel";
            this.HelloLabel.Size = new System.Drawing.Size(208, 30);
            this.HelloLabel.TabIndex = 1;
            this.HelloLabel.Text = "Hello,";
            this.HelloLabel.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            // 
            // ExitButton
            // 
            this.ExitButton.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.ExitButton.Location = new System.Drawing.Point(28, 417);
            this.ExitButton.Name = "ExitButton";
            this.ExitButton.Size = new System.Drawing.Size(126, 32);
            this.ExitButton.TabIndex = 12;
            this.ExitButton.Text = "&Exit";
            this.ExitButton.UseVisualStyleBackColor = true;
            this.ExitButton.Click += new System.EventHandler(this.ExitButton_Click);
            // 
            // LogoutButton
            // 
            this.LogoutButton.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.LogoutButton.Location = new System.Drawing.Point(160, 418);
            this.LogoutButton.Name = "LogoutButton";
            this.LogoutButton.Size = new System.Drawing.Size(126, 32);
            this.LogoutButton.TabIndex = 13;
            this.LogoutButton.Text = "&Logout";
            this.LogoutButton.UseVisualStyleBackColor = true;
            this.LogoutButton.Click += new System.EventHandler(this.LogoutButton_Click);
            // 
            // CreateBookingForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 12F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(889, 478);
            this.Controls.Add(this.LogoutButton);
            this.Controls.Add(this.ExitButton);
            this.Controls.Add(this.HelloLabel);
            this.Controls.Add(this.CreateButton);
            this.Controls.Add(this.ViewBookingButton);
            this.Controls.Add(this.RoomGroupBox);
            this.Controls.Add(this.RoomDataGridView);
            this.Controls.Add(this.EmailLabel);
            this.Controls.Add(this.CompanyLabel);
            this.Controls.Add(this.NameLabel);
            this.Controls.Add(this.RoomInfoLabel);
            this.Controls.Add(this.TimeComboBox);
            this.Controls.Add(this.BookingDateTimePicker);
            this.Controls.Add(this.TimeLabel);
            this.Controls.Add(this.DateLabel);
            this.Controls.Add(this.panel1);
            this.Name = "CreateBookingForm";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "CreateBookingForm";
            this.Load += new System.EventHandler(this.CreateBookingForm_Load);
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.RoomDataGridView)).EndInit();
            this.RoomGroupBox.ResumeLayout(false);
            this.RoomGroupBox.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Label BookingLabel;
        private System.Windows.Forms.Label DateLabel;
        private System.Windows.Forms.Label TimeLabel;
        private System.Windows.Forms.DateTimePicker BookingDateTimePicker;
        private System.Windows.Forms.ComboBox TimeComboBox;
        private System.Windows.Forms.Label RoomInfoLabel;
        private System.Windows.Forms.Label NameLabel;
        private System.Windows.Forms.Label CompanyLabel;
        private System.Windows.Forms.Label EmailLabel;
        private System.Windows.Forms.DataGridView RoomDataGridView;
        private System.Windows.Forms.GroupBox RoomGroupBox;
        private System.Windows.Forms.Button ViewBookingButton;
        private System.Windows.Forms.Button CreateButton;
        private System.Windows.Forms.CheckBox Room206CheckBox;
        private System.Windows.Forms.CheckBox Room205CheckBox;
        private System.Windows.Forms.CheckBox Room204CheckBox;
        private System.Windows.Forms.CheckBox Room203CheckBox;
        private System.Windows.Forms.CheckBox Room202CheckBox;
        private System.Windows.Forms.CheckBox Room201CheckBox;
        private System.Windows.Forms.Label HelloLabel;
        private System.Windows.Forms.Button ExitButton;
        private System.Windows.Forms.Button LogoutButton;
    }
}