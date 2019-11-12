using System;

namespace Tours.Lesson6
{
    class V {
        public virtual void M() { Console.WriteLine("virtual"); }
    }
    class O : V{
        public override void M() { Console.WriteLine("override"); }
    }
    abstract class A {
        public abstract void M();
    }
    class B : A {
        public override void M () { Console.WriteLine("abstract implement."); }
    }
}
