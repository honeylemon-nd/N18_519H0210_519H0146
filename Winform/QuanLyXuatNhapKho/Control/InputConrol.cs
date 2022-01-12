using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using Control;
using Model;

namespace QuanLyXuatNhapKho.Control
{
    public class InputConrol
    {
       
        public static void DataLoad(DataGridView dgv_View)
        {
            using (QLXNKEntities dbo = new QLXNKEntities())
            {
                var rd = from c in dbo.InputInfo select new { c.IdInput, IdInputInfo=c.Id,DisplayNameObject= c.Object.DisplayName, c.Input.DateInput, c.Count,c.InputPrice, DisplayNameUser=c.Input.Users.DisplayName };
                dgv_View.DataSource = rd.ToList().OrderByDescending(p => p.IdInputInfo).ToList();
            }
        }

    }


}
