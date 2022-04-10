using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.IO;

namespace lesson5_08._04
{
    public partial class Rating : Form
    {
        public Rating()
        {
            InitializeComponent();
        }

        private void Rating_Load(object sender, EventArgs e)
        {
            foreach(string str in File.ReadAllLines("Rating.txt"))
            {
                string[] text = str.Split();
                dataGridView1.Rows.Add(text[0], text[1], text[2]);
            }

            dataGridView1.Sort(dataGridView1.Columns[1], ListSortDirection.Descending);
        }

        private void btnSort_Click(object sender, EventArgs e)
        {
            dataGridView1.Sort(dataGridView1.Columns[2], ListSortDirection.Descending);
        }

        private void btnSort2_Click(object sender, EventArgs e)
        {
            dataGridView1.Sort(dataGridView1.Columns[1], ListSortDirection.Descending);
        }
    }
}
