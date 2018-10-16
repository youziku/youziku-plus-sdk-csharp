using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using V35Test.Sample.lmpl;
using V45Test.Sample.lmpl;

namespace V45Test.Sample
{
    class Program
    {
        static void Main(string[] args)
        {
            IInterfaceTestAsync test=new TestRamUnicodeWebFontImpl();
            test.Run();
            Console.WriteLine("执行完毕");
            Console.ReadKey();
        }
    }
}
