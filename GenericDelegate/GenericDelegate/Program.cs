using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace GenericDelegate
{
    class Program
    {
        public delegate T MyGenDel<T>(T obj);
        public delegate void MyEventDel(int value);
        static void Main(string[] args)
        {
            Publisher p = new Publisher();
            Subscriber s1 = new Subscriber();
            Subscriber s2 = new Subscriber();
            p.MyEvent += s1.MyMethod;
            p.MyEvent += s2.MyMethod;
            p.FireEvent(10);
            MyGenDel<int> del = delegate (int value)
              {
                  return value * 2;
              };
            Console.WriteLine(del(100));
            Console.ReadKey();
        }
        Func<int, int, long> add = delegate (int a, int b)
            {
                return a + b;
            };
        Action<int, int> add2 = delegate (int a, int b)
           {
               Console.WriteLine(a + b);
           };
        public class Publisher //事件发布者类
        {
            public event MyEventDel MyEvent;
            public void FireEvent(int EventArgu)
            {
                if (MyEvent != null) MyEvent(EventArgu);
            }
        }
        public class Subscriber {
            public void MyMethod(int value)
            {
                Console.WriteLine(value);
            }
        }//事件响应者类
    }
}
