namespace Personnel_Department
{
    partial class Add_row_in_staff_list
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
            this.label5 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.salary_textBox = new System.Windows.Forms.TextBox();
            this.count_units_textBox = new System.Windows.Forms.TextBox();
            this.post_name_textBox = new System.Windows.Forms.TextBox();
            this.num_dep_textBox = new System.Windows.Forms.TextBox();
            this.add_button = new System.Windows.Forms.Button();
            this.sqlConnection1 = new System.Data.SqlClient.SqlConnection();
            this.add_Command = new System.Data.SqlClient.SqlCommand();
            this.SuspendLayout();
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Font = new System.Drawing.Font("Microsoft Sans Serif", 20.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.label5.Location = new System.Drawing.Point(24, 54);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(264, 31);
            this.label5.TabIndex = 10;
            this.label5.Text = "Добавление записи";
            this.label5.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Cooper Black", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label4.Location = new System.Drawing.Point(90, 294);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(61, 17);
            this.label4.TabIndex = 18;
            this.label4.Text = "Зарплата:";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Cooper Black", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.Location = new System.Drawing.Point(9, 240);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(145, 17);
            this.label3.TabIndex = 17;
            this.label3.Text = "Количество рабочих мест:";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Cooper Black", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.Location = new System.Drawing.Point(80, 192);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(71, 17);
            this.label2.TabIndex = 16;
            this.label2.Text = "Должность:";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Cooper Black", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(66, 142);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(86, 17);
            this.label1.TabIndex = 15;
            this.label1.Text = "Номер отдела:";
            // 
            // salary_textBox
            // 
            this.salary_textBox.Location = new System.Drawing.Point(158, 294);
            this.salary_textBox.Name = "salary_textBox";
            this.salary_textBox.Size = new System.Drawing.Size(100, 20);
            this.salary_textBox.TabIndex = 14;
            this.salary_textBox.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.salary_textBox_KeyPress);
            // 
            // count_units_textBox
            // 
            this.count_units_textBox.Location = new System.Drawing.Point(158, 240);
            this.count_units_textBox.Name = "count_units_textBox";
            this.count_units_textBox.Size = new System.Drawing.Size(100, 20);
            this.count_units_textBox.TabIndex = 13;
            this.count_units_textBox.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.count_units_textBox_KeyPress);
            // 
            // post_name_textBox
            // 
            this.post_name_textBox.Location = new System.Drawing.Point(158, 192);
            this.post_name_textBox.Name = "post_name_textBox";
            this.post_name_textBox.Size = new System.Drawing.Size(100, 20);
            this.post_name_textBox.TabIndex = 12;
            this.post_name_textBox.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.post_name_textBox_KeyPress);
            // 
            // num_dep_textBox
            // 
            this.num_dep_textBox.Location = new System.Drawing.Point(158, 142);
            this.num_dep_textBox.Name = "num_dep_textBox";
            this.num_dep_textBox.Size = new System.Drawing.Size(100, 20);
            this.num_dep_textBox.TabIndex = 11;
            this.num_dep_textBox.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.num_dep_textBox_KeyPress);
            // 
            // add_button
            // 
            this.add_button.Location = new System.Drawing.Point(12, 334);
            this.add_button.Name = "add_button";
            this.add_button.Size = new System.Drawing.Size(286, 23);
            this.add_button.TabIndex = 19;
            this.add_button.Text = "Добавить запись";
            this.add_button.UseVisualStyleBackColor = true;
            this.add_button.Click += new System.EventHandler(this.add_button_Click);
            // 
            // sqlConnection1
            // 
            this.sqlConnection1.ConnectionString = "Data Source=DESKTOP-T003JCT\\SQLEXPRESS;Initial Catalog=Otdel_kadrov;Integrated Se" +
    "curity=True";
            this.sqlConnection1.FireInfoMessageEventOnUserErrors = false;
            // 
            // add_Command
            // 
            this.add_Command.CommandText = "Add_new_row_in_staff_list";
            this.add_Command.CommandType = System.Data.CommandType.StoredProcedure;
            this.add_Command.Connection = this.sqlConnection1;
            this.add_Command.Parameters.AddRange(new System.Data.SqlClient.SqlParameter[] {
            new System.Data.SqlClient.SqlParameter("@num_dep", System.Data.SqlDbType.Int),
            new System.Data.SqlClient.SqlParameter("@post_name", System.Data.SqlDbType.VarChar, 50),
            new System.Data.SqlClient.SqlParameter("@count_units", System.Data.SqlDbType.Int),
            new System.Data.SqlClient.SqlParameter("@salary", System.Data.SqlDbType.Float),
            new System.Data.SqlClient.SqlParameter("@message", System.Data.SqlDbType.VarChar, 100, System.Data.ParameterDirection.Output, false, ((byte)(0)), ((byte)(0)), "", System.Data.DataRowVersion.Current, null)});
            // 
            // Add_row_in_staff_list
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.ActiveCaption;
            this.ClientSize = new System.Drawing.Size(315, 399);
            this.Controls.Add(this.add_button);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.salary_textBox);
            this.Controls.Add(this.count_units_textBox);
            this.Controls.Add(this.post_name_textBox);
            this.Controls.Add(this.num_dep_textBox);
            this.Controls.Add(this.label5);
            this.Name = "Add_row_in_staff_list";
            this.Text = "Добавление записи";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox salary_textBox;
        private System.Windows.Forms.TextBox count_units_textBox;
        private System.Windows.Forms.TextBox post_name_textBox;
        private System.Windows.Forms.TextBox num_dep_textBox;
        private System.Windows.Forms.Button add_button;
        private System.Data.SqlClient.SqlConnection sqlConnection1;
        private System.Data.SqlClient.SqlCommand add_Command;
    }
}