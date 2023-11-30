namespace Personnel_Department
{
    partial class Create_mission
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
            this.label1 = new System.Windows.Forms.Label();
            this.workers_listbox = new System.Windows.Forms.ListBox();
            this.workerBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.otdel_kadrovDataSet = new Personnel_Department.Otdel_kadrovDataSet();
            this.workerTableAdapter = new Personnel_Department.Otdel_kadrovDataSetTableAdapters.WorkerTableAdapter();
            this.start_dateTimePicker = new System.Windows.Forms.DateTimePicker();
            this.end_dateTimePicker = new System.Windows.Forms.DateTimePicker();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.place_textBox = new System.Windows.Forms.TextBox();
            this.button1 = new System.Windows.Forms.Button();
            this.sqlConnection1 = new System.Data.SqlClient.SqlConnection();
            this.sqlCommand1 = new System.Data.SqlClient.SqlCommand();
            this.textBox1 = new System.Windows.Forms.TextBox();
            this.label5 = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.workerBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.otdel_kadrovDataSet)).BeginInit();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(13, 15);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(118, 13);
            this.label1.TabIndex = 3;
            this.label1.Text = "Выберите сотрудника";
            // 
            // workers_listbox
            // 
            this.workers_listbox.DataSource = this.workerBindingSource;
            this.workers_listbox.DisplayMember = "FIO_worker";
            this.workers_listbox.FormattingEnabled = true;
            this.workers_listbox.Location = new System.Drawing.Point(12, 34);
            this.workers_listbox.Name = "workers_listbox";
            this.workers_listbox.Size = new System.Drawing.Size(331, 316);
            this.workers_listbox.TabIndex = 4;
            this.workers_listbox.ValueMember = "ID_worker";
            // 
            // workerBindingSource
            // 
            this.workerBindingSource.DataMember = "Worker";
            this.workerBindingSource.DataSource = this.otdel_kadrovDataSet;
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
            // start_dateTimePicker
            // 
            this.start_dateTimePicker.Location = new System.Drawing.Point(521, 66);
            this.start_dateTimePicker.Name = "start_dateTimePicker";
            this.start_dateTimePicker.Size = new System.Drawing.Size(200, 20);
            this.start_dateTimePicker.TabIndex = 5;
            // 
            // end_dateTimePicker
            // 
            this.end_dateTimePicker.Location = new System.Drawing.Point(521, 113);
            this.end_dateTimePicker.Name = "end_dateTimePicker";
            this.end_dateTimePicker.Size = new System.Drawing.Size(200, 20);
            this.end_dateTimePicker.TabIndex = 6;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(364, 66);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(151, 13);
            this.label2.TabIndex = 7;
            this.label2.Text = "Дата начала командировки:";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(346, 113);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(169, 13);
            this.label3.TabIndex = 8;
            this.label3.Text = "Дата окончания командировки:";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(398, 156);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(119, 13);
            this.label4.TabIndex = 9;
            this.label4.Text = "Место командировки:";
            // 
            // place_textBox
            // 
            this.place_textBox.Location = new System.Drawing.Point(522, 156);
            this.place_textBox.Name = "place_textBox";
            this.place_textBox.Size = new System.Drawing.Size(199, 20);
            this.place_textBox.TabIndex = 10;
            this.place_textBox.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.place_textBox_KeyPress);
            // 
            // button1
            // 
            this.button1.Location = new System.Drawing.Point(372, 202);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(338, 23);
            this.button1.TabIndex = 11;
            this.button1.Text = "Сформировать приказ о командировке";
            this.button1.UseVisualStyleBackColor = true;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // sqlConnection1
            // 
            this.sqlConnection1.ConnectionString = "Data Source=DESKTOP-T003JCT\\SQLEXPRESS;Initial Catalog=Otdel_kadrov;Integrated Se" +
    "curity=True";
            this.sqlConnection1.FireInfoMessageEventOnUserErrors = false;
            // 
            // sqlCommand1
            // 
            this.sqlCommand1.CommandText = "Create_mission";
            this.sqlCommand1.CommandType = System.Data.CommandType.StoredProcedure;
            this.sqlCommand1.Connection = this.sqlConnection1;
            this.sqlCommand1.Parameters.AddRange(new System.Data.SqlClient.SqlParameter[] {
            new System.Data.SqlClient.SqlParameter("@id_worker", System.Data.SqlDbType.Int),
            new System.Data.SqlClient.SqlParameter("@start_date", System.Data.SqlDbType.DateTime),
            new System.Data.SqlClient.SqlParameter("@end_date", System.Data.SqlDbType.DateTime),
            new System.Data.SqlClient.SqlParameter("@message", System.Data.SqlDbType.VarChar, 100, System.Data.ParameterDirection.Output, false, ((byte)(0)), ((byte)(0)), "", System.Data.DataRowVersion.Current, null),
            new System.Data.SqlClient.SqlParameter("@place", System.Data.SqlDbType.VarChar, 100)});
            // 
            // textBox1
            // 
            this.textBox1.Location = new System.Drawing.Point(56, 356);
            this.textBox1.Name = "textBox1";
            this.textBox1.Size = new System.Drawing.Size(287, 20);
            this.textBox1.TabIndex = 12;
            this.textBox1.TextChanged += new System.EventHandler(this.textBox1_TextChanged);
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(13, 359);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(37, 13);
            this.label5.TabIndex = 13;
            this.label5.Text = "ФИО:";
            // 
            // Create_mission
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.ActiveCaption;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.textBox1);
            this.Controls.Add(this.button1);
            this.Controls.Add(this.place_textBox);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.end_dateTimePicker);
            this.Controls.Add(this.start_dateTimePicker);
            this.Controls.Add(this.workers_listbox);
            this.Controls.Add(this.label1);
            this.Name = "Create_mission";
            this.Text = "Создание командировки";
            this.Load += new System.EventHandler(this.Create_mission_Load);
            ((System.ComponentModel.ISupportInitialize)(this.workerBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.otdel_kadrovDataSet)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.ListBox workers_listbox;
        private Otdel_kadrovDataSet otdel_kadrovDataSet;
        private System.Windows.Forms.BindingSource workerBindingSource;
        private Otdel_kadrovDataSetTableAdapters.WorkerTableAdapter workerTableAdapter;
        private System.Windows.Forms.DateTimePicker start_dateTimePicker;
        private System.Windows.Forms.DateTimePicker end_dateTimePicker;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.TextBox place_textBox;
        private System.Windows.Forms.Button button1;
        private System.Data.SqlClient.SqlConnection sqlConnection1;
        private System.Data.SqlClient.SqlCommand sqlCommand1;
        private System.Windows.Forms.TextBox textBox1;
        private System.Windows.Forms.Label label5;
    }
}