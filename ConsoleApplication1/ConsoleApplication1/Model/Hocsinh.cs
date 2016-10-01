using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using ConsoleApplication1.Helper;

namespace ConsoleApplication1.Model
{
    class Hocsinh
    {
        public int MaHS { get; set; }
        public string TenHS { get; set; }
        public DateTime Ngaysinh { get; set; }
        public Hocsinh(InputType it)
        {
            if (it == InputType.NhapThem)
                Console.WriteLine("Nhap du lieu de them hoc sinh moi:");
            else if(it== InputType.NhapSua)
                Console.WriteLine("Nhap du lieu de sua hoc sinh da co:");
            else if (it == InputType.NhapXoa)
                Console.WriteLine("Nhap ma hoc sinh de xoa hoc sinh da co:");

            MaHS = InputData.IntInput(Res.MsgMaHS, Res.ErrInt);

            if (it == InputType.NhapThem || it == InputType.NhapSua)
            {
                TenHS = InputData.StrInput(Res.MsgTenHS, Res.ErrStr, 1, 20);
                Ngaysinh = InputData.DTInput(Res.MsgNgaysinh, Res.ErrDT, new DateTime(1996, 1, 1), new DateTime(2000, 1, 1));
            }
        }
        public void Show()
        {
            Console.WriteLine("{0} --- {1} --- {2}", MaHS, TenHS, Ngaysinh.ToShortDateString());
        }
    }
}
