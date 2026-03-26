using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BTL_QLCHG.Models
{
    public class NhanVien
    {
        public string MaNV { get; set; }
        public string TenNV { get; set; }
        public string GioiTinh { get; set; }
        public DateTime NgayVaoLam { get; set; }
        public decimal LuongCoBan { get; set; }
        public string TaiKhoan { get; set; }
        public string MatKhau { get; set; }
        public string Quyen { get; set; } 
    }
}
