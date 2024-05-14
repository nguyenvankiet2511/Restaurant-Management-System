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

namespace GUI_RestaurantManager.UserControls.UsersControls_KhachHang
{
    public partial class UC_DatHang : UserControl
    {
        private GUI_KhachHang gui_KH;
        BUS_MonAn bus_monAn= new BUS_MonAn();
        BUS_DanhSachDonHang bus_dsdh= new BUS_DanhSachDonHang();
        public UC_DatHang()
        {
            InitializeComponent();
        }
        public void SetFormParent(GUI_KhachHang form)
        {
            gui_KH = form;
            LoadTables();
        }

        private void label4_Click(object sender, EventArgs e)
        {

        }
        public void LoadTables()
        {
            comboBoxMonAn.DataSource = bus_monAn.getListMonAn();
            comboBoxMonAn.DisplayMember = "tenMon";
            comboBoxMonAn.ValueMember = "maMonAn";
            //
            dataGVDonHangDat.DataSource = bus_dsdh.LayDanhSachDonHangDat(gui_KH.CurrentUserKH);
            dataGVDonHangDat.RowTemplate.Height = 50; // Đặt chiều cao của mỗi dòng
            dataGVDonHangDat.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.Fill;
            dataGVDonHangDat.Columns["maDSDH"].HeaderText = "Mã đơn hàng";
            dataGVDonHangDat.Columns["NgayDat"].HeaderText = "Ngày đặt";
            dataGVDonHangDat.Columns["tenMon"].HeaderText = "Tên món";
            dataGVDonHangDat.Columns["soLuong"].HeaderText = "Số lượng";
            dataGVDonHangDat.Columns["maMonAn"].Visible = false;
            dataGVDonHangDat.Columns["maKH"].Visible = false;
            dataGVDonHangDat.Columns["ngayDat"].DefaultCellStyle.Format = "dd/MM/yyyy";
            //
            dataGVMonAn.DataSource = bus_monAn.getListMonAn();
            dataGVMonAn.RowTemplate.Height = 50; // Đặt chiều cao của mỗi dòng
            dataGVMonAn.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.Fill;
            dataGVMonAn.Columns["maMonAn"].HeaderText = "Mã Món Ăn";
            dataGVMonAn.Columns["tenMon"].HeaderText = "Tên Món Ăn";
            dataGVMonAn.Columns["moTa"].HeaderText = "Mô Tả Món";
            dataGVMonAn.Columns["giaMon"].HeaderText = "Giá($)";
            dataGVMonAn.Refresh();
        }

        private void btnAdd_Click(object sender, EventArgs e)
        {
            string tenMon=comboBoxMonAn.Text;
            int maMon= Convert.ToInt32(comboBoxMonAn.SelectedValue);
            int soLuong= Convert.ToInt32(txtSoLuong.Text);
            int maKH = gui_KH.CurrentUserKH;
            DTO_DanhSachDonHang donHang = new DTO_DanhSachDonHang(tenMon, soLuong, maMon, maKH);
            if (bus_dsdh.ThemDonHangDat(donHang))
            {
                LoadTables();
                MessageBox.Show("Đặt hàng thành công");
            }
            else
            {
                MessageBox.Show("Đặt hàng không thành công!");

            }
        }

        private void dataGVMonAn_Click(object sender, EventArgs e)
        {
            if (dataGVMonAn.CurrentRow != null)
            {
                if (lbMaDSDH.Text == "")
                { 
                    btnAdd.Enabled = true; 
                }     
                DataGridViewRow row = dataGVMonAn.CurrentRow;
                string maMonAn = row.Cells["maMonAn"].Value.ToString();
                string tenMonAn = row.Cells["tenMon"].Value.ToString();

                // Tìm đối tượng trong ComboBox bằng mã món ăn
                int index = comboBoxMonAn.FindStringExact(tenMonAn);

                // Nếu tìm thấy, chọn đối tượng tương ứng
                if (index != -1)
                {
                    comboBoxMonAn.SelectedIndex = index;
                }
            }
        }

        private void btnDelete_Click(object sender, EventArgs e)
        {
            // Kiểm tra xem đã chọn dòng nào chưa
            if (dataGVDonHangDat.SelectedRows.Count > 0)
            {
                DataGridViewRow selectedRow = dataGVDonHangDat.SelectedRows[0];
                int maDSDH = Convert.ToInt32(selectedRow.Cells["maDSDH"].Value);
                bool result = bus_dsdh.XoaDonHangDat(maDSDH);
                if (result)
                {
                    dataGVDonHangDat.DataSource = bus_dsdh.LayDanhSachDonHangDat(gui_KH.CurrentUserKH);
                    MessageBox.Show("Đã xóa đơn hàng thành công!");
                }
                else
                {
                    MessageBox.Show("Xóa đơn hàng không thành công. Vui lòng thử lại sau.");
                }
            }
            else
            {
                MessageBox.Show("Vui lòng chọn một đơn hàng để xóa.");
            }
        }

        private void dataGVDonHangDat_Click(object sender, EventArgs e)
        {
            if (dataGVDonHangDat.CurrentRow != null)
            {
                btnAdd.Enabled = false;
                DataGridViewRow row = dataGVDonHangDat.CurrentRow;
                string tenMon = row.Cells["tenMon"].Value.ToString();
                txtSoLuong.Text = row.Cells["soLuong"].Value.ToString();
                lbMaDSDH.Text = row.Cells["maDSDH"].Value.ToString();
                int index = comboBoxMonAn.FindStringExact(tenMon);
                comboBoxMonAn.SelectedIndex = index;
            }
        }

        private void btnUpdate_Click(object sender, EventArgs e)
        {
            string tenMon= comboBoxMonAn.Text.ToString();
            int soLuong = Convert.ToInt32(txtSoLuong.Text);
            int maDSDH = Convert.ToInt32( lbMaDSDH.Text);
            int maMonAn= Convert.ToInt32(comboBoxMonAn.SelectedValue);
            DTO_DanhSachDonHang donHang = new DTO_DanhSachDonHang(maDSDH, tenMon, soLuong, maMonAn);
            if (bus_dsdh.CapNhatDonHang(donHang))
            {
                LoadTables();
                lbMaDSDH.Text = "";
                MessageBox.Show("Thay đổi thành công");
            }
            else
            {
                MessageBox.Show("Thay đổi không thành công!");
            }

        }

        private void dataGVDonHangDat_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

        }
    }
}
