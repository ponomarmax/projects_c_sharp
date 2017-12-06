namespace DataBaseProgramm
{
    partial class Form2
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
            this.groupBox_with_4_rad = new System.Windows.Forms.GroupBox();
            this.radioButton_delete_categorie = new System.Windows.Forms.RadioButton();
            this.radioButton_update_categorie = new System.Windows.Forms.RadioButton();
            this.radioButton_add_categorie = new System.Windows.Forms.RadioButton();
            this.radioButton_get_all_categories = new System.Windows.Forms.RadioButton();
            this.textBox_f2_id = new System.Windows.Forms.TextBox();
            this.textBox_f2_descripe = new System.Windows.Forms.TextBox();
            this.textBox_f2_categorie = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.button_f2_query = new System.Windows.Forms.Button();
            this.button2 = new System.Windows.Forms.Button();
            this.label4 = new System.Windows.Forms.Label();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.dgt = new System.Windows.Forms.DataGridView();
            this.textBox_message = new System.Windows.Forms.TextBox();
            this.label5 = new System.Windows.Forms.Label();
            this.groupBox_with_4_rad.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.dgt)).BeginInit();
            this.SuspendLayout();
            // 
            // groupBox_with_4_rad
            // 
            this.groupBox_with_4_rad.Controls.Add(this.radioButton_delete_categorie);
            this.groupBox_with_4_rad.Controls.Add(this.radioButton_update_categorie);
            this.groupBox_with_4_rad.Controls.Add(this.radioButton_add_categorie);
            this.groupBox_with_4_rad.Controls.Add(this.radioButton_get_all_categories);
            this.groupBox_with_4_rad.Location = new System.Drawing.Point(292, 48);
            this.groupBox_with_4_rad.Name = "groupBox_with_4_rad";
            this.groupBox_with_4_rad.Size = new System.Drawing.Size(200, 110);
            this.groupBox_with_4_rad.TabIndex = 1;
            this.groupBox_with_4_rad.TabStop = false;
            // 
            // radioButton_delete_categorie
            // 
            this.radioButton_delete_categorie.AutoSize = true;
            this.radioButton_delete_categorie.Location = new System.Drawing.Point(6, 88);
            this.radioButton_delete_categorie.Name = "radioButton_delete_categorie";
            this.radioButton_delete_categorie.Size = new System.Drawing.Size(103, 17);
            this.radioButton_delete_categorie.TabIndex = 3;
            this.radioButton_delete_categorie.TabStop = true;
            this.radioButton_delete_categorie.Text = "Delete categorie";
            this.radioButton_delete_categorie.UseVisualStyleBackColor = true;
            this.radioButton_delete_categorie.CheckedChanged += new System.EventHandler(this.radioButton_delete_categorie_CheckedChanged);
            this.radioButton_delete_categorie.Click += new System.EventHandler(this.radioButton_delete_categorie_Click);
            // 
            // radioButton_update_categorie
            // 
            this.radioButton_update_categorie.AutoSize = true;
            this.radioButton_update_categorie.Location = new System.Drawing.Point(6, 65);
            this.radioButton_update_categorie.Name = "radioButton_update_categorie";
            this.radioButton_update_categorie.Size = new System.Drawing.Size(107, 17);
            this.radioButton_update_categorie.TabIndex = 2;
            this.radioButton_update_categorie.TabStop = true;
            this.radioButton_update_categorie.Text = "Update categorie";
            this.radioButton_update_categorie.UseVisualStyleBackColor = true;
            this.radioButton_update_categorie.CheckedChanged += new System.EventHandler(this.radioButton_update_categorie_CheckedChanged);
            this.radioButton_update_categorie.Click += new System.EventHandler(this.radioButton_update_categorie_Click);
            // 
            // radioButton_add_categorie
            // 
            this.radioButton_add_categorie.AutoSize = true;
            this.radioButton_add_categorie.Location = new System.Drawing.Point(6, 42);
            this.radioButton_add_categorie.Name = "radioButton_add_categorie";
            this.radioButton_add_categorie.Size = new System.Drawing.Size(91, 17);
            this.radioButton_add_categorie.TabIndex = 1;
            this.radioButton_add_categorie.TabStop = true;
            this.radioButton_add_categorie.Text = "Add categorie";
            this.radioButton_add_categorie.UseVisualStyleBackColor = true;
            this.radioButton_add_categorie.CheckedChanged += new System.EventHandler(this.radioButton_add_categorie_CheckedChanged);
            this.radioButton_add_categorie.Click += new System.EventHandler(this.radioButton_add_categorie_Click);
            // 
            // radioButton_get_all_categories
            // 
            this.radioButton_get_all_categories.AutoSize = true;
            this.radioButton_get_all_categories.Location = new System.Drawing.Point(6, 19);
            this.radioButton_get_all_categories.Name = "radioButton_get_all_categories";
            this.radioButton_get_all_categories.Size = new System.Drawing.Size(107, 17);
            this.radioButton_get_all_categories.TabIndex = 0;
            this.radioButton_get_all_categories.TabStop = true;
            this.radioButton_get_all_categories.Text = "Get all categories";
            this.radioButton_get_all_categories.UseVisualStyleBackColor = true;
            this.radioButton_get_all_categories.Click += new System.EventHandler(this.radioButton_get_all_categories_Click);
            // 
            // textBox_f2_id
            // 
            this.textBox_f2_id.Enabled = false;
            this.textBox_f2_id.Location = new System.Drawing.Point(30, 215);
            this.textBox_f2_id.Name = "textBox_f2_id";
            this.textBox_f2_id.Size = new System.Drawing.Size(33, 20);
            this.textBox_f2_id.TabIndex = 1;
            // 
            // textBox_f2_descripe
            // 
            this.textBox_f2_descripe.Enabled = false;
            this.textBox_f2_descripe.Location = new System.Drawing.Point(254, 215);
            this.textBox_f2_descripe.Name = "textBox_f2_descripe";
            this.textBox_f2_descripe.Size = new System.Drawing.Size(189, 20);
            this.textBox_f2_descripe.TabIndex = 2;
            // 
            // textBox_f2_categorie
            // 
            this.textBox_f2_categorie.Enabled = false;
            this.textBox_f2_categorie.Location = new System.Drawing.Point(90, 215);
            this.textBox_f2_categorie.Name = "textBox_f2_categorie";
            this.textBox_f2_categorie.Size = new System.Drawing.Size(86, 20);
            this.textBox_f2_categorie.TabIndex = 3;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(27, 199);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(18, 13);
            this.label1.TabIndex = 4;
            this.label1.Text = "ID";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(87, 199);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(94, 13);
            this.label2.TabIndex = 5;
            this.label2.Text = "Name of categorie";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(251, 199);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(49, 13);
            this.label3.TabIndex = 6;
            this.label3.Text = "Descripe";
            // 
            // button_f2_query
            // 
            this.button_f2_query.Location = new System.Drawing.Point(30, 265);
            this.button_f2_query.Name = "button_f2_query";
            this.button_f2_query.Size = new System.Drawing.Size(75, 23);
            this.button_f2_query.TabIndex = 0;
            this.button_f2_query.Text = "Done query";
            this.button_f2_query.UseVisualStyleBackColor = true;
            this.button_f2_query.Click += new System.EventHandler(this.button1_Click);
            // 
            // button2
            // 
            this.button2.Location = new System.Drawing.Point(140, 265);
            this.button2.Name = "button2";
            this.button2.Size = new System.Drawing.Size(75, 23);
            this.button2.TabIndex = 8;
            this.button2.Text = "Back";
            this.button2.UseVisualStyleBackColor = true;
            this.button2.Click += new System.EventHandler(this.button2_Click);
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.BackColor = System.Drawing.SystemColors.ButtonFace;
            this.label4.Location = new System.Drawing.Point(12, 341);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(100, 13);
            this.label4.TabIndex = 10;
            this.label4.Text = "Result of last query:";
            this.label4.Click += new System.EventHandler(this.label4_Click);
            // 
            // pictureBox1
            // 
            this.pictureBox1.Location = new System.Drawing.Point(8, 12);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(258, 146);
            this.pictureBox1.TabIndex = 14;
            this.pictureBox1.TabStop = false;
            // 
            // dgt
            // 
            this.dgt.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgt.Location = new System.Drawing.Point(8, 357);
            this.dgt.Name = "dgt";
            this.dgt.Size = new System.Drawing.Size(751, 140);
            this.dgt.TabIndex = 15;
            // 
            // textBox_message
            // 
            this.textBox_message.Location = new System.Drawing.Point(8, 357);
            this.textBox_message.Multiline = true;
            this.textBox_message.Name = "textBox_message";
            this.textBox_message.Size = new System.Drawing.Size(751, 140);
            this.textBox_message.TabIndex = 16;
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.BackColor = System.Drawing.SystemColors.ButtonHighlight;
            this.label5.Location = new System.Drawing.Point(118, 341);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(55, 13);
            this.label5.TabIndex = 17;
            this.label5.Text = "Messages";
            this.label5.Click += new System.EventHandler(this.label5_Click);
            // 
            // Form2
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.AppWorkspace;
            this.ClientSize = new System.Drawing.Size(771, 499);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.textBox_message);
            this.Controls.Add(this.dgt);
            this.Controls.Add(this.pictureBox1);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.button2);
            this.Controls.Add(this.button_f2_query);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.textBox_f2_categorie);
            this.Controls.Add(this.textBox_f2_descripe);
            this.Controls.Add(this.textBox_f2_id);
            this.Controls.Add(this.groupBox_with_4_rad);
            this.MaximumSize = new System.Drawing.Size(787, 538);
            this.MinimumSize = new System.Drawing.Size(787, 538);
            this.Name = "Form2";
            this.Text = "Form2";
            this.Load += new System.EventHandler(this.Form2_Load);
            this.groupBox_with_4_rad.ResumeLayout(false);
            this.groupBox_with_4_rad.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.dgt)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.GroupBox groupBox_with_4_rad;
        private System.Windows.Forms.RadioButton radioButton_delete_categorie;
        private System.Windows.Forms.RadioButton radioButton_update_categorie;
        private System.Windows.Forms.RadioButton radioButton_add_categorie;
        private System.Windows.Forms.RadioButton radioButton_get_all_categories;
        private System.Windows.Forms.TextBox textBox_f2_id;
        private System.Windows.Forms.TextBox textBox_f2_descripe;
        private System.Windows.Forms.TextBox textBox_f2_categorie;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Button button_f2_query;
        private System.Windows.Forms.Button button2;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.PictureBox pictureBox1;
        private System.Windows.Forms.TextBox textBox_message;
        private System.Windows.Forms.DataGridView dgt;
        private System.Windows.Forms.Label label5;
    }
}