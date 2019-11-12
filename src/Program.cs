using System;

namespace Tours
{
    class Program
    {
        static void Main(string[] args)
        {
            Lesson0();
            Lesson1();
            Lesson2();
            Lesson3();
            Lesson4();
            Lesson5();
            Lesson6();
            Lesson7();
            Lesson8();
        }
        static void Lesson0() {
            var p = new Tours.Lesson0.Point(1, 2);
            Console.WriteLine($"{p.x}, {p.y}");
        }
        static void Lesson1() {
            var p = new Tours.Lesson1.Point<double>(1.1d, 2.2d);
            Console.WriteLine($"{p.x}, {p.y}");
        }
        static void Lesson2() {
            var p = new Tours.Lesson2.Point3D(1,2,3);
            Console.WriteLine($"{p.x}, {p.y}, {p.z}");
        }
        static void Lesson3() {
            var c = new Tours.Lesson3.Color(16,32,64);
//            Console.WriteLine($"{c.r}, {c.g}, {c.b}"); // error CS0122
//            Tours.Lesson3.Color.White = c; // error CS0198
            Console.WriteLine($"{Tours.Lesson3.Color.White}"); 
        }
        static void Lesson4() {
            var p1 = new Tours.Lesson4.Point(1,1);
            Console.WriteLine($"{p1.x}, {p1.y}");
            Tours.Lesson4.Point.M_in(in p1);
            Console.WriteLine($"{p1.x}, {p1.y}");
            Tours.Lesson4.Point.M_ref(ref p1);
            Console.WriteLine($"{p1.x}, {p1.y}");
            Tours.Lesson4.Point.M_out(out p1);
            Console.WriteLine($"{p1.x}, {p1.y}");

            Tours.Lesson4.Point p2; // 初期化せず
//            Tours.Lesson4.Point.M_in(in p2); // error CS0165
//            Console.WriteLine($"{p1.x}, {p1.y}");
//            Tours.Lesson4.Point.M_ref(ref p2); // error CS0165
//            Console.WriteLine($"{p1.x}, {p1.y}");
            Tours.Lesson4.Point.M_out(out p2);
            Console.WriteLine($"{p1.x}, {p1.y}");
        }
        static void Lesson5() {
            var p = new Tours.Lesson5.Points(1,2,3,4);
            foreach (int x in p.Values) {
                Console.WriteLine($"{x}"); 
            }
        }
        static void Lesson6() {
            var v = new Tours.Lesson6.V();
            var o = new Tours.Lesson6.O();
//            var a = new Tours.Lesson6.A(); // error CS0144
            var b = new Tours.Lesson6.B();
            v.M();
            o.M();
            b.M();
        }
        static void Lesson7() {
            var c = new Tours.Lesson7.C();
            c.M();
            c.M(0);
            c.M(0d);
        }
        static void Lesson8() {
            var c = new Tours.Lesson8.C();
            var d = new Tours.Lesson8.C();
            c.Changed += (object sender, EventArgs e) => Console.WriteLine("Changed()");
            Console.WriteLine($"{c.P1}");
            Console.WriteLine($"{c.P2}");
            Console.WriteLine($"{c["MyKey"]}");
            Console.WriteLine($"{c == c}");
            Console.WriteLine($"{c == d}");
        }





    }
}
