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
using static System.Windows.Forms.VisualStyles.VisualStyleElement.Rebar;

namespace GUI_RestaurantManager.UserControls.UsersControls_TiepTan
{
    public partial class UC_QuanLyBan : UserControl
    {
        private GUI_NhanVienTiepTan gui_nvtt;
        public UC_QuanLyBan()
        {
            InitializeComponent();
            LoadTables();
            LoadMonAn();
        }

        private void LoadTables()
        {
            panelBan.Refresh();
            BUS_Ban bus_Ban = new BUS_Ban();
            List<DTO_Ban> listBan = bus_Ban.getListBan();
            int pictureBoxWidth = 70;
            int pictureBoxHeight = 70;
            int padding = 10;
            int offetY = 10, offetX = 10;
            int rowCount = panelBan.Width / (pictureBoxWidth + padding);
            int colCount = (int)Math.Ceiling((double)listBan.Count / rowCount);

            for (int i = 0; i < listBan.Count; i++)
            {
                int row = i / rowCount;
                int col = i % rowCount;
                DTO_Ban ban = listBan[i];
                PictureBox tablePictureBox = new PictureBox();
                tablePictureBox.Size = new Size(pictureBoxWidth, pictureBoxHeight);
                tablePictureBox.BackColor = ban.trangThai ? Color.Green : Color.Red;
                tablePictureBox.Location = new Point(col * (pictureBoxWidth + padding) + offetX, row * (pictureBoxHeight + padding) + offetY);
                tablePictureBox.SizeMode = PictureBoxSizeMode.StretchImage;
                Label label = new Label();
                label.Text = ban.tenBan;
                label.ForeColor = Color.White;
                label.Dock = DockStyle.Fill;
                label.TextAlign = ContentAlignment.MiddleCenter;
                // Thêm Label vào PictureBox
                tablePictureBox.Controls.Add(label);
                label.Click += (sender, e) =>
                {
                    if(ban.trangThai)
                    {
                        btnAdd.Enabled = true;
                        txtName.Text = "";
                        txtEmail.Text = "";
                        txtSoDienThoai.Text = "";
                        txtSoLuong.Text = "";
                        txtViTri.Text = ban.maBan.ToString();
                    }
                    else
                    {
                        btnAdd.Enabled = false;
                        BUS_BanDat bus_banDat = new BUS_BanDat();
                        BUS_NguoiDung bus_nguoiDung= new BUS_NguoiDung(); 
                        DTO_BanDat banDat= bus_banDat.LayThongTinBan(ban.maBan);     
                        DTO_NguoiDung nguoiDung = bus_nguoiDung.LayThongTinNguoiDung(banDat.maKH);
                        txtName.Text = nguoiDung.tenNguoiDung;
                        txtEmail.Text = nguoiDung.email;
                        txtSoDienThoai.Text = nguoiDung.soDienThoai;
                        txtSoLuong.Text = banDat.soLuongNguoi.ToString();
                        try { dateThoiGian.Value = banDat.thoiGian;}
                        catch{dateThoiGian.Value=DateTime.Now;  }
                        txtViTri.Text = banDat.viTri.ToString();
                        lbMaBanDat.Text=banDat.maBanDat.ToString();
                       // MessageBox.Show("Bàn đã được đặt hay đang sử dụng.", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    }
                };
                panelBan.Controls.Add(tablePictureBox);
            }
        }
        private void LoadMonAn()
        {
            BUS_MonAn bus_MonAn = new BUS_MonAn();
            dataGVMonAn.DataSource = bus_MonAn.getListMonAn();
            dataGVMonAn.RowTemplate.Height = 50; // Đặt chiều cao của mỗi dòng
            dataGVMonAn.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.Fill;
            dataGVMonAn.Refresh();
        }
        public void SetParentForm(GUI_NhanVienTiepTan form)
        {
            gui_nvtt = form;
        }
        private void btnUpdate_Click(object sender, EventArgs e)
        {
            int maBanDat= Convert.ToInt32(lbMaBanDat.Text);
            int soLuongNguoi = Convert.ToInt32(txtSoLuong.Text);
            int viTri = Convert.ToInt32(txtViTri.Text);
            //int maBanDat = Convert.ToInt32(lbMaBanDat.Text);
            //int maBanDat = Convert.ToInt32(lbMaBanDat.Text);

            DTO_BanDat banDatMoi= new DTO_BanDat();
        }
        private void btnAdd_Click(object sender, EventArgs e)
        {

        }
    }
}
