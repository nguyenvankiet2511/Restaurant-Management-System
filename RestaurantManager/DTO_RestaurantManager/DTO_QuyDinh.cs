using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DTO_RestaurantManager
{
    public class DTO_QuyDinh
    {
        public int maQuyDinh { get; set; }
        public string tenQuyDinh { get; set;}
        public int giaTri {  get; set; }
        public DTO_QuyDinh() 
        { 
        }
        public DTO_QuyDinh(int qD_maQuyDinh, string qD_tenQuyDinh, int qD_giaTri)
        {
            this.maQuyDinh = qD_maQuyDinh;
            this.tenQuyDinh = qD_tenQuyDinh;
            this.giaTri = qD_giaTri;
        }
        public DTO_QuyDinh(string tenQuyDinh, int giaTri)
        {
            this.tenQuyDinh= tenQuyDinh;
            this.giaTri = giaTri;
        }
    }

 
}
