using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Text;
using System.Windows.Forms;
using System.Collections;

namespace Account_Payable
{
    public partial class Account_Payable_Main : Account_Payable_Template
    {
        int docNum = 0;
        int docType = 0;
        int extRef = 0;
        int intRef = 0;
        int status = 0;
        int docRef = 0;
        string textValue1 = "";
        string textValue2 = "";
        double numValue1 = 0.0;
        double numValue2 = 0.0;
        string comments = "";
        /*
        double price = 0;
        int quantity = 0;
        int processID = 0;
        */

        public Account_Payable_Main()
        {
            InitializeComponent();
        }


        public Account_Payable_Main(IdentityObject ident)
        {
            InitializeComponent();
            base.SaveIdent(ident);
            base.DisplayIdent(ident);
        }

      // to diplay  the Purchase order data on to the  grid view in main form 
             private void btndiplayDdoc_Click(object sender, EventArgs e)
        {
            String dataforgdview = "Select * from ProcessDocs where DocType=12";

            DataTable doctable = Utilities.DataBaseUtility.GetTable(dataforgdview);
            DeliveryDocGdview.DataSource = doctable;
           

        }




        // to get the contents of grid view on to Invoice form
             private void DeliveryDocGdview_CellContentClick(object sender, DataGridViewCellEventArgs e)
             {
                 
                 docNum = Convert.ToInt32(DeliveryDocGdview.Rows[e.RowIndex].Cells[0].Value);
                 docType = Convert.ToInt32(DeliveryDocGdview.Rows[e.RowIndex].Cells[1].Value);
                 string ditype = docType.ToString();
               
                
                 extRef = Convert.ToInt32(DeliveryDocGdview.Rows[e.RowIndex].Cells[2].Value);
                 intRef = Convert.ToInt32(DeliveryDocGdview.Rows[e.RowIndex].Cells[3].Value);
                 status = Convert.ToInt32(DeliveryDocGdview.Rows[e.RowIndex].Cells[4].Value);
                 docRef = Convert.ToInt32(DeliveryDocGdview.Rows[e.RowIndex].Cells[5].Value);
                 textValue1 = DeliveryDocGdview.Rows[e.RowIndex].Cells[6].Value.ToString();
                 textValue2 = DeliveryDocGdview.Rows[e.RowIndex].Cells[7].Value.ToString();
              
                 numValue1 = Convert.ToDouble(DeliveryDocGdview.Rows[e.RowIndex].Cells[8].Value);
                 numValue2 = Convert.ToDouble(DeliveryDocGdview.Rows[e.RowIndex].Cells[9].Value);
                 comments = DeliveryDocGdview.Rows[e.RowIndex].Cells[10].Value.ToString();
                
                 
                 Invoice inv = new Invoice(base.ident, docNum, docType);
                 inv.populateFileds(docNum,docType,extRef,intRef,status,docRef,textValue1,textValue2,numValue1,numValue2,comments);
               
                 inv.Show();
                 inv.changevisibility(docType);

             }


        //  to get the payment table data on to grid view 
             private void btnMakePayment_Click(object sender, EventArgs e)
             {
                 {
                     String dataforgdview = "Select * from PayableDocs where DocType=41";

                     DataTable doctable = Utilities.DataBaseUtility.GetTable(dataforgdview);
                     DeliveryDocGdview.DataSource = doctable;
                    

                 }
             }
             public static object[,] ToArray(DataTable data)
             {
                 var ret = Array.CreateInstance(typeof(object), data.Rows.Count, data.Columns.Count) as object[,];
                 for (var i = 0; i < data.Rows.Count - 1; i++)
                     for (var j = 0; j < data.Columns.Count - 1; j++)
                         ret[i, j] = data.Rows[i][j];
                 return ret;
             }
             

        //batch update 
             private void btnUpdateButton_Click(object sender, EventArgs e)
             {
                 try
                 {
                     string p = "Select A.ExtRef,B1-B2 from (select PayableDocs.ExtRef as ExtRef,Sum(PayableDocs.InvPaid) As B1 from PayableDocs group by PayableDocs.ExtRef)A  INNER JOIN (select Payment.ExtRef as ExtRef,Sum(Payment.InvPaidAmount) As B2 from Payment group by Payment.ExtRef)B on (A.ExtRef=B.ExtRef)";
                     DataTable pddt = Utilities.DataBaseUtility.GetTable(p);
                    //DeliveryDocGdview.DataSource = pddt;
                     int r4 = Utilities.DataBaseUtility.Execute(ident, p);

                     ArrayList pddtExtRef = new ArrayList();
                     ArrayList pddtNumValue = new ArrayList();

              
                     int r5 = 0;
                     for (int i = 0; i < pddt.Rows.Count; i++)
                     {
                         for (int j = 0; j < pddt.Columns.Count; j = j + 2)
                         {

                             string up = "update ACC_PAYABLE set ACC_PAYABLE.Balance=" + pddt.Rows[i].ItemArray[j + 1] + " where ACC_PAYABLE.ExtRef=" + pddt.Rows[i].ItemArray[j];
                             //MessageBox.Show(pddt.Rows[i].ItemArray[j + 1].ToString() + pddt.Rows[i].ItemArray[j].ToString());

                             r5 = Utilities.DataBaseUtility.Execute(ident, up);
                     
                         }
                     }


                     MessageBox.Show("Account Payables Updated");

                 }

                 catch(Exception ex)
                 {
                        
                 }
             }
        



                 


    }
}
