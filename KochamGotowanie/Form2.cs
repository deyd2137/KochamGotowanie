﻿using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace KochamGotowanie
{
    public partial class Form2 : Form
    {
        public Form2()
        {
            Random random = new Random();
            int x = random.Next(0, 1920);
            int y = random.Next(0, 1080);

            this.StartPosition = FormStartPosition.Manual;
            this.Location = new Point(x, y);
            this.ShowInTaskbar = false;
            this.TopMost = true;

            InitializeComponent();
        }
    }
}
