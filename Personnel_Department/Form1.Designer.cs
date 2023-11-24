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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(List_Of_Workers));
            this.otdel_kadrovDataSet = new Personnel_Department.Otdel_kadrovDataSet();
            this.workerBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.workerTableAdapter = new Personnel_Department.Otdel_kadrovDataSetTableAdapters.WorkerTableAdapter();
            this.tableAdapterManager = new Personnel_Department.Otdel_kadrovDataSetTableAdapters.TableAdapterManager();
            this.workerBindingNavigator = new System.Windows.Forms.BindingNavigator(this.components);
            this.bindingNavigatorAddNewItem = new System.Windows.Forms.ToolStripButton();
            this.bindingNavigatorCountItem = new System.Windows.Forms.ToolStripLabel();
            this.bindingNavigatorDeleteItem = new System.Windows.Forms.ToolStripButton();
            this.bindingNavigatorMoveFirstItem = new System.Windows.Forms.ToolStripButton();
            this.bindingNavigatorMovePreviousItem = new System.Windows.Forms.ToolStripButton();
            this.bindingNavigatorSeparator = new System.Windows.Forms.ToolStripSeparator();
            this.bindingNavigatorPositionItem = new System.Windows.Forms.ToolStripTextBox();
            this.bindingNavigatorSeparator1 = new System.Windows.Forms.ToolStripSeparator();
            this.bindingNavigatorMoveNextItem = new System.Windows.Forms.ToolStripButton();
            this.bindingNavigatorMoveLastItem = new System.Windows.Forms.ToolStripButton();
            this.bindingNavigatorSeparator2 = new System.Windows.Forms.ToolStripSeparator();
            this.workerBindingNavigatorSaveItem = new System.Windows.Forms.ToolStripButton();
            this.workerDataGridView = new System.Windows.Forms.DataGridView();
            this.dataGridViewTextBoxColumn2 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dataGridViewTextBoxColumn3 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dataGridViewTextBoxColumn4 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dataGridViewTextBoxColumn5 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dataGridViewTextBoxColumn6 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dataGridViewTextBoxColumn7 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dataGridViewTextBoxColumn8 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dataGridViewTextBoxColumn9 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dataGridViewTextBoxColumn10 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dataGridViewTextBoxColumn11 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.sort_groupBox = new System.Windows.Forms.GroupBox();
            this.label1 = new System.Windows.Forms.Label();
            this.sort_button = new System.Windows.Forms.Button();
            this.descending_radioButton = new System.Windows.Forms.RadioButton();
            this.ascending_radioButton = new System.Windows.Forms.RadioButton();
            this.sort_listBox = new System.Windows.Forms.ListBox();
            this.show_all = new System.Windows.Forms.Button();
            this.show_men_radio = new System.Windows.Forms.RadioButton();
            this.show_women_radio = new System.Windows.Forms.RadioButton();
            this.label2 = new System.Windows.Forms.Label();
            this.fio_textBox = new System.Windows.Forms.TextBox();
            this.find_button = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.otdel_kadrovDataSet)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.workerBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.workerBindingNavigator)).BeginInit();
            this.workerBindingNavigator.SuspendLayout();
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
            // workerBindingNavigator
            // 
            this.workerBindingNavigator.AddNewItem = this.bindingNavigatorAddNewItem;
            this.workerBindingNavigator.BindingSource = this.workerBindingSource;
            this.workerBindingNavigator.CountItem = this.bindingNavigatorCountItem;
            this.workerBindingNavigator.DeleteItem = this.bindingNavigatorDeleteItem;
            this.workerBindingNavigator.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.bindingNavigatorMoveFirstItem,
            this.bindingNavigatorMovePreviousItem,
            this.bindingNavigatorSeparator,
            this.bindingNavigatorPositionItem,
            this.bindingNavigatorCountItem,
            this.bindingNavigatorSeparator1,
            this.bindingNavigatorMoveNextItem,
            this.bindingNavigatorMoveLastItem,
            this.bindingNavigatorSeparator2,
            this.bindingNavigatorAddNewItem,
            this.bindingNavigatorDeleteItem,
            this.workerBindingNavigatorSaveItem});
            this.workerBindingNavigator.Location = new System.Drawing.Point(0, 0);
            this.workerBindingNavigator.MoveFirstItem = this.bindingNavigatorMoveFirstItem;
            this.workerBindingNavigator.MoveLastItem = this.bindingNavigatorMoveLastItem;
            this.workerBindingNavigator.MoveNextItem = this.bindingNavigatorMoveNextItem;
            this.workerBindingNavigator.MovePreviousItem = this.bindingNavigatorMovePreviousItem;
            this.workerBindingNavigator.Name = "workerBindingNavigator";
            this.workerBindingNavigator.PositionItem = this.bindingNavigatorPositionItem;
            this.workerBindingNavigator.Size = new System.Drawing.Size(1210, 25);
            this.workerBindingNavigator.TabIndex = 0;
            this.workerBindingNavigator.Text = "bindingNavigator1";
            // 
            // bindingNavigatorAddNewItem
            // 
            this.bindingNavigatorAddNewItem.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
            this.bindingNavigatorAddNewItem.Image = ((System.Drawing.Image)(resources.GetObject("bindingNavigatorAddNewItem.Image")));
            this.bindingNavigatorAddNewItem.Name = "bindingNavigatorAddNewItem";
            this.bindingNavigatorAddNewItem.RightToLeftAutoMirrorImage = true;
            this.bindingNavigatorAddNewItem.Size = new System.Drawing.Size(23, 22);
            this.bindingNavigatorAddNewItem.Text = "Добавить";
            // 
            // bindingNavigatorCountItem
            // 
            this.bindingNavigatorCountItem.Name = "bindingNavigatorCountItem";
            this.bindingNavigatorCountItem.Size = new System.Drawing.Size(43, 22);
            this.bindingNavigatorCountItem.Text = "для {0}";
            this.bindingNavigatorCountItem.ToolTipText = "Общее число элементов";
            // 
            // bindingNavigatorDeleteItem
            // 
            this.bindingNavigatorDeleteItem.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
            this.bindingNavigatorDeleteItem.Image = ((System.Drawing.Image)(resources.GetObject("bindingNavigatorDeleteItem.Image")));
            this.bindingNavigatorDeleteItem.Name = "bindingNavigatorDeleteItem";
            this.bindingNavigatorDeleteItem.RightToLeftAutoMirrorImage = true;
            this.bindingNavigatorDeleteItem.Size = new System.Drawing.Size(23, 22);
            this.bindingNavigatorDeleteItem.Text = "Удалить";
            // 
            // bindingNavigatorMoveFirstItem
            // 
            this.bindingNavigatorMoveFirstItem.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
            this.bindingNavigatorMoveFirstItem.Image = ((System.Drawing.Image)(resources.GetObject("bindingNavigatorMoveFirstItem.Image")));
            this.bindingNavigatorMoveFirstItem.Name = "bindingNavigatorMoveFirstItem";
            this.bindingNavigatorMoveFirstItem.RightToLeftAutoMirrorImage = true;
            this.bindingNavigatorMoveFirstItem.Size = new System.Drawing.Size(23, 22);
            this.bindingNavigatorMoveFirstItem.Text = "Переместить в начало";
            // 
            // bindingNavigatorMovePreviousItem
            // 
            this.bindingNavigatorMovePreviousItem.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
            this.bindingNavigatorMovePreviousItem.Image = ((System.Drawing.Image)(resources.GetObject("bindingNavigatorMovePreviousItem.Image")));
            this.bindingNavigatorMovePreviousItem.Name = "bindingNavigatorMovePreviousItem";
            this.bindingNavigatorMovePreviousItem.RightToLeftAutoMirrorImage = true;
            this.bindingNavigatorMovePreviousItem.Size = new System.Drawing.Size(23, 22);
            this.bindingNavigatorMovePreviousItem.Text = "Переместить назад";
            // 
            // bindingNavigatorSeparator
            // 
            this.bindingNavigatorSeparator.Name = "bindingNavigatorSeparator";
            this.bindingNavigatorSeparator.Size = new System.Drawing.Size(6, 25);
            // 
            // bindingNavigatorPositionItem
            // 
            this.bindingNavigatorPositionItem.AccessibleName = "Положение";
            this.bindingNavigatorPositionItem.AutoSize = false;
            this.bindingNavigatorPositionItem.Font = new System.Drawing.Font("Segoe UI", 9F);
            this.bindingNavigatorPositionItem.Name = "bindingNavigatorPositionItem";
            this.bindingNavigatorPositionItem.Size = new System.Drawing.Size(50, 23);
            this.bindingNavigatorPositionItem.Text = "0";
            this.bindingNavigatorPositionItem.ToolTipText = "Текущее положение";
            // 
            // bindingNavigatorSeparator1
            // 
            this.bindingNavigatorSeparator1.Name = "bindingNavigatorSeparator1";
            this.bindingNavigatorSeparator1.Size = new System.Drawing.Size(6, 25);
            // 
            // bindingNavigatorMoveNextItem
            // 
            this.bindingNavigatorMoveNextItem.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
            this.bindingNavigatorMoveNextItem.Image = ((System.Drawing.Image)(resources.GetObject("bindingNavigatorMoveNextItem.Image")));
            this.bindingNavigatorMoveNextItem.Name = "bindingNavigatorMoveNextItem";
            this.bindingNavigatorMoveNextItem.RightToLeftAutoMirrorImage = true;
            this.bindingNavigatorMoveNextItem.Size = new System.Drawing.Size(23, 22);
            this.bindingNavigatorMoveNextItem.Text = "Переместить вперед";
            // 
            // bindingNavigatorMoveLastItem
            // 
            this.bindingNavigatorMoveLastItem.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
            this.bindingNavigatorMoveLastItem.Image = ((System.Drawing.Image)(resources.GetObject("bindingNavigatorMoveLastItem.Image")));
            this.bindingNavigatorMoveLastItem.Name = "bindingNavigatorMoveLastItem";
            this.bindingNavigatorMoveLastItem.RightToLeftAutoMirrorImage = true;
            this.bindingNavigatorMoveLastItem.Size = new System.Drawing.Size(23, 22);
            this.bindingNavigatorMoveLastItem.Text = "Переместить в конец";
            // 
            // bindingNavigatorSeparator2
            // 
            this.bindingNavigatorSeparator2.Name = "bindingNavigatorSeparator2";
            this.bindingNavigatorSeparator2.Size = new System.Drawing.Size(6, 25);
            // 
            // workerBindingNavigatorSaveItem
            // 
            this.workerBindingNavigatorSaveItem.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
            this.workerBindingNavigatorSaveItem.Image = ((System.Drawing.Image)(resources.GetObject("workerBindingNavigatorSaveItem.Image")));
            this.workerBindingNavigatorSaveItem.Name = "workerBindingNavigatorSaveItem";
            this.workerBindingNavigatorSaveItem.Size = new System.Drawing.Size(23, 22);
            this.workerBindingNavigatorSaveItem.Text = "Сохранить данные";
            this.workerBindingNavigatorSaveItem.Click += new System.EventHandler(this.workerBindingNavigatorSaveItem_Click);
            // 
            // workerDataGridView
            // 
            this.workerDataGridView.AutoGenerateColumns = false;
            this.workerDataGridView.BackgroundColor = System.Drawing.SystemColors.ActiveBorder;
            this.workerDataGridView.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.workerDataGridView.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.dataGridViewTextBoxColumn2,
            this.dataGridViewTextBoxColumn3,
            this.dataGridViewTextBoxColumn4,
            this.dataGridViewTextBoxColumn5,
            this.dataGridViewTextBoxColumn6,
            this.dataGridViewTextBoxColumn7,
            this.dataGridViewTextBoxColumn8,
            this.dataGridViewTextBoxColumn9,
            this.dataGridViewTextBoxColumn10,
            this.dataGridViewTextBoxColumn11});
            this.workerDataGridView.DataSource = this.workerBindingSource;
            this.workerDataGridView.Location = new System.Drawing.Point(12, 28);
            this.workerDataGridView.Name = "workerDataGridView";
            this.workerDataGridView.Size = new System.Drawing.Size(1044, 373);
            this.workerDataGridView.TabIndex = 1;
            // 
            // dataGridViewTextBoxColumn2
            // 
            this.dataGridViewTextBoxColumn2.DataPropertyName = "FIO_worker";
            this.dataGridViewTextBoxColumn2.HeaderText = "ФИО";
            this.dataGridViewTextBoxColumn2.Name = "dataGridViewTextBoxColumn2";
            // 
            // dataGridViewTextBoxColumn3
            // 
            this.dataGridViewTextBoxColumn3.DataPropertyName = "Dep";
            this.dataGridViewTextBoxColumn3.HeaderText = "Отдел";
            this.dataGridViewTextBoxColumn3.Name = "dataGridViewTextBoxColumn3";
            // 
            // dataGridViewTextBoxColumn4
            // 
            this.dataGridViewTextBoxColumn4.DataPropertyName = "Post_name";
            this.dataGridViewTextBoxColumn4.HeaderText = "Должность";
            this.dataGridViewTextBoxColumn4.Name = "dataGridViewTextBoxColumn4";
            // 
            // dataGridViewTextBoxColumn5
            // 
            this.dataGridViewTextBoxColumn5.DataPropertyName = "Data_birth";
            this.dataGridViewTextBoxColumn5.HeaderText = "Дата рождения";
            this.dataGridViewTextBoxColumn5.Name = "dataGridViewTextBoxColumn5";
            // 
            // dataGridViewTextBoxColumn6
            // 
            this.dataGridViewTextBoxColumn6.DataPropertyName = "Sex";
            this.dataGridViewTextBoxColumn6.HeaderText = "Пол";
            this.dataGridViewTextBoxColumn6.Name = "dataGridViewTextBoxColumn6";
            // 
            // dataGridViewTextBoxColumn7
            // 
            this.dataGridViewTextBoxColumn7.DataPropertyName = "Allowance";
            this.dataGridViewTextBoxColumn7.HeaderText = "Надбавка";
            this.dataGridViewTextBoxColumn7.Name = "dataGridViewTextBoxColumn7";
            // 
            // dataGridViewTextBoxColumn8
            // 
            this.dataGridViewTextBoxColumn8.DataPropertyName = "Stage";
            this.dataGridViewTextBoxColumn8.HeaderText = "Стаж";
            this.dataGridViewTextBoxColumn8.Name = "dataGridViewTextBoxColumn8";
            // 
            // dataGridViewTextBoxColumn9
            // 
            this.dataGridViewTextBoxColumn9.DataPropertyName = "Status";
            this.dataGridViewTextBoxColumn9.HeaderText = "Статус";
            this.dataGridViewTextBoxColumn9.Name = "dataGridViewTextBoxColumn9";
            // 
            // dataGridViewTextBoxColumn10
            // 
            this.dataGridViewTextBoxColumn10.DataPropertyName = "Work_reception_date";
            this.dataGridViewTextBoxColumn10.HeaderText = "Дата принятия на работу";
            this.dataGridViewTextBoxColumn10.Name = "dataGridViewTextBoxColumn10";
            // 
            // dataGridViewTextBoxColumn11
            // 
            this.dataGridViewTextBoxColumn11.DataPropertyName = "Data_termination";
            this.dataGridViewTextBoxColumn11.HeaderText = "Дата увольнения";
            this.dataGridViewTextBoxColumn11.Name = "dataGridViewTextBoxColumn11";
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
            // List_Of_Workers
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.ActiveCaption;
            this.ClientSize = new System.Drawing.Size(1210, 452);
            this.Controls.Add(this.find_button);
            this.Controls.Add(this.fio_textBox);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.show_all);
            this.Controls.Add(this.sort_groupBox);
            this.Controls.Add(this.workerDataGridView);
            this.Controls.Add(this.workerBindingNavigator);
            this.Name = "List_Of_Workers";
            this.Text = "Список сотрудников";
            this.Load += new System.EventHandler(this.List_Of_Workers_Load);
            ((System.ComponentModel.ISupportInitialize)(this.otdel_kadrovDataSet)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.workerBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.workerBindingNavigator)).EndInit();
            this.workerBindingNavigator.ResumeLayout(false);
            this.workerBindingNavigator.PerformLayout();
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
        private System.Windows.Forms.BindingNavigator workerBindingNavigator;
        private System.Windows.Forms.ToolStripButton bindingNavigatorAddNewItem;
        private System.Windows.Forms.ToolStripLabel bindingNavigatorCountItem;
        private System.Windows.Forms.ToolStripButton bindingNavigatorDeleteItem;
        private System.Windows.Forms.ToolStripButton bindingNavigatorMoveFirstItem;
        private System.Windows.Forms.ToolStripButton bindingNavigatorMovePreviousItem;
        private System.Windows.Forms.ToolStripSeparator bindingNavigatorSeparator;
        private System.Windows.Forms.ToolStripTextBox bindingNavigatorPositionItem;
        private System.Windows.Forms.ToolStripSeparator bindingNavigatorSeparator1;
        private System.Windows.Forms.ToolStripButton bindingNavigatorMoveNextItem;
        private System.Windows.Forms.ToolStripButton bindingNavigatorMoveLastItem;
        private System.Windows.Forms.ToolStripSeparator bindingNavigatorSeparator2;
        private System.Windows.Forms.ToolStripButton workerBindingNavigatorSaveItem;
        private System.Windows.Forms.DataGridView workerDataGridView;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn2;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn3;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn4;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn5;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn6;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn7;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn8;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn9;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn10;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn11;
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
    }
}

