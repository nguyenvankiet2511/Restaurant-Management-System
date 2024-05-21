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

namespace GUI_RestaurantManager.UserControls
{
    public partial class UC_DatMon : UserControl
    {
        private GUI_KhachHang gui_KH;
        BUS_MonAn bus_monAn= new BUS_MonAn();
        BUS_BanDat bus_banDat= new BUS_BanDat();
        BUS_ThucDon bus_thucDon= new BUS_ThucDon();
        public UC_DatMon()
        {
            InitializeComponent();
            SetUpDVG();
        }

        public void SetParentForm(GUI_KhachHang form)
        {
            gui_KH = form;
            LoadTables();
        }
        public void LoadTables()
        {
            int maKH = gui_KH.CurrentUserKH;
            comboBoxBanDat.DataSource = bus_banDat.danhSachBanDatKH(maKH);
            comboBoxBanDat.DisplayMember = "maBanDat";
            comboBoxBanDat.ValueMember = "maBanDat";
            //
            comboBoxMonAn.DataSource = bus_monAn.getListMonAn();
            comboBoxMonAn.DisplayMember = "tenMon"; 
            comboBoxMonAn.ValueMember = "maMonAn"; 
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
        public void SetUpDVG()
        {
            dataGVMonDaChon.Columns.Add("maMon", "Mã món ăn");
            dataGVMonDaChon.Columns.Add("tenMon", "Tên món ăn");
            dataGVMonDaChon.Columns.Add("soLuong", "Số lượng");
            dataGVMonDaChon.Columns.Add("thanhTien", "Thành tiền");
            dataGVMonDaChon.RowTemplate.Height = 50; // Đặt chiều cao của mỗi dòng
            dataGVMonDaChon.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.Fill;
            dataGVMonDaChon.Refresh();
        }

        private void dataGVMonDaChon_Click(object sender, EventArgs e)
        {


        }
        private void dataGVMonAn_Click(object sender, EventArgs e)
        {

            if (dataGVMonAn.CurrentRow != null)
            {
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
        private List<DTO_ThucDon> LayDanhSachThucDon()
        {
            List<DTO_ThucDon> danhSachThucDon = new List<DTO_ThucDon>();
            foreach (DataGridViewRow selectedRow in dataGVMonDaChon.Rows)
            {
                if (!selectedRow.IsNewRow)
                {
                    int maMon = Convert.ToInt32(selectedRow.Cells["maMon"].Value);
                    string tenMon = selectedRow.Cells["tenMon"].Value.ToString();
                    int soLuong = Convert.ToInt32(selectedRow.Cells["soLuong"].Value);
                    int maBanDat =  (int) comboBoxBanDat.SelectedValue;
                    // Tạo DTO_DangKyBanDat từ thông tin của dòng đã chọn và thêm vào danh sách
                    DTO_ThucDon thucDon = new DTO_ThucDon(tenMon, soLuong, maMon, maBanDat);
                    danhSachThucDon.Add(thucDon);
                }
                else
                {
                    dataGVMonDaChon.Rows.Clear();
                    return danhSachThucDon;
                }
            }
            return danhSachThucDon;
        }

        private void btnAdd_Click(object sender, EventArgs e)
        {
            DTO_MonAn monAn= (DTO_MonAn)comboBoxMonAn.SelectedItem;
            int maMon = monAn.maMonAn;
            string tenMon = comboBoxMonAn.Text;
            int soLuong =Convert.ToInt32( txtSoLuong.Text);
            int gia = monAn.giaMon;
            dataGVMonDaChon.Rows.Add(maMon,tenMon,soLuong,gia);
        }
        private void btnDelete_Click(object sender, EventArgs e)
        {
            if (dataGVMonDaChon.SelectedRows.Count > 0)
            {
                foreach (DataGridViewRow row in dataGVMonDaChon.SelectedRows)
                {
                    dataGVMonDaChon.Rows.Remove(row);
                }
            }
            else
            {
                MessageBox.Show("Vui lòng chọn ít nhất một hàng để xóa.");
            }
        }
        private void btnSave_Click(object sender, EventArgs e)
        {
            bool result = false;
            List<DTO_ThucDon> danhSachThucDon = LayDanhSachThucDon();
            foreach (DTO_ThucDon thucDon in danhSachThucDon)
            {
                result= bus_thucDon.ThemThucDon(thucDon);
                if (!result)
                {
                    break;
                }
            }
            if (result)
            {
                MessageBox.Show("Tất cả thực đơn đã thêm thành công.");
            }
            else
            {
                MessageBox.Show("Thực đơn không được thêm thành công!.");
            }
        }
    }
}
