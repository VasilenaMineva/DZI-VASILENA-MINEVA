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

namespace DP_Vasilena12a.Presenter
{
    public partial class LogIn_User : Form
    {
        public LogIn_User()
        {
            InitializeComponent();
            
        }

        private void LogIn_User_Load(object sender, EventArgs e)
        {
        //TODO: This line of code loads data into the 'dP_Vasilena_DataBaseDataSet.Data' table.You can move, or remove it, as needed.
            this.dataTableAdapter.Fill(this.dP_Vasilena_DataBaseDataSet.Data);
        //TODO: This line of code loads data into the 'dP_Vasilena_DataBaseDataSet.Data' table.You can move, or remove it, as needed.
            this.dataTableAdapter.Fill(this.dP_Vasilena_DataBaseDataSet.Data);

        }

        private void addBtn_Click(object sender, EventArgs e)
        {
            dataBindingSource.AddNew();
            dataBindingSource.AddNew();
            //if (ImeTxtBox.Text != "" && FamilTxtBox.Text != "" && comboBox1.Text != "" && IzborArtikCmbBox.Text != "" && NachPoruchCmbBox.Text != "" && BrojkiTxtBox.Text != "" && dateTimePicker1.Text != "")
            //{
            //    dP_Vasilena_DataBaseDataSet.Data.AddDataRow(ImeTxtBox.Text, FamilTxtBox.Text, comboBox1.Text, IzborArtikCmbBox.Text, NachPoruchCmbBox.Text, int.Parse(BrojkiTxtBox.Text), dateTimePicker1.Text);
            //}
            dP_Vasilena_DataBaseDataSet.Data.AddDataRow(ImeTxtBox.Text, FamilTxtBox.Text, comboBox1.Text,
                IzborArtikCmbBox.Text, NachPoruchCmbBox.Text, int.Parse(BrojkiTxtBox.Text), dateTimePicker1.Text);
        }

        private void clearBtn_Click(object sender, EventArgs e)
        {
            ImeTxtBox.Clear();
            FamilTxtBox.Clear();
            comboBox1.Text = string.Empty;
            IzborArtikCmbBox.Text = string.Empty;
            NachPoruchCmbBox.Text = string.Empty;
            BrojkiTxtBox.Clear();
            dateTimePicker1.Text = string.Empty;
        }

        private void deleteBtn_Click(object sender, EventArgs e)
        {
            dataBindingSource.RemoveCurrent();
            dataBindingSource.RemoveCurrent();

        }

        private void closeBtn_Click(object sender, EventArgs e)
        {
            LogIn_User user = new LogIn_User();
            Form1 form1 = new Form1();
            user.Close();
            form1.ShowDialog();
        }

        private void ImeTxtBox_TextChanged(object sender, EventArgs e)
        {

        }

        private void FamilTxtBox_TextChanged(object sender, EventArgs e)
        {

        }

        private void comboBox1_SelectedIndexChanged(object sender, EventArgs e)
        {

        }

        private void IzborArtikCmbBox_SelectedIndexChanged(object sender, EventArgs e)
        {

        }

        private void NachPoruchCmbBox_SelectedIndexChanged(object sender, EventArgs e)
        {

        }

        private void BrojkiTxtBox_TextChanged(object sender, EventArgs e)
        {

        }

        private void dateTimePicker1_ValueChanged(object sender, EventArgs e)
        {

        }
    }
}
