using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Text;
using System.Linq;
using System.Threading.Tasks;
using System.Windows.Forms;
using DevExpress.XtraBars;
using DevExpress.XtraEditors;
using DevExpress.LookAndFeel;
using System.Runtime.InteropServices;

namespace LTSales
{
    public partial class frmMainRibbon : DevExpress.XtraBars.Ribbon.RibbonForm
    {
        [DllImport("user32.dll", SetLastError = true)]
        internal static extern bool ShowWindowAsync(IntPtr windowHandle, int nCmdShow);

        public frmMainRibbon()
        {
            InitSkins();
            InitializeComponent();
        }

        public void InitSkins()
        {
            DevExpress.Skins.SkinManager.EnableFormSkins();
            DevExpress.UserSkins.BonusSkins.Register();
            UserLookAndFeel.Default.SetSkinStyle(Properties.Settings.Default.LaskSkin);
        }
        private void InitSkinGallery()
        {
            DevExpress.XtraBars.Helpers.SkinHelper.InitSkinGallery(rgbSkins, true);
        }
        public bool IsOpenChildForm(XtraForm childForm)
        {
            foreach (XtraForm item in Application.OpenForms)
            {
                if (item.Name == childForm.Name)
                {
                    return true;
                }
            }
            return false;
        }
        public bool IsOpenChildForm(string className)
        {
            bool rtnResult = false;
            className = className.ToUpper();

            int i = 0;
            while ((i < Application.OpenForms.Count) && (Application.OpenForms[i].Name.ToUpper() != className))
            {
                i++;
            }
            if ( i < Application.OpenForms.Count)
            {
                Application.OpenForms[i].Show();
                Application.OpenForms[i].BringToFront();
                if (Application.OpenForms[i].WindowState == FormWindowState.Minimized)
                {
                    ShowWindowAsync(Application.OpenForms[i].Handle, 9);
                }
                return true;
            }
            return rtnResult;
        }
        private void OpenChildForm(XtraForm childForm)
        {
            if (!IsOpenChildForm(childForm.Name))
            {
                childForm.MdiParent = this;
                childForm.Show();
                childForm.Activate();
            }
        }
        private void frmMainRibbon_FormClosed(object sender, FormClosedEventArgs e)
        {
            Application.Exit();
        }

        private void btnExit_ItemClick(object sender, ItemClickEventArgs e)
        {
            Application.Exit();
        }

        private void btnClose_ItemClick(object sender, ItemClickEventArgs e)
        {
            try
            {
                
            }
            catch (Exception)
            {

                throw;
            }
        }

        private void btnCloseAll_ItemClick(object sender, ItemClickEventArgs e)
        {

            try
            {
                foreach (Form frm in this.MdiChildren)
                {
                    if (frm != Parent)
                    {
                        frm.Close();
                    }
                }
            }
            catch (Exception)
            {

                throw;
            }
        }

        private void frmMainRibbon_FormClosing(object sender, FormClosingEventArgs e)
        {
            Properties.Settings.Default.LaskSkin = UserLookAndFeel.Default.SkinName;
            Properties.Settings.Default.Save();
            Application.ExitThread();
        }

        private void btnPurchase_ItemClick(object sender, ItemClickEventArgs e)
        {
            frmPurchase fm = new frmPurchase();
            OpenChildForm(fm);
        }

        private void frmMainRibbon_Load(object sender, EventArgs e)
        {

        }

        private void btnItemCollection_ItemClick(object sender, ItemClickEventArgs e)
        {
            frmItemCollections fm = new frmItemCollections();
            OpenChildForm(fm);
        }

        private void btnUserManagement_ItemClick(object sender, ItemClickEventArgs e)
        {
            frmUser fm = new frmUser();
            OpenChildForm(fm);
        }
    }
}