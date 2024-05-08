using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DTO_RestaurantManager
{
    public class DTO_QuyDinh
    {
        private int maQuyDinh { get; set; }
        private string tenQuyDinh { get; set;}
        private int giaTri {  get; set; }
        //public int QUYDINH_maQuyDinh
        //{
        //    get { return _QD_maQuyDinh; }
        //    set { _QD_maQuyDinh = value; }
        //}
        //public string QUYDINH_tenQuyDinh
        //{
        //    get { return _QD_tenQuyDinh; }
        //    set { _QD_tenQuyDinh = value; }
        //}
        //public int QUYDINH_giaTri
        //{
        //    get { return _QD_giaTri; }
        //    set { _QD_giaTri = value; }
        //}
        public DTO_QuyDinh() 
        { 
        }
        public DTO_QuyDinh(int qD_maQuyDinh, string qD_tenQuyDinh, int qD_giaTri)
        {
            this.maQuyDinh = qD_maQuyDinh;
            this.tenQuyDinh = qD_tenQuyDinh;
            this.giaTri = qD_giaTri;
        }
    }

 
}
