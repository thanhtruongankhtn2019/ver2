using DoAnCK_TTA.GUI;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace DoAnCK_TTA
{
    public partial class Login : Form
    {
        public Login()
        {
            InitializeComponent();
        }

        private void Login_Load(object sender, EventArgs e)
        {

        }

        private void btnExit_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void btnTuyChon_Click(object sender, EventArgs e)
        {
            MessageBox.Show("Tùy CHọn");
        }

        private void btnDangNhap_Click(object sender, EventArgs e)
        {
            var mainWindow = new formMain();
            mainWindow.Show();
           
        }

        private void btnKetThuc_Click(object sender, EventArgs e)
        {
            this.Close();
        }
    }
}
