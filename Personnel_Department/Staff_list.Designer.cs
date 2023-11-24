namespace Personnel_Department
{
    partial class Staff_list
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
            this.staff_list_grid = new System.Windows.Forms.DataGridView();
            this.sqlConnection1 = new System.Data.SqlClient.SqlConnection();
            this.fill_the_tabel_command = new System.Data.SqlClient.SqlCommand();
            this.edit_button = new System.Windows.Forms.Button();
            this.refresh_button = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.staff_list_grid)).BeginInit();
            this.SuspendLayout();
            // 
            // staff_list_grid
            // 
            this.staff_list_grid.AllowUserToAddRows = false;
            this.staff_list_grid.AllowUserToDeleteRows = false;
            this.staff_list_grid.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.staff_list_grid.Location = new System.Drawing.Point(12, 12);
            this.staff_list_grid.Name = "staff_list_grid";
            this.staff_list_grid.ReadOnly = true;
            this.staff_list_grid.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.staff_list_grid.Size = new System.Drawing.Size(543, 258);
            this.staff_list_grid.TabIndex = 0;
            // 
            // sqlConnection1
            // 
            this.sqlConnection1.ConnectionString = "Data Source=DESKTOP-T003JCT\\SQLEXPRESS;Initial Catalog=Otdel_kadrov;Integrated Se" +
    "curity=True";
            this.sqlConnection1.FireInfoMessageEventOnUserErrors = false;
            // 
            // fill_the_tabel_command
            // 
            this.fill_the_tabel_command.CommandText = "SELECT ID_record AS \'Номер записи\', Num_dep AS \'Номер отдела\', Post_name AS \'Долж" +
    "ность\', Count_units AS \'Количество рабочих мест\', Salary AS \'Зарплата\' FROM Staf" +
    "fList";
            this.fill_the_tabel_command.Connection = this.sqlConnection1;
            // 
            // edit_button
            // 
            this.edit_button.Location = new System.Drawing.Point(572, 12);
            this.edit_button.Name = "edit_button";
            this.edit_button.Size = new System.Drawing.Size(216, 23);
            this.edit_button.TabIndex = 1;
            this.edit_button.Text = "Редактировать запись";
            this.edit_button.UseVisualStyleBackColor = true;
            this.edit_button.Click += new System.EventHandler(this.edit_button_Click);
            // 
            // refresh_button
            // 
            this.refresh_button.Location = new System.Drawing.Point(572, 51);
            this.refresh_button.Name = "refresh_button";
            this.refresh_button.Size = new System.Drawing.Size(216, 23);
            this.refresh_button.TabIndex = 2;
            this.refresh_button.Text = "Обновить таблицу";
            this.refresh_button.UseVisualStyleBackColor = true;
            this.refresh_button.Click += new System.EventHandler(this.refresh_button_Click);
            // 
            // Staff_list
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.ActiveCaption;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.refresh_button);
            this.Controls.Add(this.edit_button);
            this.Controls.Add(this.staff_list_grid);
            this.Name = "Staff_list";
            this.Text = "Штатное расписание";
            ((System.ComponentModel.ISupportInitialize)(this.staff_list_grid)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.DataGridView staff_list_grid;
        private System.Data.SqlClient.SqlConnection sqlConnection1;
        private System.Data.SqlClient.SqlCommand fill_the_tabel_command;
        private System.Windows.Forms.Button edit_button;
        private System.Windows.Forms.Button refresh_button;
    }
}