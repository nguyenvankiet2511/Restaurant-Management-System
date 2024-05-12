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

namespace GUI_RestaurantManager.UserControls
{
    public partial class UC_XemMonAn : UserControl
    {
        public UC_XemMonAn()
        {
            InitializeComponent();
            LoadMonAn();
        }

        private void dataGVMonAn_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

        }
        private void LoadMonAn()
        {
            BUS_MonAn bus_MonAn = new BUS_MonAn();
            dataGVMonAn.DataSource = bus_MonAn.getListMonAn();
            dataGVMonAn.RowTemplate.Height = 50; // Đặt chiều cao của mỗi dòng
            dataGVMonAn.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.Fill;
            dataGVMonAn.Refresh();
        }

        private void btnSearch_Click(object sender, EventArgs e)
        {
            string key = txtKey.Text;
            if (key == "") 
            { 
                LoadMonAn(); 
            }
            BUS_MonAn bus_MonAn = new BUS_MonAn();
            dataGVMonAn.DataSource = bus_MonAn.TimKiemMonAn(key);
            dataGVMonAn.RowTemplate.Height = 50;
            dataGVMonAn.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.Fill;
            dataGVMonAn.Refresh();
        }
    }
}
