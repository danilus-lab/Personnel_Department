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
    public partial class Deps_list : Form
    {
        public Deps_list()
        {
            InitializeComponent();

            myConnection.Open();
            var temp = new DataTable();

            temp.Load(fill_the_table.ExecuteReader());

            dataGridView1.DataSource = temp;

            myConnection.Close();

        }
    }
}
