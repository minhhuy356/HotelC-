using DataLayer;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BusinessLogic
{
    public class DATPHONG
    {
        Entities db;
        public DATPHONG()
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
        public List<tb_DatPhong> getAll()
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
            return db.Set<tb_DatPhong>().ToList();
        }

        public void add(tb_DatPhong dp)
        {
            try
            {
                db.Set<tb_DatPhong>().Add(dp);
                db.SaveChanges();
            }
            catch (Exception ex)
            {
                throw new Exception("Có lỗi xảy ra trong quá trình xử lý dữ liệu. " + ex.Message);
            }
        }
        public void update(tb_DatPhong dp)
        {
            tb_DatPhong _dp = db.Set<tb_DatPhong>().FirstOrDefault(x => x.IDDP == dp.IDDP);
            _dp.IDDP = dp.IDDP;
            _dp.IDPHONG = dp.IDPHONG;
            _dp.IDKH = dp.IDKH;
            _dp.NGAYDAT = dp.NGAYDAT;
            _dp.NGAYTRA = dp.NGAYTRA;
            _dp.SOTIEN = dp.SOTIEN;
            _dp.SONGUOIO = dp.SONGUOIO;
            _dp.ID_USER = dp.ID_USER;
            _dp.MAKS = dp.MAKS;
            _dp.MADVI = dp.MADVI;
            _dp.STATUS = dp.STATUS;
            _dp.THEODOAN = dp.THEODOAN;
            _dp.GHICHU = dp.GHICHU;
            _dp.CREATED_DATE = dp.CREATED_DATE;
            _dp.UPDATE_DATE = dp.UPDATE_DATE;
            _dp.UPDATE_BY = dp.UPDATE_BY;
            try
            {
                db.SaveChanges();
            }
            catch (Exception ex)
            {
                throw new Exception("Có lỗi xảy ra trong quá trình xử lý dữ liệu. " + ex.Message);
            }
        }

        public void delete(int iddp)
        {
            tb_DatPhong _dp = db.Set<tb_DatPhong>().FirstOrDefault(x => x.IDDP == iddp);
            try
            {
                db.Set<tb_DatPhong>().Remove(_dp);
                db.SaveChanges();
            }
            catch (Exception ex)
            {
                throw new Exception("Có lỗi xảy ra trong quá trình xử lý dữ liệu. " + ex.Message);
            }
        }
    }
}
