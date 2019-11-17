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

namespace DoAnCK_TTA.GUI
{
    public partial class formMain : DevExpress.XtraBars.Ribbon.RibbonForm
    {
        public Bitmap ApplicationIcon { get; set; }
        public formMain()
        {
            InitializeComponent();
        }


        private void barEditItem3_ItemClick(object sender, ItemClickEventArgs e)
        {
            this.Width = 30;
        }

        private void btnThongTin_ItemClick(object sender, ItemClickEventArgs e)
        {
            var mainWindow = new frmThongTin1();
            mainWindow.Show();
        }
        private new Form IsActive(Type type)
        {
            foreach (Form f in this.MdiChildren)
            {
                if (f.GetType() == type)
                {
                    return f;
                }

            }
            return null;
        }

        private void btnPhanQuyen_ItemClick(object sender, DevExpress.XtraBars.ItemClickEventArgs e)
        {
            Form form = IsActive(typeof(frmPhanQuyen));//kiểm tra có show hay không

            if(form ==null)
            {
                frmPhanQuyen f = new frmPhanQuyen();
                f.MdiParent = this;
                f.Text = "Phân Quyền";
                f.Show();
            }
            else
            {
                form.Activate();
            }
        }

      
        private void ribbon_Click(object sender, EventArgs e)
        {

        }

        private void btnDoiMatKhau_ItemClick(object sender, ItemClickEventArgs e)
        {
            frmDoiMatKhau frmChangePassword = new frmDoiMatKhau();
            frmChangePassword.ShowDialog();
        }

        private void formMain_Load(object sender, EventArgs e)
        {

        }

        private void xtraTabPage1_Paint(object sender, PaintEventArgs e)
        {

        }

        private void btnSaoLuu_ItemClick(object sender, ItemClickEventArgs e)
        {
            frmSaoLuu frmBackup = new frmSaoLuu();
            frmBackup.ShowDialog();
        }

        private void btnPhucHoi_ItemClick(object sender, ItemClickEventArgs e)
        {
            frmKhoiPhuc frmRecovery = new frmKhoiPhuc();
            frmRecovery.ShowDialog();
        }

        private void btnSuaChua_ItemClick(object sender, ItemClickEventArgs e)
        {
            frmBaoTri frmMaintenance = new frmBaoTri();
            frmMaintenance.ShowDialog();
        }
    }
}