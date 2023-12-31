﻿using System;
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
    public partial class Add_row_in_staff_list : Form
    {
        public Add_row_in_staff_list()
        {
            InitializeComponent();
        }

        private void add_button_Click(object sender, EventArgs e)
        {
            if (post_name_textBox.Text != "" && vacant_units_textBox.Text != "" && salary_textBox.Text != "")
            {
                sqlConnection1.Open();

                //add_Command.Parameters["@num_dep"].Value = Convert.ToInt32(num_dep_textBox.Text);
                add_Command.Parameters["@num_dep"].Value = Convert.ToInt32(comboBox1.SelectedValue);
                add_Command.Parameters["@post_name"].Value = post_name_textBox.Text;
                add_Command.Parameters["@vacant_units"].Value = Convert.ToInt32(vacant_units_textBox.Text);
                add_Command.Parameters["@salary"].Value = Convert.ToSingle(salary_textBox.Text);

                add_Command.ExecuteNonQuery();
                sqlConnection1.Close();

                string result = Convert.ToString(add_Command.Parameters["@message"].Value);
                MessageBox.Show(result);
            }
            else
            {
                MessageBox.Show(
                "Заполните все поля",
                "Ошибка",
                MessageBoxButtons.OK,
                MessageBoxIcon.Error,
                MessageBoxDefaultButton.Button1,
                MessageBoxOptions.DefaultDesktopOnly
                );
            }
        }

        private void salary_textBox_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (!char.IsControl(e.KeyChar) && !char.IsDigit(e.KeyChar) && e.KeyChar != ',')
            {
                e.Handled = true;
            }

            // Проверка наличия только одной запятой
            if (e.KeyChar == ',' && (sender as TextBox).Text.IndexOf(',') > -1)
            {
                e.Handled = true;
            }
        }

        private void num_dep_textBox_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (!char.IsControl(e.KeyChar) && !char.IsDigit(e.KeyChar))
            {
                e.Handled = true;
            }
        }

        private void count_units_textBox_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (!char.IsControl(e.KeyChar) && !char.IsDigit(e.KeyChar))
            {
                e.Handled = true;
            }
        }

        private void post_name_textBox_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (!char.IsControl(e.KeyChar) && !char.IsLetter(e.KeyChar) && e.KeyChar != 'Ё' && e.KeyChar != 'ё')
            {
                e.Handled = true;
            }
        }

        private void Add_row_in_staff_list_Load(object sender, EventArgs e)
        {
            // TODO: данная строка кода позволяет загрузить данные в таблицу "otdel_kadrovDataSet.Dep". При необходимости она может быть перемещена или удалена.
            this.depTableAdapter.Fill(this.otdel_kadrovDataSet.Dep);

        }

        private void vacant_units_textBox_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (!char.IsControl(e.KeyChar) && !char.IsDigit(e.KeyChar) && e.KeyChar != (char)Keys.Back)
            {
                e.Handled = true;
            }
        }
    }
}
