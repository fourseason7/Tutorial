using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;
using MaterialSkin;
using System.Runtime.InteropServices;
using Microsoft.Win32.SafeHandles;
using System.IO;
using System.Drawing.Printing;

namespace PackingLabel
{
    public partial class frmPackingLabel : MaterialSkin.Controls.MaterialForm
    {
        public struct _ShipBoxLable
        {
            public string ItemCode;
            public string Quantity;
            public string Status;
            public string ShipDate;
            public string Shipper;
            public string PONumber;
        }
        
        public string GetDefaultPrinter()
        {
            PrinterSettings settings = new PrinterSettings();
            return settings.PrinterName;
        }
        public static class Print2LPT
        {
            [DllImport("kernel32.dll", SetLastError = true)]
            static extern SafeFileHandle CreateFile(string lpFileName, FileAccess dwDesiredAccess, uint dwShareMode, IntPtr lpSecurityAttributes, FileMode dwCreationDisposition, uint dwFlagsAndAttributes, IntPtr hTemplateFile);

            public static bool PrintSample2LPT()
            {
                string nl = Convert.ToChar(13).ToString() + Convert.ToChar(10).ToString();
                bool IsConnected = false;

                string sampleText = "Hello World!" + nl +
                "Enjoy Printing...";
                try
                {
                    Byte[] buffer = new byte[sampleText.Length];
                    buffer = System.Text.Encoding.ASCII.GetBytes(sampleText);

                    SafeFileHandle fh = CreateFile("LPT2:", FileAccess.Write, 0, IntPtr.Zero, FileMode.OpenOrCreate, 0, IntPtr.Zero);
                    if (!fh.IsInvalid)
                    {
                        IsConnected = true;
                        FileStream lpt1 = new FileStream(fh, FileAccess.ReadWrite);
                        lpt1.Write(buffer, 0, buffer.Length);
                        lpt1.Close();
                    }

                }
                catch (Exception ex)
                {
                    string message = ex.Message;
                }

                return IsConnected;
            }
            public static bool Print(string printText, string lptPort)
            {
                bool IsConnected = false;

                //string sampleText = "Hello World!" + nl +
                //"Enjoy Printing...";
                try
                {
                    Byte[] buffer = new byte[printText.Length];
                    buffer = System.Text.Encoding.ASCII.GetBytes(printText);

                    SafeFileHandle fh = CreateFile(lptPort, FileAccess.Write, 0, IntPtr.Zero, FileMode.OpenOrCreate, 0, IntPtr.Zero);
                    if (!fh.IsInvalid)
                    {
                        IsConnected = true;
                        FileStream lpt = new FileStream(fh, FileAccess.ReadWrite);
                        lpt.Write(buffer, 0, buffer.Length);
                        lpt.Close();
                    }
                }
                catch (Exception ex)
                {
                    string message = ex.Message;
                }
                return IsConnected;
            }
        }
       public Boolean PrintShipBoxLabel(string lptPort, _ShipBoxLable ShipBoxID)
        {
            try
            {
                ShipBoxID.ItemCode = txtItem.Text.ToString();
                ShipBoxID.Quantity = txtQuantity.Text.ToString();
                ShipBoxID.Status = txtStatus.Text.ToString();
                ShipBoxID.ShipDate = dtpPackingDate.Value.ToString("MM-dd-yyyy");
                ShipBoxID.Shipper = txtShipper.Text.ToString();
                ShipBoxID.PONumber = txtPONo.Text.ToString();

                string zpl = "";
                //zpl = zpl + Environment.NewLine + "^XA";
                //zpl = zpl + Environment.NewLine + "^MMT";
                ////zpl = zpl + Environment.NewLine + string.Format("^LS{0}", Convert.ToInt16(barEditLabelShift.EditValue.ToString()).ToString());
                //zpl = zpl + Environment.NewLine + "^LS0";
                //zpl = zpl + Environment.NewLine + "^FO0080,0080^GB0730,1100,4^FS"; // outline
                //zpl = zpl + Environment.NewLine + "^FO0080,0850^GB0730,0000,4^FS"; // separate line
                //zpl = zpl + Environment.NewLine + "^FT0160,1100^A0B,58,58^FDBox ID^FS";
                //zpl = zpl + Environment.NewLine + "^FT0160,0800^A0B,58,58^FD" + ShipBoxID.ShipBoxNo + "^FS";
                //zpl = zpl + Environment.NewLine + "^FT0230,0800^BY3,3,50^BCB,,N,N^FD" + ShipBoxID.ShipBoxNo + "^FS";
                //zpl = zpl + Environment.NewLine + "^FT0300,1100^A0B,58,58^FDQuantity^FS";
                //zpl = zpl + Environment.NewLine + "^FT0300,0800^A0B,58,58^FD" + ShipBoxID.Quantity + "^FS";

                //zpl = zpl + Environment.NewLine + "^FT0370,1100^A0B,58,58^FDItem#^FS";
                //zpl = zpl + Environment.NewLine + "^FT0370,0800^A0B,58,58^FD" + ShipBoxID.ItemCode + "^FS";
                //zpl = zpl + Environment.NewLine + "^FT0440,0800^BY3,3,50^BCB,,N,N^FD" + ShipBoxID.ItemCode + "^FS";

                //zpl = zpl + Environment.NewLine + "^FT0510,1100^A0B,58,58^FDStatus^FS";
                //zpl = zpl + Environment.NewLine + "^FT0510,0800^A0B,58,58^FD" + ShipBoxID.Status + "^FS";
                //zpl = zpl + Environment.NewLine + "^FT0580,1100^A0B,58,58^FDDate^FS";
                //zpl = zpl + Environment.NewLine + "^FT0580,0800^A0B,58,58^FD" + ShipBoxID.Date + "^FS";
                //zpl = zpl + Environment.NewLine + "^FT0650,1100^A0B,58,58^FDShipper^FS";
                //zpl = zpl + Environment.NewLine + "^FT0650,0800^A0B,58,58^FDEG2 Mobile Technology^FS";
                //zpl = zpl + Environment.NewLine + "^FT0720,1100^A0B,58,58^FDPO#^FS";
                //zpl = zpl + Environment.NewLine + "^FT0720,0800^A0B,58,58^FD" + ShipBoxID.PONumber + "^FS";
                //zpl = zpl + Environment.NewLine + "^FT0790,0800^BY3,3,50^BCB,,N,N^FD" + ShipBoxID.PONumber + "^FS";
                //zpl = zpl + Environment.NewLine + "^PQ1,0,1,Y^XZ";

                zpl = zpl + Environment.NewLine + @"^XA";
                zpl = zpl + Environment.NewLine + @"^MMT";
                zpl = zpl + Environment.NewLine + @"^LS0";
                zpl = zpl + Environment.NewLine + @"^FO0080,0080^GB0680,1100,4^FS";
                zpl = zpl + Environment.NewLine + @"^FO0080,0850^GB0680,0000,4^FS";
                zpl = zpl + Environment.NewLine + @"^FT0160,1100^A0B,58,58^FH\^FDItem#^FS";
                zpl = zpl + Environment.NewLine + @"^FT0160,0800^A0B,58,58^FH\^FD" + ShipBoxID.ItemCode + "^FS";
                zpl = zpl + Environment.NewLine + @"^FT0260,1100^A0B,58,58^FH\^FDQuantity^FS";
                zpl = zpl + Environment.NewLine + @"^FT0260,0800^A0B,58,58^FH\^FD" + ShipBoxID.Quantity + "^FS";
                zpl = zpl + Environment.NewLine + @"^FT0360,1100^A0B,58,58^FH\^FDStatus^FS";
                zpl = zpl + Environment.NewLine + @"^FT0360,0800^A0B,58,58^FH\^FD" + ShipBoxID.Status + "^FS";
                zpl = zpl + Environment.NewLine + @"^FT0460,1100^A0B,58,58^FH\^FDDate^FS";
                zpl = zpl + Environment.NewLine + @"^FT0460,0800^A0B,58,58^FH\^FD" + ShipBoxID.ShipDate + "^FS";
                zpl = zpl + Environment.NewLine + @"^FT0560,1100^A0B,58,58^FH\^FDShipper^FS";
                zpl = zpl + Environment.NewLine + @"^FT0560,0800^A0B,58,58^FH\^FD" + ShipBoxID.Shipper + "^FS";
                zpl = zpl + Environment.NewLine + @"^FT0660,1100^A0B,58,58^FH\^FDPO#^FS";
                zpl = zpl + Environment.NewLine + @"^FT0660,0800^A0B,58,58^FH\^FD" + ShipBoxID.PONumber + "^FS";
                zpl = zpl + Environment.NewLine + @"^FT0740,0800^BY3,3,60^BCB,,N,N^FD"+ ShipBoxID.PONumber + "^FS";
                zpl = zpl + Environment.NewLine + @"^PQ1,0,1,Y^XZ";

                //zpl = zpl + Environment.NewLine + @"^XA";
                //zpl = zpl + Environment.NewLine + @"^MMT";
                //zpl = zpl + Environment.NewLine + @"^LS0";
                //zpl = zpl + Environment.NewLine + @"^FO0080,0080^GB0680,1100,4^FS";
                //zpl = zpl + Environment.NewLine + @"^FO0080,0850^GB0680,0000,4^FS";
                //zpl = zpl + Environment.NewLine + @"^FT0160,1100^A0B,58,58^FH\^FDItem#^FS";
                //zpl = zpl + Environment.NewLine + @"^FT0160,0800^A0B,58,58^FH\^FDOCTA-M919-W^FS";
                //zpl = zpl + Environment.NewLine + @"^FT0260,1100^A0B,58,58^FH\^FDQuantity^FS";
                //zpl = zpl + Environment.NewLine + @"^FT0260,0800^A0B,58,58^FH\^FD100^FS";
                //zpl = zpl + Environment.NewLine + @"^FT0360,1100^A0B,58,58^FH\^FDStatus^FS";
                //zpl = zpl + Environment.NewLine + @"^FT0360,0800^A0B,58,58^FH\^FDFunction Fail^FS";
                //zpl = zpl + Environment.NewLine + @"^FT0460,1100^A0B,58,58^FH\^FDDate^FS";
                //zpl = zpl + Environment.NewLine + @"^FT0460,0800^A0B,58,58^FH\^FD01/22/2016^FS";
                //zpl = zpl + Environment.NewLine + @"^FT0560,1100^A0B,58,58^FH\^FDShipper^FS";
                //zpl = zpl + Environment.NewLine + @"^FT0560,0800^A0B,58,58^FH\^FDTest Technology^FS";
                //zpl = zpl + Environment.NewLine + @"^FT0660,1100^A0B,58,58^FH\^FDPO#^FS";
                //zpl = zpl + Environment.NewLine + @"^FT0660,0800^A0B,58,58^FH\^FDTEST_N20150727-01^FS";
                //zpl = zpl + Environment.NewLine + @"^FT0740,0800^BY3,3,60^BCB,,N,N^FDTEST_N20150727-01^FS";
                //zpl = zpl + Environment.NewLine + @"^PQ1,0,1,Y^XZ";


                //Print2LPT.Print(zpl, lptPort);

                try
                {
                    
                    RawPrinterHelper.SendStringToPrinter(txtPrinterName.Text, zpl);
                }
                catch (Exception)
                {

                    throw;
                }
                
            }
            catch (SystemException ex)
            {
                MessageBox.Show("QR Code printing is not working!" + Environment.NewLine + ex.Message.ToString(), "Error!", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return false;
            }
            return true;
        }


        public frmPackingLabel()
        {
            InitializeComponent();
            var skinManager = MaterialSkinManager.Instance;
            skinManager.AddFormToManage(this);
            skinManager.Theme = MaterialSkinManager.Themes.DARK;
            skinManager.ColorScheme = new ColorScheme(Primary.BlueGrey800, Primary.BlueGrey900, Primary.BlueGrey500, Accent.LightBlue200, TextShade.WHITE);
        }

        private void frmPackingLabel_Load(object sender, EventArgs e)
        {
            // TODO: This line of code loads data into the 'lTSolutionsDataSet.tblPacking' table. You can move, or remove it, as needed.
            this.tblPackingTableAdapter.Fill(this.lTSolutionsDataSet.tblPacking);
            Edit(false);
            txtShipper.Text = "YEZONEUSA";

        }
        private void Edit(bool value)
        {
            txtItem.Enabled = value;
            txtQuantity.Enabled = value;
            txtPONo.Enabled = value;
            txtStatus.Enabled = value;
            dtpPackingDate.Enabled = value;

        }

        private void btnNew_Click(object sender, EventArgs e)
        {
            try
            {
                Edit(true);
                lTSolutionsDataSet.tblPacking.AddtblPackingRow(lTSolutionsDataSet.tblPacking.NewtblPackingRow());
                tblPackingBindingSource.MoveLast();
                txtItem.Focus();
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message, "Message", MessageBoxButtons.OK, MessageBoxIcon.Error);
                //throw;
                lTSolutionsDataSet.tblPacking.RejectChanges();
            }
        }

        private void btnEdit_Click(object sender, EventArgs e)
        {
            Edit(true);
            txtItem.Focus();
        }

        private void btnCancel_Click(object sender, EventArgs e)
        {
            Edit(false);
            tblPackingBindingSource.ResetBindings(false);
        }

        private void btnSave_Click(object sender, EventArgs e)
        {
            try
            {
                Edit(false);
                tblPackingBindingSource.EndEdit();
                tblPackingTableAdapter.Update(lTSolutionsDataSet.tblPacking);
                dataGridView1.Refresh();
                txtItem.Focus();

                MessageBox.Show("Your data has been successfully saved.", "Message", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message, "Message", MessageBoxButtons.OK, MessageBoxIcon.Error);
                //throw;
                lTSolutionsDataSet.tblPacking.RejectChanges();
            }

        }

        private void dataGridView1_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (e.KeyChar == (char)13) //enter
            {
                if (MessageBox.Show("Are you sure want to delete this record?", "Message", MessageBoxButtons.YesNo, MessageBoxIcon.Question) == DialogResult.Yes)
                    tblPackingBindingSource.RemoveCurrent();
            }
        }


        private void btnPrint_Click(object sender, EventArgs e)
        {
            _ShipBoxLable sHipBox = new _ShipBoxLable();
            //sHipBox.PONumber = strPONumber;
            //sHipBox.Model = strItemCode;
            //sHipBox.ItemCode = strItemShipping;
            //sHipBox.Quantity = intShipQty.ToString();

            try
            {
                ////string strPrintName = GetDefaultPrinter();
                //if (printDialog1.ShowDialog() == DialogResult.OK)
                //{
                //    string prtName = printDialog1.PrinterSettings.PrinterName;
                //}

                PrintShipBoxLabel("LPT2", sHipBox);
            }
            catch (Exception)
            {

                throw;
            }


            
        }

        private void btnPrinter_Click(object sender, EventArgs e)
        {
            try
            {
                //string strPrintName = GetDefaultPrinter();
                if (printDialog1.ShowDialog() == DialogResult.OK)
                {
                    string prtName = printDialog1.PrinterSettings.PrinterName;
                    if (prtName.ToUpper().Contains("ZEBRA") || prtName.ToUpper().Contains("ZDESIGNER"))
                        { txtPrinterName.Text = prtName; }
                    else
                        {MessageBox.Show("Choose other printer!", "message");
                    }
                }
            }
            catch (Exception)
            {

                throw;
            }

        }
    }
}
