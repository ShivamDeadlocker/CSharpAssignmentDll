using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AbstractClassScenario
{
    public abstract class A
    {
        public abstract int Method1();

        public abstract int Method2();

        public abstract int Method3();

        public abstract int Method4();
            
        public abstract int Method5();


    }
    public abstract class B : A
    {
        public override int Method1()
        {
            return 1;
        }

        public abstract int Method6();

        public abstract int Method7();

        public abstract int Method8();
        
    }
    public class C : B
    {
        public override int Method1()
        {
            return 1;
        }
        public override int Method2()
        {
            return 1;
        }
        public override int Method3()
        {
            return 1;
        }
        public override int Method4()
        {
            return 1;
        }
        public override int Method5()
        {
            return 1;
        }
        public override int Method6()
        {
            return 1;
        }
        public override int Method7()
        {
            return 1;
        }
        public override int Method8()
        {
            return 1;
        }
    }
}






