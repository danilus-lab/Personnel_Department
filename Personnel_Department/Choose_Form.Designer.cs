namespace Personnel_Department
{
    partial class Choose_Form
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
            this.tableLayoutPanel1 = new System.Windows.Forms.TableLayoutPanel();
            this.new_vacation = new System.Windows.Forms.Button();
            this.delete_worker = new System.Windows.Forms.Button();
            this.new_medical = new System.Windows.Forms.Button();
            this.staff_list = new System.Windows.Forms.Button();
            this.new_trip = new System.Windows.Forms.Button();
            this.add_worker = new System.Windows.Forms.Button();
            this.label1 = new System.Windows.Forms.Label();
            this.all_workers = new System.Windows.Forms.Button();
            this.menuStrip1 = new System.Windows.Forms.MenuStrip();
            this.vacations = new System.Windows.Forms.ToolStripMenuItem();
            this.medicals = new System.Windows.Forms.ToolStripMenuItem();
            this.missions = new System.Windows.Forms.ToolStripMenuItem();
            this.sqlConnection1 = new System.Data.SqlClient.SqlConnection();
            this.check_status = new System.Data.SqlClient.SqlCommand();
            this.dep = new System.Windows.Forms.ToolStripMenuItem();
            this.tableLayoutPanel1.SuspendLayout();
            this.menuStrip1.SuspendLayout();
            this.SuspendLayout();
            // 
            // tableLayoutPanel1
            // 
            this.tableLayoutPanel1.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.tableLayoutPanel1.ColumnCount = 3;
            this.tableLayoutPanel1.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 81.65829F));
            this.tableLayoutPanel1.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 18.34171F));
            this.tableLayoutPanel1.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Absolute, 295F));
            this.tableLayoutPanel1.Controls.Add(this.new_vacation, 2, 0);
            this.tableLayoutPanel1.Controls.Add(this.delete_worker, 0, 1);
            this.tableLayoutPanel1.Controls.Add(this.new_medical, 2, 1);
            this.tableLayoutPanel1.Controls.Add(this.staff_list, 0, 2);
            this.tableLayoutPanel1.Controls.Add(this.new_trip, 2, 2);
            this.tableLayoutPanel1.Controls.Add(this.add_worker, 0, 0);
            this.tableLayoutPanel1.Location = new System.Drawing.Point(99, 212);
            this.tableLayoutPanel1.Name = "tableLayoutPanel1";
            this.tableLayoutPanel1.RowCount = 3;
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 50F));
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 50F));
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 110F));
            this.tableLayoutPanel1.Size = new System.Drawing.Size(621, 326);
            this.tableLayoutPanel1.TabIndex = 0;
            // 
            // new_vacation
            // 
            this.new_vacation.Font = new System.Drawing.Font("Elephant", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.new_vacation.Location = new System.Drawing.Point(328, 3);
            this.new_vacation.Name = "new_vacation";
            this.new_vacation.Size = new System.Drawing.Size(280, 102);
            this.new_vacation.TabIndex = 1;
            this.new_vacation.Text = "Сформировать отпуск";
            this.new_vacation.UseVisualStyleBackColor = true;
            this.new_vacation.Click += new System.EventHandler(this.new_vacation_Click);
            // 
            // delete_worker
            // 
            this.delete_worker.Font = new System.Drawing.Font("Elephant", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.delete_worker.Location = new System.Drawing.Point(3, 111);
            this.delete_worker.Name = "delete_worker";
            this.delete_worker.Size = new System.Drawing.Size(260, 102);
            this.delete_worker.TabIndex = 2;
            this.delete_worker.Text = "Уволить сотрудника";
            this.delete_worker.UseVisualStyleBackColor = true;
            this.delete_worker.Click += new System.EventHandler(this.delete_worker_Click);
            // 
            // new_medical
            // 
            this.new_medical.Font = new System.Drawing.Font("Elephant", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.new_medical.Location = new System.Drawing.Point(328, 111);
            this.new_medical.Name = "new_medical";
            this.new_medical.Size = new System.Drawing.Size(280, 102);
            this.new_medical.TabIndex = 3;
            this.new_medical.Text = "Сформировать больничный";
            this.new_medical.UseVisualStyleBackColor = true;
            this.new_medical.Click += new System.EventHandler(this.new_medical_Click);
            // 
            // staff_list
            // 
            this.staff_list.Font = new System.Drawing.Font("Elephant", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.staff_list.Location = new System.Drawing.Point(3, 219);
            this.staff_list.Name = "staff_list";
            this.staff_list.Size = new System.Drawing.Size(260, 104);
            this.staff_list.TabIndex = 4;
            this.staff_list.Text = "Штатное расписание";
            this.staff_list.UseVisualStyleBackColor = true;
            this.staff_list.Click += new System.EventHandler(this.staff_list_Click);
            // 
            // new_trip
            // 
            this.new_trip.Font = new System.Drawing.Font("Elephant", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.new_trip.Location = new System.Drawing.Point(328, 219);
            this.new_trip.Name = "new_trip";
            this.new_trip.Size = new System.Drawing.Size(280, 104);
            this.new_trip.TabIndex = 5;
            this.new_trip.Text = "Сформировать командировку";
            this.new_trip.UseVisualStyleBackColor = true;
            this.new_trip.Click += new System.EventHandler(this.new_trip_Click);
            // 
            // add_worker
            // 
            this.add_worker.Font = new System.Drawing.Font("Elephant", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.add_worker.Location = new System.Drawing.Point(3, 3);
            this.add_worker.Name = "add_worker";
            this.add_worker.Size = new System.Drawing.Size(260, 102);
            this.add_worker.TabIndex = 0;
            this.add_worker.Text = "Добавить сотрудника";
            this.add_worker.UseVisualStyleBackColor = true;
            this.add_worker.Click += new System.EventHandler(this.add_worker_Click);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Elephant", 36F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(229, 109);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(363, 62);
            this.label1.TabIndex = 1;
            this.label1.Text = "Отдел кадров";
            // 
            // all_workers
            // 
            this.all_workers.Font = new System.Drawing.Font("Elephant", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.all_workers.Location = new System.Drawing.Point(99, 558);
            this.all_workers.Name = "all_workers";
            this.all_workers.Size = new System.Drawing.Size(621, 44);
            this.all_workers.TabIndex = 2;
            this.all_workers.Text = "Список сотрудников";
            this.all_workers.UseVisualStyleBackColor = true;
            this.all_workers.Click += new System.EventHandler(this.all_workers_Click);
            // 
            // menuStrip1
            // 
            this.menuStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.vacations,
            this.medicals,
            this.missions,
            this.dep});
            this.menuStrip1.Location = new System.Drawing.Point(0, 0);
            this.menuStrip1.Name = "menuStrip1";
            this.menuStrip1.Size = new System.Drawing.Size(835, 24);
            this.menuStrip1.TabIndex = 3;
            this.menuStrip1.Text = "menuStrip1";
            // 
            // vacations
            // 
            this.vacations.Name = "vacations";
            this.vacations.Size = new System.Drawing.Size(113, 20);
            this.vacations.Text = "Список отпусков";
            this.vacations.Click += new System.EventHandler(this.vacations_Click);
            // 
            // medicals
            // 
            this.medicals.Name = "medicals";
            this.medicals.Size = new System.Drawing.Size(133, 20);
            this.medicals.Text = "Список больничных";
            this.medicals.Click += new System.EventHandler(this.medicals_Click);
            // 
            // missions
            // 
            this.missions.Name = "missions";
            this.missions.Size = new System.Drawing.Size(144, 20);
            this.missions.Text = "Список командировок";
            this.missions.Click += new System.EventHandler(this.missions_Click);
            // 
            // sqlConnection1
            // 
            this.sqlConnection1.ConnectionString = "Data Source=DESKTOP-T003JCT\\SQLEXPRESS;Initial Catalog=Otdel_kadrov;Integrated Se" +
    "curity=True";
            this.sqlConnection1.FireInfoMessageEventOnUserErrors = false;
            // 
            // check_status
            // 
            this.check_status.CommandText = "Update_status";
            this.check_status.CommandType = System.Data.CommandType.StoredProcedure;
            this.check_status.Connection = this.sqlConnection1;
            // 
            // dep
            // 
            this.dep.Name = "dep";
            this.dep.Size = new System.Drawing.Size(107, 20);
            this.dep.Text = "Список отделов";
            this.dep.Click += new System.EventHandler(this.dep_Click);
            // 
            // Choose_Form
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.ActiveCaption;
            this.ClientSize = new System.Drawing.Size(835, 686);
            this.Controls.Add(this.all_workers);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.tableLayoutPanel1);
            this.Controls.Add(this.menuStrip1);
            this.MainMenuStrip = this.menuStrip1;
            this.Name = "Choose_Form";
            this.Text = "Отдел кадров";
            this.tableLayoutPanel1.ResumeLayout(false);
            this.menuStrip1.ResumeLayout(false);
            this.menuStrip1.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.TableLayoutPanel tableLayoutPanel1;
        private System.Windows.Forms.Button add_worker;
        private System.Windows.Forms.Button new_vacation;
        private System.Windows.Forms.Button delete_worker;
        private System.Windows.Forms.Button new_medical;
        private System.Windows.Forms.Button staff_list;
        private System.Windows.Forms.Button new_trip;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Button all_workers;
        private System.Windows.Forms.MenuStrip menuStrip1;
        private System.Windows.Forms.ToolStripMenuItem vacations;
        private System.Windows.Forms.ToolStripMenuItem medicals;
        private System.Windows.Forms.ToolStripMenuItem missions;
        private System.Data.SqlClient.SqlConnection sqlConnection1;
        private System.Data.SqlClient.SqlCommand check_status;
        private System.Windows.Forms.ToolStripMenuItem dep;
    }
}