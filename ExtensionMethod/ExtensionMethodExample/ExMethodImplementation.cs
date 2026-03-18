using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ExtensionMethodExample
{
    public static class ExMethodImplementation
    {
        public static string Test3(this ExMethod obj)
        {
            return "Test 3 Called";
        } 

    }
}
