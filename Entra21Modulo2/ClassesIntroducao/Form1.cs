﻿using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace ClassesIntroducao
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }
        Cliente cli = new Cliente();

        private void button1_Click(object sender, EventArgs e)
        {
            cli.Nome = "JHon";
        }

        private void button2_Click(object sender, EventArgs e)
        {
            textBox1.Text = cli.Nome;
        }
    }
}
