﻿using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace DP_Vasilena12a.View
{
    public partial class KontaktiControl : UserControl
    {
        public KontaktiControl()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            Form1 form1 = new Form1();
            form1.ShowDialog();
            form1.BringToFront();

            KontaktiControl kontaktiControl = new KontaktiControl();
            this.Hide();
        }
    }
}
