namespace Personnel_Department
{
    partial class Delete_worker
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
            this.textBox1 = new System.Windows.Forms.TextBox();
            this.label5 = new System.Windows.Forms.Label();
            this.button1 = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.workerBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.otdel_kadrovDataSet)).BeginInit();
            this.SuspendLayout();
            // 
            // workers_listbox
            // 
            this.workers_listbox.DataSource = this.workerBindingSource;
            this.workers_listbox.DisplayMember = "FIO_worker";
            this.workers_listbox.FormattingEnabled = true;
            this.workers_listbox.Location = new System.Drawing.Point(7, 12);
            this.workers_listbox.Name = "workers_listbox";
            this.workers_listbox.Size = new System.Drawing.Size(397, 329);
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
            // textBox1
            // 
            this.textBox1.Location = new System.Drawing.Point(55, 349);
            this.textBox1.Name = "textBox1";
            this.textBox1.Size = new System.Drawing.Size(349, 20);
            this.textBox1.TabIndex = 14;
            this.textBox1.TextChanged += new System.EventHandler(this.textBox1_TextChanged);
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(12, 352);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(37, 13);
            this.label5.TabIndex = 15;
            this.label5.Text = "ФИО:";
            // 
            // button1
            // 
            this.button1.Location = new System.Drawing.Point(7, 386);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(397, 23);
            this.button1.TabIndex = 16;
            this.button1.Text = "Уволить сотрудника";
            this.button1.UseVisualStyleBackColor = true;
            // 
            // Delete_worker
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.ActiveCaption;
            this.ClientSize = new System.Drawing.Size(416, 450);
            this.Controls.Add(this.button1);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.textBox1);
            this.Controls.Add(this.workers_listbox);
            this.Name = "Delete_worker";
            this.Text = "Увольнение сотрудника";
            this.Load += new System.EventHandler(this.Delete_worker_Load);
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
        private System.Windows.Forms.TextBox textBox1;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Button button1;
    }
}