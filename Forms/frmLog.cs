﻿using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace SKYNET
{
    public partial class frmLog : Form
    {
        public frmLog()
        {
            InitializeComponent();
        }

        internal void Write(string @string)
        {
            txtChat.AppendText(@string + "\n\n");
        }
    }
}
