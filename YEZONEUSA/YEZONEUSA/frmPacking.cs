using Microsoft.Win32.SafeHandles;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Data.SqlClient;
using System.Drawing;
using System.Drawing.Printing;
using System.IO;
using System.Linq;
using System.Runtime.InteropServices;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using DevExpress.XtraEditors;
using DevExpress.XtraGrid.Views.Grid.ViewInfo;

namespace YEZONEUSA
{
    public partial class frmPacking : Form
    {
        SqlConnection con = new SqlConnection(Global.ConString);

        public void InitializeFocusedControls()
        {
            txtItem.Properties.AppearanceFocused.BackColor = Color.Yellow;
            txtItem.Properties.AppearanceReadOnly.BackColor = Color.LightGoldenrodYellow;
            txtQuantity.Properties.AppearanceFocused.BackColor = Color.Yellow;
            txtQuantity.Properties.AppearanceReadOnly.BackColor = Color.LightGoldenrodYellow;
            txtPO.Properties.AppearanceFocused.BackColor = Color.Yellow;
            txtPO.Properties.AppearanceReadOnly.BackColor = Color.LightGoldenrodYellow;
            txtItemStatus.Properties.AppearanceFocused.BackColor = Color.Yellow;
            txtItemStatus.Properties.AppearanceReadOnly.BackColor = Color.LightGoldenrodYellow;
            txtSearch.Properties.AppearanceFocused.BackColor = Color.Yellow;
            txtSearch.Properties.AppearanceReadOnly.BackColor = Color.LightGoldenrodYellow;
        }

        public DateTime GetSystemDate()
        {
            string sql = "select getdate() as GetSystemDate";

            SqlCommand cmd = con.CreateCommand();
            cmd.CommandType = CommandType.Text;
            cmd.CommandText = sql;

            DateTime? dtSystemDate = null;
            var value = cmd.ExecuteScalar();
            if (value != null)
            {
                dtSystemDate = Convert.ToDateTime(value.ToString());
            }
            DateTime dt;
            dt = dtSystemDate ?? DateTime.Now;

            return dt;
        }
        public void Reset()
        {
            txtItem.EditValue = string.Empty;
            txtQuantity.EditValue = string.Empty;
            txtPO.EditValue = string.Empty;
            txtItemStatus.EditValue = string.Empty;

            datePacking.EditValue = GetSystemDate();
        }
        public void RetrieveData()
        {
            SqlCommand cmd = con.CreateCommand();
            cmd.CommandType = CommandType.Text;
            cmd.CommandText = "select * from tblPacking";
            cmd.ExecuteNonQuery();
            DataTable dt = new DataTable();
            SqlDataAdapter da = new SqlDataAdapter(cmd);
            da.Fill(dt);
            gcPacking.DataSource = dt;


            // hide columns
            //gvPacking.Columns["PackingId"].Visible = false;
            //gvPacking.Columns["HostName"].Visible = false;
            //gvPacking.Columns["CreateDate"].Visible = false;
            //gvPacking.Columns["ModifyDate"].Visible = false;

            gvPacking.OptionsBehavior.ReadOnly = true;

        }
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
        public Boolean PrintShipBoxLabel(_ShipBoxLable ShipBoxID)
        {
            try
            {
                //ShipBoxID.ItemCode = txtItem.EditValue.ToString();
                //ShipBoxID.Quantity = txtQuantity.EditValue.ToString();
                //ShipBoxID.Status = txtItemStatus.EditValue.ToString();
                //ShipBoxID.ShipDate = Convert.ToDateTime(datePacking.Text).ToString("MM-dd-yyyy");
                //ShipBoxID.Shipper = lblShipper.Text.ToString();
                //ShipBoxID.PONumber = txtPO.EditValue.ToString();

                string zpl = "";

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
                zpl = zpl + Environment.NewLine + @"^FT0740,0800^BY3,3,60^BCB,,N,N^FD" + ShipBoxID.PONumber + "^FS";
                zpl = zpl + Environment.NewLine + @"^PQ1,0,1,Y^XZ";

                //Print2LPT.Print(zpl, lptPort);

                try
                {

                    RawPrinterHelper.SendStringToPrinter(lblPrinter.Text, zpl);
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
        public Boolean PrintShipBoxLabel(string lptPort, _ShipBoxLable ShipBoxID)
        {
            try
            {
                ShipBoxID.ItemCode = txtItem.EditValue.ToString();
                ShipBoxID.Quantity = txtQuantity.EditValue.ToString();
                ShipBoxID.Status = txtItemStatus.EditValue.ToString();
                ShipBoxID.ShipDate = Convert.ToDateTime(datePacking.Text).ToString("MM-dd-yyyy");
                ShipBoxID.Shipper = lblShipper.Text.ToString();
                ShipBoxID.PONumber = txtPO.EditValue.ToString();

                string zpl = "";

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
                zpl = zpl + Environment.NewLine + @"^FT0740,0800^BY3,3,60^BCB,,N,N^FD" + ShipBoxID.PONumber + "^FS";
                zpl = zpl + Environment.NewLine + @"^PQ1,0,1,Y^XZ";

                //Print2LPT.Print(zpl, lptPort);

                try
                {

                    RawPrinterHelper.SendStringToPrinter(lblPrinter.Text, zpl);
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
        private void Edit(bool value)
        {
            txtItem.Enabled = value;
            txtQuantity.Enabled = value;
            txtPO.Enabled = value;
            txtItemStatus.Enabled = value;
            datePacking.Enabled = value;
        }
        public frmPacking()
        {
            InitializeComponent();
        }

        private void frmPacking_Load(object sender, EventArgs e)
        {

            if (con.State == ConnectionState.Open)
            {
                con.Close();
            }
            con.Open();

            datePacking.EditValue = DateTime.Now;
            Edit(false);

            InitializeFocusedControls();
            RetrieveData();
        }

        private void btnPrinter_Click(object sender, EventArgs e)
        {
            try
            {
                PrintDialog prtdig = new PrintDialog();
                //string strPrintName = GetDefaultPrinter();
                if (prtdig.ShowDialog() == DialogResult.OK)
                {
                    string prtName = prtdig.PrinterSettings.PrinterName;
                    if (prtName.ToUpper().Contains("ZEBRA") || prtName.ToUpper().Contains("ZDESIGNER"))
                        { lblPrinter.Text = prtName; }
                    else
                        {MessageBox.Show("Choose other printer!(Zebra or ZDesinger)", "message");
                    }
                }
            }
            catch (Exception)
            {

                throw;
            }
        }

        private void btnNew_Click(object sender, EventArgs e)
        {
            try
            {
                Edit(true);
                Reset();

                txtItem.Focus();
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message, "Message", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void txtItem_Validating(object sender, CancelEventArgs e)
        {
            //string currentValue = (sender as TextEdit).Text;
            //if (string.IsNullOrEmpty(currentValue))
            //{
            //    e.Cancel = true;
            //}
        }

        private void btnEdit_Click(object sender, EventArgs e)
        {
            Edit(true);
            txtItem.Focus();
        }


        private void btnSave_Click(object sender, EventArgs e)
        {
            try
            {
                string sqlScripts = string.Empty;

                Edit(false);
                string packingID = txtID.EditValue.ToString();
                if (string.IsNullOrEmpty(packingID))
                {
                    packingID = "";
                }
                string itemNo = txtItem.EditValue.ToString();
                int quantity = Convert.ToInt16(txtQuantity.EditValue.ToString());
                string poNo = txtPO.EditValue.ToString();
                String itemStatus = txtItemStatus.EditValue.ToString();
                DateTime packingDate = Convert.ToDateTime(datePacking.EditValue.ToString());
                string hostName = Environment.MachineName.ToString();
                DateTime createDate = DateTime.Now;
                DateTime modifiyDate = DateTime.Now;

                switch (packingID)
                {
                    case "": // insert
                        sqlScripts = @"insert into tblPacking(ItemNo, Quantity, PONo, Status, PackingDate, HostName, CreateDate, ModifyDate)
                                       values ('" + itemNo + "', " + quantity + ", '" + poNo + "', '" + itemStatus + "', '" + packingDate + "', '" + hostName + "', '" + createDate + "', '" + modifiyDate + "')";
                        SqlCommand insertCommand = con.CreateCommand();
                        insertCommand.CommandType = CommandType.Text;
                        insertCommand.CommandText = sqlScripts;
                        insertCommand.ExecuteNonQuery();
                        break;
                    default: // update
                        sqlScripts =
                            "update tblPacking" + "\r\n" +
                            "   set ItemNo = '" + itemNo + "'" + "\r\n" +
                            "     , Quantity = " + quantity + "\r\n" +
                            "     , PONo = '" + poNo + "'" + "\r\n" +
                            "     , Status = '" + itemStatus + "'" + "\r\n" +
                            "     , PackingDate = '" + packingDate +  "'" + "\r\n" +
                            "     , HostName = HOST_NAME()" + "\r\n" +
                            "     , ModifyDate = GETDATE()" + "\r\n" +
                            " where PackingID = " + packingID;
                        SqlCommand updateCommand = con.CreateCommand();
                        updateCommand.CommandType = CommandType.Text;
                        updateCommand.CommandText = sqlScripts;
                        updateCommand.ExecuteNonQuery();
                        break;
                }
                MessageBox.Show("Your data has been successfully saved.", "Message", MessageBoxButtons.OK, MessageBoxIcon.Information);

                if (chkSavePrint.Checked)
                {
                    // print 
                    btnPrint.PerformClick();
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message, "Message", MessageBoxButtons.OK, MessageBoxIcon.Error);
                //throw;
            }
            finally
            {
                Reset();
                RetrieveData();
                txtItem.Focus();
            }
        }

        private void btnPrint_Click(object sender, EventArgs e)
        {

            // validate item
            if (string.IsNullOrEmpty(txtItem.EditValue.ToString()))
            {
                return;
            }
            // check printer
            if (string.IsNullOrEmpty(lblPrinter.Text))
            {
                MessageBox.Show("Please, select printer first!", "Warning!", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return;
            }
            _ShipBoxLable sHipBox = new _ShipBoxLable();
            sHipBox.ItemCode = txtItem.EditValue.ToString();
            sHipBox.Quantity = txtQuantity.EditValue.ToString();
            sHipBox.Status = txtItemStatus.EditValue.ToString();
            sHipBox.ShipDate = Convert.ToDateTime(datePacking.Text).ToString("MM-dd-yyyy");
            sHipBox.Shipper = lblShipper.Text.ToString();
            sHipBox.PONumber = txtPO.EditValue.ToString();
            try
            {
                PrintShipBoxLabel(sHipBox);
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message.ToString(), "Print Error!", MessageBoxButtons.OK, MessageBoxIcon.Error);
                //throw;
                return;
            }
        }


        private void gvPacking_FocusedRowChanged(object sender, DevExpress.XtraGrid.Views.Base.FocusedRowChangedEventArgs e)
        {
            if (gvPacking.RowCount == 0 )
            {
                return;
            }
            try
            {
                //txtID.EditValue = gvPacking.GetRowCellValue(gvPacking.FocusedRowHandle, "PackingID").ToString();
                var PackingID = gvPacking.GetRowCellValue(gvPacking.FocusedRowHandle, "PackingID");
                txtItem.EditValue = gvPacking.GetRowCellValue(gvPacking.FocusedRowHandle, "ItemNo").ToString();
                txtQuantity.EditValue = gvPacking.GetRowCellValue(gvPacking.FocusedRowHandle, "Quantity").ToString();
                txtPO.EditValue = gvPacking.GetRowCellValue(gvPacking.FocusedRowHandle, "PONo").ToString();
                txtItemStatus.EditValue = gvPacking.GetRowCellValue(gvPacking.FocusedRowHandle, "Status").ToString();
                datePacking.EditValue = Convert.ToDateTime(gvPacking.GetRowCellValue(gvPacking.FocusedRowHandle, "PackingDate").ToString());
            }
            catch (Exception ex )
            {
                MessageBox.Show(ex.Message.ToString(), "Warning!", MessageBoxButtons.OK, MessageBoxIcon.Error);
                //throw;
            }
        }

        private void btnDelete_Click(object sender, EventArgs e)
        {
            try
            {

            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message.ToString(), "Error!", MessageBoxButtons.OK, MessageBoxIcon.Error);
                //throw;
            }
            finally
            {
                Reset();
                RetrieveData();
            }
        }
    }
}
