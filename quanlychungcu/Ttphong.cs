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
    public partial class Ttphong : Form
    {
        SqlConnection conn;
        SqlCommand cmd;
        string str = @"Data Source=DESKTOP-P8ADKQ4\SQLEXPRESS;Initial Catalog=ChungcuBB;Integrated Security=True";
        SqlDataAdapter apt = new SqlDataAdapter();
        DataTable table = new DataTable();
        void loaddata()
        {
            cmd = conn.CreateCommand();
            cmd.CommandText = "select * from phong ";
            apt.SelectCommand = cmd;
            table.Clear();
            apt.Fill(table);
            dgv_ttp.DataSource = table;
        }
      
        public Ttphong()
        {
            InitializeComponent();
        }

        private void button3_Click(object sender, EventArgs e)
        {
            chucnang cn = new chucnang();
            cn.Show();
            this.Hide();
        }

        private void Ttphong_Load(object sender, EventArgs e)
        {
            conn = new SqlConnection(str);
            conn.Open();
            loaddata();
           
        }

        private void dgv_ttp_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
            txt_phong.ReadOnly = true;
            int i;
            i = dgv_ttp.CurrentRow.Index;
            txt_phong.Text = dgv_ttp.Rows[i].Cells[0].Value.ToString();
            txt_gia.Text = dgv_ttp.Rows[i].Cells[1].Value.ToString();
           txt_csvc.Text= dgv_ttp.Rows[i].Cells[2].Value.ToString();
        }

        private void btn_sua_Click(object sender, EventArgs e)
        {
            cmd = conn.CreateCommand();
            cmd.CommandText = "update phong set gia='"+txt_gia.Text+"',csvc= '"+txt_csvc.Text+"' where tenphong='"+txt_phong.Text+"' ";
            cmd.ExecuteNonQuery();
            MessageBox.Show("Sửa thành công");
            loaddata();
        }

        private void btn_find_Click(object sender, EventArgs e)
        {
            cmd = conn.CreateCommand();
            cmd.CommandText = "select * from phong where tenphong='" + txt_phong.Text + "' ";
            apt.SelectCommand = cmd;
            table.Clear();
            apt.Fill(table);
            dgv_ttp.DataSource = table;
        }

        private void button1_Click(object sender, EventArgs e)
        {
            cmd = conn.CreateCommand();
            cmd.CommandText = "insert into phong values '"+txt_phong.Text+"','"+txt_csvc.Text+"','"+txt_gia.Text+"'";
            cmd.ExecuteNonQuery();
            MessageBox.Show("Thêm thành công");
            loaddata();
        }

        private void button2_Click(object sender, EventArgs e)
        {
            cmd = conn.CreateCommand();
            cmd.CommandText = "delete from phong where tenphong='"+txt_phong.Text+"'";
            cmd.ExecuteNonQuery();
            MessageBox.Show("Xóa thành công");
            loaddata();
        }
    }
}
