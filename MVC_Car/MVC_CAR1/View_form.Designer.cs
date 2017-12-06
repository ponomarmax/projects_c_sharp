namespace lab4_mvc
{
    partial class View_form
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
            this.label_sceplenie = new System.Windows.Forms.Label();
            this.label_tormoz = new System.Windows.Forms.Label();
            this.label_gas = new System.Windows.Forms.Label();
            this.panel1 = new System.Windows.Forms.Panel();
            this.ms2 = new System.Windows.Forms.Label();
            this.km_h = new System.Windows.Forms.Label();
            this.acceleration_label = new System.Windows.Forms.Label();
            this.speed_label = new System.Windows.Forms.Label();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.radioButton_sw6 = new System.Windows.Forms.RadioButton();
            this.radioButton_sw5 = new System.Windows.Forms.RadioButton();
            this.radioButton_sw4 = new System.Windows.Forms.RadioButton();
            this.radioButton_sw3 = new System.Windows.Forms.RadioButton();
            this.radioButton_sw1 = new System.Windows.Forms.RadioButton();
            this.radioButton_sw2 = new System.Windows.Forms.RadioButton();
            this.message_label = new System.Windows.Forms.Label();
            this.textacceleration_box = new System.Windows.Forms.TextBox();
            this.speed_box = new System.Windows.Forms.TextBox();
            this.panel1.SuspendLayout();
            this.groupBox1.SuspendLayout();
            this.SuspendLayout();
            // 
            // label_sceplenie
            // 
            this.label_sceplenie.AutoSize = true;
            this.label_sceplenie.Font = new System.Drawing.Font("Microsoft Sans Serif", 16.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.label_sceplenie.Location = new System.Drawing.Point(16, 19);
            this.label_sceplenie.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label_sceplenie.Name = "label_sceplenie";
            this.label_sceplenie.Size = new System.Drawing.Size(157, 26);
            this.label_sceplenie.TabIndex = 3;
            this.label_sceplenie.Text = "Q - сцепление";
            // 
            // label_tormoz
            // 
            this.label_tormoz.AutoSize = true;
            this.label_tormoz.Font = new System.Drawing.Font("Microsoft Sans Serif", 16.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.label_tormoz.Location = new System.Drawing.Point(16, 47);
            this.label_tormoz.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label_tormoz.Name = "label_tormoz";
            this.label_tormoz.Size = new System.Drawing.Size(125, 26);
            this.label_tormoz.TabIndex = 4;
            this.label_tormoz.Text = "W - тормоз";
            // 
            // label_gas
            // 
            this.label_gas.AutoSize = true;
            this.label_gas.Font = new System.Drawing.Font("Microsoft Sans Serif", 16.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.label_gas.Location = new System.Drawing.Point(16, 76);
            this.label_gas.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label_gas.Name = "label_gas";
            this.label_gas.Size = new System.Drawing.Size(77, 26);
            this.label_gas.TabIndex = 5;
            this.label_gas.Text = "Е - газ";
            // 
            // panel1
            // 
            this.panel1.Controls.Add(this.ms2);
            this.panel1.Controls.Add(this.km_h);
            this.panel1.Controls.Add(this.acceleration_label);
            this.panel1.Controls.Add(this.speed_label);
            this.panel1.Controls.Add(this.groupBox1);
            this.panel1.Controls.Add(this.message_label);
            this.panel1.Controls.Add(this.textacceleration_box);
            this.panel1.Controls.Add(this.speed_box);
            this.panel1.Font = new System.Drawing.Font("Microsoft Sans Serif", 16.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.panel1.Location = new System.Drawing.Point(26, 167);
            this.panel1.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(526, 258);
            this.panel1.TabIndex = 7;
            // 
            // ms2
            // 
            this.ms2.AutoSize = true;
            this.ms2.Location = new System.Drawing.Point(229, 48);
            this.ms2.Name = "ms2";
            this.ms2.Size = new System.Drawing.Size(70, 26);
            this.ms2.TabIndex = 12;
            this.ms2.Text = "m/s^2";
            // 
            // km_h
            // 
            this.km_h.AutoSize = true;
            this.km_h.Location = new System.Drawing.Point(229, 17);
            this.km_h.Name = "km_h";
            this.km_h.Size = new System.Drawing.Size(91, 26);
            this.km_h.TabIndex = 11;
            this.km_h.Text = "km/hour";
            // 
            // acceleration_label
            // 
            this.acceleration_label.AutoSize = true;
            this.acceleration_label.Location = new System.Drawing.Point(9, 45);
            this.acceleration_label.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.acceleration_label.Name = "acceleration_label";
            this.acceleration_label.Size = new System.Drawing.Size(120, 26);
            this.acceleration_label.TabIndex = 10;
            this.acceleration_label.Text = "Ускорение";
            // 
            // speed_label
            // 
            this.speed_label.AutoSize = true;
            this.speed_label.Location = new System.Drawing.Point(9, 17);
            this.speed_label.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.speed_label.Name = "speed_label";
            this.speed_label.Size = new System.Drawing.Size(108, 26);
            this.speed_label.TabIndex = 9;
            this.speed_label.Text = "Скорость";
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.radioButton_sw6);
            this.groupBox1.Controls.Add(this.radioButton_sw5);
            this.groupBox1.Controls.Add(this.radioButton_sw4);
            this.groupBox1.Controls.Add(this.radioButton_sw3);
            this.groupBox1.Controls.Add(this.radioButton_sw1);
            this.groupBox1.Controls.Add(this.radioButton_sw2);
            this.groupBox1.Enabled = false;
            this.groupBox1.Location = new System.Drawing.Point(382, 17);
            this.groupBox1.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Padding = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.groupBox1.Size = new System.Drawing.Size(69, 215);
            this.groupBox1.TabIndex = 5;
            this.groupBox1.TabStop = false;
            // 
            // radioButton_sw6
            // 
            this.radioButton_sw6.AutoSize = true;
            this.radioButton_sw6.Checked = true;
            this.radioButton_sw6.Location = new System.Drawing.Point(4, 24);
            this.radioButton_sw6.Name = "radioButton_sw6";
            this.radioButton_sw6.Size = new System.Drawing.Size(46, 30);
            this.radioButton_sw6.TabIndex = 8;
            this.radioButton_sw6.TabStop = true;
            this.radioButton_sw6.Text = "N";
            this.radioButton_sw6.UseVisualStyleBackColor = true;
            this.radioButton_sw6.CheckedChanged += new System.EventHandler(this.radioButton6_CheckedChanged);
            // 
            // radioButton_sw5
            // 
            this.radioButton_sw5.AutoSize = true;
            this.radioButton_sw5.Location = new System.Drawing.Point(4, 181);
            this.radioButton_sw5.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.radioButton_sw5.Name = "radioButton_sw5";
            this.radioButton_sw5.Size = new System.Drawing.Size(42, 30);
            this.radioButton_sw5.TabIndex = 7;
            this.radioButton_sw5.Text = "5";
            this.radioButton_sw5.UseVisualStyleBackColor = true;
            this.radioButton_sw5.CheckedChanged += new System.EventHandler(this.radioButton5_CheckedChanged);
            // 
            // radioButton_sw4
            // 
            this.radioButton_sw4.AutoSize = true;
            this.radioButton_sw4.Location = new System.Drawing.Point(4, 150);
            this.radioButton_sw4.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.radioButton_sw4.Name = "radioButton_sw4";
            this.radioButton_sw4.Size = new System.Drawing.Size(42, 30);
            this.radioButton_sw4.TabIndex = 6;
            this.radioButton_sw4.Text = "4";
            this.radioButton_sw4.UseVisualStyleBackColor = true;
            this.radioButton_sw4.CheckedChanged += new System.EventHandler(this.radioButton4_CheckedChanged);
            // 
            // radioButton_sw3
            // 
            this.radioButton_sw3.AutoSize = true;
            this.radioButton_sw3.Location = new System.Drawing.Point(4, 116);
            this.radioButton_sw3.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.radioButton_sw3.Name = "radioButton_sw3";
            this.radioButton_sw3.Size = new System.Drawing.Size(42, 30);
            this.radioButton_sw3.TabIndex = 5;
            this.radioButton_sw3.Text = "3";
            this.radioButton_sw3.UseVisualStyleBackColor = true;
            this.radioButton_sw3.CheckedChanged += new System.EventHandler(this.radioButton3_CheckedChanged);
            // 
            // radioButton_sw1
            // 
            this.radioButton_sw1.AutoSize = true;
            this.radioButton_sw1.Location = new System.Drawing.Point(4, 53);
            this.radioButton_sw1.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.radioButton_sw1.Name = "radioButton_sw1";
            this.radioButton_sw1.Size = new System.Drawing.Size(42, 30);
            this.radioButton_sw1.TabIndex = 0;
            this.radioButton_sw1.Text = "1";
            this.radioButton_sw1.UseVisualStyleBackColor = true;
            this.radioButton_sw1.CheckedChanged += new System.EventHandler(this.radioButton1_CheckedChanged);
            // 
            // radioButton_sw2
            // 
            this.radioButton_sw2.AutoSize = true;
            this.radioButton_sw2.Location = new System.Drawing.Point(4, 82);
            this.radioButton_sw2.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.radioButton_sw2.Name = "radioButton_sw2";
            this.radioButton_sw2.Size = new System.Drawing.Size(42, 30);
            this.radioButton_sw2.TabIndex = 1;
            this.radioButton_sw2.Text = "2";
            this.radioButton_sw2.UseVisualStyleBackColor = true;
            this.radioButton_sw2.CheckedChanged += new System.EventHandler(this.radioButton2_CheckedChanged);
            // 
            // message_label
            // 
            this.message_label.AutoSize = true;
            this.message_label.Location = new System.Drawing.Point(40, 137);
            this.message_label.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.message_label.Name = "message_label";
            this.message_label.Size = new System.Drawing.Size(131, 26);
            this.message_label.TabIndex = 2;
            this.message_label.Text = "Сообщение";
            // 
            // textacceleration_box
            // 
            this.textacceleration_box.Enabled = false;
            this.textacceleration_box.Location = new System.Drawing.Point(140, 48);
            this.textacceleration_box.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.textacceleration_box.Name = "textacceleration_box";
            this.textacceleration_box.Size = new System.Drawing.Size(76, 32);
            this.textacceleration_box.TabIndex = 1;
            // 
            // speed_box
            // 
            this.speed_box.Enabled = false;
            this.speed_box.Location = new System.Drawing.Point(140, 17);
            this.speed_box.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.speed_box.Name = "speed_box";
            this.speed_box.Size = new System.Drawing.Size(76, 32);
            this.speed_box.TabIndex = 0;
            this.speed_box.WordWrap = false;
            // 
            // View_form
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(589, 453);
            this.Controls.Add(this.panel1);
            this.Controls.Add(this.label_gas);
            this.Controls.Add(this.label_tormoz);
            this.Controls.Add(this.label_sceplenie);
            this.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.Name = "View_form";
            this.Text = "Form1";
            this.Load += new System.EventHandler(this.View_form_Load);
            this.KeyDown += new System.Windows.Forms.KeyEventHandler(this.View_form_KeyDown);
            this.KeyUp += new System.Windows.Forms.KeyEventHandler(this.View_form_KeyUp);
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private System.Windows.Forms.Label label_sceplenie;
        private System.Windows.Forms.Label label_tormoz;
        private System.Windows.Forms.Label label_gas;
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Label message_label;
        private System.Windows.Forms.TextBox textacceleration_box;
        private System.Windows.Forms.TextBox speed_box;
        private System.Windows.Forms.RadioButton radioButton_sw2;
        private System.Windows.Forms.RadioButton radioButton_sw1;
        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.RadioButton radioButton_sw5;
        private System.Windows.Forms.RadioButton radioButton_sw4;
        private System.Windows.Forms.RadioButton radioButton_sw3;
        private System.Windows.Forms.Label acceleration_label;
        private System.Windows.Forms.Label speed_label;
        private System.Windows.Forms.RadioButton radioButton_sw6;
        private System.Windows.Forms.Label ms2;
        private System.Windows.Forms.Label km_h;
    }
}

