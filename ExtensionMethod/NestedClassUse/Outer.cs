using System;

namespace NestedClassUse
{
    public class Outer
    {
        private double amount = 5000;

        public class Inner
        {
            private string name = "Shivam";

            public string TotalAmount(Outer ob)
            {
                return "Amount is " + ob.amount;
            }

            public string Name()
            {
                return "Name is " + name;
            }
        }

        public string GetName()
        {
            Inner ib = new Inner();
            return ib.Name();
        }
    }
}