namespace Personnel_Department
{
    partial class Change_dep_boss
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
            this.components = new System.ComponentModel.Container();
            this.trick = new System.Windows.Forms.Label();
            this.listBox1 = new System.Windows.Forms.ListBox();
            this.workerBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.otdel_kadrovDataSet = new Personnel_Department.Otdel_kadrovDataSet();
            this.workerTableAdapter = new Personnel_Department.Otdel_kadrovDataSetTableAdapters.WorkerTableAdapter();
            this.set_boss_button = new System.Windows.Forms.Button();
            this.sqlConnection1 = new System.Data.SqlClient.SqlConnection();
            this.set_boss_comm = new System.Data.SqlClient.SqlCommand();
            ((System.ComponentModel.ISupportInitialize)(this.workerBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.otdel_kadrovDataSet)).BeginInit();
            this.SuspendLayout();
            // 
            // trick
            // 
            this.trick.AutoSize = true;
            this.trick.Location = new System.Drawing.Point(305, 9);
            this.trick.Name = "trick";
            this.trick.Size = new System.Drawing.Size(35, 13);
            this.trick.TabIndex = 0;
            this.trick.Text = "label1";
            this.trick.Visible = false;
            // 
            // listBox1
            // 
            this.listBox1.DataSource = this.workerBindingSource;
            this.listBox1.DisplayMember = "FIO_worker";
            this.listBox1.FormattingEnabled = true;
            this.listBox1.Location = new System.Drawing.Point(13, 25);
            this.listBox1.Name = "listBox1";
            this.listBox1.Size = new System.Drawing.Size(327, 316);
            this.listBox1.TabIndex = 1;
            this.listBox1.ValueMember = "ID_worker";
            // 
            // workerBindingSource
            // 
            this.workerBindingSource.DataMember = "Worker";
            this.workerBindingSource.DataSource = this.otdel_kadrovDataSet;
            this.workerBindingSource.Filter = "";
            // 
            // otdel_kadrovDataSet
            // 
            this.otdel_kadrovDataSet.DataSetName = "Otdel_kadrovDataSet";
            this.otdel_kadrovDataSet.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
            // 
            // workerTableAdapter
            // 
            this.workerTableAdapter.ClearBeforeFill = true;
            // 
            // set_boss_button
            // 
            this.set_boss_button.Location = new System.Drawing.Point(13, 347);
            this.set_boss_button.Name = "set_boss_button";
            this.set_boss_button.Size = new System.Drawing.Size(327, 23);
            this.set_boss_button.TabIndex = 2;
            this.set_boss_button.Text = "Назначить начальником";
            this.set_boss_button.UseVisualStyleBackColor = true;
            this.set_boss_button.Click += new System.EventHandler(this.set_boss_button_Click);
            // 
            // sqlConnection1
            // 
            this.sqlConnection1.ConnectionString = "Data Source=DESKTOP-T003JCT\\SQLEXPRESS;Initial Catalog=Otdel_kadrov;Integrated Se" +
    "curity=True";
            this.sqlConnection1.FireInfoMessageEventOnUserErrors = false;
            // 
            // set_boss_comm
            // 
            this.set_boss_comm.CommandText = "Set_boss";
            this.set_boss_comm.CommandType = System.Data.CommandType.StoredProcedure;
            this.set_boss_comm.Connection = this.sqlConnection1;
            this.set_boss_comm.Parameters.AddRange(new System.Data.SqlClient.SqlParameter[] {
            new System.Data.SqlClient.SqlParameter("@dep", System.Data.SqlDbType.Int),
            new System.Data.SqlClient.SqlParameter("@boss_id", System.Data.SqlDbType.Int),
            new System.Data.SqlClient.SqlParameter("@message", System.Data.SqlDbType.VarChar, 100, System.Data.ParameterDirection.Output, false, ((byte)(0)), ((byte)(0)), "", System.Data.DataRowVersion.Current, null)});
            // 
            // Change_dep_boss
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.ActiveCaption;
            this.ClientSize = new System.Drawing.Size(352, 379);
            this.Controls.Add(this.set_boss_button);
            this.Controls.Add(this.listBox1);
            this.Controls.Add(this.trick);
            this.Name = "Change_dep_boss";
            this.Text = "Изменение начальника";
            this.Load += new System.EventHandler(this.Change_dep_boss_Load);
            ((System.ComponentModel.ISupportInitialize)(this.workerBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.otdel_kadrovDataSet)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label trick;
        private System.Windows.Forms.ListBox listBox1;
        private Otdel_kadrovDataSet otdel_kadrovDataSet;
        private System.Windows.Forms.BindingSource workerBindingSource;
        private Otdel_kadrovDataSetTableAdapters.WorkerTableAdapter workerTableAdapter;
        private System.Windows.Forms.Button set_boss_button;
        private System.Data.SqlClient.SqlConnection sqlConnection1;
        private System.Data.SqlClient.SqlCommand set_boss_comm;
    }
}