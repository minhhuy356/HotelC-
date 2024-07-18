using DataLayer;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BusinessLogic
{
    public class DONVI
    {
        Entities db;
        public DONVI()
        {
            db = Entities.CreateEntities();
        }

        public tb_DonVi getItem(string madv)
        {
            return db.Set<tb_DonVi>().FirstOrDefault(x => x.MADVI == madv);
        }

        public List<tb_DonVi> getAll()
        {
            return db.Set<tb_DonVi>().ToList();
        }
        public List<tb_DonVi> getAll(string maks)
        {
            return db.Set<tb_DonVi>().Where(x=> x.MAKS == maks).ToList();
        }

        public void add(tb_DonVi dv)
        {
            try
            {
                db.Set<tb_DonVi>().Add(dv);
                db.SaveChanges();
            }
            catch (Exception ex)
            {
                throw new Exception("Có lỗi xảy ra trong quá trình xử lý dữ liệu. " + ex.Message);
            }
        }
        public void update(tb_DonVi dv)
        {
            tb_DonVi _dv = db.Set<tb_DonVi>().FirstOrDefault(x => x.MADVI == dv.MAKS);
            _dv.MADVI = dv.MADVI;
            _dv.TENDVI = dv.TENDVI;
            _dv.DIENTHOAI = dv.DIENTHOAI;
            _dv.EMAIL = dv.EMAIL;
            _dv.DIACHI = dv.DIACHI;
            try
            {
                db.SaveChanges();
            }
            catch (Exception ex)
            {
                throw new Exception("Có lỗi xảy ra trong quá trình xử lý dữ liệu. " + ex.Message);
            }
        }
        public void delete(string madv)
        {
            tb_DonVi _dv = db.Set<tb_DonVi>().FirstOrDefault(x => x.MADVI == madv);
            try
            {
                db.Set<tb_DonVi>().Remove(_dv);
                db.SaveChanges();
            }
            catch (Exception ex)
            {
                throw new Exception("Có lỗi xảy ra trong quá trình xử lý dữ liệu. " + ex.Message);
            }
        }
    }
}
