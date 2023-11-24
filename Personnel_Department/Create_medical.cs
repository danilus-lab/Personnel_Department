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
    public partial class Create_medical : Form
    {
        public Create_medical()
        {
            InitializeComponent();
        }

        private void Create_medical_Load(object sender, EventArgs e)
        {
            // TODO: данная строка кода позволяет загрузить данные в таблицу "otdel_kadrovDataSet.Worker". При необходимости она может быть перемещена или удалена.
            this.workerTableAdapter.Fill(this.otdel_kadrovDataSet.Worker);

        }

        private void create_medical_button_Click(object sender, EventArgs e)
        {
            int id_worker = Convert.ToInt32(workers_listbox.SelectedValue);
            sqlCommand1.Parameters["@id_worker"].Value = id_worker;
            sqlCommand1.Parameters["@start_date"].Value = start_dateTimePicker.Value;
            sqlCommand1.Parameters["@end_date"].Value = end_dateTimePicker.Value;
            if (start_dateTimePicker.Value == end_dateTimePicker.Value || start_dateTimePicker.Value > end_dateTimePicker.Value)
            {
                MessageBox.Show(
                "Некорректные даты отпуска",
                "Ошибка",
                MessageBoxButtons.OK,
                MessageBoxIcon.Error,
                MessageBoxDefaultButton.Button1,
                MessageBoxOptions.DefaultDesktopOnly
                );
            }
            else
            {
                sqlConnection1.Open();
                sqlCommand1.ExecuteNonQuery();
                sqlConnection1.Close();
                string result = Convert.ToString(sqlCommand1.Parameters["@message"].Value);
                MessageBox.Show(result);
            }
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
    }
}
