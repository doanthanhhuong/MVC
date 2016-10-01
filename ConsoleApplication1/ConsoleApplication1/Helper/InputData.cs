using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApplication1.Helper
{
    class InputData
    {
        /// <summary>
        /// Input data for interger , data must be numeric
        /// </summary>
        /// <param name="msg"></param>
        /// <param name="err"></param>
        /// <returns></returns>
        public static int IntInput(string msg,string err)
        {
            bool ok = true;
            int ret;
            do
            {
                Console.WriteLine(msg);
                ok = int.TryParse(Console.ReadLine(),out ret);
                if (!ok)
                    Console.WriteLine(err);
            } while (!ok);
            return ret;
        }
        /// <summary>
        /// Input string data, data must be in-range with min-max value
        /// </summary>
        /// <param name="msg"></param>
        /// <param name="err"></param>
        /// <param name="min"></param>
        /// <param name="max"></param>
        /// <returns></returns>
        public static string StrInput(string msg, string err, int min = 1,int max = 50)
        {
            bool ok = true;
            string ret;
            do
            {
                Console.WriteLine(msg);
                ret=Console.ReadLine();
                if (!(ret.Length >= min && ret.Length <= max))
                {
                    Console.WriteLine(err);
                    ok = false;
                }
                else ok = true;
            } while (!ok);
            return ret;
        }
        /// <summary>
        /// Input datetime data in a certain range
        /// </summary>
        /// <param name="msg"></param>
        /// <param name="err"></param>
        /// <param name="min"></param>
        /// <param name="max"></param>
        /// <returns></returns>
        public static DateTime DTInput(string msg, string err, DateTime min , DateTime max )
        {
            bool ok = true;
            DateTime ret;
            do
            {
                Console.WriteLine(msg);
                ok = DateTime.TryParse(Console.ReadLine(),out ret);
                if (ok && ret >= min && ret <= max)
                {
                    ok = true;
                }
                else
                {
                    ok = false;
                    Console.WriteLine(err);
                }
            } while (!ok);
            return ret;
        }
    }
}
