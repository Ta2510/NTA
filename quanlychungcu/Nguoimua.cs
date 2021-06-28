using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Data.SqlClient;

namespace quanlychungcu
{
    public partial class Nguoimua : Form
    {
        SqlConnection conn;
        SqlCommand cmd;
        string str = @"Data Source=DESKTOP-P8ADKQ4\SQLEXPRESS;Initial Catalog=ChungcuBB;Integrated Security=True";
        SqlDataAdapter apt = new SqlDataAdapter();
        DataTable table = new DataTable();
        void loaddata()
        {
            cmd = conn.CreateCommand();
            cmd.CommandText = "select * from Nguoimua ";
            apt.SelectCommand = cmd;
            table.Clear();
            apt.Fill(table);
            dgv_nm.DataSource = table;
        }
        public Nguoimua()
        {
            InitializeComponent();
        }

        private void button3_Click(object sender, EventArgs e)
        {
            cmd = conn.CreateCommand();
            cmd.CommandText = "delete from Nguoimua where cmt ='" + txt_cmt.Text + "'";
          
            cmd.ExecuteNonQuery();
            MessageBox.Show("Xóa thành công");
            loaddata();
        }

        private void button4_Click(object sender, EventArgs e)
        {
            chucnang cn = new chucnang();
            cn.Show();
            this.Hide();
        }

        private void Nguoimua_Load(object sender, EventArgs e)
        {
            conn = new SqlConnection(str);
            conn.Open();
            loaddata();
        }

        private void button2_Click(object sender, EventArgs e)
        {
            cmd = conn.CreateCommand();
            cmd.CommandText = "update Nguoimua set tennm ='"+txt_ten.Text+"',ngaysinh='"+txt_ns.Text+"',Gioitinh='"+cbb_gt.SelectedItem+"',quequan='"+txt_qq.Text+"',cmnd='"+txt_cmt.Text+"',sdt='"+txt_sdt.Text+ "' where manm='" + txt_ma.Text + "'";
            cmd.ExecuteNonQuery();
            MessageBox.Show("Sửa thành công");
            loaddata();
        }

       
        private void button1_Click(object sender, EventArgs e)
        {
            cmd = conn.CreateCommand();
            cmd.CommandText = "insert into Nguoimua values('"+txt_ma.Text+"','" + txt_ten.Text + "','"+txt_ns.Text+"','" + cbb_gt.Text + "','" + txt_qq.Text + "','" + txt_cmt.Text + "','" + txt_sdt.Text + "')";
            cmd.ExecuteNonQuery();
            MessageBox.Show("Thêm thành công");
            loaddata();
        }

        private void dgv_nm_CellContentClick_1(object sender, DataGridViewCellEventArgs e)
        {
            int i;
            i = dgv_nm.CurrentRow.Index;
            txt_ma.Text = dgv_nm.Rows[i].Cells[0].Value.ToString();
            txt_ten.Text = dgv_nm.Rows[i].Cells[1].Value.ToString();
            txt_ns.Text = dgv_nm.Rows[i].Cells[3].Value.ToString();
            cbb_gt.Text = dgv_nm.Rows[i].Cells[4].Value.ToString();
            txt_qq.Text = dgv_nm.Rows[i].Cells[5].Value.ToString();
            txt_cmt.Text = dgv_nm.Rows[i].Cells[2].Value.ToString();
            txt_sdt.Text = dgv_nm.Rows[i].Cells[6].Value.ToString();
        }

        private void button5_Click(object sender, EventArgs e)
        {
            cmd = conn.CreateCommand();
            cmd.CommandText = "select * from Nguoimua where manm='" + txt_ma.Text + "' ";
            apt.SelectCommand = cmd;
            table.Clear();
            apt.Fill(table);
            dgv_nm.DataSource = table;
        }

        private void button6_Click(object sender, EventArgs e)
        {
            Nguoimua_Load(sender, e);
            txt_cmt.ResetText();
            txt_ma.ResetText();
            txt_ns.ResetText();
            txt_qq.ResetText();
            txt_sdt.ResetText();
            txt_ten.ResetText();
        
        }
    }
}
