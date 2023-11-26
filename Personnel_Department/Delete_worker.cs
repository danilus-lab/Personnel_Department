using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Data.SqlClient;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Personnel_Department
{
    public partial class Delete_worker : Form
    {
        public Delete_worker()
        {
            InitializeComponent();
        }

        private void Delete_worker_Load(object sender, EventArgs e)
        {
            // TODO: данная строка кода позволяет загрузить данные в таблицу "otdel_kadrovDataSet.Worker". При необходимости она может быть перемещена или удалена.
            this.workerTableAdapter.Fill(this.otdel_kadrovDataSet.Worker);

        }

        private void textBox1_TextChanged(object sender, EventArgs e)
        {
            string myString = textBox1.Text;
            // Search starting from index -1:
            int index = workers_listbox.FindString(myString, -1);
            if (index != -1)
            {
                // Select the found item:
                workers_listbox.SetSelected(index, true);
                // Send a success message:

            }
        }

        private void button1_Click(object sender, EventArgs e)
        {
            int id_worker = Convert.ToInt32(workers_listbox.SelectedValue);
            sqlConnection1.Open();

            deleteCommand.Parameters["@id_worker"].Value = id_worker;

            deleteCommand.ExecuteNonQuery();
            sqlConnection1.Close();

            string result = Convert.ToString(deleteCommand.Parameters["@message"].Value);
            MessageBox.Show(result);

            this.workerTableAdapter.Fill(this.otdel_kadrovDataSet.Worker);
        }
    }
}
