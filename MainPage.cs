﻿using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace HastahaneRandevuProje
{
    public partial class MainPage : Form
    {
        public MainPage()
        {
            InitializeComponent();
        }

        private void button2_Click(object sender, EventArgs e)
        {
            DoktorLogin doclog = new DoktorLogin();
            this.Visible = false;
            doclog.Show();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            SekreterLogin seklog = new SekreterLogin();
            this.Visible = false;
            seklog.Show();
        }
    }
}
