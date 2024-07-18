using DataLayer;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BusinessLogic
{
    public class THIETBI
    {
        Entities db;
        public THIETBI()
        {
            db = Entities.CreateEntities();
        }
        public List<tb_ThietBi> getAll()
        {
            return db.Set<tb_ThietBi>().ToList();
        }

        public void add(tb_ThietBi tbp)
        {
            try
            {
                db.Set<tb_ThietBi>().Add(tbp);
                db.SaveChanges();
            }
            catch (Exception ex)
            {
                throw new Exception("Có lỗi xảy ra trong quá trình xử lý dữ liệu. " + ex.Message);
            }
        }
        public void update(tb_ThietBi tb)
        {
            tb_ThietBi _tb = db.Set<tb_ThietBi>().FirstOrDefault(x => x.IDTB == tb.IDTB);
            _tb.IDTB = tb.IDTB;
            _tb.TENTB = tb.TENTB;
            _tb.DONGIA = tb.DONGIA;
            try
            {
                db.SaveChanges();
            }
            catch (Exception ex)
            {
                throw new Exception("Có lỗi xảy ra trong quá trình xử lý dữ liệu. " + ex.Message);
            }
        }
        public void delete(int idtb)
        {
            tb_ThietBi _tb = db.Set<tb_ThietBi>().FirstOrDefault(x => x.IDTB == idtb );
            try
            {
                db.Set<tb_ThietBi>().Remove(_tb);
                db.SaveChanges();
            }
            catch (Exception ex)
            {
                throw new Exception("Có lỗi xảy ra trong quá trình xử lý dữ liệu. " + ex.Message);
            }
        }
    }
}
