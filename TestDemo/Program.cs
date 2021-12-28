using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TestDemo
{
    internal class Program
    {
        static void Main(string[] args)
        {
            string name = "Ali";
            Console.WriteLine(name.FirstLetterLower());
            List<string> list = new List<string>();
            list.Add("Khartoum");
            list.Add("Dubai");
            list.Add("Cairo");
            list.Add("London");
            list.Add("Newyourk");
            list.Add("Khartoum");
            list.Add("Khartoum");
            list.Add("London");
            list.Add("London");
            list.Add("London");
            Console.WriteLine("------------------------------------------");
            List<string> v = list.RemoveDuplicate();
            Console.WriteLine("Cities before Removing duplicates");
            foreach (var city in list)
                Console.WriteLine(city);
            Console.WriteLine("------------------------------------------");
            Console.WriteLine("Number of Items: " + list.Count);
            Console.WriteLine("------------------------------------------");
            Console.WriteLine("Cities after Removing duplicates");
            foreach (var city in v)
                Console.WriteLine(city);
            Console.WriteLine("------------------------------------------");
            Console.WriteLine("Number of Items: "+v.Count);
            Console.WriteLine("------------------------------------------");
            var obj = new { Id = 1, Name = "Ahmed", Age = 30, Job = "Manager" };
            Console.WriteLine(obj.Id);
            Console.WriteLine(obj.Name);
            Console.WriteLine(obj.Age);
            Console.WriteLine(obj.Job);
            Console.WriteLine("------------------------------------------");
            TestPartial1 tp = new TestPartial1();
            tp.Add();
            tp.Sub();
            tp.Multi();
            Console.WriteLine("------------------------------------------");
            int a = 10;
            int? b = null;
            a = b??1;
            Console.WriteLine(a.ToString());
            b = 20;
            a=b??1;
            Func<string> x = display;
            Func<int, int, int> y = A;
            Console.WriteLine(a.ToString());
            Console.WriteLine("------------------------------------------");
            Console.WriteLine(x());
            Console.WriteLine("------------------------------------------");
            Console.WriteLine(A(4,6));
            Console.WriteLine("------------------------------------------");
            Func<int, int,int> d1 = (i,j) => i * j;
            sq s = h => h * h;
            
            Console.WriteLine(d1(4,5));
            Console.WriteLine("------------------------------------------");
            Console.WriteLine(s(5));
            Console.WriteLine("------------------------------------------");
            Func<string, string> uper = word => word.ToUpper();
            Console.WriteLine(uper("ahmed"));    
            Func<int, int, bool> sd = (i,j) => i==j;

            if (sd(int.Parse(Console.ReadLine()), int.Parse(Console.ReadLine())))
            {
                Console.WriteLine("Equal...");
            }
            else
            {
                Console.WriteLine("Not Equal...");
            }
            Func<string, int> len = l =>
           {
               int n = l.Length;
               Console.WriteLine("Length of {0} = {1}",l, n);
               return n;
           };
            len(Console.ReadLine());
            Console.ReadKey();
        }
        public delegate int sq(int x);
       public static int A(int x,int y)
        {

            return x+ y;    
        }
        public static string display()
        {
            return "TEst Delegate";
        }
    }
}
