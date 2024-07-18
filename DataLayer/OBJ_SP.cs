using System;
using System.Collections.Generic;
using System.Linq;
using System.Security.Cryptography.X509Certificates;
using System.Text;
using System.Threading.Tasks;

namespace DataLayer
{
    public class OBJ_SP
    {
        public int IDSP { get; set; }
        public string TENSP { get; set; }
        public int SOLUONG { get; set; }
        public float DONGIA { get; set; }
        public float THANHTIEN { get; set; }
        public int IDPHONG { get; set; }
        public string TENPHONG { get; set; }
        public int IDDP { get; set; }
    }
}
