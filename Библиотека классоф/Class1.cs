using System;

namespace Виндовс_формс
{
    public class MyPoint
    {
        private int x;
        public MyPoint()
        {

        }
        public MyPoint(int x)
        {
            this.x = x;
        }
        public int Sum(MyPoint temp)
        {
            return x + temp.x;
        }
    }

}