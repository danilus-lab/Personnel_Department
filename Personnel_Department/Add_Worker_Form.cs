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
    public partial class Add_Worker_Form : Form
    {
        public Add_Worker_Form()
        {
            InitializeComponent();
        }

        private void add_Click(object sender, EventArgs e)
        {
            sex_comboBox.SelectedIndex = 1;
            addCommand.Parameters["@Fio"].Value = fio_textBox.Text;
            addCommand.Parameters["@Dep"].Value = dep_textBox.Text;
            addCommand.Parameters["@Date_receprion"].Value = dateTimePicker.Value;
            addCommand.Parameters["@Post_name"].Value = postname_textBox.Text;
            addCommand.Parameters["@Data_birth"].Value = birth_date.Value;
            addCommand.Parameters["@Sex"].Value = sex_comboBox.SelectedItem.ToString();
            addCommand.Parameters["@Stage"].Value = stage_textbox.Text;

            if (fio_textBox.Text != "" && dep_textBox.Text != "" && dateTimePicker.Text != "")
            {
                myConnection.Open();
                addCommand.ExecuteNonQuery();
                myConnection.Close();
            }
            else
            {
                MessageBox.Show(
                "Заполните обязательные поля",
                "Ошибка",
                MessageBoxButtons.OK,
                MessageBoxIcon.Error,
                MessageBoxDefaultButton.Button1,
                MessageBoxOptions.DefaultDesktopOnly
                );
            }
        }
    }
}
