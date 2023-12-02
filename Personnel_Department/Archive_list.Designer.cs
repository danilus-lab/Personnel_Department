namespace Personnel_Department
{
    partial class Archive_list
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
            this.archiveDataGridView = new System.Windows.Forms.DataGridView();
            this.archiveBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.otdel_kadrovDataSet = new Personnel_Department.Otdel_kadrovDataSet();
            this.archiveTableAdapter = new Personnel_Department.Otdel_kadrovDataSetTableAdapters.ArchiveTableAdapter();
            this.tableAdapterManager = new Personnel_Department.Otdel_kadrovDataSetTableAdapters.TableAdapterManager();
            this.dataGridViewTextBoxColumn1 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.FIO_worker = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dataGridViewTextBoxColumn2 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dataGridViewTextBoxColumn3 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            ((System.ComponentModel.ISupportInitialize)(this.archiveDataGridView)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.archiveBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.otdel_kadrovDataSet)).BeginInit();
            this.SuspendLayout();
            // 
            // archiveDataGridView
            // 
            this.archiveDataGridView.AutoGenerateColumns = false;
            this.archiveDataGridView.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.AllCells;
            this.archiveDataGridView.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.archiveDataGridView.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.dataGridViewTextBoxColumn1,
            this.FIO_worker,
            this.dataGridViewTextBoxColumn2,
            this.dataGridViewTextBoxColumn3});
            this.archiveDataGridView.DataSource = this.archiveBindingSource;
            this.archiveDataGridView.Location = new System.Drawing.Point(12, 12);
            this.archiveDataGridView.Name = "archiveDataGridView";
            this.archiveDataGridView.ReadOnly = true;
            this.archiveDataGridView.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.archiveDataGridView.Size = new System.Drawing.Size(474, 426);
            this.archiveDataGridView.TabIndex = 1;
            // 
            // archiveBindingSource
            // 
            this.archiveBindingSource.DataMember = "Archive";
            this.archiveBindingSource.DataSource = this.otdel_kadrovDataSet;
            // 
            // otdel_kadrovDataSet
            // 
            this.otdel_kadrovDataSet.DataSetName = "Otdel_kadrovDataSet";
            this.otdel_kadrovDataSet.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
            // 
            // archiveTableAdapter
            // 
            this.archiveTableAdapter.ClearBeforeFill = true;
            // 
            // tableAdapterManager
            // 
            this.tableAdapterManager.BackupDataSetBeforeUpdate = false;
            this.tableAdapterManager.Connection = null;
            this.tableAdapterManager.DepTableAdapter = null;
            this.tableAdapterManager.MedicalTableAdapter = null;
            this.tableAdapterManager.MissionTableAdapter = null;
            this.tableAdapterManager.OrderTableAdapter = null;
            this.tableAdapterManager.StaffListTableAdapter = null;
            this.tableAdapterManager.StatementTableAdapter = null;
            this.tableAdapterManager.UpdateOrder = Personnel_Department.Otdel_kadrovDataSetTableAdapters.TableAdapterManager.UpdateOrderOption.InsertUpdateDelete;
            this.tableAdapterManager.VacationTableAdapter = null;
            this.tableAdapterManager.WorkerTableAdapter = null;
            // 
            // dataGridViewTextBoxColumn1
            // 
            this.dataGridViewTextBoxColumn1.DataPropertyName = "Num_order";
            this.dataGridViewTextBoxColumn1.HeaderText = "Номер приказа";
            this.dataGridViewTextBoxColumn1.Name = "dataGridViewTextBoxColumn1";
            this.dataGridViewTextBoxColumn1.ReadOnly = true;
            this.dataGridViewTextBoxColumn1.Width = 102;
            // 
            // FIO_worker
            // 
            this.FIO_worker.DataPropertyName = "FIO_worker";
            this.FIO_worker.HeaderText = "ФИО";
            this.FIO_worker.Name = "FIO_worker";
            this.FIO_worker.ReadOnly = true;
            this.FIO_worker.Width = 59;
            // 
            // dataGridViewTextBoxColumn2
            // 
            this.dataGridViewTextBoxColumn2.DataPropertyName = "Type_order";
            this.dataGridViewTextBoxColumn2.HeaderText = "Тип приказа";
            this.dataGridViewTextBoxColumn2.Name = "dataGridViewTextBoxColumn2";
            this.dataGridViewTextBoxColumn2.ReadOnly = true;
            this.dataGridViewTextBoxColumn2.Width = 88;
            // 
            // dataGridViewTextBoxColumn3
            // 
            this.dataGridViewTextBoxColumn3.DataPropertyName = "Data_order";
            this.dataGridViewTextBoxColumn3.HeaderText = "Дата приказа";
            this.dataGridViewTextBoxColumn3.Name = "dataGridViewTextBoxColumn3";
            this.dataGridViewTextBoxColumn3.ReadOnly = true;
            this.dataGridViewTextBoxColumn3.Width = 95;
            // 
            // Archive_list
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.ActiveCaption;
            this.ClientSize = new System.Drawing.Size(496, 450);
            this.Controls.Add(this.archiveDataGridView);
            this.Name = "Archive_list";
            this.Text = "Архив приказов";
            this.Load += new System.EventHandler(this.Archive_list_Load);
            ((System.ComponentModel.ISupportInitialize)(this.archiveDataGridView)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.archiveBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.otdel_kadrovDataSet)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private Otdel_kadrovDataSet otdel_kadrovDataSet;
        private System.Windows.Forms.BindingSource archiveBindingSource;
        private Otdel_kadrovDataSetTableAdapters.ArchiveTableAdapter archiveTableAdapter;
        private Otdel_kadrovDataSetTableAdapters.TableAdapterManager tableAdapterManager;
        private System.Windows.Forms.DataGridView archiveDataGridView;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn1;
        private System.Windows.Forms.DataGridViewTextBoxColumn FIO_worker;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn2;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn3;
    }
}