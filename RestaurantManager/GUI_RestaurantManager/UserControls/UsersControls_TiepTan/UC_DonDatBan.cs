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
        private GUI_NhanVienTiepTan gui_nvtt;
        public UC_DonDatBan()
        {
            InitializeComponent();
            LoadTables();
            AddColumns_DaChon();
        }
        public void LoadTables()
        {
            BUS_DangKyBanDat bus_DonDat= new BUS_DangKyBanDat();
            dataGVDonDatBan.DataSource = bus_DonDat.DanhSachDonDatBan();
            dataGVDonDatBan.RowTemplate.Height = 50; // Đặt chiều cao của mỗi dòng
            dataGVDonDatBan.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.Fill;
            ChangeHerderText();
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
            dataGVDonDatBan.Columns["maKH"].HeaderText = "Mã Khách Hàng";
        }
        public void AddColumns_DaChon()
        {
            dataGVDonDaChon.Columns.Add("MaDK", "Mã Đăng Ký");
            dataGVDonDaChon.Columns.Add("SoLuongNguoi", "Số Lượng Người");
            dataGVDonDaChon.Columns.Add("ViTri", "Vị Trí");
            dataGVDonDaChon.Columns.Add("GhiChu", "Ghi Chú");
            dataGVDonDaChon.Columns.Add("TrangThai", "Trạng Thái");
            dataGVDonDaChon.Columns.Add("ThoiGian", "Thời Gian");
            dataGVDonDaChon.Columns.Add("MaKH", "Mã Khách Hàng");
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
                int maKH = Convert.ToInt32(selectedRow.Cells["maKH"].Value);

                // Tạo DTO_DangKyBanDat object từ dữ liệu lấy được
                DTO_DangKyBanDat datBan = new DTO_DangKyBanDat(maDK, soLuongNguoi, viTri, ghiChu, trangThai, thoiGian,maKH);

                // Thêm dữ liệu vào dataGridView2
                dataGVDonDaChon.Rows.Add(datBan.maDK, datBan.soLuongNguoi, datBan.viTri, datBan.ghiChu, datBan.trangThai, datBan.thoiGian, datBan.maKH);

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
                int maKH = Convert.ToInt32(selectedRow.Cells["MaKH"].Value);

                // Tạo DTO_DangKyBanDat object từ dữ liệu lấy được
                DTO_DangKyBanDat datBan = new DTO_DangKyBanDat(maDK, soLuongNguoi, viTri, ghiChu, trangThai, thoiGian, maKH);

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

        private List<DTO_DangKyBanDat> LayDanhSachDaChon()
        {
            List<DTO_DangKyBanDat> danhSachDaChon = new List<DTO_DangKyBanDat>();

            // Lặp qua từng dòng đã chọn trong DataGridView chứa các đơn đã chọn
            foreach (DataGridViewRow selectedRow in dataGVDonDaChon.Rows)
            {
                if(!selectedRow.IsNewRow)
                {
                    //MessageBox.Show(selectedRow.Cells["GhiChu"].Value.ToString());
                    int maDK = Convert.ToInt32(selectedRow.Cells["MaDK"].Value);
                    int soLuongNguoi = Convert.ToInt32(selectedRow.Cells["SoLuongNguoi"].Value);
                    int viTri = Convert.ToInt32(selectedRow.Cells["ViTri"].Value);
                    string ghiChu = selectedRow.Cells["GhiChu"].Value.ToString();
                    bool trangThai = Convert.ToBoolean(selectedRow.Cells["TrangThai"].Value);
                    DateTime thoiGian = Convert.ToDateTime(selectedRow.Cells["ThoiGian"].Value);
                    int maKH = Convert.ToInt32(selectedRow.Cells["MaKH"].Value);
                    // Tạo DTO_DangKyBanDat từ thông tin của dòng đã chọn và thêm vào danh sách
                    DTO_DangKyBanDat datBan = new DTO_DangKyBanDat(maDK, soLuongNguoi, viTri, ghiChu, trangThai, thoiGian, maKH);
                    danhSachDaChon.Add(datBan);
                }
                else
                {
                    dataGVDonDaChon.Rows.Clear();
                    return danhSachDaChon;
                }           
            }
            return danhSachDaChon;
        }

        private void btnXacNhan_Click(object sender, EventArgs e)
        {
            BUS_BanDat bus_datBan = new BUS_BanDat();
            BUS_DangKyBanDat bus_dangKyBanDat= new BUS_DangKyBanDat();
            List<DTO_DangKyBanDat> dsdk = LayDanhSachDaChon();
            foreach(DTO_DangKyBanDat d in dsdk)
            {
                DTO_BanDat banDat = new DTO_BanDat(d.soLuongNguoi,d.viTri,d.ghiChu,d.thoiGian, d.maKH, gui_nvtt.CurrentUser);
                bool result= bus_datBan.ThemBanDat(banDat);
                if (result)
                {
                    bus_dangKyBanDat.XoaDangKyBanDat(d.maDK);
                    MessageBox.Show("Thành công: Đã thêm bàn đặt.", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Information);
                    LoadTables();
                }
                else
                {
                    MessageBox.Show("Lỗi: Không thể thêm bàn đặt.", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    LoadTables();
                }
            }
        }
        private void btnDelete_Click(object sender, EventArgs e)
        {
            BUS_DangKyBanDat bus_dangKyBanDat = new BUS_DangKyBanDat();
            List<DTO_DangKyBanDat> dsdk = LayDanhSachDaChon();
            int result=0;
            foreach (DTO_DangKyBanDat d in dsdk)
            {
                bus_dangKyBanDat.XoaDangKyBanDat(d.maDK);
                result++;
            }
            if(dsdk.Count == result) 
            {
                MessageBox.Show("Thành công: Đã xóa danh sách đăng ký được chọn.", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
            else { MessageBox.Show("Lỗi: Không thể xóa.", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Error); }
        }
        public void SetParentForm(GUI_NhanVienTiepTan form)
        {
            gui_nvtt = form;
        }
    }
}
