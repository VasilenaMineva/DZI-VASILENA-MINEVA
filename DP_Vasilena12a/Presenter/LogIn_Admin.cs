using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace DP_Vasilena12a.Presenter
{
    public partial class LogIn_Admin : Form
    {
        public LogIn_Admin()
        {
            InitializeComponent();
        }

        private void comboBox2_SelectedIndexChanged(object sender, EventArgs e)
        {

        }

        private void comboBox3_SelectedIndexChanged(object sender, EventArgs e)
        {

        }

        private void dataGridView2_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

        }

        private void groupBox1_Enter(object sender, EventArgs e)
        {

        }

        private void LogIn_Admin_Load(object sender, EventArgs e)
        {
            // TODO: This line of code loads data into the 'dP_Vasilena_DataBaseDataSet.Products' table. You can move, or remove it, as needed.
            this.productsTableAdapter.Fill(this.dP_Vasilena_DataBaseDataSet.Products);
            // TODO: This line of code loads data into the 'dP_Vasilena_DataBaseDataSet.Data' table. You can move, or remove it, as needed.
            this.dataTableAdapter.Fill(this.dP_Vasilena_DataBaseDataSet.Data);
            // TODO: This line of code loads data into the 'dP_Vasilena_DataBaseDataSet.Products' table. You can move, or remove it, as needed.
            this.productsTableAdapter.Fill(this.dP_Vasilena_DataBaseDataSet.Products);
            // TODO: This line of code loads data into the 'dP_Vasilena_DataBaseDataSet.Data' table. You can move, or remove it, as needed.
            this.dataTableAdapter.Fill(this.dP_Vasilena_DataBaseDataSet.Data);

        }
        
        private void addBtn_Click(object sender, EventArgs e)
        {
            dP_Vasilena_DataBaseDataSet.Data.AddDataRow(comboBox4.Text, int.Parse(textBox1.Text), dateTimePicker1.Text, textBox2.Text, comboBox3.Text, int.Parse(comboBox1.Text));
            dP_Vasilena_DataBaseDataSet.Products.AddProductsRow(comboBox4.Text, int.Parse(textBox1.Text), dateTimePicker1.Text, textBox2.Text, comboBox3.Text, int.Parse(comboBox1.Text));

            dataBindingSource.AddNew();
            productsBindingSource.AddNew();
        }

        private void clearBtn_Click(object sender, EventArgs e)
        {
            comboBox1.Text = string.Empty;
            comboBox3.Text = string.Empty;
            comboBox4.Text = string.Empty;
            dateTimePicker1.Text = string.Empty;
            textBox1.Clear();
            textBox2.Clear();
        }

        private void deleteBtn_Click(object sender, EventArgs e)
        {
            dataBindingSource.RemoveCurrent();
            productsBindingSource.RemoveCurrent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            dataBindingSource.RemoveCurrent();
            dataTableAdapter.Update(dP_Vasilena_DataBaseDataSet.Data);
            productsBindingSource.RemoveCurrent();
            productsTableAdapter.Update(dP_Vasilena_DataBaseDataSet.Products);
            MessageBox.Show("Записа е направен!");
        }
        
        private void comboBox4_SelectedIndexChanged(object sender, EventArgs e)
        {

        }

        private void textBox1_TextChanged(object sender, EventArgs e)
        {

        }

        private void dateTimePicker1_ValueChanged(object sender, EventArgs e)
        {

        }

        private void textBox2_TextChanged(object sender, EventArgs e)
        {

        }

        private void comboBox1_SelectedIndexChanged(object sender, EventArgs e)
        {

        }

        private void closeBtn_Click(object sender, EventArgs e)
        {
            LogIn_Admin admin = new LogIn_Admin();
            Form1 form1 = new Form1();
            admin.Close();
            form1.ShowDialog();
        }
    }
}
