using BUS_RestaurantManager;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Web.UI.DataVisualization.Charting;
using System.Windows.Forms;
using System.Windows.Forms.DataVisualization.Charting;

namespace GUI_RestaurantManager.UserControls.UsersControls_QuanTri
{
    public partial class UC_TKBC : UserControl
    {
       
        BUS_HoaDon bus_hoaDon= new BUS_HoaDon();
        BUS_MonAn bus_monAn= new BUS_MonAn();

        public UC_TKBC()
        {
            InitializeComponent();
            LoadChar();
            ChangeTypeDate();
        }
        public void ChangeTypeDate()
        {
            dateNgayChon.CustomFormat = "MM/yyyy";
            dateNgayChon.Format = DateTimePickerFormat.Custom;
            dateNgayChon.ShowUpDown = true;
        }
        public void LoadChar()
        {
            int month = dateNgayChon.Value.Month;
            int year= dateNgayChon.Value.Year;
            //Xóa các biểu đồ cũ
            chartDoangThu.Series.Clear();
            chartDoangThu.Titles.Clear();
            
            chartSoLuongKhach.Series.Clear();
            chartSoLuongKhach.Titles.Clear();

            chartTanXuatMon.Series.Clear();
            chartTanXuatMon.Titles.Clear();

            chartDoanhThuDonHang.Series.Clear();
            chartDoanhThuDonHang.Titles.Clear();

            // Vẽ biểu đồ doanh thu 
            DataTable doanhThuTheoThang = bus_hoaDon.LayDoanhThuTheoThang(year);
            System.Windows.Forms.DataVisualization.Charting.Series revenueSeries = new System.Windows.Forms.DataVisualization.Charting.Series();
            revenueSeries.Name = "Doang thu";
            revenueSeries.ChartType = System.Windows.Forms.DataVisualization.Charting.SeriesChartType.Column;
            revenueSeries.MarkerStyle = System.Windows.Forms.DataVisualization.Charting.MarkerStyle.None;
            foreach (DataRow row in doanhThuTheoThang.Rows)
            {
                revenueSeries.Points.AddXY(row["Month"], row["Revenue"]);
            }
            chartDoangThu.Series.Add(revenueSeries);
            chartDoangThu.Titles.Add("Doanh thu trong năm "+year);

            // Vẽ biểu đồ số lượng khách
            DataTable soLuongKhachTheoThang = bus_hoaDon.LaySoLuongKhachTheoThang(year);
            System.Windows.Forms.DataVisualization.Charting.Series customerSeries = new System.Windows.Forms.DataVisualization.Charting.Series();
            customerSeries.Name = "Số lượng khách";  // Changed to a more appropriate name
            customerSeries.ChartType = System.Windows.Forms.DataVisualization.Charting.SeriesChartType.Line;
            customerSeries.MarkerStyle = System.Windows.Forms.DataVisualization.Charting.MarkerStyle.None;
            foreach (DataRow row in soLuongKhachTheoThang.Rows)
            {
                customerSeries.Points.AddXY(row["Month"], row["NumberOfCustomers"]); 
            }
            chartSoLuongKhach.Series.Add(customerSeries);
            chartSoLuongKhach.Titles.Add("Tần suất số lượng khách"); 

            // Vẽ biểu đồ hình tròn tần suất món
            DataTable tanSuatMonAn= bus_monAn.LayTanSuatMonAn(month,year);
            System.Windows.Forms.DataVisualization.Charting.Series tanSuatMon = new System.Windows.Forms.DataVisualization.Charting.Series();
            tanSuatMon.Name = "Tần suất món";
            tanSuatMon.ChartType = System.Windows.Forms.DataVisualization.Charting.SeriesChartType.Pie;
            foreach(DataRow row in tanSuatMonAn.Rows)
            {
                tanSuatMon.Points.AddXY(row["TenMonAn"], row["TanSuat"]);
            }
            chartTanXuatMon.Series.Add(tanSuatMon);
            chartTanXuatMon.Titles.Add("Tần suất món ăn trong tháng "+month+" năm "+year);

            //Vẽ biêu đồ doanh thu đơn hàng
            DataTable doanhThuDonHang = bus_hoaDon.LayDoanhThuDonHangTheoThang(year);
            System.Windows.Forms.DataVisualization.Charting.Series dtDonHang = new System.Windows.Forms.DataVisualization.Charting.Series();
            dtDonHang.Name = "Doanh thu";
            dtDonHang.ChartType = System.Windows.Forms.DataVisualization.Charting.SeriesChartType.Column;
            dtDonHang.MarkerStyle = System.Windows.Forms.DataVisualization.Charting.MarkerStyle.None;
            foreach (DataRow row in doanhThuDonHang.Rows)
            {
                dtDonHang.Points.AddXY(row["Month"], row["Revenue"]);
            }
            chartDoanhThuDonHang.Series.Add(dtDonHang);
            chartDoanhThuDonHang.Titles.Add("Doang thu đơn hàng");
        }
       
        private void btnXemTK_Click(object sender, EventArgs e)
        {
            LoadChar();
        }
    }
}
