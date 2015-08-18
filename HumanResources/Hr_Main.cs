using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Text;
using System.Windows.Forms;

namespace Hr
{
    public partial class Hr_Main : HAWK_Template_2
    {
        public Hr_Main()
        {
            InitializeComponent();
        }


        //private void button_ListObjects_Click(object sender, EventArgs e)
        //{
            
        //    ListObjects newapp = new ListObjects();
        //    newapp.Show();
        //}

        //private void button_DisplaySelectedObject_Click_1(object sender, EventArgs e)
        //{
        //    DisplaySelectedObject newapp = new DisplaySelectedObject();
        //    newapp.Show();

        //}

        private void button1_Click(object sender, EventArgs e)
        {
           //  new HrRecruiting_Template.RecruitingTables().Show();
            new NewApplication.NewApplication_Main(base.ident).Show();
        }

        private void button2_Click(object sender, EventArgs e)
        {
          //  new HRBenefits.HRBenefits_Main(base.ident).Show();
            new NewApplication.NewApplication_Main(base.ident).Show();
        }
    }
}
