using DataLayer;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BusinessLogic
{
    public class THIETBI_PHONG
    {
        Entities db;
        public THIETBI_PHONG()
        {
            db = Entities.CreateEntities();
        }
        public class Model
        {
            public string IDTB { get; set; }
            public string TENTB {  get; set; }
            public string IDPHONG { get; set; }
            public string TENPHONG { get; set; }
            public int SOLUONG { get; set; }

        }
        public List<Model> getAll()
        {
            var query = from thietbi_phong in db.Set<tb_Phong_ThietBi>()
                        join phong in db.Set<tb_Phong>() on thietbi_phong.IDPHONG equals phong.IDPHONG
                        join thietbi in db.Set<tb_ThietBi>() on thietbi_phong.IDTB equals thietbi.IDTB
                        select new Model
                        {
                            IDTB = thietbi_phong.IDTB.ToString(),
                            TENTB = thietbi.TENTB,
                            IDPHONG = thietbi_phong.IDPHONG.ToString(),
                            TENPHONG = phong.TENPHONG,
                            SOLUONG = (int)thietbi_phong.SOLUONG
                        };
            return query.ToList();
        }
        public List<Model> getByTB(string idtb)
        {
            var query = from thietbi_phong in db.Set<tb_Phong_ThietBi>()
                        join phong in db.Set<tb_Phong>() on thietbi_phong.IDPHONG equals phong.IDPHONG
                        join thietbi in db.Set<tb_ThietBi>() on thietbi_phong.IDTB equals thietbi.IDTB
                        where thietbi_phong.IDTB.ToString() == idtb
                        select new Model
                        {
                            IDTB = thietbi_phong.IDTB.ToString(),
                            TENTB = thietbi.TENTB,
                            IDPHONG = thietbi_phong.IDPHONG.ToString(),
                            TENPHONG = phong.TENPHONG,
                            SOLUONG = (int)thietbi_phong.SOLUONG
                        };
                        
            return query.ToList();
        }
        public List<Model> getByP(string idp)
        {
            var query = from thietbi_phong in db.Set<tb_Phong_ThietBi>()
                        join phong in db.Set<tb_Phong>() on thietbi_phong.IDPHONG equals phong.IDPHONG
                        join thietbi in db.Set<tb_ThietBi>() on thietbi_phong.IDTB equals thietbi.IDTB
                        where thietbi_phong.IDPHONG.ToString() == idp
                        select new Model
                        {
                            IDTB = thietbi_phong.IDTB.ToString(),
                            TENTB = thietbi.TENTB,
                            IDPHONG = thietbi_phong.IDPHONG.ToString(),
                            TENPHONG = phong.TENPHONG,
                            SOLUONG = (int)thietbi_phong.SOLUONG
                        };

            return query.ToList();
        }
        public List<Model> getPorTB(string idp, string idtb)
        {
            var query = from thietbi_phong in db.Set<tb_Phong_ThietBi>()
                        join phong in db.Set<tb_Phong>() on thietbi_phong.IDPHONG equals phong.IDPHONG
                        join thietbi in db.Set<tb_ThietBi>() on thietbi_phong.IDTB equals thietbi.IDTB
                        where thietbi_phong.IDTB.ToString() == idtb && thietbi_phong.IDPHONG.ToString() == idp
                        select new Model
                        {
                            IDTB = thietbi_phong.IDTB.ToString(),
                            TENTB = thietbi.TENTB,
                            IDPHONG = thietbi_phong.IDPHONG.ToString(),
                            TENPHONG = phong.TENPHONG,
                            SOLUONG = (int)thietbi_phong.SOLUONG
                        };

            return query.ToList();
        }

        public void add(tb_Phong_ThietBi tbp)
        {
            try
            {
                db.Set<tb_Phong_ThietBi>().Add(tbp);
                db.SaveChanges();
            }
            catch (Exception ex)
            {
                throw new Exception("Có lỗi xảy ra trong quá trình xử lý dữ liệu. " + ex.Message);
            }
        }
        public void update(tb_Phong_ThietBi tbp)
        {
            tb_Phong_ThietBi _tbp = db.Set<tb_Phong_ThietBi>().FirstOrDefault(x => x.IDTB == tbp.IDTB && x.IDPHONG == tbp.IDPHONG);
            _tbp.IDPHONG = tbp.IDPHONG;
            _tbp.IDTB = tbp.IDTB;
            _tbp.SOLUONG = tbp.SOLUONG;
            try
            {
                db.SaveChanges();
            }
            catch (Exception ex)
            {
                throw new Exception("Có lỗi xảy ra trong quá trình xử lý dữ liệu. " + ex.Message);
            }
        }

        public void delete(int idtb, int idp)
        {
            tb_Phong_ThietBi _tbp = db.Set<tb_Phong_ThietBi>().FirstOrDefault(x => x.IDTB == idtb && x.IDPHONG == idp);
            try
            {
                db.Set<tb_Phong_ThietBi>().Remove(_tbp);
                db.SaveChanges();
            }
            catch (Exception ex)
            {
                throw new Exception("Có lỗi xảy ra trong quá trình xử lý dữ liệu. " + ex.Message);
            }
        }
    }
}
