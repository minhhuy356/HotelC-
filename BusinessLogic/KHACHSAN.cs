using DataLayer;
using System;
using System.Collections.Generic;
using System.Data.Entity;
using System.Data.Entity.Migrations;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BusinessLogic
{
    public class KHACHSAN
    {
        Entities db;
        public KHACHSAN()
        {
            db = Entities.CreateEntities();
        }

        public tb_KhachSan getItem(string maks)
        {
            return db.Set<tb_KhachSan>().FirstOrDefault(x=>x.MAKS == maks);
        }

        public List<tb_KhachSan> getAll()
        {
            return db.Set<tb_KhachSan>().ToList();
        }

        public void add(tb_KhachSan ks)
        {
            try
            {
                db.Set<tb_KhachSan>().Add(ks);
                db.SaveChanges();
            }
            catch (Exception ex)
            {
                throw new Exception("Có lỗi xảy ra trong quá trình xử lý dữ liệu. " + ex.Message);
            }
        }
        public void update(tb_KhachSan ks)
        {
            tb_KhachSan _ks = db.Set<tb_KhachSan>().FirstOrDefault(x => x.MAKS == ks.MAKS);
            _ks.MAKS = ks.MAKS;
            _ks.TENKS = ks.TENKS;
            _ks.DIENTHOAI = ks.DIENTHOAI;
            _ks.EMAIL = ks.EMAIL;
            _ks.DIACHI = ks.DIACHI;
            _ks.DISABLE = ks.DISABLE;
            try
            {
                db.SaveChanges();
            }
            catch (Exception ex)
            {
                throw new Exception("Có lỗi xảy ra trong quá trình xử lý dữ liệu. " + ex.Message);
            }
        }
        public void delete(string maks)
        {
            tb_KhachSan _ks = db.Set<tb_KhachSan>().FirstOrDefault(x => x.MAKS == maks);
            try
            {
                db.Set<tb_KhachSan>().Remove(_ks);
                db.SaveChanges();
            }
            catch (Exception ex)
            {
                throw new Exception("Có lỗi xảy ra trong quá trình xử lý dữ liệu. " + ex.Message);
            }
        }
    }
}
