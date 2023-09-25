using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace CSharp_dethithu
{
    public partial class frmmain : Form
    {
        public frmmain()
        {
            InitializeComponent();
        }

        private void label1_Click(object sender, EventArgs e)
        {
            string hovaten = "Nguyễn Văn A";
            string mssv = "123456789";
            string monthi = "Lập trình Windows 2 - c#";

            lblInFo.Text = "Họ và Tên: " + hovaten;
            lblInFo.Text += "\n MSSV: " + mssv;
            lblInFo.Text += "\n Ngày thi: " + System.DateTime.Now.ToString();
            lblInFo.Text += "\n Môn Thi: " + monthi;
        }

        private void thoátToolStripMenuItem_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void giớiThiệuToolStripMenuItem_Click(object sender, EventArgs e)
        {
            MessageBox.Show("Chương Trình Tiện Ít", "Thông Tin");
        }

        private void giảiPT2ToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Giải_PT_2 gpt = new Giải_PT_2();
            gpt.Show();
        }

        private void địnhDạngToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Định_Dạng dd = new Định_Dạng();
            dd.Show();
        }
    }
}
