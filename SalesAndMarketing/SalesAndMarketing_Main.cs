using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Text;
using System.Windows.Forms;

namespace SalesAndMarketing
{
    public partial class SalesAndMarketing_Main : SalesAndMarketing.SalesAndMarketing_template
    {
        public SalesAndMarketing_Main()
        {
            InitializeComponent();
        }
        public SalesAndMarketing_Main(IdentityObject ident)
        {
            InitializeComponent();
            base.SaveIdent(ident);
            base.DisplayIdent(ident);

        }

        private void button1_Click(object sender, EventArgs e)
        {
           // Sales_sm.ListServiceTypes app = new Sales_sm.ListServiceTypes(ident);   app.Show();
            new NewApplication.NewApplication_Main(base.ident).Show();
        }

        private void button3_Click(object sender, EventArgs e)
        {
           // Sales_sm.CustomerInfo app = new Sales_sm.CustomerInfo(ident);   app.Show();
            new NewApplication.NewApplication_Main(base.ident).Show();
        }

        private void button2_Click(object sender, EventArgs e)
        {
          //  Sales_sm.LogSrvcReq app = new Sales_sm.LogSrvcReq(ident);     app.Show();
            new NewApplication.NewApplication_Main(base.ident).Show();
        }

        private void button_PreSales_Click(object sender, EventArgs e)
        {
          //  new SalesAndMarketing.PreSales(base.ident).Show();
            new NewApplication.NewApplication_Main(base.ident).Show();
        }
    }
}
