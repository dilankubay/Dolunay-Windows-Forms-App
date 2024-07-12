using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Data;
using System.Data.SqlClient;
using DolunaySuAritma.Models;

namespace DolunaySuAritma
{
    public partial class BakimFormlariListesi : Form
    {
        public BakimFormlariListesi()
        {
            InitializeComponent();
            LoadData();
        }
        private void LoadData()
        {
            using (var context = new DolunayContext()) // Replace with your actual DbContext class
            {
                try
                {
                    var data = context.BakimFormlaris.ToList(); // Replace with your actual DbSet property
                    dataGridView1.DataSource = data;
                    dataGridView1.Refresh();
                }
                catch (Exception ex)
                {
                    MessageBox.Show("An error occurred: " + ex.Message);
                }
            }
        }
        private void BakimFormlariListesi_Load(object sender, EventArgs e)
        {
            dataGridView1.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.Fill;
        }

        private void dataGridView1_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

        }

        private void dataGridView1_CellContentClick_1(object sender, DataGridViewCellEventArgs e)
        {

        }
    }
}
