namespace Personnel_Department
{
    partial class Create_vacation
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
            this.workers_listbox = new System.Windows.Forms.ListBox();
            this.workerBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.otdel_kadrovDataSet = new Personnel_Department.Otdel_kadrovDataSet();
            this.workerTableAdapter = new Personnel_Department.Otdel_kadrovDataSetTableAdapters.WorkerTableAdapter();
            this.label1 = new System.Windows.Forms.Label();
            this.start_dateTimePicker = new System.Windows.Forms.DateTimePicker();
            this.end_dateTimePicker = new System.Windows.Forms.DateTimePicker();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.create_vacation_button = new System.Windows.Forms.Button();
            this.payed_radio = new System.Windows.Forms.RadioButton();
            this.unpayed_radio = new System.Windows.Forms.RadioButton();
            this.sqlCommand1 = new System.Data.SqlClient.SqlCommand();
            this.sqlConnection1 = new System.Data.SqlClient.SqlConnection();
            this.textBox1 = new System.Windows.Forms.TextBox();
            this.label5 = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.workerBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.otdel_kadrovDataSet)).BeginInit();
            this.SuspendLayout();
            // 
            // workers_listbox
            // 
            this.workers_listbox.DataSource = this.workerBindingSource;
            this.workers_listbox.DisplayMember = "FIO_worker";
            this.workers_listbox.FormattingEnabled = true;
            this.workers_listbox.Location = new System.Drawing.Point(12, 34);
            this.workers_listbox.Name = "workers_listbox";
            this.workers_listbox.Size = new System.Drawing.Size(331, 316);
            this.workers_listbox.TabIndex = 0;
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
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(13, 15);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(118, 13);
            this.label1.TabIndex = 1;
            this.label1.Text = "Выберите сотрудника";
            // 
            // start_dateTimePicker
            // 
            this.start_dateTimePicker.Location = new System.Drawing.Point(510, 66);
            this.start_dateTimePicker.Name = "start_dateTimePicker";
            this.start_dateTimePicker.Size = new System.Drawing.Size(200, 20);
            this.start_dateTimePicker.TabIndex = 2;
            // 
            // end_dateTimePicker
            // 
            this.end_dateTimePicker.Location = new System.Drawing.Point(510, 113);
            this.end_dateTimePicker.Name = "end_dateTimePicker";
            this.end_dateTimePicker.Size = new System.Drawing.Size(200, 20);
            this.end_dateTimePicker.TabIndex = 3;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(387, 66);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(117, 13);
            this.label2.TabIndex = 4;
            this.label2.Text = "Дата начала отпуска:";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(369, 113);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(135, 13);
            this.label3.TabIndex = 5;
            this.label3.Text = "Дата окончания отпуска:";
            // 
            // create_vacation_button
            // 
            this.create_vacation_button.Location = new System.Drawing.Point(372, 202);
            this.create_vacation_button.Name = "create_vacation_button";
            this.create_vacation_button.Size = new System.Drawing.Size(338, 23);
            this.create_vacation_button.TabIndex = 6;
            this.create_vacation_button.Text = "Сформировать приказ об отпуске";
            this.create_vacation_button.UseVisualStyleBackColor = true;
            this.create_vacation_button.Click += new System.EventHandler(this.create_vacation_button_Click);
            // 
            // payed_radio
            // 
            this.payed_radio.AutoSize = true;
            this.payed_radio.Location = new System.Drawing.Point(419, 152);
            this.payed_radio.Name = "payed_radio";
            this.payed_radio.Size = new System.Drawing.Size(102, 17);
            this.payed_radio.TabIndex = 7;
            this.payed_radio.TabStop = true;
            this.payed_radio.Text = "Оплачиваемый";
            this.payed_radio.UseVisualStyleBackColor = true;
            // 
            // unpayed_radio
            // 
            this.unpayed_radio.AutoSize = true;
            this.unpayed_radio.Location = new System.Drawing.Point(544, 152);
            this.unpayed_radio.Name = "unpayed_radio";
            this.unpayed_radio.Size = new System.Drawing.Size(117, 17);
            this.unpayed_radio.TabIndex = 8;
            this.unpayed_radio.TabStop = true;
            this.unpayed_radio.Text = "Не оплачиваемый";
            this.unpayed_radio.UseVisualStyleBackColor = true;
            // 
            // sqlCommand1
            // 
            this.sqlCommand1.CommandText = "Create_vacation";
            this.sqlCommand1.CommandType = System.Data.CommandType.StoredProcedure;
            this.sqlCommand1.Connection = this.sqlConnection1;
            this.sqlCommand1.Parameters.AddRange(new System.Data.SqlClient.SqlParameter[] {
            new System.Data.SqlClient.SqlParameter("@id_worker", System.Data.SqlDbType.Int),
            new System.Data.SqlClient.SqlParameter("@start_date", System.Data.SqlDbType.DateTime),
            new System.Data.SqlClient.SqlParameter("@end_date", System.Data.SqlDbType.DateTime),
            new System.Data.SqlClient.SqlParameter("@type_vacation", System.Data.SqlDbType.VarChar, 15),
            new System.Data.SqlClient.SqlParameter("@message", System.Data.SqlDbType.VarChar, 100, System.Data.ParameterDirection.Output, false, ((byte)(0)), ((byte)(0)), "", System.Data.DataRowVersion.Current, null)});
            // 
            // sqlConnection1
            // 
            this.sqlConnection1.ConnectionString = "Data Source=DESKTOP-T003JCT\\SQLEXPRESS;Initial Catalog=Otdel_kadrov;Integrated Se" +
    "curity=True";
            this.sqlConnection1.FireInfoMessageEventOnUserErrors = false;
            // 
            // textBox1
            // 
            this.textBox1.Location = new System.Drawing.Point(56, 356);
            this.textBox1.Name = "textBox1";
            this.textBox1.Size = new System.Drawing.Size(287, 20);
            this.textBox1.TabIndex = 13;
            this.textBox1.TextChanged += new System.EventHandler(this.textBox1_TextChanged);
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(13, 359);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(37, 13);
            this.label5.TabIndex = 14;
            this.label5.Text = "ФИО:";
            // 
            // Create_vacation
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.ActiveCaption;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.textBox1);
            this.Controls.Add(this.unpayed_radio);
            this.Controls.Add(this.payed_radio);
            this.Controls.Add(this.create_vacation_button);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.end_dateTimePicker);
            this.Controls.Add(this.start_dateTimePicker);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.workers_listbox);
            this.Name = "Create_vacation";
            this.Text = "Создание отпуска";
            this.Load += new System.EventHandler(this.Create_vacation_Load);
            ((System.ComponentModel.ISupportInitialize)(this.workerBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.otdel_kadrovDataSet)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.ListBox workers_listbox;
        private Otdel_kadrovDataSet otdel_kadrovDataSet;
        private System.Windows.Forms.BindingSource workerBindingSource;
        private Otdel_kadrovDataSetTableAdapters.WorkerTableAdapter workerTableAdapter;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.DateTimePicker start_dateTimePicker;
        private System.Windows.Forms.DateTimePicker end_dateTimePicker;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Button create_vacation_button;
        private System.Windows.Forms.RadioButton payed_radio;
        private System.Windows.Forms.RadioButton unpayed_radio;
        private System.Data.SqlClient.SqlCommand sqlCommand1;
        private System.Data.SqlClient.SqlConnection sqlConnection1;
        private System.Windows.Forms.TextBox textBox1;
        private System.Windows.Forms.Label label5;
    }
}