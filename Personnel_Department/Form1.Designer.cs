namespace Personnel_Department
{
    partial class List_Of_Workers
    {
        /// <summary>
        /// Обязательная переменная конструктора.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Освободить все используемые ресурсы.
        /// </summary>
        /// <param name="disposing">истинно, если управляемый ресурс должен быть удален; иначе ложно.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Код, автоматически созданный конструктором форм Windows

        /// <summary>
        /// Требуемый метод для поддержки конструктора — не изменяйте 
        /// содержимое этого метода с помощью редактора кода.
        /// </summary>
        private void InitializeComponent()
        {
            this.components = new System.ComponentModel.Container();
            this.otdel_kadrovDataSet = new Personnel_Department.Otdel_kadrovDataSet();
            this.workerBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.workerTableAdapter = new Personnel_Department.Otdel_kadrovDataSetTableAdapters.WorkerTableAdapter();
            this.tableAdapterManager = new Personnel_Department.Otdel_kadrovDataSetTableAdapters.TableAdapterManager();
            this.workerDataGridView = new System.Windows.Forms.DataGridView();
            this.iDworkerDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.fIOworkerDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.depDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.postnameDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.databirthDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.sexDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.allowanceDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.stageDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.statusDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.workreceptiondateDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dataterminationDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.sort_groupBox = new System.Windows.Forms.GroupBox();
            this.label1 = new System.Windows.Forms.Label();
            this.sort_button = new System.Windows.Forms.Button();
            this.show_women_radio = new System.Windows.Forms.RadioButton();
            this.descending_radioButton = new System.Windows.Forms.RadioButton();
            this.ascending_radioButton = new System.Windows.Forms.RadioButton();
            this.sort_listBox = new System.Windows.Forms.ListBox();
            this.show_men_radio = new System.Windows.Forms.RadioButton();
            this.show_all = new System.Windows.Forms.Button();
            this.label2 = new System.Windows.Forms.Label();
            this.fio_textBox = new System.Windows.Forms.TextBox();
            this.find_button = new System.Windows.Forms.Button();
            this.edit_worker_button = new System.Windows.Forms.Button();
            this.sqlConnection1 = new System.Data.SqlClient.SqlConnection();
            this.fill_the_tabel_command = new System.Data.SqlClient.SqlCommand();
            this.refresh_button = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.otdel_kadrovDataSet)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.workerBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.workerDataGridView)).BeginInit();
            this.sort_groupBox.SuspendLayout();
            this.SuspendLayout();
            // 
            // otdel_kadrovDataSet
            // 
            this.otdel_kadrovDataSet.DataSetName = "Otdel_kadrovDataSet";
            this.otdel_kadrovDataSet.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
            // 
            // workerBindingSource
            // 
            this.workerBindingSource.DataMember = "Worker";
            this.workerBindingSource.DataSource = this.otdel_kadrovDataSet;
            // 
            // workerTableAdapter
            // 
            this.workerTableAdapter.ClearBeforeFill = true;
            // 
            // tableAdapterManager
            // 
            this.tableAdapterManager.BackupDataSetBeforeUpdate = false;
            this.tableAdapterManager.DepTableAdapter = null;
            this.tableAdapterManager.MedicalTableAdapter = null;
            this.tableAdapterManager.MissionTableAdapter = null;
            this.tableAdapterManager.OrderTableAdapter = null;
            this.tableAdapterManager.StaffListTableAdapter = null;
            this.tableAdapterManager.StatementTableAdapter = null;
            this.tableAdapterManager.UpdateOrder = Personnel_Department.Otdel_kadrovDataSetTableAdapters.TableAdapterManager.UpdateOrderOption.InsertUpdateDelete;
            this.tableAdapterManager.VacationTableAdapter = null;
            this.tableAdapterManager.WorkerTableAdapter = this.workerTableAdapter;
            // 
            // workerDataGridView
            // 
            this.workerDataGridView.AllowUserToAddRows = false;
            this.workerDataGridView.AllowUserToDeleteRows = false;
            this.workerDataGridView.AutoGenerateColumns = false;
            this.workerDataGridView.BackgroundColor = System.Drawing.SystemColors.ActiveBorder;
            this.workerDataGridView.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.workerDataGridView.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.iDworkerDataGridViewTextBoxColumn,
            this.fIOworkerDataGridViewTextBoxColumn,
            this.depDataGridViewTextBoxColumn,
            this.postnameDataGridViewTextBoxColumn,
            this.databirthDataGridViewTextBoxColumn,
            this.sexDataGridViewTextBoxColumn,
            this.allowanceDataGridViewTextBoxColumn,
            this.stageDataGridViewTextBoxColumn,
            this.statusDataGridViewTextBoxColumn,
            this.workreceptiondateDataGridViewTextBoxColumn,
            this.dataterminationDataGridViewTextBoxColumn});
            this.workerDataGridView.DataSource = this.workerBindingSource;
            this.workerDataGridView.Location = new System.Drawing.Point(12, 28);
            this.workerDataGridView.Name = "workerDataGridView";
            this.workerDataGridView.ReadOnly = true;
            this.workerDataGridView.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.workerDataGridView.Size = new System.Drawing.Size(1044, 373);
            this.workerDataGridView.TabIndex = 1;
            // 
            // iDworkerDataGridViewTextBoxColumn
            // 
            this.iDworkerDataGridViewTextBoxColumn.DataPropertyName = "ID_worker";
            this.iDworkerDataGridViewTextBoxColumn.HeaderText = "Номер работника";
            this.iDworkerDataGridViewTextBoxColumn.Name = "iDworkerDataGridViewTextBoxColumn";
            this.iDworkerDataGridViewTextBoxColumn.ReadOnly = true;
            // 
            // fIOworkerDataGridViewTextBoxColumn
            // 
            this.fIOworkerDataGridViewTextBoxColumn.DataPropertyName = "FIO_worker";
            this.fIOworkerDataGridViewTextBoxColumn.HeaderText = "ФИО";
            this.fIOworkerDataGridViewTextBoxColumn.Name = "fIOworkerDataGridViewTextBoxColumn";
            this.fIOworkerDataGridViewTextBoxColumn.ReadOnly = true;
            // 
            // depDataGridViewTextBoxColumn
            // 
            this.depDataGridViewTextBoxColumn.DataPropertyName = "Dep";
            this.depDataGridViewTextBoxColumn.HeaderText = "Номер отдела";
            this.depDataGridViewTextBoxColumn.Name = "depDataGridViewTextBoxColumn";
            this.depDataGridViewTextBoxColumn.ReadOnly = true;
            // 
            // postnameDataGridViewTextBoxColumn
            // 
            this.postnameDataGridViewTextBoxColumn.DataPropertyName = "Post_name";
            this.postnameDataGridViewTextBoxColumn.HeaderText = "Должность";
            this.postnameDataGridViewTextBoxColumn.Name = "postnameDataGridViewTextBoxColumn";
            this.postnameDataGridViewTextBoxColumn.ReadOnly = true;
            // 
            // databirthDataGridViewTextBoxColumn
            // 
            this.databirthDataGridViewTextBoxColumn.DataPropertyName = "Data_birth";
            this.databirthDataGridViewTextBoxColumn.HeaderText = "Дата рождения";
            this.databirthDataGridViewTextBoxColumn.Name = "databirthDataGridViewTextBoxColumn";
            this.databirthDataGridViewTextBoxColumn.ReadOnly = true;
            // 
            // sexDataGridViewTextBoxColumn
            // 
            this.sexDataGridViewTextBoxColumn.DataPropertyName = "Sex";
            this.sexDataGridViewTextBoxColumn.HeaderText = "Пол";
            this.sexDataGridViewTextBoxColumn.Name = "sexDataGridViewTextBoxColumn";
            this.sexDataGridViewTextBoxColumn.ReadOnly = true;
            // 
            // allowanceDataGridViewTextBoxColumn
            // 
            this.allowanceDataGridViewTextBoxColumn.DataPropertyName = "Allowance";
            this.allowanceDataGridViewTextBoxColumn.HeaderText = "Надбавка";
            this.allowanceDataGridViewTextBoxColumn.Name = "allowanceDataGridViewTextBoxColumn";
            this.allowanceDataGridViewTextBoxColumn.ReadOnly = true;
            // 
            // stageDataGridViewTextBoxColumn
            // 
            this.stageDataGridViewTextBoxColumn.DataPropertyName = "Stage";
            this.stageDataGridViewTextBoxColumn.HeaderText = "Стаж";
            this.stageDataGridViewTextBoxColumn.Name = "stageDataGridViewTextBoxColumn";
            this.stageDataGridViewTextBoxColumn.ReadOnly = true;
            // 
            // statusDataGridViewTextBoxColumn
            // 
            this.statusDataGridViewTextBoxColumn.DataPropertyName = "Status";
            this.statusDataGridViewTextBoxColumn.HeaderText = "Статус";
            this.statusDataGridViewTextBoxColumn.Name = "statusDataGridViewTextBoxColumn";
            this.statusDataGridViewTextBoxColumn.ReadOnly = true;
            // 
            // workreceptiondateDataGridViewTextBoxColumn
            // 
            this.workreceptiondateDataGridViewTextBoxColumn.DataPropertyName = "Work_reception_date";
            this.workreceptiondateDataGridViewTextBoxColumn.HeaderText = "Дата принятия на работу";
            this.workreceptiondateDataGridViewTextBoxColumn.Name = "workreceptiondateDataGridViewTextBoxColumn";
            this.workreceptiondateDataGridViewTextBoxColumn.ReadOnly = true;
            // 
            // dataterminationDataGridViewTextBoxColumn
            // 
            this.dataterminationDataGridViewTextBoxColumn.DataPropertyName = "Data_termination";
            this.dataterminationDataGridViewTextBoxColumn.HeaderText = "Дата увольнения";
            this.dataterminationDataGridViewTextBoxColumn.Name = "dataterminationDataGridViewTextBoxColumn";
            this.dataterminationDataGridViewTextBoxColumn.ReadOnly = true;
            // 
            // sort_groupBox
            // 
            this.sort_groupBox.Controls.Add(this.label1);
            this.sort_groupBox.Controls.Add(this.sort_button);
            this.sort_groupBox.Controls.Add(this.show_women_radio);
            this.sort_groupBox.Controls.Add(this.descending_radioButton);
            this.sort_groupBox.Controls.Add(this.ascending_radioButton);
            this.sort_groupBox.Controls.Add(this.sort_listBox);
            this.sort_groupBox.Controls.Add(this.show_men_radio);
            this.sort_groupBox.Location = new System.Drawing.Point(1062, 28);
            this.sort_groupBox.Name = "sort_groupBox";
            this.sort_groupBox.Size = new System.Drawing.Size(142, 419);
            this.sort_groupBox.TabIndex = 2;
            this.sort_groupBox.TabStop = false;
            this.sort_groupBox.Text = "Сортировка";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(7, 31);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(116, 13);
            this.label1.TabIndex = 4;
            this.label1.Text = "Поле для сортировки";
            // 
            // sort_button
            // 
            this.sort_button.Enabled = false;
            this.sort_button.Location = new System.Drawing.Point(5, 340);
            this.sort_button.Name = "sort_button";
            this.sort_button.Size = new System.Drawing.Size(130, 23);
            this.sort_button.TabIndex = 3;
            this.sort_button.Text = "Сортировать";
            this.sort_button.UseVisualStyleBackColor = true;
            this.sort_button.Click += new System.EventHandler(this.sort_button_Click);
            // 
            // show_women_radio
            // 
            this.show_women_radio.AutoSize = true;
            this.show_women_radio.Location = new System.Drawing.Point(10, 392);
            this.show_women_radio.Name = "show_women_radio";
            this.show_women_radio.Size = new System.Drawing.Size(118, 17);
            this.show_women_radio.TabIndex = 5;
            this.show_women_radio.TabStop = true;
            this.show_women_radio.Text = "Показать женщин";
            this.show_women_radio.UseVisualStyleBackColor = true;
            this.show_women_radio.CheckedChanged += new System.EventHandler(this.show_women_radio_CheckedChanged);
            // 
            // descending_radioButton
            // 
            this.descending_radioButton.AutoSize = true;
            this.descending_radioButton.Location = new System.Drawing.Point(6, 317);
            this.descending_radioButton.Name = "descending_radioButton";
            this.descending_radioButton.Size = new System.Drawing.Size(93, 17);
            this.descending_radioButton.TabIndex = 2;
            this.descending_radioButton.Text = "По убыванию";
            this.descending_radioButton.UseVisualStyleBackColor = true;
            // 
            // ascending_radioButton
            // 
            this.ascending_radioButton.AutoSize = true;
            this.ascending_radioButton.Checked = true;
            this.ascending_radioButton.Location = new System.Drawing.Point(7, 294);
            this.ascending_radioButton.Name = "ascending_radioButton";
            this.ascending_radioButton.Size = new System.Drawing.Size(109, 17);
            this.ascending_radioButton.TabIndex = 1;
            this.ascending_radioButton.TabStop = true;
            this.ascending_radioButton.Text = "По возрастанию";
            this.ascending_radioButton.UseVisualStyleBackColor = true;
            // 
            // sort_listBox
            // 
            this.sort_listBox.FormattingEnabled = true;
            this.sort_listBox.Items.AddRange(new object[] {
            "ФИО",
            "Дата рождения",
            "Надбавка",
            "Стаж",
            "Дата принятия"});
            this.sort_listBox.Location = new System.Drawing.Point(5, 50);
            this.sort_listBox.Name = "sort_listBox";
            this.sort_listBox.Size = new System.Drawing.Size(130, 238);
            this.sort_listBox.TabIndex = 0;
            this.sort_listBox.SelectedIndexChanged += new System.EventHandler(this.sort_listBox_SelectedIndexChanged);
            // 
            // show_men_radio
            // 
            this.show_men_radio.AutoSize = true;
            this.show_men_radio.Location = new System.Drawing.Point(10, 369);
            this.show_men_radio.Name = "show_men_radio";
            this.show_men_radio.Size = new System.Drawing.Size(115, 17);
            this.show_men_radio.TabIndex = 4;
            this.show_men_radio.TabStop = true;
            this.show_men_radio.Text = "Показать мужчин";
            this.show_men_radio.UseVisualStyleBackColor = true;
            this.show_men_radio.CheckedChanged += new System.EventHandler(this.show_men_radio_CheckedChanged);
            // 
            // show_all
            // 
            this.show_all.Location = new System.Drawing.Point(520, 407);
            this.show_all.Name = "show_all";
            this.show_all.Size = new System.Drawing.Size(143, 23);
            this.show_all.TabIndex = 3;
            this.show_all.Text = "Показать все";
            this.show_all.UseVisualStyleBackColor = true;
            this.show_all.Click += new System.EventHandler(this.show_all_Click);
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(12, 411);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(37, 13);
            this.label2.TabIndex = 6;
            this.label2.Text = "ФИО:";
            // 
            // fio_textBox
            // 
            this.fio_textBox.Location = new System.Drawing.Point(55, 409);
            this.fio_textBox.Name = "fio_textBox";
            this.fio_textBox.Size = new System.Drawing.Size(311, 20);
            this.fio_textBox.TabIndex = 7;
            // 
            // find_button
            // 
            this.find_button.Location = new System.Drawing.Point(372, 407);
            this.find_button.Name = "find_button";
            this.find_button.Size = new System.Drawing.Size(142, 23);
            this.find_button.TabIndex = 8;
            this.find_button.Text = "Найти";
            this.find_button.UseVisualStyleBackColor = true;
            this.find_button.Click += new System.EventHandler(this.find_button_Click);
            // 
            // edit_worker_button
            // 
            this.edit_worker_button.Location = new System.Drawing.Point(669, 407);
            this.edit_worker_button.Name = "edit_worker_button";
            this.edit_worker_button.Size = new System.Drawing.Size(224, 23);
            this.edit_worker_button.TabIndex = 9;
            this.edit_worker_button.Text = "Редактировать данные о сотруднике";
            this.edit_worker_button.UseVisualStyleBackColor = true;
            this.edit_worker_button.Click += new System.EventHandler(this.edit_worker_button_Click);
            // 
            // sqlConnection1
            // 
            this.sqlConnection1.ConnectionString = "Data Source=DESKTOP-T003JCT\\SQLEXPRESS;Initial Catalog=Otdel_kadrov;Integrated Se" +
    "curity=True";
            this.sqlConnection1.FireInfoMessageEventOnUserErrors = false;
            // 
            // fill_the_tabel_command
            // 
            this.fill_the_tabel_command.Connection = this.sqlConnection1;
            // 
            // refresh_button
            // 
            this.refresh_button.Location = new System.Drawing.Point(899, 407);
            this.refresh_button.Name = "refresh_button";
            this.refresh_button.Size = new System.Drawing.Size(156, 23);
            this.refresh_button.TabIndex = 10;
            this.refresh_button.Text = "Обновить таблицу";
            this.refresh_button.UseVisualStyleBackColor = true;
            this.refresh_button.Click += new System.EventHandler(this.refresh_button_Click);
            // 
            // List_Of_Workers
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.ActiveCaption;
            this.ClientSize = new System.Drawing.Size(1210, 452);
            this.Controls.Add(this.refresh_button);
            this.Controls.Add(this.edit_worker_button);
            this.Controls.Add(this.find_button);
            this.Controls.Add(this.fio_textBox);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.show_all);
            this.Controls.Add(this.sort_groupBox);
            this.Controls.Add(this.workerDataGridView);
            this.Name = "List_Of_Workers";
            this.Text = "Список сотрудников";
            this.Load += new System.EventHandler(this.List_Of_Workers_Load);
            ((System.ComponentModel.ISupportInitialize)(this.otdel_kadrovDataSet)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.workerBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.workerDataGridView)).EndInit();
            this.sort_groupBox.ResumeLayout(false);
            this.sort_groupBox.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private Otdel_kadrovDataSet otdel_kadrovDataSet;
        private System.Windows.Forms.BindingSource workerBindingSource;
        private Otdel_kadrovDataSetTableAdapters.WorkerTableAdapter workerTableAdapter;
        private Otdel_kadrovDataSetTableAdapters.TableAdapterManager tableAdapterManager;
        private System.Windows.Forms.DataGridView workerDataGridView;
        private System.Windows.Forms.GroupBox sort_groupBox;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Button sort_button;
        private System.Windows.Forms.RadioButton descending_radioButton;
        private System.Windows.Forms.RadioButton ascending_radioButton;
        private System.Windows.Forms.ListBox sort_listBox;
        private System.Windows.Forms.Button show_all;
        private System.Windows.Forms.RadioButton show_men_radio;
        private System.Windows.Forms.RadioButton show_women_radio;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.TextBox fio_textBox;
        private System.Windows.Forms.Button find_button;
        private System.Windows.Forms.Button edit_worker_button;
        private System.Data.SqlClient.SqlConnection sqlConnection1;
        private System.Data.SqlClient.SqlCommand fill_the_tabel_command;
        private System.Windows.Forms.DataGridViewTextBoxColumn iDworkerDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn fIOworkerDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn depDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn postnameDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn databirthDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn sexDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn allowanceDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn stageDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn statusDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn workreceptiondateDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataterminationDataGridViewTextBoxColumn;
        private System.Windows.Forms.Button refresh_button;
    }
}

