using System;

namespace Tours.Lesson4
{
    public class Point
    {
        public int x, y;
        public Point(int x, int y) => (this.x, this.y) = (x, y);

        public static void M_in(in Point p) { p.x++; } // p = new Point(1,2); はエラー
        public static void M_ref(ref Point p) { p.x++; p = new Point(0,0); } // 既存の参照先がある。それを変更できる
        public static void M_out(out Point p) { p = new Point(0,0); p.x++; } // 既存の参照先は不要。メソッド内で先に代入必須。
    }
}
