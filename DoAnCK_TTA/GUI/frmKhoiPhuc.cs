using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Text;
using System.Linq;
using System.Threading.Tasks;
using System.Windows.Forms;
using DevExpress.XtraEditors;

namespace DoAnCK_TTA.GUI
{
    public partial class frmKhoiPhuc : DevExpress.XtraEditors.XtraForm
    {
        public frmKhoiPhuc()
        {
            InitializeComponent();
        }

        private void frmKhoiPhuc_Load(object sender, EventArgs e)
        {

        }

        private void btnCLose_Click(object sender, EventArgs e)
        {
            this.Close();
        }
    }
}