using DataLayer;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BusinessLogic
{
    public class DATPHONG_CT
    {
        Entities db;
        public DATPHONG_CT()
        {
            db = Entities.CreateEntities();
        }
        public class Model
        {
            public string IDTB { get; set; }
            public string TENTB { get; set; }
            public string IDPHONG { get; set; }
            public string TENPHONG { get; set; }
            public int SOLUONG { get; set; }

        }
        public List<tb_DatPhong_CT> getAll()
        {
            /*            var query = from thietbi_phong in db.Set<tb_Phong_ThietBi>()
                                    join phong in db.Set<tb_Phong>() on thietbi_phong.IDPHONG equals phong.IDPHONG
                                    join thietbi in db.Set<tb_ThietBi>() on thietbi_phong.IDTB equals thietbi.IDTB
                                    select new Model
                                    {
                                        IDTB = thietbi_phong.IDTB.ToString(),
                                        TENTB = thietbi.TENTB,
                                        IDPHONG = thietbi_phong.IDPHONG.ToString(),
                                        TENPHONG = phong.TENPHONG,
                                        SOLUONG = (int)thietbi_phong.SOLUONG
                                    };*/
            return db.Set<tb_DatPhong_CT>().ToList();
        }

        public void add(tb_DatPhong_CT dp_ct)
        {
            try
            {
                db.Set<tb_DatPhong_CT>().Add(dp_ct);
                db.SaveChanges();
            }
            catch (Exception ex)
            {
                throw new Exception("Có lỗi xảy ra trong quá trình xử lý dữ liệu. " + ex.Message);
            }
        }
        public void update(tb_DatPhong_CT dp_ct)
        {
            tb_DatPhong_CT _dp_ct = db.Set<tb_DatPhong_CT>().FirstOrDefault(x => x.IDDPCT == dp_ct.IDDPCT);
            _dp_ct.IDDP = dp_ct.IDDP;
            _dp_ct.IDPHONG = dp_ct.IDPHONG;
            _dp_ct.SONGAYO = dp_ct.SONGAYO;
            _dp_ct.DONGIA = dp_ct.DONGIA;
            _dp_ct.THANHTIEN = dp_ct.THANHTIEN;
            _dp_ct.NGAY = dp_ct.NGAY;
            try
            {
                db.SaveChanges();
            }
            catch (Exception ex)
            {
                throw new Exception("Có lỗi xảy ra trong quá trình xử lý dữ liệu. " + ex.Message);
            }
        }

        public void delete(int iddp_ct)
        {
            tb_DatPhong_CT _dp = db.Set<tb_DatPhong_CT>().FirstOrDefault(x => x.IDDPCT == iddp_ct);
            try
            {
                db.Set<tb_DatPhong_CT>().Remove(_dp);
                db.SaveChanges();
            }
            catch (Exception ex)
            {
                throw new Exception("Có lỗi xảy ra trong quá trình xử lý dữ liệu. " + ex.Message);
            }
        }
    }
}
