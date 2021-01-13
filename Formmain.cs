using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace quanlygiaothongdothi
{
    public partial class Formmain : Form
    {
        public Formmain()
        {
            InitializeComponent();
        }

        private void đANGXUẤTTHOÁTToolStripMenuItem_Click(object sender, EventArgs e)
        {
           
            ĐĂNG_NHẬPcs DN = new ĐĂNG_NHẬPcs();
            DN.ShowDialog();
           
           
        }

        private void tHOÁTToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }

        private void qUANLÝCHỦXEToolStripMenuItem_Click(object sender, EventArgs e)
        {
            THONG_TIN_CHU_XE CX = new THONG_TIN_CHU_XE();
            CX.ShowDialog();
        }

        private void qUẢNLÝTÀIXẾToolStripMenuItem_Click(object sender, EventArgs e)
        {
            QUẢN_LÝ_TÀI_XẾ TX = new QUẢN_LÝ_TÀI_XẾ();
            TX.ShowDialog();
        }

        private void qUẢNLÝLOẠIXEToolStripMenuItem_Click(object sender, EventArgs e)
        {
            LOẠI_XE LX = new LOẠI_XE();
            LX.ShowDialog();
        }

        private void qUẢNLÝHÓAĐƠNSUACHỮAToolStripMenuItem_Click(object sender, EventArgs e)
        {
            HÓA_ĐƠN_SỬA_CHỮA SC = new HÓA_ĐƠN_SỬA_CHỮA();
            SC.ShowDialog();
        }

        private void qUẢNLÝHỒSƠBẢOTRÌXEToolStripMenuItem_Click(object sender, EventArgs e)
        {
            HỒ_SƠ_BẢO_TRÌ_XE bc = new HỒ_SƠ_BẢO_TRÌ_XE();
            bc.ShowDialog();
        }

        private void qLHỒSƠBẢOHIỂMToolStripMenuItem_Click(object sender, EventArgs e)
        {
          
        }

        private void tRỢGIÚPToolStripMenuItem_Click(object sender, EventArgs e)
        {
            TRỢ_GIÚP tg = new TRỢ_GIÚP();
            tg.ShowDialog();
        }

        private void bẢOHIỂMXEToolStripMenuItem_Click(object sender, EventArgs e)
        {
            HỒ_SƠ_BẢO_BẢO_HIỂM_XE bh = new HỒ_SƠ_BẢO_BẢO_HIỂM_XE();
            bh.ShowDialog();
        }

        private void bẢOHIỂMNGƯỜIToolStripMenuItem_Click(object sender, EventArgs e)
        {
            HỒ_SƠ_BẢO_HIỂM_NGƯỜI bhn = new HỒ_SƠ_BẢO_HIỂM_NGƯỜI();
            bhn.ShowDialog();
        }

        private void lOẠIXEToolStripMenuItem_Click(object sender, EventArgs e)
        {

        }

        private void tHỐNGKÊToolStripMenuItem_Click(object sender, EventArgs e)
        {
            THỐNG_KÊ_XE tk = new THỐNG_KÊ_XE();
            tk.Show();
        }
    }
}
