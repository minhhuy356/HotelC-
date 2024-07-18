using DataLayer;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BusinessLogic
{
    public class TANG
    {
        Entities db;
        public TANG()
        {
            db = Entities.CreateEntities();
        }
        public tb_Tang getItem(int idt)
        {
            return db.Set<tb_Tang>().FirstOrDefault(x => x.IDTANG == idt);
        }

        public List<tb_Tang> getAllForMain()
        {
            List<tb_Tang> tang = db.Set<tb_Tang>().ToList(); // Lấy dữ liệu từ cơ sở dữ liệu

            // Sắp xếp trong bộ nhớ sau khi dữ liệu đã được lấy về
            List<tb_Tang> sortedTang = tang.OrderBy(t => int.Parse(t.TENTANG.Replace("Tầng ", ""))).ToList();

            return sortedTang;
        }
        public List<tb_Tang> getAll()
        {
            List<tb_Tang> tang = db.Set<tb_Tang>().ToList(); // Lấy dữ liệu từ cơ sở dữ liệu
            return tang;
        }
        public void add(tb_Tang t)
        {
            try
            {
                db.Set<tb_Tang>().Add(t);
                db.SaveChanges();
            }
            catch (Exception ex)
            {
                throw new Exception("Có lỗi xảy ra trong quá trình xử lý dữ liệu. " + ex.Message);
            }
        }
        public void update(tb_Tang t)
        {
            tb_Tang _t = db.Set<tb_Tang>().FirstOrDefault(x => x.TENTANG == t.TENTANG);
            _t.TENTANG = t.TENTANG;
            try
            {
                db.SaveChanges();
            }
            catch (Exception ex)
            {
                throw new Exception("Có lỗi xảy ra trong quá trình xử lý dữ liệu. " + ex.Message);
            }
        }
        public void delete(int idt)
        {
            tb_Tang _t = db.Set<tb_Tang>().FirstOrDefault(x => x.IDTANG == idt);
            try
            {
                db.Set<tb_Tang>().Remove(_t);
                db.SaveChanges();
            }
            catch (Exception ex)
            {
                throw new Exception("Có lỗi xảy ra trong quá trình xử lý dữ liệu. " + ex.Message);
            }
        }
    }
}
