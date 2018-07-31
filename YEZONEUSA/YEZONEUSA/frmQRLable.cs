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
    public partial class frmQRLable : DevExpress.XtraEditors.XtraForm
    {
        SqlConnection con = new SqlConnection(Properties.Settings.Default.connectionString);

        public static int capacity = 512;

        // Write & Read INI file
        [DllImport("kernel32", CharSet = CharSet.Unicode)]
        private static extern int GetPrivateProfileString(string section, string key,
        string defaultValue, StringBuilder value, int size, string filePath);

        [DllImport("kernel32.dll", CharSet = CharSet.Unicode)]
        static extern int GetPrivateProfileString(string section, string key, string defaultValue,
        [In, Out]char[] value, int size, string filePath);

        [DllImport("kernel32.dll", CharSet = CharSet.Auto)]
        private static extern int GetPrivateProfileSection(string section, IntPtr keyValue,
        int size, string filePath);

        [DllImport("kernel32", CharSet = CharSet.Unicode, SetLastError = true)]
        [return: MarshalAs(UnmanagedType.Bool)]
        private static extern bool WritePrivateProfileString(string section, string key,
        string value, string filePath);

        public static string ReadValue(string section, string key, string filePath, string defaultValue = "")
        {
            var value = new StringBuilder(capacity);
            GetPrivateProfileString(section, key, defaultValue, value, value.Capacity, filePath);
            return value.ToString();
        }
        //You can write values with the following code.
        public static bool WriteValue(string section, string key, string value, string filePath)
        {
            bool result = WritePrivateProfileString(section, key, value, filePath);
            return result;
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
            txtPONumber.EditValue = String.Empty;
            txtSupplierID.EditValue = "YZU";
            txtItemCode.EditValue = String.Empty;
            txtItemQuantity.EditValue = "1";
            txtFactoryCode.EditValue = String.Empty;
            txtShipDate.EditValue = GetSystemDate();
            txtSerialNumber.EditValue = "1";
            txtMaterialSource.EditValue = String.Empty;

            txtPONumber.Focus();
        }
        public Boolean SaveValidate()
        {
            Boolean blnRtnValue = true;
            string retMessage = string.Empty;
            if (string.IsNullOrEmpty(txtPONumber.Text) && blnRtnValue)
            {
                retMessage = "Please, check P/O Number!";
                txtPONumber.Focus();
                blnRtnValue = false;
            }
            if (string.IsNullOrEmpty(txtSupplierID.Text) && blnRtnValue)
            {
                retMessage = "Please, check Supplier ID!";
                txtSupplierID.Focus();
                blnRtnValue = false;
            }
            if (string.IsNullOrEmpty(txtItemCode.Text) && blnRtnValue)
            {
                retMessage = "Please, check Item Code!";
                txtItemCode.Focus();
                blnRtnValue = false;
            }
            if (string.IsNullOrEmpty(txtShipDate.Text) && blnRtnValue)
            {
                retMessage = "Please, check Ship Date!";
                txtShipDate.Focus();
                blnRtnValue = false;
            }
            if (blnRtnValue == false)
            {
                MessageBox.Show(retMessage, "Validation Error!", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
            return blnRtnValue;
        }
        public void RetrieveData()
        {
            Reset();
            //string searchValue = "%";
            //try
            //{
            //    searchValue = txtPONumber.EditValue.ToString();
            //    if (string.IsNullOrEmpty(searchValue))
            //    {
            //        searchValue = "%";
            //    }
            //}
            //catch (Exception)
            //{
            //    //throw;
            //}


            //string sqlScripts = @"select * " + "\r\n" +
            //                    "  from tblPacking" + "\r\n" +
            //                    " where ItemNo like '%' + '" + searchValue + "' + '%'" + "\r\n" +
            //                    "    or PONo like '%' + '" + searchValue + "' + '%'" + "\r\n" +
            //                    "	or Status like '%' + '" + searchValue + "' + '%'" + "\r\n" +
            //                    " Order by PackingId Desc";



            //SqlCommand cmd = con.CreateCommand();
            //cmd.CommandType = CommandType.Text;
            ////cmd.CommandText = @"select * from tblPacking";
            //cmd.CommandText = sqlScripts;

            //cmd.ExecuteNonQuery();
            //DataTable dt = new DataTable();
            //SqlDataAdapter da = new SqlDataAdapter(cmd);
            //da.Fill(dt);
            //gcPacking.DataSource = dt;


            //// hide columns
            //gvPacking.Columns["PackingId"].Visible = false;
            //gvPacking.Columns["HostName"].Visible = false;
            //gvPacking.Columns["CreateDate"].Visible = false;
            //gvPacking.Columns["ModifyDate"].Visible = false;

            //gvPacking.OptionsBehavior.ReadOnly = true;
        }
        public struct _QRCode
        {
            public string QRCode;
            public string PONumber;
            public int LineNumber;
            public string SupplierID;
            public string ItemCode;
            public int ItemQuantity;
            public string FactoryCode;
            public string ProductionDate;  //YYMMDD
            public string ShipDate; //YYMMDD
            public int SerialNumber;
            public string MaterialSource; // Reclaim Supply
            public int OrderQty;
            public int ShippedQty;
            public int RemainQty;
            public int ID; // po detail id
            public string CVEReserved1;
            public string CVEReserved2;
            public string SupplierSection;
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
        public Boolean PrintQRCodeLabel(_QRCode qRCode)
        {
            try
            {
                string zpl = "";
                string nl = Convert.ToChar(13).ToString() + Convert.ToChar(10).ToString();
                string QRCode;

                for (int i = 1; i <= Convert.ToInt16(qRCode.ItemQuantity); i++)
                {
                    QRCode = string.Format("{0}|{1}|{2}|{3}|{4}|{5}|{6}|{7}|{8}|{9}|{10}|{11}"
                        , qRCode.PONumber
                        , qRCode.SupplierID
                        , qRCode.ItemCode
                        , qRCode.ItemQuantity.ToString()
                        , qRCode.FactoryCode
                        , qRCode.ProductionDate
                        , qRCode.ShipDate
                        , qRCode.SerialNumber.ToString()
                        , qRCode.MaterialSource
                        , qRCode.CVEReserved1
                        , qRCode.CVEReserved2
                        , qRCode.SupplierSection);

                    if (qRCode.SerialNumber == 0)
                    {
                        qRCode.SerialNumber = 1;
                    }

                    zpl = zpl + "^XA";
                    zpl = zpl + Environment.NewLine + "^MMT";
                    zpl = zpl + Environment.NewLine + "^PW250";
                    zpl = zpl + Environment.NewLine + "^LL0500";
                    zpl = zpl + Environment.NewLine + "^LH0,20";
                    zpl = zpl + Environment.NewLine + "^LS0";
                    zpl = zpl + Environment.NewLine + string.Format("~SD{0}", Convert.ToInt16(txtDarkness.EditValue.ToString()));
                    zpl = zpl + Environment.NewLine + string.Format("^FO0,20^BQ,3,3^FD{0}^FS", QRCode);
                    zpl = zpl + Environment.NewLine + string.Format("^FO100,35^A0N,20,20^FD{0}^FS", qRCode.ItemCode );
                    zpl = zpl + Environment.NewLine + string.Format("^FO100,55^A0N,20,20^FD{0}^FS", qRCode.PONumber);
                    zpl = zpl + Environment.NewLine + string.Format("^FO100,75^A0N,20,20^FD{0}^FS", qRCode.ShipDate);
                    zpl = zpl + Environment.NewLine + string.Format("^FO100,95^A0N,20,20^FD{0}^FS", qRCode.SerialNumber);
                    zpl = zpl + Environment.NewLine + "^XZ";
                    zpl = zpl + Environment.NewLine;

                    qRCode.SerialNumber = qRCode.SerialNumber + 1;

                    //Print2LPT.Print(zpl, lptPort);
                    try
                    {

                        RawPrinterHelper.SendStringToPrinter(lblPrinterName.Text, zpl);

                    }
                    catch (Exception)
                    {

                        throw;
                    }
                    finally
                    {
                        zpl = string.Empty;
                    }

                }
            }
            catch (SystemException ex)
            {
                MessageBox.Show("QR Code printing is not working!" + Environment.NewLine + ex.Message.ToString(), "Error!", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return false;
            }
            return true;
        }

        public Boolean PrintQRCodeLabel(string lptPort, _QRCode qRCode)
        {
            try
            {
                string zpl = "";
                string nl = Convert.ToChar(13).ToString() + Convert.ToChar(10).ToString();
                string QRCode;

                for (int i = 1; i <= Convert.ToInt16(qRCode.ItemQuantity); i++)
                {
                    QRCode = string.Format("{0}|{1}|{2}|{3}|{4}|{5}|{6}|{7}|{8}|{9}|{10}|{11}"
                        , qRCode.PONumber
                        , qRCode.SupplierID
                        , qRCode.ItemCode
                        , qRCode.ItemQuantity.ToString()
                        , qRCode.FactoryCode
                        , qRCode.ProductionDate
                        , qRCode.ShipDate
                        , qRCode.SerialNumber.ToString()
                        , qRCode.MaterialSource
                        , qRCode.CVEReserved1
                        , qRCode.CVEReserved2
                        , qRCode.SupplierSection);

                    if (qRCode.SerialNumber == 0)
                    {
                        qRCode.SerialNumber = 1;
                    }

                    zpl = zpl + "^XA";
                    zpl = zpl + Environment.NewLine + "^MMT";
                    zpl = zpl + Environment.NewLine + "^PW203";
                    zpl = zpl + Environment.NewLine + "^LL0102";
                    zpl = zpl + Environment.NewLine + "^LH10,5";
                    zpl = zpl + Environment.NewLine + "^LS10";
                    zpl = zpl + Environment.NewLine + "^FT20,100^BQ,2,2^FDMA," + QRCode + "^FS";
                    zpl = zpl + Environment.NewLine + "^FO90,20^A0N,12,12^FD" + qRCode.ItemCode + "^FS";
                    zpl = zpl + Environment.NewLine + "^FO90,40^A0N,12,12^FD" + qRCode.PONumber + "^FS";
                    zpl = zpl + Environment.NewLine + "^FO90,60^A0N,12,12^FD" + qRCode.ShipDate + "^FS";
                    zpl = zpl + Environment.NewLine + "^FO90,80^A0N,12,12^FD" + qRCode.SerialNumber + "^FS";
                    zpl = zpl + Environment.NewLine + "^XZ";
                    zpl = zpl + Environment.NewLine;

                    qRCode.SerialNumber = qRCode.SerialNumber + 1;

                }
                Print2LPT.Print(zpl, lptPort);
            }
            catch (SystemException ex)
            {
                MessageBox.Show("QR Code printing is not working!" + Environment.NewLine + ex.Message.ToString(), "Error!", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return false;
            }
            return true;
        }
        public frmQRLable()
        {
            InitializeComponent();
        }

        private void frmQRLable_Load(object sender, EventArgs e)
        {
            string iniFileName = string.Format("{0}\\Setting.INI", Application.StartupPath.ToString());
            string value = ReadValue("Printer", "QRLabelPrinter", iniFileName, "");
            if (value != null && value != "")
            {
                lblPrinterName.Text = value;
            }

            if (con.State == ConnectionState.Open)
            {
                con.Close();
            }
            con.Open();

            Reset();
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
                    lblPrinterName.Text = prtName;
                    string value = prtName;
                    string iniFileName = string.Format("{0}\\Setting.INI", Application.StartupPath.ToString());

                    bool blnReturnValue = WriteValue("Printer", "QRLabelPrinter", value, iniFileName);


                    //if (prtName.ToUpper().Contains("ZEBRA") || prtName.ToUpper().Contains("ZDESIGNER"))
                    //{
                    //    lblPrinterName.Text = prtName;
                    //    string value = prtName;
                    //    string iniFileName = string.Format("{0}\\Setting.INI", Application.StartupPath.ToString());

                    //    bool blnReturnValue = WriteValue("Printer", "QRLabelPrinter", value, iniFileName);

                    //}
                    //else
                    //{
                    //    MessageBox.Show("Choose other printer!(Zebra or ZDesinger)", "message");
                    //}
                }
            }
            catch (Exception)
            {

                throw;
            }
        }

        private void btnPrint_Click(object sender, EventArgs e)
        {
            bool blnRtnValue = true;
            string retMessage = string.Empty;

            string poNumber = string.Empty;
            string supplierId = string.Empty;
            string itemCode = string.Empty;
            string factoryCode = string.Empty;
            DateTime shipDate;
            
            string materialSource = string.Empty;

            int itemQuantity = 0;
            int serialNumber = 0;

            if (string.IsNullOrEmpty(txtPONumber.EditValue.ToString()) && blnRtnValue)
            {
                poNumber = "Please, check P/O Number!";
                txtPONumber.Focus();
                blnRtnValue = false;
            }
            else
            {
                poNumber = txtPONumber.EditValue.ToString();
            }
            if (string.IsNullOrEmpty(txtSupplierID.EditValue.ToString()) && blnRtnValue)
            {
                retMessage = "Please, check Supplier ID!";
                txtSupplierID.Focus();
                blnRtnValue = false;
            }
            else
            {
                supplierId = txtSupplierID.EditValue.ToString();
            }
            if (string.IsNullOrEmpty(txtItemCode.EditValue.ToString()) && blnRtnValue)
            {
                retMessage = "Please, check Item Code!";
                txtItemCode.Focus();
                blnRtnValue = false;
            }
            else
            {
                itemCode = txtItemCode.EditValue.ToString();
            }

            if (string.IsNullOrEmpty(txtShipDate.EditValue.ToString()) && blnRtnValue)
            {
                retMessage = "Please, check Ship Date!";
                txtShipDate.Focus();
                blnRtnValue = false;
            }
            shipDate = Convert.ToDateTime(txtShipDate.DateTime.ToString());


            itemQuantity = Convert.ToInt16(txtItemQuantity.EditValue.ToString()) ;
            serialNumber = Convert.ToInt16(txtSerialNumber.EditValue.ToString());

            if (string.IsNullOrEmpty(txtFactoryCode.EditValue.ToString()) && blnRtnValue)
            {
                //retMessage = "Please, check Item Code!";
                //txtItemCode.Focus();
                //blnRtnValue = false;
                factoryCode = string.Empty;
            }
            else
            {
                factoryCode = txtItemCode.EditValue.ToString();
            }


            if (blnRtnValue == false)
            {
                MessageBox.Show(retMessage, "Warning!", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return;
            }


            // check printer
            if (string.IsNullOrEmpty(lblPrinterName.Text))
            {
                MessageBox.Show("Please, select printer first!", "Warning!", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return;
            }

            try
            {
                materialSource = txtMaterialSource.Properties.GetKeyValueByDisplayText(txtMaterialSource.Text).ToString();
            }
            catch (Exception)
            {
                materialSource = string.Empty;
            }
            
            _QRCode qrCode = new _QRCode();
            qrCode.PONumber = poNumber;
            qrCode.SupplierID = supplierId;
            qrCode.ItemCode = itemCode;
            qrCode.ItemQuantity = itemQuantity;
            qrCode.FactoryCode = txtFactoryCode.EditValue.ToString();
            qrCode.ProductionDate = string.Empty;
            qrCode.ShipDate = shipDate.ToString("yyMMdd");
            qrCode.SerialNumber = serialNumber;
            qrCode.MaterialSource = materialSource;
            qrCode.CVEReserved1 = string.Empty;
            qrCode.CVEReserved2 = string.Empty;

            PrintQRCodeLabel(qrCode);
        }

        private void frmQRLable_Shown(object sender, EventArgs e)
        {
        }
    }
}
