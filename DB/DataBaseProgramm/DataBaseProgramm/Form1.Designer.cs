namespace DataBaseProgramm
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
            this.groupBox_4way = new System.Windows.Forms.GroupBox();
            this.delete_tra = new System.Windows.Forms.RadioButton();
            this.update_tra = new System.Windows.Forms.RadioButton();
            this.add_transports = new System.Windows.Forms.RadioButton();
            this.get_repr = new System.Windows.Forms.RadioButton();
            this.groupBox_3way = new System.Windows.Forms.GroupBox();
            this.radioButton_get_all = new System.Windows.Forms.RadioButton();
            this.by_id = new System.Windows.Forms.RadioButton();
            this.by_categorie = new System.Windows.Forms.RadioButton();
            this.textBox_id = new System.Windows.Forms.TextBox();
            this.textBox_repr = new System.Windows.Forms.TextBox();
            this.categories = new System.Windows.Forms.ComboBox();
            this.button_query = new System.Windows.Forms.Button();
            this.button2 = new System.Windows.Forms.Button();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.dgt = new System.Windows.Forms.DataGridView();
            this.label5 = new System.Windows.Forms.Label();
            this.textBox_message = new System.Windows.Forms.TextBox();
            this.groupBox_4way.SuspendLayout();
            this.groupBox_3way.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.dgt)).BeginInit();
            this.SuspendLayout();
            // 
            // groupBox_4way
            // 
            this.groupBox_4way.BackColor = System.Drawing.SystemColors.AppWorkspace;
            this.groupBox_4way.Controls.Add(this.delete_tra);
            this.groupBox_4way.Controls.Add(this.update_tra);
            this.groupBox_4way.Controls.Add(this.add_transports);
            this.groupBox_4way.Controls.Add(this.get_repr);
            this.groupBox_4way.Location = new System.Drawing.Point(276, 12);
            this.groupBox_4way.Name = "groupBox_4way";
            this.groupBox_4way.Size = new System.Drawing.Size(156, 105);
            this.groupBox_4way.TabIndex = 0;
            this.groupBox_4way.TabStop = false;
            // 
            // delete_tra
            // 
            this.delete_tra.AutoSize = true;
            this.delete_tra.Location = new System.Drawing.Point(27, 84);
            this.delete_tra.Name = "delete_tra";
            this.delete_tra.Size = new System.Drawing.Size(105, 17);
            this.delete_tra.TabIndex = 3;
            this.delete_tra.TabStop = true;
            this.delete_tra.Text = "Delete transports";
            this.delete_tra.UseVisualStyleBackColor = true;
            this.delete_tra.CheckedChanged += new System.EventHandler(this.delete_tra_CheckedChanged);
            this.delete_tra.Click += new System.EventHandler(this.delete_tra_Click);
            // 
            // update_tra
            // 
            this.update_tra.AutoSize = true;
            this.update_tra.Location = new System.Drawing.Point(27, 61);
            this.update_tra.Name = "update_tra";
            this.update_tra.Size = new System.Drawing.Size(109, 17);
            this.update_tra.TabIndex = 2;
            this.update_tra.TabStop = true;
            this.update_tra.Text = "Update transports";
            this.update_tra.UseVisualStyleBackColor = true;
            this.update_tra.CheckedChanged += new System.EventHandler(this.update_tra_CheckedChanged);
            this.update_tra.Click += new System.EventHandler(this.update_tra_Click);
            // 
            // add_transports
            // 
            this.add_transports.AutoSize = true;
            this.add_transports.Location = new System.Drawing.Point(27, 42);
            this.add_transports.Name = "add_transports";
            this.add_transports.Size = new System.Drawing.Size(93, 17);
            this.add_transports.TabIndex = 1;
            this.add_transports.TabStop = true;
            this.add_transports.Text = "Add transports";
            this.add_transports.UseVisualStyleBackColor = true;
            this.add_transports.CheckedChanged += new System.EventHandler(this.add_transports_CheckedChanged);
            this.add_transports.Click += new System.EventHandler(this.add_transports_Click);
            // 
            // get_repr
            // 
            this.get_repr.AutoSize = true;
            this.get_repr.Checked = true;
            this.get_repr.Location = new System.Drawing.Point(27, 19);
            this.get_repr.Name = "get_repr";
            this.get_repr.Size = new System.Drawing.Size(91, 17);
            this.get_repr.TabIndex = 0;
            this.get_repr.TabStop = true;
            this.get_repr.Text = "Get transports";
            this.get_repr.UseVisualStyleBackColor = true;
            this.get_repr.CheckedChanged += new System.EventHandler(this.delete_mark_from_get);
            this.get_repr.Click += new System.EventHandler(this.get_repr_Click);
            // 
            // groupBox_3way
            // 
            this.groupBox_3way.Controls.Add(this.radioButton_get_all);
            this.groupBox_3way.Controls.Add(this.by_id);
            this.groupBox_3way.Controls.Add(this.by_categorie);
            this.groupBox_3way.Location = new System.Drawing.Point(438, 12);
            this.groupBox_3way.Name = "groupBox_3way";
            this.groupBox_3way.Size = new System.Drawing.Size(225, 39);
            this.groupBox_3way.TabIndex = 1;
            this.groupBox_3way.TabStop = false;
            // 
            // radioButton_get_all
            // 
            this.radioButton_get_all.AutoSize = true;
            this.radioButton_get_all.Checked = true;
            this.radioButton_get_all.Location = new System.Drawing.Point(160, 4);
            this.radioButton_get_all.Name = "radioButton_get_all";
            this.radioButton_get_all.Size = new System.Drawing.Size(53, 17);
            this.radioButton_get_all.TabIndex = 2;
            this.radioButton_get_all.TabStop = true;
            this.radioButton_get_all.Text = "get all";
            this.radioButton_get_all.UseVisualStyleBackColor = true;
            this.radioButton_get_all.CheckedChanged += new System.EventHandler(this.radioButton_get_all_CheckedChanged);
            this.radioButton_get_all.Click += new System.EventHandler(this.radioButton_get_all_Click);
            // 
            // by_id
            // 
            this.by_id.Location = new System.Drawing.Point(95, 0);
            this.by_id.Name = "by_id";
            this.by_id.Size = new System.Drawing.Size(59, 24);
            this.by_id.TabIndex = 1;
            this.by_id.TabStop = true;
            this.by_id.Text = "by ID";
            this.by_id.UseVisualStyleBackColor = true;
            this.by_id.CheckedChanged += new System.EventHandler(this.by_id_CheckedChanged);
            this.by_id.Click += new System.EventHandler(this.by_id_Click);
            // 
            // by_categorie
            // 
            this.by_categorie.AutoSize = true;
            this.by_categorie.Location = new System.Drawing.Point(6, 4);
            this.by_categorie.Name = "by_categorie";
            this.by_categorie.Size = new System.Drawing.Size(83, 17);
            this.by_categorie.TabIndex = 0;
            this.by_categorie.TabStop = true;
            this.by_categorie.Text = "by categorie";
            this.by_categorie.UseVisualStyleBackColor = true;
            this.by_categorie.CheckedChanged += new System.EventHandler(this.delete_mark_from_repre);
            this.by_categorie.Click += new System.EventHandler(this.by_categorie_CheckedChanged);
            // 
            // textBox_id
            // 
            this.textBox_id.Enabled = false;
            this.textBox_id.Location = new System.Drawing.Point(26, 197);
            this.textBox_id.Name = "textBox_id";
            this.textBox_id.Size = new System.Drawing.Size(31, 20);
            this.textBox_id.TabIndex = 2;
            // 
            // textBox_repr
            // 
            this.textBox_repr.Enabled = false;
            this.textBox_repr.Location = new System.Drawing.Point(114, 196);
            this.textBox_repr.Name = "textBox_repr";
            this.textBox_repr.Size = new System.Drawing.Size(216, 20);
            this.textBox_repr.TabIndex = 3;
            // 
            // categories
            // 
            this.categories.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.categories.Enabled = false;
            this.categories.FormattingEnabled = true;
            this.categories.Location = new System.Drawing.Point(444, 196);
            this.categories.Name = "categories";
            this.categories.Size = new System.Drawing.Size(121, 21);
            this.categories.TabIndex = 4;
            // 
            // button_query
            // 
            this.button_query.Location = new System.Drawing.Point(26, 242);
            this.button_query.Name = "button_query";
            this.button_query.Size = new System.Drawing.Size(75, 23);
            this.button_query.TabIndex = 0;
            this.button_query.Text = "Done query";
            this.button_query.UseVisualStyleBackColor = true;
            this.button_query.Click += new System.EventHandler(this.button1_Click);
            // 
            // button2
            // 
            this.button2.Location = new System.Drawing.Point(149, 242);
            this.button2.Name = "button2";
            this.button2.Size = new System.Drawing.Size(98, 23);
            this.button2.TabIndex = 6;
            this.button2.Text = "Add categorie";
            this.button2.UseVisualStyleBackColor = true;
            this.button2.Click += new System.EventHandler(this.button2_Click);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.BackColor = System.Drawing.SystemColors.ButtonHighlight;
            this.label1.Location = new System.Drawing.Point(12, 302);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(97, 13);
            this.label1.TabIndex = 7;
            this.label1.Text = "Result of last query";
            this.label1.Click += new System.EventHandler(this.label1_Click);
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(26, 181);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(18, 13);
            this.label2.TabIndex = 9;
            this.label2.Text = "ID";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(111, 180);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(123, 13);
            this.label3.TabIndex = 10;
            this.label3.Text = "representative of vehicle";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(441, 181);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(105, 13);
            this.label4.TabIndex = 11;
            this.label4.Text = "categories of vehicle";
            // 
            // pictureBox1
            // 
            this.pictureBox1.Location = new System.Drawing.Point(12, 12);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(258, 146);
            this.pictureBox1.TabIndex = 13;
            this.pictureBox1.TabStop = false;
            // 
            // dgt
            // 
            this.dgt.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgt.Location = new System.Drawing.Point(12, 318);
            this.dgt.Name = "dgt";
            this.dgt.Size = new System.Drawing.Size(651, 194);
            this.dgt.TabIndex = 14;
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.BackColor = System.Drawing.SystemColors.ButtonHighlight;
            this.label5.Location = new System.Drawing.Point(111, 302);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(55, 13);
            this.label5.TabIndex = 15;
            this.label5.Text = "Messages";
            this.label5.Click += new System.EventHandler(this.label5_Click);
            // 
            // textBox_message
            // 
            this.textBox_message.Location = new System.Drawing.Point(12, 318);
            this.textBox_message.Multiline = true;
            this.textBox_message.Name = "textBox_message";
            this.textBox_message.Size = new System.Drawing.Size(651, 194);
            this.textBox_message.TabIndex = 16;
            this.textBox_message.Visible = false;
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.AppWorkspace;
            this.ClientSize = new System.Drawing.Size(669, 524);
            this.Controls.Add(this.textBox_message);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.dgt);
            this.Controls.Add(this.pictureBox1);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.button2);
            this.Controls.Add(this.button_query);
            this.Controls.Add(this.categories);
            this.Controls.Add(this.textBox_repr);
            this.Controls.Add(this.textBox_id);
            this.Controls.Add(this.groupBox_3way);
            this.Controls.Add(this.groupBox_4way);
            this.MaximumSize = new System.Drawing.Size(685, 563);
            this.MinimumSize = new System.Drawing.Size(685, 563);
            this.Name = "Form1";
            this.Text = "Form1";
            this.Load += new System.EventHandler(this.Form1_Load);
            this.groupBox_4way.ResumeLayout(false);
            this.groupBox_4way.PerformLayout();
            this.groupBox_3way.ResumeLayout(false);
            this.groupBox_3way.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.dgt)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.GroupBox groupBox_4way;
        private System.Windows.Forms.RadioButton delete_tra;
        private System.Windows.Forms.RadioButton update_tra;
        private System.Windows.Forms.RadioButton add_transports;
        private System.Windows.Forms.RadioButton get_repr;
        private System.Windows.Forms.GroupBox groupBox_3way;
        private System.Windows.Forms.RadioButton by_id;
        private System.Windows.Forms.RadioButton by_categorie;
        private System.Windows.Forms.TextBox textBox_id;
        private System.Windows.Forms.TextBox textBox_repr;
        private System.Windows.Forms.ComboBox categories;
        private System.Windows.Forms.Button button_query;
        private System.Windows.Forms.Button button2;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.RadioButton radioButton_get_all;
        private System.Windows.Forms.PictureBox pictureBox1;
        private System.Windows.Forms.DataGridView dgt;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.TextBox textBox_message;
    }
}

