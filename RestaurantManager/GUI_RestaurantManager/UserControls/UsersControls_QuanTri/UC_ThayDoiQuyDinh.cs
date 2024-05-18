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

namespace GUI_RestaurantManager.UserControls.UsersControls_QuanTri
{
    public partial class UC_ThayDoiQuyDinh : UserControl
    {
        BUS_QuyDinh bus_quyDinh= new BUS_QuyDinh();
        public UC_ThayDoiQuyDinh()
        {
            InitializeComponent();
            LoadTables();
        }
        public void LoadTables()
        {
            dataGVQuyDinh.DataSource = bus_quyDinh.LayDanhSachQuyDinh();
            dataGVQuyDinh.RowTemplate.Height = 50; // Đặt chiều cao của mỗi dòng
            dataGVQuyDinh.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.Fill;
            dataGVQuyDinh.Columns["maQuyDinh"].HeaderText = "Mã quy định";
            dataGVQuyDinh.Columns["tenQuyDinh"].HeaderText = "Tên quy định";
            dataGVQuyDinh.Columns["giaTri"].HeaderText = "Giá trị";
        }
        private void btnAdd_Click(object sender, EventArgs e)
        {
            string tenQuyDinh= txtName.Text;
            int giaTri= Convert.ToInt32(txtValue.Text);
            DTO_QuyDinh quyDinh= new DTO_QuyDinh(tenQuyDinh,giaTri);
            if (bus_quyDinh.ThemQuyDinh(quyDinh))
            {
                LoadTables();
                MessageBox.Show("Thêm quy định thành công");
            }
            else
            {
                MessageBox.Show("Thêm không thành công!");
            }
        }

        private void dataGVQuyDinh_Click(object sender, EventArgs e)
        {
            if (dataGVQuyDinh.CurrentRow != null)
            {
                DataGridViewRow row = dataGVQuyDinh.CurrentRow;
                lbMaQD.Text= row.Cells["maQuyDinh"].Value.ToString();
                txtName.Text = row.Cells["tenQuyDinh"].Value.ToString();
                txtValue.Text = row.Cells["giaTri"].Value.ToString();
            }
        }

        private void btnUpdate_Click(object sender, EventArgs e)
        {
            int maQuyDinh = Convert.ToInt32(lbMaQD.Text);
            string tenQuyDinh = txtName.Text;
            int giaTri = Convert.ToInt32(txtValue.Text);
            DTO_QuyDinh quyDinh = new DTO_QuyDinh(maQuyDinh,tenQuyDinh, giaTri);
            if (bus_quyDinh.SuaQuyDinh(quyDinh))
            {
                LoadTables();
                MessageBox.Show("Sửa quy định thành công");
            }
            else
            {
                MessageBox.Show("Sửa không thành công!");
            }
        }
    }
}
