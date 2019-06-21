﻿using CleverStocker.Utils;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace CleverStocker.Client
{
    public partial class MainForm : Form
    {
        public MainForm()
        {
            this.Icon = AppResource.Icon;
            this.Text = Application.ProductName;

            this.InitializeComponent();
        }
    }
}
