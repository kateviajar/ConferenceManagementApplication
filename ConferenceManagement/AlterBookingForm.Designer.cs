
namespace ConferenceManagement
{
    partial class AlterBookingForm
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
            this.BookingInfoDataGridView = new System.Windows.Forms.DataGridView();
            this.BookingInfoLabel = new System.Windows.Forms.Label();
            this.SearchGroupBox = new System.Windows.Forms.GroupBox();
            this.ResetButton = new System.Windows.Forms.Button();
            this.SearchButton = new System.Windows.Forms.Button();
            this.EmailSearchTextBox = new System.Windows.Forms.TextBox();
            this.NameSearchTextBox = new System.Windows.Forms.TextBox();
            this.BookingIdLabel = new System.Windows.Forms.Label();
            this.BookingIdTextBox = new System.Windows.Forms.TextBox();
            this.NameLabel = new System.Windows.Forms.Label();
            this.NameTextBox = new System.Windows.Forms.TextBox();
            this.CompanyTextBox = new System.Windows.Forms.TextBox();
            this.CompanyLabel = new System.Windows.Forms.Label();
            this.EmailTextBox = new System.Windows.Forms.TextBox();
            this.EmailLabel = new System.Windows.Forms.Label();
            this.ChangeGroupBox = new System.Windows.Forms.GroupBox();
            this.BookingIDEditLabel = new System.Windows.Forms.Label();
            this.UpdateButton = new System.Windows.Forms.Button();
            this.CancelBookingGroupBox = new System.Windows.Forms.GroupBox();
            this.VerifyCheckBox = new System.Windows.Forms.CheckBox();
            this.CancelButton = new System.Windows.Forms.Button();
            this.ExitButton = new System.Windows.Forms.Button();
            this.CreateButton = new System.Windows.Forms.Button();
            this.LogoutButton = new System.Windows.Forms.Button();
            this.panel1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.BookingInfoDataGridView)).BeginInit();
            this.SearchGroupBox.SuspendLayout();
            this.ChangeGroupBox.SuspendLayout();
            this.CancelBookingGroupBox.SuspendLayout();
            this.SuspendLayout();
            // 
            // panel1
            // 
            this.panel1.BackColor = System.Drawing.SystemColors.GradientActiveCaption;
            this.panel1.Controls.Add(this.BookingLabel);
            this.panel1.Dock = System.Windows.Forms.DockStyle.Top;
            this.panel1.Location = new System.Drawing.Point(0, 0);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(887, 108);
            this.panel1.TabIndex = 0;
            // 
            // BookingLabel
            // 
            this.BookingLabel.AutoSize = true;
            this.BookingLabel.Font = new System.Drawing.Font("Century Gothic", 21.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.BookingLabel.Location = new System.Drawing.Point(233, 29);
            this.BookingLabel.Name = "BookingLabel";
            this.BookingLabel.Size = new System.Drawing.Size(450, 36);
            this.BookingLabel.TabIndex = 0;
            this.BookingLabel.Text = "Create, Edit or Cancel Booking";
            // 
            // BookingInfoDataGridView
            // 
            this.BookingInfoDataGridView.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.BookingInfoDataGridView.Location = new System.Drawing.Point(61, 366);
            this.BookingInfoDataGridView.Name = "BookingInfoDataGridView";
            this.BookingInfoDataGridView.RowHeadersWidth = 82;
            this.BookingInfoDataGridView.RowTemplate.Height = 24;
            this.BookingInfoDataGridView.Size = new System.Drawing.Size(784, 185);
            this.BookingInfoDataGridView.TabIndex = 5;
            this.BookingInfoDataGridView.CellClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.BookingInfoDataGridView_CellClick);
            // 
            // BookingInfoLabel
            // 
            this.BookingInfoLabel.Font = new System.Drawing.Font("Century Gothic", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.BookingInfoLabel.Location = new System.Drawing.Point(358, 330);
            this.BookingInfoLabel.Name = "BookingInfoLabel";
            this.BookingInfoLabel.Size = new System.Drawing.Size(171, 33);
            this.BookingInfoLabel.TabIndex = 4;
            this.BookingInfoLabel.Text = "Booking Information";
            this.BookingInfoLabel.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            // 
            // SearchGroupBox
            // 
            this.SearchGroupBox.Controls.Add(this.ResetButton);
            this.SearchGroupBox.Controls.Add(this.SearchButton);
            this.SearchGroupBox.Controls.Add(this.EmailSearchTextBox);
            this.SearchGroupBox.Controls.Add(this.NameSearchTextBox);
            this.SearchGroupBox.Font = new System.Drawing.Font("Century Gothic", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.SearchGroupBox.Location = new System.Drawing.Point(61, 115);
            this.SearchGroupBox.Name = "SearchGroupBox";
            this.SearchGroupBox.Size = new System.Drawing.Size(200, 212);
            this.SearchGroupBox.TabIndex = 1;
            this.SearchGroupBox.TabStop = false;
            this.SearchGroupBox.Text = "Search Your Booking";
            // 
            // ResetButton
            // 
            this.ResetButton.Location = new System.Drawing.Point(104, 172);
            this.ResetButton.Name = "ResetButton";
            this.ResetButton.Size = new System.Drawing.Size(75, 34);
            this.ResetButton.TabIndex = 3;
            this.ResetButton.Text = "&Reset";
            this.ResetButton.UseVisualStyleBackColor = true;
            this.ResetButton.Click += new System.EventHandler(this.ResetButton_Click);
            // 
            // SearchButton
            // 
            this.SearchButton.Location = new System.Drawing.Point(20, 172);
            this.SearchButton.Name = "SearchButton";
            this.SearchButton.Size = new System.Drawing.Size(75, 34);
            this.SearchButton.TabIndex = 2;
            this.SearchButton.Text = "S&earch";
            this.SearchButton.UseVisualStyleBackColor = true;
            this.SearchButton.Click += new System.EventHandler(this.SearchButton_Click);
            // 
            // EmailSearchTextBox
            // 
            this.EmailSearchTextBox.Location = new System.Drawing.Point(20, 92);
            this.EmailSearchTextBox.Name = "EmailSearchTextBox";
            this.EmailSearchTextBox.Size = new System.Drawing.Size(159, 27);
            this.EmailSearchTextBox.TabIndex = 1;
            this.EmailSearchTextBox.Text = "By Email";
            this.EmailSearchTextBox.Enter += new System.EventHandler(this.EmailSearchTextBox_Enter);
            this.EmailSearchTextBox.Leave += new System.EventHandler(this.EmailSearchTextBox_Leave);
            // 
            // NameSearchTextBox
            // 
            this.NameSearchTextBox.Location = new System.Drawing.Point(20, 39);
            this.NameSearchTextBox.Name = "NameSearchTextBox";
            this.NameSearchTextBox.Size = new System.Drawing.Size(159, 27);
            this.NameSearchTextBox.TabIndex = 0;
            this.NameSearchTextBox.Text = "By Name";
            this.NameSearchTextBox.Enter += new System.EventHandler(this.NameSearchTextBox_Enter);
            this.NameSearchTextBox.Leave += new System.EventHandler(this.NameSearchTextBox_Leave);
            // 
            // BookingIdLabel
            // 
            this.BookingIdLabel.AutoSize = true;
            this.BookingIdLabel.Font = new System.Drawing.Font("Century Gothic", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.BookingIdLabel.Location = new System.Drawing.Point(18, 46);
            this.BookingIdLabel.Name = "BookingIdLabel";
            this.BookingIdLabel.Size = new System.Drawing.Size(92, 21);
            this.BookingIdLabel.TabIndex = 0;
            this.BookingIdLabel.Text = "Booking ID";
            // 
            // BookingIdTextBox
            // 
            this.BookingIdTextBox.Font = new System.Drawing.Font("Century Gothic", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.BookingIdTextBox.Location = new System.Drawing.Point(126, 42);
            this.BookingIdTextBox.Name = "BookingIdTextBox";
            this.BookingIdTextBox.Size = new System.Drawing.Size(100, 27);
            this.BookingIdTextBox.TabIndex = 1;
            // 
            // NameLabel
            // 
            this.NameLabel.AutoSize = true;
            this.NameLabel.Font = new System.Drawing.Font("Century Gothic", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.NameLabel.Location = new System.Drawing.Point(17, 42);
            this.NameLabel.Name = "NameLabel";
            this.NameLabel.Size = new System.Drawing.Size(58, 21);
            this.NameLabel.TabIndex = 0;
            this.NameLabel.Text = "Name";
            // 
            // NameTextBox
            // 
            this.NameTextBox.Font = new System.Drawing.Font("Century Gothic", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.NameTextBox.Location = new System.Drawing.Point(111, 39);
            this.NameTextBox.Name = "NameTextBox";
            this.NameTextBox.Size = new System.Drawing.Size(141, 27);
            this.NameTextBox.TabIndex = 1;
            // 
            // CompanyTextBox
            // 
            this.CompanyTextBox.Font = new System.Drawing.Font("Century Gothic", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.CompanyTextBox.Location = new System.Drawing.Point(111, 82);
            this.CompanyTextBox.Name = "CompanyTextBox";
            this.CompanyTextBox.Size = new System.Drawing.Size(141, 27);
            this.CompanyTextBox.TabIndex = 3;
            // 
            // CompanyLabel
            // 
            this.CompanyLabel.AutoSize = true;
            this.CompanyLabel.Font = new System.Drawing.Font("Century Gothic", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.CompanyLabel.Location = new System.Drawing.Point(17, 89);
            this.CompanyLabel.Name = "CompanyLabel";
            this.CompanyLabel.Size = new System.Drawing.Size(88, 21);
            this.CompanyLabel.TabIndex = 2;
            this.CompanyLabel.Text = "Company";
            // 
            // EmailTextBox
            // 
            this.EmailTextBox.Font = new System.Drawing.Font("Century Gothic", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.EmailTextBox.Location = new System.Drawing.Point(111, 127);
            this.EmailTextBox.Name = "EmailTextBox";
            this.EmailTextBox.Size = new System.Drawing.Size(141, 27);
            this.EmailTextBox.TabIndex = 5;
            // 
            // EmailLabel
            // 
            this.EmailLabel.AutoSize = true;
            this.EmailLabel.Font = new System.Drawing.Font("Century Gothic", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.EmailLabel.Location = new System.Drawing.Point(17, 130);
            this.EmailLabel.Name = "EmailLabel";
            this.EmailLabel.Size = new System.Drawing.Size(51, 21);
            this.EmailLabel.TabIndex = 4;
            this.EmailLabel.Text = "Email";
            // 
            // ChangeGroupBox
            // 
            this.ChangeGroupBox.Controls.Add(this.BookingIDEditLabel);
            this.ChangeGroupBox.Controls.Add(this.UpdateButton);
            this.ChangeGroupBox.Controls.Add(this.NameLabel);
            this.ChangeGroupBox.Controls.Add(this.EmailTextBox);
            this.ChangeGroupBox.Controls.Add(this.NameTextBox);
            this.ChangeGroupBox.Controls.Add(this.EmailLabel);
            this.ChangeGroupBox.Controls.Add(this.CompanyLabel);
            this.ChangeGroupBox.Controls.Add(this.CompanyTextBox);
            this.ChangeGroupBox.Font = new System.Drawing.Font("Century Gothic", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.ChangeGroupBox.Location = new System.Drawing.Point(302, 115);
            this.ChangeGroupBox.Name = "ChangeGroupBox";
            this.ChangeGroupBox.Size = new System.Drawing.Size(271, 212);
            this.ChangeGroupBox.TabIndex = 2;
            this.ChangeGroupBox.TabStop = false;
            this.ChangeGroupBox.Text = "Edit Your Booking Info";
            // 
            // BookingIDEditLabel
            // 
            this.BookingIDEditLabel.AutoSize = true;
            this.BookingIDEditLabel.Font = new System.Drawing.Font("Century Gothic", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.BookingIDEditLabel.Location = new System.Drawing.Point(195, 17);
            this.BookingIDEditLabel.Name = "BookingIDEditLabel";
            this.BookingIDEditLabel.Size = new System.Drawing.Size(64, 15);
            this.BookingIDEditLabel.TabIndex = 7;
            this.BookingIDEditLabel.Text = "Booking ID";
            this.BookingIDEditLabel.Visible = false;
            // 
            // UpdateButton
            // 
            this.UpdateButton.Location = new System.Drawing.Point(85, 172);
            this.UpdateButton.Name = "UpdateButton";
            this.UpdateButton.Size = new System.Drawing.Size(81, 34);
            this.UpdateButton.TabIndex = 6;
            this.UpdateButton.Text = "&Update";
            this.UpdateButton.UseVisualStyleBackColor = true;
            this.UpdateButton.Click += new System.EventHandler(this.UpdateButton_Click);
            // 
            // CancelBookingGroupBox
            // 
            this.CancelBookingGroupBox.Controls.Add(this.VerifyCheckBox);
            this.CancelBookingGroupBox.Controls.Add(this.CancelButton);
            this.CancelBookingGroupBox.Controls.Add(this.BookingIdLabel);
            this.CancelBookingGroupBox.Controls.Add(this.BookingIdTextBox);
            this.CancelBookingGroupBox.Font = new System.Drawing.Font("Century Gothic", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.CancelBookingGroupBox.Location = new System.Drawing.Point(606, 115);
            this.CancelBookingGroupBox.Name = "CancelBookingGroupBox";
            this.CancelBookingGroupBox.Size = new System.Drawing.Size(239, 212);
            this.CancelBookingGroupBox.TabIndex = 3;
            this.CancelBookingGroupBox.TabStop = false;
            this.CancelBookingGroupBox.Text = "Cancel Your Booking";
            // 
            // VerifyCheckBox
            // 
            this.VerifyCheckBox.AutoSize = true;
            this.VerifyCheckBox.Location = new System.Drawing.Point(22, 141);
            this.VerifyCheckBox.Name = "VerifyCheckBox";
            this.VerifyCheckBox.Size = new System.Drawing.Size(204, 25);
            this.VerifyCheckBox.TabIndex = 3;
            this.VerifyCheckBox.Text = "Verify the cancellation";
            this.VerifyCheckBox.UseVisualStyleBackColor = true;
            // 
            // CancelButton
            // 
            this.CancelButton.Location = new System.Drawing.Point(76, 172);
            this.CancelButton.Name = "CancelButton";
            this.CancelButton.Size = new System.Drawing.Size(97, 34);
            this.CancelButton.TabIndex = 4;
            this.CancelButton.Text = "D&elete";
            this.CancelButton.UseVisualStyleBackColor = true;
            this.CancelButton.Click += new System.EventHandler(this.CancelButton_Click);
            // 
            // ExitButton
            // 
            this.ExitButton.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F);
            this.ExitButton.Location = new System.Drawing.Point(678, 559);
            this.ExitButton.Name = "ExitButton";
            this.ExitButton.Size = new System.Drawing.Size(167, 37);
            this.ExitButton.TabIndex = 8;
            this.ExitButton.Text = "&Exit";
            this.ExitButton.UseVisualStyleBackColor = true;
            this.ExitButton.Click += new System.EventHandler(this.ExitButton_Click);
            // 
            // CreateButton
            // 
            this.CreateButton.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F);
            this.CreateButton.Location = new System.Drawing.Point(61, 557);
            this.CreateButton.Name = "CreateButton";
            this.CreateButton.Size = new System.Drawing.Size(167, 35);
            this.CreateButton.TabIndex = 6;
            this.CreateButton.Text = "Create &Booking";
            this.CreateButton.UseVisualStyleBackColor = true;
            this.CreateButton.Click += new System.EventHandler(this.CreateButton_Click);
            // 
            // LogoutButton
            // 
            this.LogoutButton.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F);
            this.LogoutButton.Location = new System.Drawing.Point(362, 556);
            this.LogoutButton.Name = "LogoutButton";
            this.LogoutButton.Size = new System.Drawing.Size(167, 37);
            this.LogoutButton.TabIndex = 7;
            this.LogoutButton.Text = "&Logout";
            this.LogoutButton.UseVisualStyleBackColor = true;
            this.LogoutButton.Click += new System.EventHandler(this.LogoutButton_Click);
            // 
            // AlterBookingForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(887, 606);
            this.Controls.Add(this.LogoutButton);
            this.Controls.Add(this.CreateButton);
            this.Controls.Add(this.ExitButton);
            this.Controls.Add(this.CancelBookingGroupBox);
            this.Controls.Add(this.ChangeGroupBox);
            this.Controls.Add(this.SearchGroupBox);
            this.Controls.Add(this.BookingInfoDataGridView);
            this.Controls.Add(this.BookingInfoLabel);
            this.Controls.Add(this.panel1);
            this.Name = "AlterBookingForm";
            this.Text = "AlterBookingForm";
            this.Load += new System.EventHandler(this.AlterBookingForm_Load);
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.BookingInfoDataGridView)).EndInit();
            this.SearchGroupBox.ResumeLayout(false);
            this.SearchGroupBox.PerformLayout();
            this.ChangeGroupBox.ResumeLayout(false);
            this.ChangeGroupBox.PerformLayout();
            this.CancelBookingGroupBox.ResumeLayout(false);
            this.CancelBookingGroupBox.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Label BookingLabel;
        private System.Windows.Forms.DataGridView BookingInfoDataGridView;
        private System.Windows.Forms.Label BookingInfoLabel;
        private System.Windows.Forms.GroupBox SearchGroupBox;
        private System.Windows.Forms.TextBox EmailSearchTextBox;
        private System.Windows.Forms.TextBox NameSearchTextBox;
        private System.Windows.Forms.Button ResetButton;
        private System.Windows.Forms.Button SearchButton;
        private System.Windows.Forms.Label BookingIdLabel;
        private System.Windows.Forms.TextBox BookingIdTextBox;
        private System.Windows.Forms.Label NameLabel;
        private System.Windows.Forms.TextBox NameTextBox;
        private System.Windows.Forms.TextBox CompanyTextBox;
        private System.Windows.Forms.Label CompanyLabel;
        private System.Windows.Forms.TextBox EmailTextBox;
        private System.Windows.Forms.Label EmailLabel;
        private System.Windows.Forms.GroupBox ChangeGroupBox;
        private System.Windows.Forms.Button UpdateButton;
        private System.Windows.Forms.GroupBox CancelBookingGroupBox;
        private System.Windows.Forms.Button CancelButton;
        private System.Windows.Forms.CheckBox VerifyCheckBox;
        private System.Windows.Forms.Label BookingIDEditLabel;
        private System.Windows.Forms.Button ExitButton;
        private System.Windows.Forms.Button CreateButton;
        private System.Windows.Forms.Button LogoutButton;
    }
}