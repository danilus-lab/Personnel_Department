using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using static System.Windows.Forms.VisualStyles.VisualStyleElement;
using static System.Windows.Forms.VisualStyles.VisualStyleElement.Button;

namespace Personnel_Department
{
    public partial class List_Of_Workers : Form
    {
        public List_Of_Workers()
        {
            InitializeComponent();
        }

        private void workerBindingNavigatorSaveItem_Click(object sender, EventArgs e)
        {
            this.Validate();
            this.workerBindingSource.EndEdit();
            this.tableAdapterManager.UpdateAll(this.otdel_kadrovDataSet);

        }

        private void List_Of_Workers_Load(object sender, EventArgs e)
        {
            // TODO: данная строка кода позволяет загрузить данные в таблицу "otdel_kadrovDataSet.Worker". При необходимости она может быть перемещена или удалена.
            this.workerTableAdapter.Fill(this.otdel_kadrovDataSet.Worker);

        }

        private void sort_listBox_SelectedIndexChanged(object sender, EventArgs e)
        {
            sort_button.Enabled = true;
        }

        private void sort_button_Click(object sender, EventArgs e)
        {
            System.Windows.Forms.DataGridViewColumn Col = default(System.Windows.Forms.DataGridViewColumn);
            switch (sort_listBox.SelectedIndex)
            {
                case 0:
                    Col = dataGridViewTextBoxColumn2;
                    break;
                case 1:
                    Col = dataGridViewTextBoxColumn5;
                    break;
                case 2:
                    Col = dataGridViewTextBoxColumn7;
                    break;
                case 3:
                    Col = dataGridViewTextBoxColumn8;
                    break;
                case 4:
                    Col = dataGridViewTextBoxColumn10;
                    break;
            }
            if (ascending_radioButton.Checked)
                workerDataGridView.Sort(Col, System.ComponentModel.ListSortDirection.Ascending);
            else
                workerDataGridView.Sort(Col, System.ComponentModel.ListSortDirection.Descending);
        }

        private void show_all_Click(object sender, EventArgs e)
        {
            workerBindingSource.Filter = "";
        }

        private void show_men_radio_CheckedChanged(object sender, EventArgs e)
        {
            workerBindingSource.Filter = "Sex = 'М'";
        }

        private void show_women_radio_CheckedChanged(object sender, EventArgs e)
        {
            workerBindingSource.Filter = "Sex = 'Ж'";
        }

        private void find_button_Click(object sender, EventArgs e)
        {
            workerBindingSource.Filter = "FIO_worker Like '" + fio_textBox.Text + "%'";
        }
    }
}
