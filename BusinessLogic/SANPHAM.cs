using DataLayer;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BusinessLogic
{
    public class SANPHAM
    {
        Entities db;
        public SANPHAM() 
        {
            db = Entities.CreateEntities();
        }
        public List<tb_SanPham> getAll()
        {
            return db.Set<tb_SanPham>().ToList();
        }

        public void add(tb_SanPham sp)
        {
            try
            {
                db.Set<tb_SanPham>().Add(sp);
                db.SaveChanges();
            }
            catch (Exception ex)
            {
                throw new Exception("Có lỗi xảy ra trong quá trình xử lý dữ liệu. " + ex.Message);
            }
        }
        public void update(tb_SanPham sp)
        {
            tb_SanPham _sp = db.Set<tb_SanPham>().FirstOrDefault(x => x.IDSP == sp.IDSP);
            _sp.IDSP = sp.IDSP;
            _sp.TENSP = sp.TENSP;
            _sp.DONGIA = sp.DONGIA;
            try
            {
                db.SaveChanges();
            }
            catch (Exception ex)
            {
                throw new Exception("Có lỗi xảy ra trong quá trình xử lý dữ liệu. " + ex.Message);
            }
        }
        public void delete(int idsp)
        {
            tb_SanPham _sp = db.Set<tb_SanPham>().FirstOrDefault(x => x.IDSP == idsp);
            try
            {
                db.Set<tb_SanPham>().Remove(_sp);
                db.SaveChanges();
            }
            catch (Exception ex)
            {
                throw new Exception("Có lỗi xảy ra trong quá trình xử lý dữ liệu. " + ex.Message);
            }
        }
    }
}
