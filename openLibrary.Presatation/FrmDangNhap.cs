using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using OpenLibrary.Bussiness;

namespace openLibrary.Presatation
{
    public partial class FrmDangNhap : Form
    {
        public FrmDangNhap()
        {
            InitializeComponent();
        }

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void FrmDangNhap_Load(object sender, EventArgs e)
        {

        }

        private void simpleButton2_Click(object sender, EventArgs e)
        {

        }

        private void simpleButton1_Click(object sender, EventArgs e)
        {
            if (!validData())
            {
                return;
            }
            bool xacthucthongtin = ctrDangNhap.login(txtUserName.Text, txtPassword.Text);
            if (xacthucthongtin)
            {
                var f = (FrmMain)this.ParentForm;
                f.xuLyLogin();
                this.Close();
            }
            else MessageBox.Show("Sai Username và Password", "Lỗi Đăng nhập", MessageBoxButtons.OK, MessageBoxIcon.Error);
        
    }

        private void txtUserName_TextChanged(object sender, EventArgs e)
        {

        }
        CtrDangNhap ctrDangNhap = new CtrDangNhap();
        private bool validData()
        {
            errorProvider1.SetError(txtUserName, ((txtUserName.Text == "") ? "Hãy nhập Username" : ""));
            errorProvider2.SetError(txtPassword, ((txtPassword.Text == "") ? "Hãy nhập Password" : ""));
            return (txtUserName.Text != "" && txtPassword.Text != "");
        }
        private void BtnDangNhapdn_Click(object sender, EventArgs e)
        {
            if (!validData())
            {
                return;
            }
            bool xacthucthongtin = ctrDangNhap.login(txtUserName.Text, txtPassword.Text);
            if (xacthucthongtin)
            {
                var f = (FrmMain)this.ParentForm;
                f.xuLyLogin();
                this.Close();
            }
            else MessageBox.Show("Sai Username và Password", "Lỗi Đăng nhập", MessageBoxButtons.OK, MessageBoxIcon.Error);
        }
        private void btnThoatDangNhap_Click(object sender, EventArgs e)
        {
            this.Close();
        }
    }
}
