using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Struct
{
    public struct Point
    {
        public int x;
        public int y;
        public Point(int x,int y)
        {
            this.x = x;
            this.y = y; 
        }
    }
    internal class Program
    {
        static void Main(string[] args)
        {
            Point p = new Point(30,70);
            Console.WriteLine($"point.x={p.x}, point.y={p.y}");
            Point p2; //new 없이 생성하면 초기화를 해줘야함
            p2.x = 30;
            p2.y = -49;
            Console.WriteLine($"point.x={p2.x}, point.y={p2.y}");
        }
    }
}
