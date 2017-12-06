namespace Lab5_Client
{
    partial class Form1
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
            this.monthCalendar_from = new System.Windows.Forms.MonthCalendar();
            this.textBox_passport = new System.Windows.Forms.TextBox();
            this.label_passport = new System.Windows.Forms.Label();
            this.comboBox_risk = new System.Windows.Forms.ComboBox();
            this.label_risk = new System.Windows.Forms.Label();
            this.monthCalendar_to = new System.Windows.Forms.MonthCalendar();
            this.label_from = new System.Windows.Forms.Label();
            this.label_to = new System.Windows.Forms.Label();
            this.button_ok = new System.Windows.Forms.Button();
            this.label_status = new System.Windows.Forms.Label();
            this.textBox_ensure_sum = new System.Windows.Forms.TextBox();
            this.label_ensure_sum = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.textBox_cost = new System.Windows.Forms.TextBox();
            this.SuspendLayout();
            // 
            // monthCalendar_from
            // 
            this.monthCalendar_from.FirstDayOfWeek = System.Windows.Forms.Day.Monday;
            this.monthCalendar_from.Location = new System.Drawing.Point(32, 151);
            this.monthCalendar_from.MaxSelectionCount = 1;
            this.monthCalendar_from.MinDate = new System.DateTime(2017, 11, 6, 21, 52, 45, 0);
            this.monthCalendar_from.Name = "monthCalendar_from";
            this.monthCalendar_from.ShowToday = false;
            this.monthCalendar_from.ShowTodayCircle = false;
            this.monthCalendar_from.TabIndex = 0;
            // 
            // textBox_passport
            // 
            this.textBox_passport.Location = new System.Drawing.Point(32, 46);
            this.textBox_passport.Name = "textBox_passport";
            this.textBox_passport.Size = new System.Drawing.Size(100, 20);
            this.textBox_passport.TabIndex = 1;
            // 
            // label_passport
            // 
            this.label_passport.AutoSize = true;
            this.label_passport.Location = new System.Drawing.Point(32, 27);
            this.label_passport.Name = "label_passport";
            this.label_passport.Size = new System.Drawing.Size(48, 13);
            this.label_passport.TabIndex = 2;
            this.label_passport.Text = "Passport";
            // 
            // comboBox_risk
            // 
            this.comboBox_risk.FormattingEnabled = true;
            this.comboBox_risk.Items.AddRange(new object[] {
            "P1",
            "P2",
            "P3",
            "P4"});
            this.comboBox_risk.Location = new System.Drawing.Point(35, 93);
            this.comboBox_risk.Name = "comboBox_risk";
            this.comboBox_risk.Size = new System.Drawing.Size(121, 21);
            this.comboBox_risk.TabIndex = 3;
            this.comboBox_risk.Text = "P1";
            // 
            // label_risk
            // 
            this.label_risk.AutoSize = true;
            this.label_risk.Location = new System.Drawing.Point(35, 73);
            this.label_risk.Name = "label_risk";
            this.label_risk.Size = new System.Drawing.Size(58, 13);
            this.label_risk.TabIndex = 4;
            this.label_risk.Text = "Risk group";
            // 
            // monthCalendar_to
            // 
            this.monthCalendar_to.FirstDayOfWeek = System.Windows.Forms.Day.Monday;
            this.monthCalendar_to.Location = new System.Drawing.Point(314, 151);
            this.monthCalendar_to.MaxSelectionCount = 1;
            this.monthCalendar_to.MinDate = new System.DateTime(2017, 11, 6, 21, 52, 45, 0);
            this.monthCalendar_to.Name = "monthCalendar_to";
            this.monthCalendar_to.ShowToday = false;
            this.monthCalendar_to.ShowTodayCircle = false;
            this.monthCalendar_to.TabIndex = 5;
            // 
            // label_from
            // 
            this.label_from.AutoSize = true;
            this.label_from.Location = new System.Drawing.Point(38, 126);
            this.label_from.Name = "label_from";
            this.label_from.Size = new System.Drawing.Size(27, 13);
            this.label_from.TabIndex = 6;
            this.label_from.Text = "from";
            // 
            // label_to
            // 
            this.label_to.AutoSize = true;
            this.label_to.Location = new System.Drawing.Point(314, 126);
            this.label_to.Name = "label_to";
            this.label_to.Size = new System.Drawing.Size(16, 13);
            this.label_to.TabIndex = 7;
            this.label_to.Text = "to";
            // 
            // button_ok
            // 
            this.button_ok.Location = new System.Drawing.Point(453, 345);
            this.button_ok.Name = "button_ok";
            this.button_ok.Size = new System.Drawing.Size(106, 23);
            this.button_ok.TabIndex = 8;
            this.button_ok.Text = "Ok";
            this.button_ok.UseVisualStyleBackColor = true;
            this.button_ok.Click += new System.EventHandler(this.button_ok_Click);
            // 
            // label_status
            // 
            this.label_status.AutoSize = true;
            this.label_status.Location = new System.Drawing.Point(35, 350);
            this.label_status.Name = "label_status";
            this.label_status.Size = new System.Drawing.Size(0, 13);
            this.label_status.TabIndex = 9;
            // 
            // textBox_ensure_sum
            // 
            this.textBox_ensure_sum.Location = new System.Drawing.Point(226, 45);
            this.textBox_ensure_sum.Name = "textBox_ensure_sum";
            this.textBox_ensure_sum.Size = new System.Drawing.Size(100, 20);
            this.textBox_ensure_sum.TabIndex = 10;
            this.textBox_ensure_sum.Text = "1000";
            // 
            // label_ensure_sum
            // 
            this.label_ensure_sum.AutoSize = true;
            this.label_ensure_sum.Location = new System.Drawing.Point(226, 26);
            this.label_ensure_sum.Name = "label_ensure_sum";
            this.label_ensure_sum.Size = new System.Drawing.Size(62, 13);
            this.label_ensure_sum.TabIndex = 11;
            this.label_ensure_sum.Text = "Ensure sum";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(393, 51);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(63, 13);
            this.label1.TabIndex = 12;
            this.label1.Text = "Ensure cost";
            // 
            // textBox_cost
            // 
            this.textBox_cost.Enabled = false;
            this.textBox_cost.Location = new System.Drawing.Point(473, 51);
            this.textBox_cost.Name = "textBox_cost";
            this.textBox_cost.Size = new System.Drawing.Size(100, 20);
            this.textBox_cost.TabIndex = 13;
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(653, 385);
            this.Controls.Add(this.textBox_cost);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.label_ensure_sum);
            this.Controls.Add(this.textBox_ensure_sum);
            this.Controls.Add(this.label_status);
            this.Controls.Add(this.button_ok);
            this.Controls.Add(this.label_to);
            this.Controls.Add(this.label_from);
            this.Controls.Add(this.monthCalendar_to);
            this.Controls.Add(this.label_risk);
            this.Controls.Add(this.comboBox_risk);
            this.Controls.Add(this.label_passport);
            this.Controls.Add(this.textBox_passport);
            this.Controls.Add(this.monthCalendar_from);
            this.Name = "Form1";
            this.Text = "Form1";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.MonthCalendar monthCalendar_from;
        private System.Windows.Forms.TextBox textBox_passport;
        private System.Windows.Forms.Label label_passport;
        private System.Windows.Forms.ComboBox comboBox_risk;
        private System.Windows.Forms.Label label_risk;
        private System.Windows.Forms.MonthCalendar monthCalendar_to;
        private System.Windows.Forms.Label label_from;
        private System.Windows.Forms.Label label_to;
        private System.Windows.Forms.Button button_ok;
        private System.Windows.Forms.Label label_status;
        private System.Windows.Forms.TextBox textBox_ensure_sum;
        private System.Windows.Forms.Label label_ensure_sum;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox textBox_cost;
    }
}

