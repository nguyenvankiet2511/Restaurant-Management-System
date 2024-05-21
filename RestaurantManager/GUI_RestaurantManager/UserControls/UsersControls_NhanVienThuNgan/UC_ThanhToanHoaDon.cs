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

namespace GUI_RestaurantManager.UserControls.UsersControls_NhanVienThuNgan
{
    public partial class UC_ThanhToanHoaDon : UserControl
    {
        private GUI_NhanVienThuNgan gui_nvtn;
        BUS_ThucDon bus_thucDon= new BUS_ThucDon();
        BUS_QuyDinh bus_quyDinh= new BUS_QuyDinh(); 
        BUS_Ban bus_ban = new BUS_Ban();
        BUS_BanDat bus_banDat= new BUS_BanDat();
        BUS_HoaDon bus_hoaDon= new BUS_HoaDon();
        public UC_ThanhToanHoaDon()
        {
            InitializeComponent();
        }
        public void SetFormParent(GUI_NhanVienThuNgan form)
        {
            this.gui_nvtn = form;
        }
        private void btnXem_Click(object sender, EventArgs e)
        {
            int maBanDat= Convert.ToInt32(txtMaBanDat.Text);
            if (bus_banDat.LayTrangThaiBanDat(maBanDat))
            {
                dataGVThucDon.DataSource = bus_thucDon.GetThucDonList(maBanDat);
                dataGVThucDon.RowTemplate.Height = 50; // Đặt chiều cao của mỗi dòng
                dataGVThucDon.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.Fill;
                dataGVThucDon.Columns["tenMon"].HeaderText = "Tên món ăn";
                dataGVThucDon.Columns["soLuong"].HeaderText = "Số lượng";
                dataGVThucDon.Columns["giaMon"].HeaderText = "Giá món";
                dataGVThucDon.Columns["thanhTien"].HeaderText = "Thành tiền";
                dataGVThucDon.Refresh();
                //
                DTO_BanDat banDat = bus_banDat.LayThongTinBan(Convert.ToInt32(txtMaBanDat.Text));
                lbMaBan.Text = banDat.maBanDat.ToString();
                lbViTri.Text = banDat.viTri.ToString();
                int tienBan = bus_quyDinh.LayGiaTriQuyDinh(1);
                lbTienBan.Text = tienBan.ToString();
                int tienMon = CalculateTotalThanhTien(dataGVThucDon);
                lbTienMon.Text = tienMon.ToString();
                int khuyenMai = checkBoxKM.Checked ? bus_quyDinh.LayGiaTriQuyDinh(2) : 0;
                int tong = (tienBan + tienMon) * (100 - khuyenMai) / 100;
                lbTongTien.Text = tong.ToString();
            }
            else
            {
                MessageBox.Show("Bàn đặt đã thanh toán!");
            }
        }
        private int CalculateTotalThanhTien(DataGridView dataGridView)
        {
            int total = 0;

            foreach (DataGridViewRow row in dataGridView.Rows)
            {
                if (row.Cells["thanhTien"].Value != null)
                {
                    total += Convert.ToInt32(row.Cells["thanhTien"].Value);
                }
            }
            return total;
        }

        private void checkBoxKM_CheckedChanged(object sender, EventArgs e)
        {
            int tienBan = bus_quyDinh.LayGiaTriQuyDinh(1);
            lbTienBan.Text = tienBan.ToString();
            int tienMon = CalculateTotalThanhTien(dataGVThucDon);
            lbTienMon.Text = tienMon.ToString();
            int khuyenMai = checkBoxKM.Checked ? bus_quyDinh.LayGiaTriQuyDinh(2) : 0;
            int tong = (tienBan + tienMon) * (100 - khuyenMai) / 100;
            lbTongTien.Text = tong.ToString();
        }
        public void ResetLable()
        {
            txtMaBanDat.Text = "";
            lbMaBan.Text = "";
            lbTienBan.Text = "";
            lbTienMon.Text = "";
            lbTongTien.Text = "";
            lbViTri.Text = "";
            checkBoxKM.Checked = false;
        }

        private void btnThanhToan_Click(object sender, EventArgs e)
        {
            int maBanDat = Convert.ToInt32(lbMaBan.Text);
            if (bus_banDat.LayTrangThaiBanDat(maBanDat))
            {
                int viTri = Convert.ToInt32(lbViTri.Text);
                int maNVTN = gui_nvtn.CurrentUser;
                int tongTien = Convert.ToInt32(lbTongTien.Text);
                DTO_HoaDon hoaDon = new DTO_HoaDon(tongTien, maNVTN, maBanDat);
                if (bus_hoaDon.ThemHoaDon(hoaDon))
                {
                    bus_ban.CapNhatTrangThaiBan(viTri);
                    bus_banDat.CapNhatTrangThaiBanDat(maBanDat);
                    MessageBox.Show("Thanh toán thành công!");
                    ResetLable();
                }
                else
                {
                    MessageBox.Show("Thanh toán không thành công!");
                    ResetLable();
                }
            }
            else
            {
                MessageBox.Show("Bàn đặt đã thanh toán!");
                ResetLable();
            }
        }
    }
}
