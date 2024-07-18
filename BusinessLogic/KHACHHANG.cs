using DataLayer;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BusinessLogic
{
    public class KHACHHANG
    {
        Entities db;
        public KHACHHANG()
        {
            db = Entities.CreateEntities();
        }
        public tb_KhachHang getItem(int idkh)
        {
            return db.Set<tb_KhachHang>().FirstOrDefault(x => x.IDKH == idkh);
        }

        public List<tb_KhachHang> getAll()
        {
            return db.Set<tb_KhachHang>().ToList();
        }

        public void add(tb_KhachHang kh)
        {
            try
            {
                db.Set<tb_KhachHang>().Add(kh);
                db.SaveChanges();
            }
            catch (Exception ex)
            {
                throw new Exception("Có lỗi xảy ra trong quá trình xử lý dữ liệu. " + ex.Message);
            }
        }
        public void update(tb_KhachHang kh)
        {
            tb_KhachHang _kh = db.Set<tb_KhachHang>().FirstOrDefault(x => x.IDKH == kh.IDKH);
            _kh.IDKH = kh.IDKH;
            _kh.DIENTHOAI = kh.DIENTHOAI;
            _kh.DIACHI = kh.DIACHI;
            _kh.HOTEN = kh.HOTEN;
            _kh.CCCD = kh.CCCD;
            _kh.EMAIL = kh.EMAIL;
            _kh.GIOITINH = kh.GIOITINH;
            try
            {
                db.SaveChanges();
            }
            catch (Exception ex)
            {
                throw new Exception("Có lỗi xảy ra trong quá trình xử lý dữ liệu. " + ex.Message);
            }
        }
        public void delete(int idkh)
        {
            tb_KhachHang _kh = db.Set<tb_KhachHang>().FirstOrDefault(x => x.IDKH == idkh);
            try
            {
                db.Set<tb_KhachHang>().Remove(_kh);
                db.SaveChanges();
            }
            catch (Exception ex)
            {
                throw new Exception("Có lỗi xảy ra trong quá trình xử lý dữ liệu. " + ex.Message);
            }
        }
    }
}
