﻿namespace Personnel_Department
{
    partial class Edit_worker
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
            this.fio_textBox = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.dep_textBox = new System.Windows.Forms.TextBox();
            this.label2 = new System.Windows.Forms.Label();
            this.post_name_textBox = new System.Windows.Forms.TextBox();
            this.allowance_textBox = new System.Windows.Forms.TextBox();
            this.label3 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.save_changes_button = new System.Windows.Forms.Button();
            this.trick = new System.Windows.Forms.Label();
            this.sqlConnection1 = new System.Data.SqlClient.SqlConnection();
            this.change_worker_Command = new System.Data.SqlClient.SqlCommand();
            this.SuspendLayout();
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Font = new System.Drawing.Font("Microsoft Sans Serif", 20.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.label5.Location = new System.Drawing.Point(0, 54);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(318, 31);
            this.label5.TabIndex = 10;
            this.label5.Text = "Редактирование записи";
            // 
            // fio_textBox
            // 
            this.fio_textBox.Location = new System.Drawing.Point(126, 140);
            this.fio_textBox.Name = "fio_textBox";
            this.fio_textBox.Size = new System.Drawing.Size(135, 20);
            this.fio_textBox.TabIndex = 11;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(86, 143);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(37, 13);
            this.label1.TabIndex = 12;
            this.label1.Text = "ФИО:";
            // 
            // dep_textBox
            // 
            this.dep_textBox.Location = new System.Drawing.Point(126, 186);
            this.dep_textBox.Name = "dep_textBox";
            this.dep_textBox.Size = new System.Drawing.Size(135, 20);
            this.dep_textBox.TabIndex = 13;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(41, 189);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(82, 13);
            this.label2.TabIndex = 14;
            this.label2.Text = "Номер отдела:";
            // 
            // post_name_textBox
            // 
            this.post_name_textBox.Location = new System.Drawing.Point(126, 233);
            this.post_name_textBox.Name = "post_name_textBox";
            this.post_name_textBox.Size = new System.Drawing.Size(135, 20);
            this.post_name_textBox.TabIndex = 15;
            // 
            // allowance_textBox
            // 
            this.allowance_textBox.Location = new System.Drawing.Point(126, 278);
            this.allowance_textBox.Name = "allowance_textBox";
            this.allowance_textBox.Size = new System.Drawing.Size(135, 20);
            this.allowance_textBox.TabIndex = 16;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(55, 236);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(68, 13);
            this.label3.TabIndex = 17;
            this.label3.Text = "Должность:";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(60, 281);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(60, 13);
            this.label4.TabIndex = 18;
            this.label4.Text = "Надбавка:";
            // 
            // save_changes_button
            // 
            this.save_changes_button.Location = new System.Drawing.Point(12, 339);
            this.save_changes_button.Name = "save_changes_button";
            this.save_changes_button.Size = new System.Drawing.Size(286, 23);
            this.save_changes_button.TabIndex = 19;
            this.save_changes_button.Text = "Сохранить изменения";
            this.save_changes_button.UseVisualStyleBackColor = true;
            this.save_changes_button.Click += new System.EventHandler(this.save_changes_button_Click);
            // 
            // trick
            // 
            this.trick.AutoSize = true;
            this.trick.Location = new System.Drawing.Point(133, 96);
            this.trick.Name = "trick";
            this.trick.Size = new System.Drawing.Size(35, 13);
            this.trick.TabIndex = 20;
            this.trick.Text = "label6";
            this.trick.Visible = false;
            // 
            // sqlConnection1
            // 
            this.sqlConnection1.ConnectionString = "Data Source=DESKTOP-T003JCT\\SQLEXPRESS;Initial Catalog=Otdel_kadrov;Integrated Se" +
    "curity=True";
            this.sqlConnection1.FireInfoMessageEventOnUserErrors = false;
            // 
            // change_worker_Command
            // 
            this.change_worker_Command.CommandText = "Change_worker_card";
            this.change_worker_Command.CommandType = System.Data.CommandType.StoredProcedure;
            this.change_worker_Command.Connection = this.sqlConnection1;
            this.change_worker_Command.Parameters.AddRange(new System.Data.SqlClient.SqlParameter[] {
            new System.Data.SqlClient.SqlParameter("@id_worker", System.Data.SqlDbType.Int),
            new System.Data.SqlClient.SqlParameter("@fio", System.Data.SqlDbType.VarChar, 70),
            new System.Data.SqlClient.SqlParameter("@num_dep", System.Data.SqlDbType.Int),
            new System.Data.SqlClient.SqlParameter("@post_name", System.Data.SqlDbType.VarChar, 50),
            new System.Data.SqlClient.SqlParameter("@allowance", System.Data.SqlDbType.Float),
            new System.Data.SqlClient.SqlParameter("@message", System.Data.SqlDbType.VarChar, 100, System.Data.ParameterDirection.Output, false, ((byte)(0)), ((byte)(0)), "", System.Data.DataRowVersion.Current, null)});
            // 
            // Edit_worker
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.ActiveCaption;
            this.ClientSize = new System.Drawing.Size(315, 399);
            this.Controls.Add(this.trick);
            this.Controls.Add(this.save_changes_button);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.allowance_textBox);
            this.Controls.Add(this.post_name_textBox);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.dep_textBox);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.fio_textBox);
            this.Controls.Add(this.label5);
            this.Name = "Edit_worker";
            this.Text = "Редактирование данных сотрудника";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.TextBox fio_textBox;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox dep_textBox;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.TextBox post_name_textBox;
        private System.Windows.Forms.TextBox allowance_textBox;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Button save_changes_button;
        private System.Windows.Forms.Label trick;
        private System.Data.SqlClient.SqlConnection sqlConnection1;
        private System.Data.SqlClient.SqlCommand change_worker_Command;
    }
}