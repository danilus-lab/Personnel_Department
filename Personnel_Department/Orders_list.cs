using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Personnel_Department
{
    public partial class Orders_list : Form
    {
        public Orders_list()
        {
            InitializeComponent();
            this.orderTableAdapter.Fill(this.otdel_kadrovDataSet.Order);
        }

        private void Orders_list_Load(object sender, EventArgs e)
        {
            // TODO: данная строка кода позволяет загрузить данные в таблицу "otdel_kadrovDataSet.Order". При необходимости она может быть перемещена или удалена.
            this.orderTableAdapter.Fill(this.otdel_kadrovDataSet.Order);
        }

        private void vacation_radio_CheckedChanged(object sender, EventArgs e)
        {
            orderBindingSource.Filter = "Type_order = 'На отпуск'";
        }

        private void medical_radio_CheckedChanged(object sender, EventArgs e)
        {
            orderBindingSource.Filter = "Type_order = 'На больничный'";
        }

        private void mission_radio_CheckedChanged(object sender, EventArgs e)
        {
            orderBindingSource.Filter = "Type_order = 'На командировку'";
        }

        private void find_button_Click(object sender, EventArgs e)
        {
            orderBindingSource.Filter = "FIO_worker Like '" + textBox1.Text + "%'";
        }

        private void dismiss_radio_CheckedChanged(object sender, EventArgs e)
        {
            orderBindingSource.Filter = "Type_order = 'На увольнение'";
        }

        private void all_radio_CheckedChanged(object sender, EventArgs e)
        {
            orderBindingSource.Filter = "";
        }
    }
}
