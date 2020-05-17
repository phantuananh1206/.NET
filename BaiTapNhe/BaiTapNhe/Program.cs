using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;


namespace BaiTapNhe
{

    class Program
    {
        static bool ktSNT(int n)
        {
            if (n < 2)
                return false;
            for (int i = 2; i <= Math.Sqrt(n); i++)
            {
                if (n % i == 0)
                    return false;
            }
            return true;
        }
        static void Main(string[] args)
       {
            
            //float a;
            //Console.WriteLine("Nhập cạnh hình vuông: ");
            //a = float.Parse(Console.ReadLine());
            //float cv = a * 4;
            //Double dt = Math.Pow(a, 2);
            //Console.WriteLine("Chu vi hình vuông: " + cv);
            //Console.WriteLine("Diện tích hình vuông: " + dt);

            int n;
            Console.WriteLine("Nhap so nguyen n: ");
            n = int.Parse(Console.ReadLine());
            //if (ktSNT(n))
            //    Console.WriteLine(n + " la so nguyen to");
            //else
            //    Console.WriteLine(n + " khong phai la so nguyen to");

            for (int i = 1; i <= n; i++)
            {
                if (ktSNT(i))
                    Console.Write(i + " ");
            }

            Console.ReadKey();
        }
    }
}
