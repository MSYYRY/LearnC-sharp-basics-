using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _019_bool运算
{
    class Program
    {
        static void Main(string[] args)
        {
            //定义score是90。
            int score = 90;
            
            bool sec = score > 50;
            //如果score大于50，则输出true；反之则为false。
            Console.WriteLine(sec);
            
            //最终输出的结果为true。
            Console.ReadKey();
        }
    }
}
