using System;
using System.Collections.Generic;
using System.Linq;
using System.Security.Cryptography.X509Certificates;
using System.Text;
using System.Threading.Tasks;

namespace DataLayer
{
    public class OBJ_DP
    {
        public int ID {  get; set; }
        public string TENPHONG { get; set; }
        public double DONGIA { get; set; }
        public bool STATUS { get; set; }
        public int IDTANG { get; set; }
        public int IDLOAIPHONG { get; set; }
        public string TENTANG { get; set; }
        public string TENLOAIPHONG { get; set; }
    }
}
