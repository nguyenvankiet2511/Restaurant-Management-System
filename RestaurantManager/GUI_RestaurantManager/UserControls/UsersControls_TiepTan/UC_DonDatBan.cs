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

namespace GUI_RestaurantManager.UserControls.UsersControls_TiepTan
{
    public partial class UC_DonDatBan : UserControl
    {
        public UC_DonDatBan()
        {
            InitializeComponent();
            LoadTables();
            AddColumns_DaChon();
            ChangeHerderText();
        }
        public void LoadTables()
        {
            BUS_DangKyBanDat bus_DonDat= new BUS_DangKyBanDat();
            dataGVDonDatBan.DataSource = bus_DonDat.DanhSachDonDatBan();
            dataGVDonDatBan.RowTemplate.Height = 50; // Đặt chiều cao của mỗi dòng
            dataGVDonDatBan.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.Fill;
            
            dataGVDonDatBan.Refresh();
        }
        public void ChangeHerderText()
        {
            dataGVDonDatBan.Columns["maDK"].HeaderText = "Mã Đăng Ký";
            dataGVDonDatBan.Columns["soLuongNguoi"].HeaderText = "Số Lượng Người";
            dataGVDonDatBan.Columns["viTri"].HeaderText = "Vị Trí";
            dataGVDonDatBan.Columns["ghiChu"].HeaderText = "Ghi Chú";
            dataGVDonDatBan.Columns["trangThai"].HeaderText = "Trạng thái";
            dataGVDonDatBan.Columns["thoiGian"].HeaderText = "Thời Gian";
        }
        public void AddColumns_DaChon()
        {
            dataGVDonDaChon.Columns.Add("MaDK", "Mã Đăng Ký");
            dataGVDonDaChon.Columns.Add("SoLuongNguoi", "Số Lượng Người");
            dataGVDonDaChon.Columns.Add("ViTri", "Vị Trí");
            dataGVDonDaChon.Columns.Add("GhiChu", "Ghi Chú");
            dataGVDonDaChon.Columns.Add("TrangThai", "Trạng Thái");
            dataGVDonDaChon.Columns.Add("ThoiGian", "Thời Gian");
            dataGVDonDaChon.RowTemplate.Height = 50; // Đặt chiều cao của mỗi dòng
            dataGVDonDaChon.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.Fill;
            dataGVDonDaChon.Refresh();
        }
        private void dataGVDonDatBan_Click(object sender, EventArgs e)
        {
            // Kiểm tra xem có dòng nào được chọn không
            if (dataGVDonDatBan.SelectedRows.Count > 0)
            {
                // Lấy dòng được chọn
                DataGridViewRow selectedRow = dataGVDonDatBan.SelectedRows[0];

                // Lấy dữ liệu từ dòng được chọn
                int maDK = Convert.ToInt32(selectedRow.Cells["MaDK"].Value);
                int soLuongNguoi = Convert.ToInt32(selectedRow.Cells["soLuongNguoi"].Value);
                int viTri = Convert.ToInt32(selectedRow.Cells["viTri"].Value.ToString());
                string ghiChu = selectedRow.Cells["ghiChu"].Value.ToString();
                bool trangThai = Convert.ToBoolean(selectedRow.Cells["trangThai"].Value);
                DateTime thoiGian = Convert.ToDateTime(selectedRow.Cells["thoiGian"].Value);

                // Tạo DTO_DangKyBanDat object từ dữ liệu lấy được
                DTO_DangKyBanDat datBan = new DTO_DangKyBanDat(maDK, soLuongNguoi, viTri, ghiChu, trangThai, thoiGian);

                // Thêm dữ liệu vào dataGridView2
                dataGVDonDaChon.Rows.Add(datBan.maDK, datBan.soLuongNguoi, datBan.viTri, datBan.ghiChu, datBan.trangThai, datBan.thoiGian);

                // Xóa dữ liệu từ nguồn dữ liệu của dataGridView1
                List<DTO_DangKyBanDat> dataSource = (List<DTO_DangKyBanDat>)dataGVDonDatBan.DataSource;
                DTO_DangKyBanDat itemToRemove = dataSource.Find(item => item.maDK == maDK);
                dataSource.Remove(itemToRemove);

                // Cập nhật lại dataGridView1 bằng cách gán lại nguồn dữ liệu
                dataGVDonDatBan.DataSource = null;
                dataGVDonDatBan.DataSource = dataSource;
                ChangeHerderText();
            }
        }
        private void dataGVDonDaChon_Click(object sender, EventArgs e)
        {
            // Kiểm tra xem có dòng nào được chọn không
            if (dataGVDonDaChon.SelectedRows.Count > 0)
            {
                // Lấy dòng được chọn
                DataGridViewRow selectedRow = dataGVDonDaChon.SelectedRows[0];

                // Lấy dữ liệu từ dòng được chọn trong dataGridView2
                int maDK = Convert.ToInt32(selectedRow.Cells["MaDK"].Value);
                int soLuongNguoi = Convert.ToInt32(selectedRow.Cells["SoLuongNguoi"].Value);
                int viTri = Convert.ToInt32(selectedRow.Cells["ViTri"].Value);
                string ghiChu = selectedRow.Cells["GhiChu"].Value.ToString();
                bool trangThai = Convert.ToBoolean(selectedRow.Cells["TrangThai"].Value);
                DateTime thoiGian = Convert.ToDateTime(selectedRow.Cells["ThoiGian"].Value);

                // Tạo DTO_DangKyBanDat object từ dữ liệu lấy được
                DTO_DangKyBanDat datBan = new DTO_DangKyBanDat(maDK, soLuongNguoi, viTri, ghiChu, trangThai, thoiGian);

                // Thêm dữ liệu vào nguồn dữ liệu của dataGridView1
                List<DTO_DangKyBanDat> dataSource1 = (List<DTO_DangKyBanDat>)dataGVDonDatBan.DataSource;
                dataSource1.Add(datBan);

                // Cập nhật lại dataGridView1 bằng cách gán lại nguồn dữ liệu
                dataGVDonDatBan.DataSource = null;
                dataGVDonDatBan.DataSource = dataSource1;
                ChangeHerderText();

                // Xóa dòng đã được chọn từ dataGridView2
                dataGVDonDaChon.Rows.Remove(selectedRow);
            }
        }

    }
}
