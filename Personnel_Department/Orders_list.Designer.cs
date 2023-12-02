namespace Personnel_Department
{
    partial class Orders_list
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Orders_list));
            this.sqlConnection1 = new System.Data.SqlClient.SqlConnection();
            this.fill_the_table_comm = new System.Data.SqlClient.SqlCommand();
            this.label5 = new System.Windows.Forms.Label();
            this.textBox1 = new System.Windows.Forms.TextBox();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.dismiss_radio = new System.Windows.Forms.RadioButton();
            this.all_radio = new System.Windows.Forms.RadioButton();
            this.mission_radio = new System.Windows.Forms.RadioButton();
            this.medical_radio = new System.Windows.Forms.RadioButton();
            this.vacation_radio = new System.Windows.Forms.RadioButton();
            this.orderBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.otdel_kadrovDataSet = new Personnel_Department.Otdel_kadrovDataSet();
            this.orderTableAdapter = new Personnel_Department.Otdel_kadrovDataSetTableAdapters.OrderTableAdapter();
            this.find_button = new System.Windows.Forms.Button();
            this.tableAdapterManager = new Personnel_Department.Otdel_kadrovDataSetTableAdapters.TableAdapterManager();
            this.orderDataGridView = new System.Windows.Forms.DataGridView();
            this.numorderDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.fIOworkerDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.typeorderDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dataorderDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.groupBox1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.orderBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.otdel_kadrovDataSet)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.orderDataGridView)).BeginInit();
            this.SuspendLayout();
            // 
            // sqlConnection1
            // 
            this.sqlConnection1.ConnectionString = "Data Source=DESKTOP-T003JCT\\SQLEXPRESS;Initial Catalog=Otdel_kadrov;Integrated Se" +
    "curity=True";
            this.sqlConnection1.FireInfoMessageEventOnUserErrors = false;
            // 
            // fill_the_table_comm
            // 
            this.fill_the_table_comm.CommandText = resources.GetString("fill_the_table_comm.CommandText");
            this.fill_the_table_comm.Connection = this.sqlConnection1;
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(16, 327);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(37, 13);
            this.label5.TabIndex = 17;
            this.label5.Text = "ФИО:";
            // 
            // textBox1
            // 
            this.textBox1.Location = new System.Drawing.Point(59, 324);
            this.textBox1.Name = "textBox1";
            this.textBox1.Size = new System.Drawing.Size(233, 20);
            this.textBox1.TabIndex = 16;
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.dismiss_radio);
            this.groupBox1.Controls.Add(this.all_radio);
            this.groupBox1.Controls.Add(this.mission_radio);
            this.groupBox1.Controls.Add(this.medical_radio);
            this.groupBox1.Controls.Add(this.vacation_radio);
            this.groupBox1.Location = new System.Drawing.Point(19, 350);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(500, 88);
            this.groupBox1.TabIndex = 18;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Показать:";
            // 
            // dismiss_radio
            // 
            this.dismiss_radio.AutoSize = true;
            this.dismiss_radio.Location = new System.Drawing.Point(7, 65);
            this.dismiss_radio.Name = "dismiss_radio";
            this.dismiss_radio.Size = new System.Drawing.Size(99, 17);
            this.dismiss_radio.TabIndex = 4;
            this.dismiss_radio.TabStop = true;
            this.dismiss_radio.Text = "на увольнение";
            this.dismiss_radio.UseVisualStyleBackColor = true;
            this.dismiss_radio.CheckedChanged += new System.EventHandler(this.dismiss_radio_CheckedChanged);
            // 
            // all_radio
            // 
            this.all_radio.AutoSize = true;
            this.all_radio.Location = new System.Drawing.Point(155, 65);
            this.all_radio.Name = "all_radio";
            this.all_radio.Size = new System.Drawing.Size(90, 17);
            this.all_radio.TabIndex = 3;
            this.all_radio.TabStop = true;
            this.all_radio.Text = "все приказы";
            this.all_radio.UseVisualStyleBackColor = true;
            this.all_radio.CheckedChanged += new System.EventHandler(this.all_radio_CheckedChanged);
            // 
            // mission_radio
            // 
            this.mission_radio.AutoSize = true;
            this.mission_radio.Location = new System.Drawing.Point(325, 19);
            this.mission_radio.Name = "mission_radio";
            this.mission_radio.Size = new System.Drawing.Size(160, 17);
            this.mission_radio.TabIndex = 2;
            this.mission_radio.TabStop = true;
            this.mission_radio.Text = "приказы на командировку";
            this.mission_radio.UseVisualStyleBackColor = true;
            this.mission_radio.CheckedChanged += new System.EventHandler(this.mission_radio_CheckedChanged);
            // 
            // medical_radio
            // 
            this.medical_radio.AutoSize = true;
            this.medical_radio.Location = new System.Drawing.Point(155, 19);
            this.medical_radio.Name = "medical_radio";
            this.medical_radio.Size = new System.Drawing.Size(148, 17);
            this.medical_radio.TabIndex = 1;
            this.medical_radio.TabStop = true;
            this.medical_radio.Text = "приказы на больничный";
            this.medical_radio.UseVisualStyleBackColor = true;
            this.medical_radio.CheckedChanged += new System.EventHandler(this.medical_radio_CheckedChanged);
            // 
            // vacation_radio
            // 
            this.vacation_radio.AutoSize = true;
            this.vacation_radio.Location = new System.Drawing.Point(6, 19);
            this.vacation_radio.Name = "vacation_radio";
            this.vacation_radio.Size = new System.Drawing.Size(121, 17);
            this.vacation_radio.TabIndex = 0;
            this.vacation_radio.TabStop = true;
            this.vacation_radio.Text = "приказы на отпуск";
            this.vacation_radio.UseVisualStyleBackColor = true;
            this.vacation_radio.CheckedChanged += new System.EventHandler(this.vacation_radio_CheckedChanged);
            // 
            // orderBindingSource
            // 
            this.orderBindingSource.DataMember = "Order";
            this.orderBindingSource.DataSource = this.otdel_kadrovDataSet;
            // 
            // otdel_kadrovDataSet
            // 
            this.otdel_kadrovDataSet.DataSetName = "Otdel_kadrovDataSet";
            this.otdel_kadrovDataSet.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
            // 
            // orderTableAdapter
            // 
            this.orderTableAdapter.ClearBeforeFill = true;
            // 
            // find_button
            // 
            this.find_button.Location = new System.Drawing.Point(294, 322);
            this.find_button.Name = "find_button";
            this.find_button.Size = new System.Drawing.Size(225, 23);
            this.find_button.TabIndex = 21;
            this.find_button.Text = "Найти";
            this.find_button.UseVisualStyleBackColor = true;
            this.find_button.Click += new System.EventHandler(this.find_button_Click);
            // 
            // tableAdapterManager
            // 
            this.tableAdapterManager.BackupDataSetBeforeUpdate = false;
            this.tableAdapterManager.DepTableAdapter = null;
            this.tableAdapterManager.MedicalTableAdapter = null;
            this.tableAdapterManager.MissionTableAdapter = null;
            this.tableAdapterManager.OrderTableAdapter = this.orderTableAdapter;
            this.tableAdapterManager.StaffListTableAdapter = null;
            this.tableAdapterManager.StatementTableAdapter = null;
            this.tableAdapterManager.UpdateOrder = Personnel_Department.Otdel_kadrovDataSetTableAdapters.TableAdapterManager.UpdateOrderOption.InsertUpdateDelete;
            this.tableAdapterManager.VacationTableAdapter = null;
            this.tableAdapterManager.WorkerTableAdapter = null;
            // 
            // orderDataGridView
            // 
            this.orderDataGridView.AutoGenerateColumns = false;
            this.orderDataGridView.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.AllCells;
            this.orderDataGridView.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.orderDataGridView.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.numorderDataGridViewTextBoxColumn,
            this.fIOworkerDataGridViewTextBoxColumn,
            this.typeorderDataGridViewTextBoxColumn,
            this.dataorderDataGridViewTextBoxColumn});
            this.orderDataGridView.DataSource = this.orderBindingSource;
            this.orderDataGridView.Location = new System.Drawing.Point(2, 12);
            this.orderDataGridView.Name = "orderDataGridView";
            this.orderDataGridView.ReadOnly = true;
            this.orderDataGridView.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.orderDataGridView.Size = new System.Drawing.Size(517, 306);
            this.orderDataGridView.TabIndex = 21;
            // 
            // numorderDataGridViewTextBoxColumn
            // 
            this.numorderDataGridViewTextBoxColumn.DataPropertyName = "Num_order";
            this.numorderDataGridViewTextBoxColumn.HeaderText = "Номер приказа";
            this.numorderDataGridViewTextBoxColumn.Name = "numorderDataGridViewTextBoxColumn";
            this.numorderDataGridViewTextBoxColumn.ReadOnly = true;
            this.numorderDataGridViewTextBoxColumn.Width = 102;
            // 
            // fIOworkerDataGridViewTextBoxColumn
            // 
            this.fIOworkerDataGridViewTextBoxColumn.DataPropertyName = "FIO_worker";
            this.fIOworkerDataGridViewTextBoxColumn.HeaderText = "Фио работника";
            this.fIOworkerDataGridViewTextBoxColumn.Name = "fIOworkerDataGridViewTextBoxColumn";
            this.fIOworkerDataGridViewTextBoxColumn.ReadOnly = true;
            this.fIOworkerDataGridViewTextBoxColumn.Width = 102;
            // 
            // typeorderDataGridViewTextBoxColumn
            // 
            this.typeorderDataGridViewTextBoxColumn.DataPropertyName = "Type_order";
            this.typeorderDataGridViewTextBoxColumn.HeaderText = "Тип приказа";
            this.typeorderDataGridViewTextBoxColumn.Name = "typeorderDataGridViewTextBoxColumn";
            this.typeorderDataGridViewTextBoxColumn.ReadOnly = true;
            this.typeorderDataGridViewTextBoxColumn.Width = 88;
            // 
            // dataorderDataGridViewTextBoxColumn
            // 
            this.dataorderDataGridViewTextBoxColumn.DataPropertyName = "Data_order";
            this.dataorderDataGridViewTextBoxColumn.HeaderText = "Дата приказа";
            this.dataorderDataGridViewTextBoxColumn.Name = "dataorderDataGridViewTextBoxColumn";
            this.dataorderDataGridViewTextBoxColumn.ReadOnly = true;
            this.dataorderDataGridViewTextBoxColumn.Width = 95;
            // 
            // Orders_list
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.ActiveCaption;
            this.ClientSize = new System.Drawing.Size(530, 458);
            this.Controls.Add(this.orderDataGridView);
            this.Controls.Add(this.find_button);
            this.Controls.Add(this.groupBox1);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.textBox1);
            this.Name = "Orders_list";
            this.Text = "Список приказов";
            this.Load += new System.EventHandler(this.Orders_list_Load);
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.orderBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.otdel_kadrovDataSet)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.orderDataGridView)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private System.Data.SqlClient.SqlConnection sqlConnection1;
        private System.Data.SqlClient.SqlCommand fill_the_table_comm;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.TextBox textBox1;
        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.RadioButton mission_radio;
        private System.Windows.Forms.RadioButton medical_radio;
        private System.Windows.Forms.RadioButton vacation_radio;
        private System.Windows.Forms.RadioButton all_radio;
        private Otdel_kadrovDataSet otdel_kadrovDataSet;
        private System.Windows.Forms.BindingSource orderBindingSource;
        private Otdel_kadrovDataSetTableAdapters.OrderTableAdapter orderTableAdapter;
        private System.Windows.Forms.DataGridViewTextBoxColumn iDworkerDataGridViewTextBoxColumn;
        private System.Windows.Forms.RadioButton dismiss_radio;
        private System.Windows.Forms.Button find_button;
        private Otdel_kadrovDataSetTableAdapters.TableAdapterManager tableAdapterManager;
        private System.Windows.Forms.DataGridView orderDataGridView;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn1;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn2;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn3;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn4;
        private System.Windows.Forms.DataGridViewTextBoxColumn numorderDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn fIOworkerDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn typeorderDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataorderDataGridViewTextBoxColumn;
    }
}