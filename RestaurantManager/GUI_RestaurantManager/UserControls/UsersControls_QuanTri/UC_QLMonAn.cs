using BUS_RestaurantManager;
using DTO_RestaurantManager;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace GUI_RestaurantManager.UserControls.UsersControls_QuanTri
{
    public partial class UC_QLMonAn : UserControl
    {
        private BUS_MonAn bus_monAn= new BUS_MonAn();
        public UC_QLMonAn()
        {
            InitializeComponent();
            LoadDvgMonAn();
        }    
        public void LoadDvgMonAn()
        {
            dataGVMonAn.DataSource = bus_monAn.getListMonAn();
            dataGVMonAn.RowTemplate.Height = 50; // Đặt chiều cao của mỗi dòng
            dataGVMonAn.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.Fill;
            dataGVMonAn.Columns["maMonAn"].HeaderText = "Mã Món Ăn";
            dataGVMonAn.Columns["tenMon"].HeaderText = "Tên Món Ăn";
            dataGVMonAn.Columns["moTa"].HeaderText = "Mô Tả Món";
            dataGVMonAn.Columns["giaMon"].HeaderText = "Giá($)";
            dataGVMonAn.Refresh();
        }

        private void dataGVMonAn_Click(object sender, EventArgs e)
        {
            if (dataGVMonAn.CurrentRow != null)
            {
                DataGridViewRow row = dataGVMonAn.CurrentRow;
                txtMaMon.Text = row.Cells["maMonAn"].Value.ToString();
                txtTenMon.Text = row.Cells["tenMon"].Value.ToString();
                txtMota.Text = row.Cells["moTa"].Value.ToString();
                txtGia.Text = row.Cells["giaMon"].Value.ToString();
            }
        }

        private void btnAdd_Click(object sender, EventArgs e)
        {
            
            string tenMon = txtTenMon.Text;
            string moTa= txtMota.Text;
            int gia= Convert.ToInt32(txtGia.Text);
            DTO_MonAn monAn = new DTO_MonAn(tenMon,moTa,gia);
            bool kiemTraMon=false;
            if (txtTenMon.Text != "")
            {
                 kiemTraMon = bus_monAn.KiemTraMonAn(tenMon);
            }
            if(kiemTraMon!=true)
            {
                bool result = bus_monAn.ThemMonAn(monAn);
                if (result)
                {
                    MessageBox.Show("Thêm món thành công");
                    LoadDvgMonAn();
                }
                else
                {
                    MessageBox.Show("Thêm món không thành công");
                }
            }
            else
            {
                MessageBox.Show("Món đã tồn tại!");
            }           
        }
        private void btnUpdate_Click(object sender, EventArgs e)
        {
            int maMon= Convert.ToInt32(txtMaMon.Text);
            string tenMon = txtTenMon.Text;
            string moTa = txtMota.Text;
            int gia = Convert.ToInt32(txtGia.Text);
            DTO_MonAn monAn= new DTO_MonAn(maMon,tenMon,moTa,gia);
            bool result = bus_monAn.CapNhatMonAn(monAn);
            if (result)
            {
                LoadDvgMonAn() ;
                MessageBox.Show("Cập nhật món thành công");
            }
            else
            {
                MessageBox.Show("Cập nhật món không thành công");
            }
        }
        private void btnDelete_Click(object sender, EventArgs e)
        {
            int maMon=Convert.ToInt32(txtMaMon.Text);
            bool result = bus_monAn.XoaMonAn(maMon);
            if (result)
            {
                LoadDvgMonAn();
                MessageBox.Show("Xóa món thành công");
            }
            else
            {
                MessageBox.Show("Xóa món không thành công");
            }
        }

        private void btnSearch_Click(object sender, EventArgs e)
        {
            string key = txtKey.Text;
            if (key == "")
            {
                LoadDvgMonAn();
            }
            dataGVMonAn.DataSource = bus_monAn.TimKiemMonAn(key);
            dataGVMonAn.RowTemplate.Height = 50;
            dataGVMonAn.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.Fill;
            dataGVMonAn.Columns["maMonAn"].HeaderText = "Mã Món Ăn";
            dataGVMonAn.Columns["tenMon"].HeaderText = "Tên Món Ăn";
            dataGVMonAn.Columns["moTa"].HeaderText = "Mô Tả Món";
            dataGVMonAn.Columns["giaMon"].HeaderText = "Giá($)";
            dataGVMonAn.Refresh();
        }

       

        private void groupBox1_Enter(object sender, EventArgs e)
        {

        }
    }
}
