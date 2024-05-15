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

namespace GUI_RestaurantManager.UserControls.UsersControls_NhanVienSale
{
    public partial class UC_DonDatHang : UserControl
    {
        private GUI_NhanVienSale gui_nvSale;
        BUS_DanhSachDonHang bus_dsdh = new BUS_DanhSachDonHang();
        BUS_MonAn bus_monAn=new BUS_MonAn();
        BUS_DonHang bus_donHang = new BUS_DonHang();
        public UC_DonDatHang()
        {
            InitializeComponent();
            LoadTables();
        }
        public void LoadTables()
        {
            dataGVDonDatHang.DataSource = bus_dsdh.GetAllDanhSachDonHang();
            dataGVDonDatHang.Columns["maDSDH"].HeaderText = "Mã DSDH";
            dataGVDonDatHang.Columns["ngayDat"].HeaderText = "Ngày đặt";
            dataGVDonDatHang.Columns["tenMon"].HeaderText = "Tên món";
            dataGVDonDatHang.Columns["soLuong"].HeaderText = "Số lượng";
            dataGVDonDatHang.Columns["maMonAn"].HeaderText = "Mã món ăn";
            dataGVDonDatHang.Columns["maKH"].HeaderText = "Mã khách hàng";
            dataGVDonDatHang.RowTemplate.Height = 50; // Đặt chiều cao của mỗi dòng
            dataGVDonDatHang.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.Fill;
            //
            dataGVDanhSachXacNhan.Columns.Add("maDSDH", "Mã DSDH");
            dataGVDanhSachXacNhan.Columns.Add("ngayDat", "Ngày đặt");
            dataGVDanhSachXacNhan.Columns.Add("tenMon", "Tên món");
            dataGVDanhSachXacNhan.Columns.Add("soLuong", "Số lượng");
            dataGVDanhSachXacNhan.Columns.Add("maMonAn", "Mã món ăn");
            dataGVDanhSachXacNhan.Columns.Add("maKH", "Mã khách hàng");
            dataGVDanhSachXacNhan.RowTemplate.Height = 50; // Đặt chiều cao của mỗi dòng
            dataGVDanhSachXacNhan.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.Fill;
        }
        public List<DTO_DonHang> LayDanhSachXacNhan()
        {
            List<DTO_DonHang> dsDonHang = new List<DTO_DonHang>();
            foreach (DataGridViewRow selectedRow in dataGVDanhSachXacNhan.Rows)
            {
                if (!selectedRow.IsNewRow)
                {
                    int maMonAn = Convert.ToInt32(selectedRow.Cells["maMonAn"].Value);
                    int maKH= Convert.ToInt32(selectedRow.Cells["maKH"].Value) ;
                    int maNhanVien = gui_nvSale.CurrentUser;
                    DateTime ngayDat = Convert.ToDateTime(selectedRow.Cells["ngayDat"].Value);
                    DTO_DonHang donHang = new DTO_DonHang(ngayDat, maKH, maMonAn, maNhanVien);
                    dsDonHang.Add(donHang);
                }
            }
            dataGVDanhSachXacNhan.Rows.Clear();
            return dsDonHang;
        }
        private void btnXacNhan_Click(object sender, EventArgs e)
        {
            List<DTO_DonHang> dsDonHang = LayDanhSachXacNhan();
            bool result = true;
            foreach( DTO_DonHang d in dsDonHang)
            {
               if(!bus_donHang.ThemDonHang(d))
                {
                    result = false;
                    break;
                }
            }
            if (result)
            {
                MessageBox.Show("Xác nhận thành công");
            }
            else
            {
                MessageBox.Show("Xác nhận không thành công!");
            }
        }
        public void SetFromParent(GUI_NhanVienSale from)
        {
            gui_nvSale = from;
        }
        private void dataGVDonDatHang_Click(object sender, EventArgs e)
        {
            if (dataGVDonDatHang.CurrentRow != null)
            {
                int selectedIndex = dataGVDonDatHang.CurrentRow.Index;
                DataGridViewRow selectedRow = dataGVDonDatHang.Rows[selectedIndex];
                object[] rowData = new object[selectedRow.Cells.Count];
                for (int i = 0; i < selectedRow.Cells.Count; i++)
                {
                    rowData[i] = selectedRow.Cells[i].Value;
                }
                dataGVDanhSachXacNhan.Rows.Add(rowData);
                dataGVDonDatHang.Rows.RemoveAt(selectedIndex);
            }
        }
        private void btnXoa_Click(object sender, EventArgs e)
        {
            if (dataGVDonDatHang.CurrentRow != null)
            {
                DataGridViewRow row = dataGVDonDatHang.CurrentRow;
                int maDSDH = Convert.ToInt32(row.Cells["maDSDH"].Value);
                DialogResult result = MessageBox.Show("Bạn muốn xóa đơn hàng mã " + maDSDH.ToString(), "Xác nhận", MessageBoxButtons.OKCancel, MessageBoxIcon.Question);

                if (result == DialogResult.OK)
                {
                    if (bus_dsdh.XoaDonHang(maDSDH))
                    {
                        MessageBox.Show("Xóa thành công");
                    }
                    else
                    {
                        MessageBox.Show("Xóa không thành công");
                    }
                }
                else if (result == DialogResult.Cancel)
                {
                }
            }
        }
        private void dataGVDanhSachXacNhan_Click(object sender, EventArgs e)
        {
            if (dataGVDanhSachXacNhan.CurrentRow != null)
            {
                DataTable dtDonDatHang = (DataTable)dataGVDonDatHang.DataSource;
                int selectedIndex = dataGVDanhSachXacNhan.CurrentRow.Index;
                DataGridViewRow selectedRow = dataGVDanhSachXacNhan.Rows[selectedIndex];    
                DataRow newRow = dtDonDatHang.NewRow();
                // Thêm dữ liệu vào hàng mới
                newRow["maDSDH"] = Convert.ToInt32(selectedRow.Cells["maDSDH"].Value); 
                newRow["ngayDat"] = Convert.ToDateTime(selectedRow.Cells["ngayDat"].Value);
                newRow["tenMon"] = selectedRow.Cells["tenMon"].Value.ToString();
                newRow["soLuong"] = Convert.ToInt32(selectedRow.Cells["soLuong"].Value);
                newRow["maMonAn"] = Convert.ToInt32(selectedRow.Cells["maMonAn"].Value);
                newRow["maKH"] = Convert.ToInt32(selectedRow.Cells["maKH"].Value);
                dtDonDatHang.Rows.Add(newRow);
                dataGVDanhSachXacNhan.Rows.RemoveAt(selectedIndex);
            }
        }    
    }
}
