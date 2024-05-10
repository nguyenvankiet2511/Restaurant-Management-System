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
using System;

namespace GUI_RestaurantManager.UserControls
{
    public partial class UC_DatBan : UserControl
    {
        public UC_DatBan()
        {
            InitializeComponent();
            LoadTables();
        }
        private void LoadTables()
        {
            panelBan.Refresh();
            BUS_Ban bus_Ban = new BUS_Ban();
            List<DTO_Ban> listBan = bus_Ban.getListBan();
            int pictureBoxWidth = 150;
            int pictureBoxHeight = 150;
            int padding = 30;
            int offetY = 30, offetX=30;
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
                tablePictureBox.Location = new Point(col * (pictureBoxWidth + padding)+offetX, row * (pictureBoxHeight + padding)+ offetY);
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
                    if (ban.trangThai == false)
                    {
                        MessageBox.Show($"Bàn: {ban.tenBan}\nTrạng thái: Đang sử dụng");
                    }
                    else
                    {
                        lbBan.Text = "Bàn số "+ ban.maBan;
                        lbMaBan.Text = ban.maBan.ToString();
                    }
                };
                panelBan.Controls.Add(tablePictureBox);
            }
        }

        private void panelBan_Paint(object sender, PaintEventArgs e)
        {

        }

        private void btnAdd_Click(object sender, EventArgs e)
        {
            BUS_DangKyBanDat bus_datBan = new BUS_DangKyBanDat();
            BUS_Ban bus_Ban = new BUS_Ban();

            try
            {
                int soLuong = int.Parse(txtSoLuong.Text);
                string ghiChu = txtGhiChu.Text;
                int viTri = int.Parse(lbMaBan.Text);
                DateTime thoiGian = dateThoiGian.Value;

                DTO_DangKyBanDat banDat = new DTO_DangKyBanDat(soLuong, viTri, ghiChu, thoiGian);
                bool result = bus_datBan.themDKBanDat(banDat);

                if (result)
                {
                    bool s= bus_Ban.CapNhatTrangThaiBan(viTri);
                    LoadTables();
                    MessageBox.Show("Thêm thành công");
                }
                else
                {
                    MessageBox.Show("Thêm không thành công");
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show("Đã xảy ra lỗi: " + ex.Message);
            }
        }

        private void btnReset_Click(object sender, EventArgs e)
        {
            txtName.Text = "";
            txtSoLuong.Text = "";
            txtGhiChu.Text = "";
            lbBan.Text = "Chọn bàn";
            lbMaBan.Text = "";
        }
    }
}
