using DataLayer;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BusinessLogic
{
    public class LOAIPHONG
    {
        Entities db;
        public LOAIPHONG()
        {
            db = Entities.CreateEntities();
        }
        public tb_LoaiPhong getItem(int idlp)
        {
            return db.Set<tb_LoaiPhong>().FirstOrDefault(x => x.IDLOAIPHONG == idlp);
        }

        public List<tb_LoaiPhong> getAll()
        {
            return db.Set<tb_LoaiPhong>().ToList();
        }

        public void add(tb_LoaiPhong ks)
        {
            try
            {
                db.Set<tb_LoaiPhong>().Add(ks);
                db.SaveChanges();
            }
            catch (Exception ex)
            {
                throw new Exception("Có lỗi xảy ra trong quá trình xử lý dữ liệu. " + ex.Message);
            }
        }
        public void update(tb_LoaiPhong lp)
        {
            tb_LoaiPhong _lp = db.Set<tb_LoaiPhong>().FirstOrDefault(x => x.IDLOAIPHONG == lp.IDLOAIPHONG);
            _lp.TENLOAIPHONG = lp.TENLOAIPHONG;
            _lp.DONGIA = lp.DONGIA;
            _lp.SONGUOI = lp.SONGUOI;
            _lp.SOGIUONG = lp.SOGIUONG;
            try
            {
                db.SaveChanges();
            }
            catch (Exception ex)
            {
                throw new Exception("Có lỗi xảy ra trong quá trình xử lý dữ liệu. " + ex.Message);
            }
        }
        public void delete(int idlp)
        {
            tb_LoaiPhong _lp = db.Set<tb_LoaiPhong>().FirstOrDefault(x => x.IDLOAIPHONG == idlp);
            try
            {
                db.Set<tb_LoaiPhong>().Remove(_lp);
                db.SaveChanges();
            }
            catch (Exception ex)
            {
                throw new Exception("Có lỗi xảy ra trong quá trình xử lý dữ liệu. " + ex.Message);
            }
        }
    }
}
