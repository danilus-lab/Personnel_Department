namespace Personnel_Department
{
    partial class Add_Worker_Form
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
            this.fio_textBox = new System.Windows.Forms.TextBox();
            this.dateTimePicker = new System.Windows.Forms.DateTimePicker();
            this.myConnection = new System.Data.SqlClient.SqlConnection();
            this.addCommand = new System.Data.SqlClient.SqlCommand();
            this.add = new System.Windows.Forms.Button();
            this.fio_label = new System.Windows.Forms.Label();
            this.dep_label = new System.Windows.Forms.Label();
            this.date_label = new System.Windows.Forms.Label();
            this.sex_label = new System.Windows.Forms.Label();
            this.sex_comboBox = new System.Windows.Forms.ComboBox();
            this.birth_date = new System.Windows.Forms.DateTimePicker();
            this.birth_label = new System.Windows.Forms.Label();
            this.stage_label = new System.Windows.Forms.Label();
            this.postname_label = new System.Windows.Forms.Label();
            this.stage_textbox = new System.Windows.Forms.TextBox();
            this.dep_comboBox = new System.Windows.Forms.ComboBox();
            this.otdel_kadrovDataSet = new Personnel_Department.Otdel_kadrovDataSet();
            this.depBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.depTableAdapter = new Personnel_Department.Otdel_kadrovDataSetTableAdapters.DepTableAdapter();
            this.post_name_combo = new System.Windows.Forms.ComboBox();
            this.staffListBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.staffListTableAdapter = new Personnel_Department.Otdel_kadrovDataSetTableAdapters.StaffListTableAdapter();
            ((System.ComponentModel.ISupportInitialize)(this.otdel_kadrovDataSet)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.depBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.staffListBindingSource)).BeginInit();
            this.SuspendLayout();
            // 
            // fio_textBox
            // 
            this.fio_textBox.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.fio_textBox.Location = new System.Drawing.Point(139, 77);
            this.fio_textBox.Name = "fio_textBox";
            this.fio_textBox.Size = new System.Drawing.Size(242, 20);
            this.fio_textBox.TabIndex = 0;
            this.fio_textBox.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.fio_textBox_KeyPress);
            // 
            // dateTimePicker
            // 
            this.dateTimePicker.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.dateTimePicker.Location = new System.Drawing.Point(139, 316);
            this.dateTimePicker.Name = "dateTimePicker";
            this.dateTimePicker.Size = new System.Drawing.Size(242, 20);
            this.dateTimePicker.TabIndex = 3;
            // 
            // myConnection
            // 
            this.myConnection.ConnectionString = "Data Source=DESKTOP-T003JCT\\SQLEXPRESS;Initial Catalog=Otdel_kadrov;Integrated Se" +
    "curity=True";
            this.myConnection.FireInfoMessageEventOnUserErrors = false;
            // 
            // addCommand
            // 
            this.addCommand.CommandText = "Add_Worker";
            this.addCommand.CommandType = System.Data.CommandType.StoredProcedure;
            this.addCommand.Connection = this.myConnection;
            this.addCommand.Parameters.AddRange(new System.Data.SqlClient.SqlParameter[] {
            new System.Data.SqlClient.SqlParameter("@Fio", System.Data.SqlDbType.VarChar, 70),
            new System.Data.SqlClient.SqlParameter("@Dep", System.Data.SqlDbType.Int),
            new System.Data.SqlClient.SqlParameter("@Date_receprion", System.Data.SqlDbType.DateTime),
            new System.Data.SqlClient.SqlParameter("@Post_name", System.Data.SqlDbType.VarChar, 70),
            new System.Data.SqlClient.SqlParameter("@Data_birth", System.Data.SqlDbType.DateTime),
            new System.Data.SqlClient.SqlParameter("@Sex", System.Data.SqlDbType.VarChar, 1),
            new System.Data.SqlClient.SqlParameter("@Stage", System.Data.SqlDbType.Int)});
            // 
            // add
            // 
            this.add.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.add.Font = new System.Drawing.Font("Elephant", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.add.Location = new System.Drawing.Point(139, 371);
            this.add.Name = "add";
            this.add.Size = new System.Drawing.Size(242, 33);
            this.add.TabIndex = 4;
            this.add.Text = "Добавить";
            this.add.UseVisualStyleBackColor = true;
            this.add.Click += new System.EventHandler(this.add_Click);
            // 
            // fio_label
            // 
            this.fio_label.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.fio_label.AutoSize = true;
            this.fio_label.Font = new System.Drawing.Font("Elephant", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.fio_label.Location = new System.Drawing.Point(73, 77);
            this.fio_label.Name = "fio_label";
            this.fio_label.Size = new System.Drawing.Size(57, 20);
            this.fio_label.TabIndex = 5;
            this.fio_label.Text = "ФИО*:";
            // 
            // dep_label
            // 
            this.dep_label.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.dep_label.AutoSize = true;
            this.dep_label.Font = new System.Drawing.Font("Elephant", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.dep_label.Location = new System.Drawing.Point(64, 232);
            this.dep_label.Name = "dep_label";
            this.dep_label.Size = new System.Drawing.Size(66, 20);
            this.dep_label.TabIndex = 6;
            this.dep_label.Text = "Отдел*:";
            // 
            // date_label
            // 
            this.date_label.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.date_label.AutoSize = true;
            this.date_label.Font = new System.Drawing.Font("Elephant", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.date_label.Location = new System.Drawing.Point(12, 316);
            this.date_label.Name = "date_label";
            this.date_label.Size = new System.Drawing.Size(123, 20);
            this.date_label.TabIndex = 7;
            this.date_label.Text = "Дата принятия*:";
            // 
            // sex_label
            // 
            this.sex_label.AutoSize = true;
            this.sex_label.Font = new System.Drawing.Font("Elephant", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.sex_label.Location = new System.Drawing.Point(87, 116);
            this.sex_label.Name = "sex_label";
            this.sex_label.Size = new System.Drawing.Size(43, 20);
            this.sex_label.TabIndex = 9;
            this.sex_label.Text = "Пол:";
            // 
            // sex_comboBox
            // 
            this.sex_comboBox.FormattingEnabled = true;
            this.sex_comboBox.Items.AddRange(new object[] {
            "М",
            "Ж"});
            this.sex_comboBox.Location = new System.Drawing.Point(139, 115);
            this.sex_comboBox.Name = "sex_comboBox";
            this.sex_comboBox.Size = new System.Drawing.Size(36, 21);
            this.sex_comboBox.TabIndex = 10;
            // 
            // birth_date
            // 
            this.birth_date.Location = new System.Drawing.Point(139, 152);
            this.birth_date.Name = "birth_date";
            this.birth_date.Size = new System.Drawing.Size(200, 20);
            this.birth_date.TabIndex = 11;
            // 
            // birth_label
            // 
            this.birth_label.AutoSize = true;
            this.birth_label.Font = new System.Drawing.Font("Elephant", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.birth_label.Location = new System.Drawing.Point(8, 152);
            this.birth_label.Name = "birth_label";
            this.birth_label.Size = new System.Drawing.Size(122, 20);
            this.birth_label.TabIndex = 12;
            this.birth_label.Text = "Дата рождения:";
            // 
            // stage_label
            // 
            this.stage_label.AutoSize = true;
            this.stage_label.Font = new System.Drawing.Font("Elephant", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.stage_label.Location = new System.Drawing.Point(75, 190);
            this.stage_label.Name = "stage_label";
            this.stage_label.Size = new System.Drawing.Size(58, 20);
            this.stage_label.TabIndex = 14;
            this.stage_label.Text = "Стаж*:";
            // 
            // postname_label
            // 
            this.postname_label.AutoSize = true;
            this.postname_label.Font = new System.Drawing.Font("Elephant", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.postname_label.Location = new System.Drawing.Point(28, 270);
            this.postname_label.Name = "postname_label";
            this.postname_label.Size = new System.Drawing.Size(102, 20);
            this.postname_label.TabIndex = 15;
            this.postname_label.Text = "Должность*:";
            // 
            // stage_textbox
            // 
            this.stage_textbox.Location = new System.Drawing.Point(139, 190);
            this.stage_textbox.Name = "stage_textbox";
            this.stage_textbox.Size = new System.Drawing.Size(36, 20);
            this.stage_textbox.TabIndex = 17;
            this.stage_textbox.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.stage_textbox_KeyPress);
            // 
            // dep_comboBox
            // 
            this.dep_comboBox.DataSource = this.depBindingSource;
            this.dep_comboBox.DisplayMember = "Num_dep";
            this.dep_comboBox.FormattingEnabled = true;
            this.dep_comboBox.Location = new System.Drawing.Point(139, 231);
            this.dep_comboBox.Name = "dep_comboBox";
            this.dep_comboBox.Size = new System.Drawing.Size(36, 21);
            this.dep_comboBox.TabIndex = 18;
            this.dep_comboBox.ValueMember = "Num_dep";
            this.dep_comboBox.SelectedIndexChanged += new System.EventHandler(this.dep_comboBox_SelectedIndexChanged);
            // 
            // otdel_kadrovDataSet
            // 
            this.otdel_kadrovDataSet.DataSetName = "Otdel_kadrovDataSet";
            this.otdel_kadrovDataSet.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
            // 
            // depBindingSource
            // 
            this.depBindingSource.DataMember = "Dep";
            this.depBindingSource.DataSource = this.otdel_kadrovDataSet;
            // 
            // depTableAdapter
            // 
            this.depTableAdapter.ClearBeforeFill = true;
            // 
            // post_name_combo
            // 
            this.post_name_combo.FormattingEnabled = true;
            this.post_name_combo.Location = new System.Drawing.Point(139, 271);
            this.post_name_combo.Name = "post_name_combo";
            this.post_name_combo.Size = new System.Drawing.Size(121, 21);
            this.post_name_combo.TabIndex = 19;
            // 
            // staffListBindingSource
            // 
            this.staffListBindingSource.DataMember = "StaffList";
            this.staffListBindingSource.DataSource = this.otdel_kadrovDataSet;
            // 
            // staffListTableAdapter
            // 
            this.staffListTableAdapter.ClearBeforeFill = true;
            // 
            // Add_Worker_Form
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.ActiveCaption;
            this.ClientSize = new System.Drawing.Size(484, 461);
            this.Controls.Add(this.post_name_combo);
            this.Controls.Add(this.dep_comboBox);
            this.Controls.Add(this.stage_textbox);
            this.Controls.Add(this.postname_label);
            this.Controls.Add(this.stage_label);
            this.Controls.Add(this.birth_label);
            this.Controls.Add(this.birth_date);
            this.Controls.Add(this.sex_comboBox);
            this.Controls.Add(this.sex_label);
            this.Controls.Add(this.date_label);
            this.Controls.Add(this.dep_label);
            this.Controls.Add(this.fio_label);
            this.Controls.Add(this.add);
            this.Controls.Add(this.dateTimePicker);
            this.Controls.Add(this.fio_textBox);
            this.Name = "Add_Worker_Form";
            this.Text = "Добавления сотрудника";
            this.Load += new System.EventHandler(this.Add_Worker_Form_Load);
            ((System.ComponentModel.ISupportInitialize)(this.otdel_kadrovDataSet)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.depBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.staffListBindingSource)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.TextBox fio_textBox;
        private System.Windows.Forms.DateTimePicker dateTimePicker;
        private System.Data.SqlClient.SqlConnection myConnection;
        private System.Data.SqlClient.SqlCommand addCommand;
        private System.Windows.Forms.Button add;
        private System.Windows.Forms.Label fio_label;
        private System.Windows.Forms.Label dep_label;
        private System.Windows.Forms.Label date_label;
        private System.Windows.Forms.Label sex_label;
        private System.Windows.Forms.ComboBox sex_comboBox;
        private System.Windows.Forms.DateTimePicker birth_date;
        private System.Windows.Forms.Label birth_label;
        private System.Windows.Forms.Label stage_label;
        private System.Windows.Forms.Label postname_label;
        private System.Windows.Forms.TextBox stage_textbox;
        private System.Windows.Forms.ComboBox dep_comboBox;
        private Otdel_kadrovDataSet otdel_kadrovDataSet;
        private System.Windows.Forms.BindingSource depBindingSource;
        private Otdel_kadrovDataSetTableAdapters.DepTableAdapter depTableAdapter;
        private System.Windows.Forms.ComboBox post_name_combo;
        private System.Windows.Forms.BindingSource staffListBindingSource;
        private Otdel_kadrovDataSetTableAdapters.StaffListTableAdapter staffListTableAdapter;
    }
}