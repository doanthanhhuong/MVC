using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApplication1.Helper
{
    enum InputType
    {
        NhapThem,
        NhapSua,
        NhapXoa
    }
    enum ErrorType
    {
        Thanhcong,//0
        Chuatontai,//1
        Datontai,//2
        DSRong//3
    }
    class ErrorHandle
    {
        public static void Log(ErrorType et)
        {
            switch(et)
            {
                case ErrorType.Thanhcong:
                    Console.WriteLine("Thuc hien thao tac thanh cong.");
                    break;
                case ErrorType.DSRong:
                    Console.WriteLine("Khong co ban ghi nao trong danh sach.");
                    break;
                case ErrorType.Chuatontai:
                    Console.WriteLine("Ban ghi khong ton tai trong danh sach.");
                    break;
                case ErrorType.Datontai:
                    Console.WriteLine("Ban ghi da ton tai trong danh sach.");
                    break;
            }
        }
    }
}
