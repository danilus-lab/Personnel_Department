namespace Personnel_Department
{
    partial class Change_row_in_staff_list
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
            this.salary_textBox = new System.Windows.Forms.TextBox();
            this.label4 = new System.Windows.Forms.Label();
            this.save_chenges_button = new System.Windows.Forms.Button();
            this.label5 = new System.Windows.Forms.Label();
            this.sqlConnection1 = new System.Data.SqlClient.SqlConnection();
            this.save_row_command = new System.Data.SqlClient.SqlCommand();
            this.trick = new System.Windows.Forms.Label();
            this.vacant_units_textBox = new System.Windows.Forms.TextBox();
            this.label6 = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // salary_textBox
            // 
            this.salary_textBox.Location = new System.Drawing.Point(176, 176);
            this.salary_textBox.Name = "salary_textBox";
            this.salary_textBox.Size = new System.Drawing.Size(100, 20);
            this.salary_textBox.TabIndex = 3;
            this.salary_textBox.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.salary_textBox_KeyPress);
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Cooper Black", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label4.Location = new System.Drawing.Point(108, 176);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(61, 17);
            this.label4.TabIndex = 7;
            this.label4.Text = "Зарплата:";
            // 
            // save_chenges_button
            // 
            this.save_chenges_button.Location = new System.Drawing.Point(6, 230);
            this.save_chenges_button.Name = "save_chenges_button";
            this.save_chenges_button.Size = new System.Drawing.Size(286, 23);
            this.save_chenges_button.TabIndex = 8;
            this.save_chenges_button.Text = "Сохранить изменения";
            this.save_chenges_button.UseVisualStyleBackColor = true;
            this.save_chenges_button.Click += new System.EventHandler(this.save_chenges_button_Click);
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Font = new System.Drawing.Font("Microsoft Sans Serif", 20.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.label5.Location = new System.Drawing.Point(0, 54);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(318, 31);
            this.label5.TabIndex = 9;
            this.label5.Text = "Редактирование записи";
            // 
            // sqlConnection1
            // 
            this.sqlConnection1.ConnectionString = "Data Source=DESKTOP-T003JCT\\SQLEXPRESS;Initial Catalog=Otdel_kadrov;Integrated Se" +
    "curity=True";
            this.sqlConnection1.FireInfoMessageEventOnUserErrors = false;
            // 
            // save_row_command
            // 
            this.save_row_command.CommandText = "Change_row_in_staff_list";
            this.save_row_command.CommandType = System.Data.CommandType.StoredProcedure;
            this.save_row_command.Connection = this.sqlConnection1;
            this.save_row_command.Parameters.AddRange(new System.Data.SqlClient.SqlParameter[] {
            new System.Data.SqlClient.SqlParameter("@id_record", System.Data.SqlDbType.Int),
            new System.Data.SqlClient.SqlParameter("@vacant_units", System.Data.SqlDbType.Int),
            new System.Data.SqlClient.SqlParameter("@salary", System.Data.SqlDbType.Float),
            new System.Data.SqlClient.SqlParameter("@message", System.Data.SqlDbType.VarChar, 100, System.Data.ParameterDirection.Output, false, ((byte)(0)), ((byte)(0)), "", System.Data.DataRowVersion.Current, null)});
            // 
            // trick
            // 
            this.trick.AutoSize = true;
            this.trick.Location = new System.Drawing.Point(195, 96);
            this.trick.Name = "trick";
            this.trick.Size = new System.Drawing.Size(35, 13);
            this.trick.TabIndex = 10;
            this.trick.Text = "label6";
            this.trick.Visible = false;
            // 
            // vacant_units_textBox
            // 
            this.vacant_units_textBox.Location = new System.Drawing.Point(176, 141);
            this.vacant_units_textBox.Name = "vacant_units_textBox";
            this.vacant_units_textBox.Size = new System.Drawing.Size(100, 20);
            this.vacant_units_textBox.TabIndex = 11;
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Font = new System.Drawing.Font("Cooper Black", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label6.Location = new System.Drawing.Point(10, 141);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(160, 17);
            this.label6.TabIndex = 12;
            this.label6.Text = "Количество свободных мест:";
            // 
            // Change_row_in_staff_list
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.ActiveCaption;
            this.ClientSize = new System.Drawing.Size(315, 304);
            this.Controls.Add(this.label6);
            this.Controls.Add(this.vacant_units_textBox);
            this.Controls.Add(this.trick);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.save_chenges_button);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.salary_textBox);
            this.Name = "Change_row_in_staff_list";
            this.Text = "Редактирование записи";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private System.Windows.Forms.TextBox salary_textBox;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Button save_chenges_button;
        private System.Windows.Forms.Label label5;
        private System.Data.SqlClient.SqlConnection sqlConnection1;
        private System.Data.SqlClient.SqlCommand save_row_command;
        private System.Windows.Forms.Label trick;
        private System.Windows.Forms.TextBox vacant_units_textBox;
        private System.Windows.Forms.Label label6;
    }
}