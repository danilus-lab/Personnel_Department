namespace Personnel_Department
{
    partial class Deps_list
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Deps_list));
            this.myConnection = new System.Data.SqlClient.SqlConnection();
            this.dataGridView1 = new System.Windows.Forms.DataGridView();
            this.fill_the_table = new System.Data.SqlClient.SqlCommand();
            this.change_boss_button = new System.Windows.Forms.Button();
            this.refresh_button = new System.Windows.Forms.Button();
            this.add_new_dep_button = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).BeginInit();
            this.SuspendLayout();
            // 
            // myConnection
            // 
            this.myConnection.ConnectionString = "Data Source=DESKTOP-T003JCT\\SQLEXPRESS;Initial Catalog=Otdel_kadrov;Integrated Se" +
    "curity=True";
            this.myConnection.FireInfoMessageEventOnUserErrors = false;
            // 
            // dataGridView1
            // 
            this.dataGridView1.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.AllCells;
            this.dataGridView1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridView1.Location = new System.Drawing.Point(12, 12);
            this.dataGridView1.Name = "dataGridView1";
            this.dataGridView1.ReadOnly = true;
            this.dataGridView1.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.dataGridView1.Size = new System.Drawing.Size(422, 265);
            this.dataGridView1.TabIndex = 0;
            // 
            // fill_the_table
            // 
            this.fill_the_table.CommandText = resources.GetString("fill_the_table.CommandText");
            this.fill_the_table.Connection = this.myConnection;
            // 
            // change_boss_button
            // 
            this.change_boss_button.Location = new System.Drawing.Point(12, 284);
            this.change_boss_button.Name = "change_boss_button";
            this.change_boss_button.Size = new System.Drawing.Size(422, 23);
            this.change_boss_button.TabIndex = 1;
            this.change_boss_button.Text = "Изменить начальника отдела";
            this.change_boss_button.UseVisualStyleBackColor = true;
            this.change_boss_button.Click += new System.EventHandler(this.change_boss_button_Click);
            // 
            // refresh_button
            // 
            this.refresh_button.Location = new System.Drawing.Point(12, 343);
            this.refresh_button.Name = "refresh_button";
            this.refresh_button.Size = new System.Drawing.Size(422, 23);
            this.refresh_button.TabIndex = 2;
            this.refresh_button.Text = "Обновить таблицу";
            this.refresh_button.UseVisualStyleBackColor = true;
            this.refresh_button.Click += new System.EventHandler(this.refresh_button_Click);
            // 
            // add_new_dep_button
            // 
            this.add_new_dep_button.Location = new System.Drawing.Point(13, 314);
            this.add_new_dep_button.Name = "add_new_dep_button";
            this.add_new_dep_button.Size = new System.Drawing.Size(421, 23);
            this.add_new_dep_button.TabIndex = 3;
            this.add_new_dep_button.Text = "Добавить новый отдел";
            this.add_new_dep_button.UseVisualStyleBackColor = true;
            this.add_new_dep_button.Click += new System.EventHandler(this.add_new_dep_button_Click);
            // 
            // Deps_list
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.ActiveCaption;
            this.ClientSize = new System.Drawing.Size(443, 374);
            this.Controls.Add(this.add_new_dep_button);
            this.Controls.Add(this.refresh_button);
            this.Controls.Add(this.change_boss_button);
            this.Controls.Add(this.dataGridView1);
            this.Name = "Deps_list";
            this.Text = "Список отделов";
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Data.SqlClient.SqlConnection myConnection;
        private System.Windows.Forms.DataGridView dataGridView1;
        private System.Data.SqlClient.SqlCommand fill_the_table;
        private System.Windows.Forms.Button change_boss_button;
        private System.Windows.Forms.Button refresh_button;
        private System.Windows.Forms.Button add_new_dep_button;
    }
}