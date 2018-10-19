using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Diagnostics;

namespace fileOpen
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            try
            {
                string strTarget = string.Empty;
                //strTarget = @"D:\Temp\CVE10152018_Group O.xlsx";
                strTarget = "http://google.com/search?q=";
                strTarget += txtString.Text.Trim();

                //strTarget = "https://wwwapps.ups.com/WebTracking/track?track=yes&trackNums=1z1234";
                Process.Start(strTarget);
                //Process.Start(@"D:\Temp\CVE10152018_Group O.xlsx");
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.ToString(), "Exception!", MessageBoxButtons.OK, MessageBoxIcon.Error);
                //throw;
            }
        }

        private void btnUPSTracking_Click(object sender, EventArgs e)
        {
            try
            {
                string strTarget = string.Empty;
                //strTarget = @"D:\Temp\CVE10152018_Group O.xlsx";
                strTarget = "https://wwwapps.ups.com/WebTracking/track?track=yes&trackNums=";
                strTarget += txtString.Text.Trim();
                Process.Start(strTarget);
                //Process.Start(@"D:\Temp\CVE10152018_Group O.xlsx");
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.ToString(), "Exception!", MessageBoxButtons.OK, MessageBoxIcon.Error);
                //throw;
            }
        }
    }
}
