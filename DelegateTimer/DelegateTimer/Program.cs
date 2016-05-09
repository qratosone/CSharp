using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Threading;
namespace DelegateTimer
{
    class TaskInfo
    {
        public int count;
        public TaskInfo() { count = 0; }
    }

    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Press any key to stop");
            TaskInfo ti = new TaskInfo();
            //创建一个Timer对象，然后把一个回调函数传给他
            Timer tm = new Timer(ShowTime, ti, 0, 1000);
            Console.ReadKey();
            tm.Dispose();
        }
        //需要被Timer回调的函数ShowTime
        static void ShowTime(Object ti)
        {
            TaskInfo obj = ti as TaskInfo;
            obj.count++;
            Console.WriteLine("续{0}秒{1}", obj.count, DateTime.Now);
        }
    }
}
