﻿using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace WindowsFormsApp2
{
    public partial class ArticleForm : Form
    {
        public ArticleForm(string name, string text)
        {
            InitializeComponent();
            nameLabel.Text = name;
            textLabel.Text = text;
        }

        private void Article_Load(object sender, EventArgs e)
        {

        }
    }
}
