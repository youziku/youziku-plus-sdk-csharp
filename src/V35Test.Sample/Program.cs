using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using V35Test.Sample.lmpl;

namespace V35Test.Sample
{
    class Program
    {
        static void Main(string[] args)
        {

            IInterfaceTest test = new TestRamUnicodeWebFontImpl();
            test.Run();
            Console.WriteLine("执行完毕");
            Console.ReadKey();


        }
    }
}
