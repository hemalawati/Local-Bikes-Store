﻿using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Text;
using System.Windows.Forms;

namespace Account_Payable
{
    public partial class Account_Payable_Template : HAWK_Template_2
    {
        public Account_Payable_Template()
        {
            InitializeComponent();
        }
        protected override void button_ListObjects_Click(object sender, EventArgs e)
        {
            ListObjects mylist = new ListObjects(base.ident); mylist.Show();
        }
        protected override void button_DisplaySelectedObject_Click(object sender, EventArgs e)
        {
          DisplaySelectedObject app = new DisplaySelectedObject(base.ident); app.Show();
        }

    }
}
