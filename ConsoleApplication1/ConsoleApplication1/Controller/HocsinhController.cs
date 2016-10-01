using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using ConsoleApplication1.Model;
using ConsoleApplication1.Helper;
namespace ConsoleApplication1.Controller
{
    class HocsinhController
    {
        List<Hocsinh> lstHS = new List<Hocsinh>();
        /// <summary>
        /// Add more student
        /// </summary>
        /// <param name="hs"></param>
        /// <returns></returns>
        public ErrorType Add(Hocsinh hs)
        {
            if(lstHS.Count==0)
            {
                lstHS.Add(hs);
                return ErrorType.Thanhcong;
            }
            else
            {
                int pos = lstHS.FindIndex(x => x.MaHS == hs.MaHS);
                if (pos == -1)
                {
                    lstHS.Add(hs);
                    return ErrorType.Thanhcong;
                }
                else return ErrorType.Datontai;
                
            }
        }
        /// <summary>
        /// Update information of a student
        /// </summary>
        /// <param name="hs"></param>
        /// <returns></returns>
        public ErrorType Update(Hocsinh hs)
        {
            if (lstHS.Count == 0)
                return ErrorType.Chuatontai;
            else
            {
                int pos = lstHS.FindIndex(x => x.MaHS == hs.MaHS);
                if (pos == -1)
                {
                    return ErrorType.Chuatontai;
                }
                else
                {
                    lstHS[pos] = hs;
                    return ErrorType.Thanhcong;
                }
            }
        }
        /// <summary>
        /// 
        /// </summary>
        /// <param name="MaHS"></param>
        /// <returns></returns>
        public ErrorType Delete(int MaHS)
        {
            if (lstHS.Count == 0)
                return ErrorType.Chuatontai;
            else
            {
                int pos = lstHS.FindIndex(x => x.MaHS == MaHS);
                if (pos == -1)
                {
                    return ErrorType.Chuatontai;
                }
                else
                {
                    lstHS.RemoveAt(pos);
                    return ErrorType.Thanhcong;
                }
            }
        }
        /// <summary>
        /// Show all students in current list
        /// </summary>
        /// <returns></returns>
        public ErrorType ViewAll()
        {
            if (lstHS.Count == 0)
                return ErrorType.DSRong;
            else
            {
                foreach (Hocsinh hs in lstHS)
                    hs.Show();
                return ErrorType.Thanhcong;
            }
        }
    }
}
