using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Text;
using System.Windows.Forms;

namespace Accounting
{
    public partial class Accounting_Main : HAWK_Template_1 
    {
    

        public Accounting_Main()
        {
            InitializeComponent();
        }


        public Accounting_Main(IdentityObject ident)
        {
            InitializeComponent();
            base.SaveIdent(ident);
            base.DisplayIdent(ident);
        }


        private void button_AccPayable_Click(object sender, EventArgs e)
        {
          //  new Account_Payable.Account_Payable_Main(base.ident).Show();
           // new NewApplication.NewApplication_Main(base.ident).Show();
/*
            int deptNo = 0;
            deptNo = base.ident.Dept;
            if (deptNo == 4 || deptNo == 5)
            {


                Account_Payable.Account_Payable_Main NewApp = new Account_Payable.Account_Payable_Main();
                NewApp.Show();
            }
            else
            {
                MessageBox.Show("Access Denied!!! " + "\n" + "Non accountants  cannot  Accounting Information");
            }
        
 */
            Account_Payable.Account_Payable_Main NewApp = new Account_Payable.Account_Payable_Main();
            NewApp.Show();
             }
 
        private void button_AccReceivable_Click(object sender, EventArgs e)
        {
          //  new AccountsReceivable.AccountsReceivable_Main(base.ident).Show();
            new NewApplication.NewApplication_Main(base.ident).Show();
        }
        






    }
}
