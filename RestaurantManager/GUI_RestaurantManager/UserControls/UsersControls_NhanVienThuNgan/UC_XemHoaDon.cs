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

namespace GUI_RestaurantManager.UserControls.UsersControls_NhanVienThuNgan
{
    public partial class UC_XemHoaDon : UserControl
    {
        BUS_HoaDon bus_hoaDon= new BUS_HoaDon();
        public UC_XemHoaDon()
        {
            InitializeComponent();
            LoadTables();
        }
        public void LoadTables()
        {
            dataGVHoaDon.DataSource = bus_hoaDon.LayDanhSachHoaDon();
            dataGVHoaDon.RowTemplate.Height = 50; // Đặt chiều cao của mỗi dòng
            dataGVHoaDon.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.Fill;
            dataGVHoaDon.Columns["maHoaDon"].HeaderText = "Mã hóa đơn";
            dataGVHoaDon.Columns["ngayLap"].HeaderText = "Ngày lập";
            dataGVHoaDon.Columns["moTa"].Visible= false;
            dataGVHoaDon.Columns["thanhTien"].HeaderText = "Thành tiền";
            dataGVHoaDon.Columns["maNVTN"].HeaderText = "Mã nhân viên";
            dataGVHoaDon.Columns["maBanDat"].HeaderText = "Mã bàn đặt";
            dataGVHoaDon.Refresh();
        }
        private void dataGVHoaDon_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
        }
    }
}
