using DP_Vasilena12a.Presenter;
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
using static System.Windows.Forms.VisualStyles.VisualStyleElement.StartPanel;

namespace DP_Vasilena12a.View
{
    public partial class ClearBtn : UserControl
    {
        public ClearBtn()
        {
            InitializeComponent();
        }

        private void VhodBtn_Click(object sender, EventArgs e)
        {
            string name = textBox1.Text;
            string password =textBox2.Text;
            if (name == "Admin" && password == "123")
            {

                MessageBox.Show("Добре дошъл");
                this.Hide();
                LogIn_Admin admin = new LogIn_Admin();
                admin.ShowDialog();

            }
            else if (name == "Potrebitel" && password == "321")
            {
                MessageBox.Show("Добре дошъл");
                this.Hide();
                LogIn_User potrebitel = new LogIn_User();
                potrebitel.ShowDialog();
            }
            else MessageBox.Show("Грешно име или парола");

            //if (name.Contains(textBox1.Text) && password.Contains(textBox2.Text))
            //{

            //    this.Hide();
            //    var form3 = new Form1();
            //    form3.Closed += (s, args) => this.Close();
            //    form3.Show();
            //}


        }

        private void button1_Click(object sender, EventArgs e)
        {
            Form1 form1 = new Form1();
            form1.ShowDialog();
            ClearBtn vhodControl = new ClearBtn();
            this.Hide();
        }

        private void textBox1_TextChanged(object sender, EventArgs e)
        {

        }

        private void textBox2_TextChanged(object sender, EventArgs e)
        {

        }

        private void button2_Click(object sender, EventArgs e)
        {
            textBox1.Clear();
            textBox2.Clear();
        }
    }
}
