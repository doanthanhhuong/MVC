using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using ConsoleApplication1.Model;
using ConsoleApplication1.Controller;
using ConsoleApplication1.Helper;

namespace ConsoleApplication1.View
{
    class HocsinhView
    {
        HocsinhController hc = new HocsinhController();
        public void Menu()
        {
            Console.Clear();
            Console.WriteLine("--------QLTTHS-----------");
            Console.WriteLine("1. Them hoc sinh");
            Console.WriteLine("2. Sua hoc sinh");
            Console.WriteLine("3. Xoa hoc sinh");
            Console.WriteLine("4. Xem hoc sinh");
            Console.WriteLine("5. Thoat");
            Console.WriteLine("Lua chon:");
            char c = Console.ReadKey().KeyChar;
            Execute(c);
        }
        public void Execute(char c)
        {
            switch(c)
            {
                case '1':
                    ErrorHandle.Log(hc.Add(new Hocsinh(InputType.NhapThem)));
                    break;
                case '2':
                    ErrorHandle.Log(hc.Update(new Hocsinh(InputType.NhapSua)));
                    break;
                case '3':
                    ErrorHandle.Log(hc.Delete((new Hocsinh(InputType.NhapXoa)).MaHS));
                    break;
                case '4':
                    ErrorHandle.Log(hc.ViewAll());
                    break;
                case '5':
                    return;
            }
            Console.ReadKey();
            Menu();
        }
    }
}
