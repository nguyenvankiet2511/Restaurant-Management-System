using BUS_RestaurantManager;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace GUI_RestaurantManager.UserControls.UsersControls_NhanVienSale
{
    public partial class UC_QuanLyDonHang : UserControl
    {
        BUS_DonHang bus_donHang= new BUS_DonHang();
        public UC_QuanLyDonHang()
        {
            InitializeComponent();
            LoadTables();
        }
        public void LoadTables()
        {
            dataGVDonHang.DataSource = bus_donHang.LayDanhSachDonHang();
            dataGVDonHang.RowTemplate.Height = 50; // Đặt chiều cao của mỗi dòng
            dataGVDonHang.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.Fill;
        }
        private void dataGVDonHang_Click(object sender, EventArgs e)
        {

        }

        private void dataGVDonHang_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

        }
    }
}
