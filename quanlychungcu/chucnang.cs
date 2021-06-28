using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace quanlychungcu
{
    public partial class chucnang : Form
    {
        public chucnang()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            Ttphong ttp = new Ttphong();
            ttp.Show();
            this.Hide();
        }

        private void button2_Click(object sender, EventArgs e)
        {
            HDmp hdmp = new HDmp();
            hdmp.Show();
            this.Hide();

        }

        private void button3_Click(object sender, EventArgs e)
        {
           
        }

        private void button4_Click(object sender, EventArgs e)
        {
            Nguoimua nguoimua = new Nguoimua();
            nguoimua.Show();
            this.Hide();
        }

        private void button5_Click(object sender, EventArgs e)
        {
            qldien qld = new qldien();
            qld.Show();
            this.Hide();
        }

        private void button6_Click(object sender, EventArgs e)
        {
            qlnuoc qln = new qlnuoc();
            qln.Show();
            this.Hide();

        }

        private void groupBox1_Enter(object sender, EventArgs e)
        {

        }

        private void groupBox3_Enter(object sender, EventArgs e)
        {

        }

        private void button12_Click(object sender, EventArgs e)
        {
            Dangnhap dn = new Dangnhap();
            dn.Show();
            this.Hide();
        }

        private void button7_Click(object sender, EventArgs e)
        {
            hethongns ht = new hethongns();
            ht.Show();
            this.Hide();
        }

        private void button8_Click(object sender, EventArgs e)
        {
            Luong luong = new Luong();
            luong.Show();
            this.Hide();

        }

        private void button9_Click(object sender, EventArgs e)
        {
            csvc csvc = new csvc();
            csvc.Show();
            this.Hide();
        }

        private void button10_Click(object sender, EventArgs e)
        {
            guixe guixe = new guixe();
            guixe.Show();
            this.Hide();
        }

        private void button11_Click(object sender, EventArgs e)
        {
            Vesinh vs = new Vesinh();
            vs.Show();
            this.Hide();
        }
    }
}
