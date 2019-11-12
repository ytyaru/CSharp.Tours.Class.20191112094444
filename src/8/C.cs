using System;

namespace Tours.Lesson8
{
    class C {
        public C() => Console.WriteLine("コンストラクタ");
        ~C() => Console.WriteLine("デストラクタ");
        public string P1 => "プロパティ1";
        public string P2 { get => "プロパティ2"; set => OnChanged(); }
        public string this[string key] { get => key; }
        public void M() => Console.WriteLine("M()");
        public event EventHandler Changed;
        public static bool operator ==(C a, C b) => Equals(a, b);
        public static bool operator !=(C a, C b) => !Equals(a, b);
        protected virtual void OnChanged() => Changed?.Invoke(this, EventArgs.Empty);
    }
}
