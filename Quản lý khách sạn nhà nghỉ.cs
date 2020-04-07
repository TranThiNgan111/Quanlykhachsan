using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Data.SqlClient;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace QUẢN_LÝ_KHÁCH_SẠN
{
    public partial class Quản_lý_khách_sạn_nhà_nghỉ : Form
    {
        SqlConnection con = new SqlConnection();


        public Quản_lý_khách_sạn_nhà_nghỉ()
        {
            InitializeComponent();
        }

        private void Quản_lý_khách_sạn_nhà_nghỉ_Load(object sender, EventArgs e)
        {
            string connectionString = "Data Source=localhost\\SQLEXPRESS2012;Initial Catalog=QuanLyKhachSan;Integrated Security=True";
            con.ConnectionString = connectionString;
            con.Open();

            loaddatatoGridview();

          //  string sql = "Select * From tbl_Phong";
           // SqlDataAdapter adp = new SqlDataAdapter(sql, con);
           // DataTable tabletbl_Phong = new DataTable();
           // adp.Fill(tabletbl_Phong);
          //  dataGridView_Phong.DataSource = tabletbl_Phong;
        }

        private void button1_Click(object sender, EventArgs e)
        {
            string sql = "Delete From tbl_Phong Where Maphong = '" + txtMaphong.Text + "'";
            SqlCommand cmd = new SqlCommand(sql, con);
            cmd.ExecuteNonQuery();
            loaddatatoGridview();


        }
         private void loaddatatoGridview()
        {
            string sql = " Select * From tbl_Phong";
            SqlDataAdapter adp = new SqlDataAdapter(sql, con);
            DataTable tabletbl_Phong = new DataTable();
            adp.Fill(tabletbl_Phong);
            dataGridView_Phong.DataSource = tabletbl_Phong;
        }

        private void dataGridView_Phong_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
            txtMaphong.Text = dataGridView_Phong.CurrentRow.Cells["Maphong"].Value.ToString();
            txtTenphong.Text = dataGridView_Phong.CurrentRow.Cells["Tenphong"].Value.ToString();
            txtDongia.Text = dataGridView_Phong.CurrentRow.Cells["Dongia"].Value.ToString();

            txtMaphong.Enabled = false;
        }

        private void bntThem_Click(object sender, EventArgs e)
        {
            txtMaphong.Text = "";
            txtTenphong.Text = "";
            txtDongia.Text = "";
            txtMaphong.Enabled = true;
        }

        private void bntLuu_Click(object sender, EventArgs e)
        {
            if (txtMaphong.Text == "")
            {
                MessageBox.Show("Bạn cần nhập mã phòng");
                txtMaphong.Focus();
                return;
            }
            if(txtTenphong.Text=="")
            {
                MessageBox.Show("Bạn cần nhập tên phòng ");
                txtTenphong.Focus();

            }
            else
            {
                // insert into tbl_Phong values ()
                string sql = "insert into tbl_Phong values ('" + txtMaphong.Text + "' , '" + txtTenphong.Text + "'";
                if (txtDongia.Text != "")
                    sql = sql + " , " + txtDongia.Text.Trim();
                sql = sql + ")";
                //MessageBox.Show(sql);
                SqlCommand cmd = new SqlCommand(sql, con);
                cmd.ExecuteNonQuery();

                loaddatatoGridview();
                    
            }
        }

       private void txtDongia_KeyPress(object sender, KeyPressEventArgs e)
        {

        }

        private void bntSua_Click(object sender, EventArgs e)
        {
           
                string sql;
                if (txtTenphong.Text == "")
                {
                    MessageBox.Show("Bạn chưa chọn bản ghi nào!", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Information);
                    return;
                }
                if (txtTenphong.Text.Trim().Length == 0)
                {
                    MessageBox.Show("Bạn phải nhập tên phong!", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                    txtTenphong.Focus();
                    return;
                }
                sql = "UPDATE Phong SET Tenphong=N'" + txtTenphong.Text.Trim() + "',Dongia=N'" + txtDongia.Text.Trim()
                    + "' WHERE Maphong=N'" + txtMaphong.Text + "'";
                RunSQL(sql);
                loadDataGridView();
                txtMaphong.Text = "";
                txtTenphong.Text = "";
                txtDongia.Text = "";
                btnHuybo.Enabled = false;
            }

        }

        private void bntHuybo_Click(object sender, EventArgs e)
        {
            txtMaphong.Text = "";
            txtTenphong.Text = "";
            txtDongia.Text = "";
            bntHuybo.Enabled = false;
            bntHuybo.Enabled = true;
            button1.enabled = true;
            bntSua.Enabled = true;
            bntLuu = false;
            txtMaphong.Enabled = false;
        }

        private void bntThoat_Click(object sender, EventArgs e)
        {
            con.Close();
            this.Close();
        }

        private void dataGridView_Phong_CellCont(object sender, DataGridViewCellEventArgs e)
        {

        }
    }
}
