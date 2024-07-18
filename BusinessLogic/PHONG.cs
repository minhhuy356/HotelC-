using DataLayer;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using static BusinessLogic.THIETBI_PHONG;

namespace BusinessLogic
{
    public class PHONG
    {
        Entities db;
        public PHONG()
        {
            db = Entities.CreateEntities();
            
        }
        public class Model
        {
            public int IDPHONG { get; set; }
            public bool TRANGTHAI { get; set; }
            public string TENPHONG { get; set; }
            public string TENLOAIPHONG { get; set; }
            public string TENTANG { get; set; }
        }
        public List<Model> getAll()
        {
            var query = from phong in db.Set<tb_Phong>()
                        join loaiphong in db.Set<tb_LoaiPhong>() on phong.IDLOAIPHONG equals loaiphong.IDLOAIPHONG
                        join tang in db.Set<tb_Tang>() on phong.IDTANG equals tang.IDTANG
                        select new Model
                        {
                            IDPHONG = phong.IDPHONG,
                            TRANGTHAI = (bool)phong.TRANGTHAI,
                            TENPHONG = phong.TENPHONG,
                            TENLOAIPHONG = loaiphong.TENLOAIPHONG,
                            TENTANG = tang.TENTANG
                        };

            return query.ToList();
        }

        public List<tb_Phong> getByTang(int idTang)
        {
            return db.Set<tb_Phong>().Where(x=>x.IDTANG == idTang).ToList();
        }
        public void add(tb_Phong p)
        {
            try
            {
                db.Set<tb_Phong>().Add(p);
                db.SaveChanges();
            }
            catch (Exception ex)
            {
                throw new Exception("Có lỗi xảy ra trong quá trình xử lý dữ liệu. " + ex.Message);
            }
        }
        public void update(tb_Phong p)
        {
            tb_Phong _p = db.Set<tb_Phong>().FirstOrDefault(x => x.IDPHONG == p.IDPHONG);
            _p.IDPHONG = p.IDPHONG;
            _p.TENPHONG = p.TENPHONG;
            _p.TRANGTHAI = p.TRANGTHAI;
            _p.IDTANG = p.IDTANG;
            _p.IDLOAIPHONG = p.IDLOAIPHONG;
            try
            {
                db.SaveChanges();
            }
            catch (Exception ex)
            {
                throw new Exception("Có lỗi xảy ra trong quá trình xử lý dữ liệu. " + ex.Message);
            }
        }
        public void delete(int idp)
        {
            tb_Phong _p = db.Set<tb_Phong>().FirstOrDefault(x => x.IDPHONG == idp);
            try
            {
                db.Set<tb_Phong>().Remove(_p);
                db.SaveChanges();
            }
            catch (Exception ex)
            {
                throw new Exception("Có lỗi xảy ra trong quá trình xử lý dữ liệu. " + ex.Message);
            }
        }
    }
}
