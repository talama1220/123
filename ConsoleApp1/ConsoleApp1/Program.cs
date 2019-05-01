using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp1
{
    class Program
    {
        static int[] Hamnhapmang()
        {
            int[] A;
            Console.WriteLine("Nhap so luong phan tu cua mang");
            int N = int.Parse(Console.ReadLine());
            A = new int[N];
            for (int i = 0; i < A.Length; i++)
            {
                Console.WriteLine($"Nhap vao gia tri phan tu A[{i}]:");
                A[i] = int.Parse(Console.ReadLine());
            }
            return A;
        }
       
        static int timmax(int[] A)
        {
            int max = A[0];
            for (int i = 0; i < A.Length; i++)
            {
                if (A[i] > max)
                {
                    max = A[i];
                }
            }
            return max;
        }
        static int timmin(int[] A)
        {
            int min = A[0];
            for (int i = 0; i < A.Length; i++)
            {
                if (A[i] < min)
                {
                    min = A[i];
                }
            }
            return min;
        }
        static bool KiemtraSoNgTo(int a)
        {
            bool lasonguyento = true;
            for (int i = 2; i < Math.Sqrt(a); i++)
            {
                if (a % i == 0)
                {
                    lasonguyento = false;
                    break;
                }
            }
            return lasonguyento;
        }
      static bool Kientramangtangdan(int[] A)
        {
            bool lamangtangdan = true;
            for (int i = 0; i < (A.Length - 1); i++)
            {
                if (A[i] > A[i + 1])
                {
                    lamangtangdan = false;
                    break;
                }
            }
            return lamangtangdan;
        }
      static int TinhtongA(int[] A)
        {
            int TongA = 0;
            for (int i = 0; i <A.Length; i++)
            {
                TongA = TongA + A[i];
            }
            return TongA;
        }
        static void Xuatmang(int[] A)
        {
            Console.WriteLine($"Mang A gom cac so:");
            for (int i = 0; i < A.Length; i++)
            {
                Console.Write($"A[{i}]= {A[i]} ");
            }
            Console.WriteLine();
        }
        static int Timsolonnhi(int[] A)
        {
            int Max = A[0];
            int Lonnhi=0;
            for (int i = 1; i < A.Length; i++)
            {
                if (A[i] > Max)
                {
                    Max = A[i];
                }
            }
            for (int i = 0; i < A.Length; i++)
            {
                if (A[i] != Max)
                {
                    if (A[i] > Lonnhi)
                    {
                        Lonnhi = A[i];
                    }
                }
            }
            return Lonnhi;
        }
        static Double Tinhtbc(int[] A)
        {
            int tong = 0;
            int soptl = 0;
            for (int i = 0; i < A.Length; i++)
            {
                if (A[i] % 2 != 0)
                {
                    soptl++;
                    tong = tong + A[i];
                }
            }
            if (soptl == 0) { return tong; }
            return (1.0*tong / soptl);
        }
        static bool lasonguyento(int a)
        {
            bool dkkt = true;
            if (a == 1)
            {
                dkkt = false;
                return dkkt;
            }
            int i = 2;
            while (i <= Math.Sqrt(a))
            {
                if (a % i == 0)
                {
                    dkkt = false;
                    break;
                }
                i++;
            }
            return dkkt;
        }
        static Double Tinhtbcsnt(int[]A)
        {
            int tong = 0;
            int soptl = 0;
            for (int i = 0; i < A.Length; i++)
            {
                if (lasonguyento(A[i]))
                {
                    soptl++;
                    tong = tong + A[i];
                }
            }
            if (soptl == 0) { return tong; }
            return (1.0 * tong / soptl);
        }
        static int Timsoduongnhonhat(int[] A)
        {
            int minindex = -1;
            for (int i = 0; i < A.Length; i++)
            {
                if (A[i] > 0)
                {
                    minindex = i;
                    break;
                }
            }
            if (minindex >= 0)
            {
                for (int i = 0; i < A.Length; i++)
                {
                    if (A[i] > 0 && A[i] < A[minindex])
                    {

                        minindex = i;

                    }
                }
            }
            
            return minindex;
        }
        static int demsongto(int[] A)
        {
            int sl = 0;
            for (int i = 0; i < A.Length; i++)
            {
                if (lasonguyento(A[i]))
                {
                    sl++;
                }
            }
            return sl;
        }
        static int timsongtonhonhat(int []A)
        {
            int minindex = -1;
            for (int i = 0; i < A.Length; i++)
            {
                if (lasonguyento(A[i]))
                {
                    minindex = i;
                    break;
                }
            }
            if (minindex >= 0)
            {
                for (int i = 0; i < A.Length; i++)
                {
                    if (lasonguyento(A[i]) && A[i] < A[minindex])
                    {

                        minindex = i;

                    }
                }
            }

            return minindex;
        }
        static int[,] NhapMaTran()
        {
            int[,] A;
            int N, M;
            Console.WriteLine("Nhap vao so luong dong: ");
            N = int.Parse(Console.ReadLine());
            Console.WriteLine("Nhap vao so luong cot: ");
            M = int.Parse(Console.ReadLine());
            A = new int[N, M];
            for (int i = 0; i < N; i++)
            {
                for (int j = 0; j < M; j++)
                {
                    Console.WriteLine($"Nhap vao phan tu A[{i},{j}]: ");
                    A[i, j] = int.Parse(Console.ReadLine());
                }
            }
            return A;
        }
        static void XuatMaTran(int[,] A)
        {
            Console.WriteLine("Ma tran A co gia tri: ");
            for (int i = 0; i < A.GetLength(0); i++)
            {
                for (int j = 0; j < A.GetLength(1); j++)
                {
                    Console.Write($"A[{i},{j}]= {A[i, j]} ");

                }
                Console.WriteLine();
            }
        }
        static double TinhTBCMT(int[,] A)
        {
            int tong = 0;
            int soptl = 0;
            for (int i = 0; i < A.GetLength(0); i++)
            {
                for (int j = 0; j < A.GetLength(1); j++)
                {
                    if (A[i, j] > 0)
                    {
                        soptl++;
                        tong = tong + A[i, j];
                    }
                }
            }
            if (soptl == 0) { return 0; }
            return (1.0 * tong / soptl);
        }
        static int TimPhanTuNhoNhatTrenCotK(int[,] A,int k)
        {
            int min = A[0, k];
            for (int i = 1; i < A.GetLength(0); i++)
            {
                if (A[i, k] < min)
                {
                    min = A[i, k];
                }
            }
            return min;
        }
        static int TimPhanTuLonNhatTrenhangK(int[,] A, int k)
        {
            int max = A[k, 0];
            for (int i = 1; i < A.GetLength(1); i++)
            {
                if (A[k, i] > max)
                {
                    max = A[k, i];
                }
            }
            return max;
        }
        static bool KiemTraMTTangDan(int[,] A)
        {
            int prev = A[0, 0];
            for (int i = 0; i < A.GetLength(0); i++)
            {
                for (int j = 0; j < A.GetLength(1); j++)
                {
                    if (A[i, j] < prev)
                    {
                        return false;
                    }
                    A[i, j] = prev;
                }
            }
            return true;
        }
        static int DemsoPtK(int[,] A, int k)
        {
            int spt = 0;
            for (int i = 0; i < A.GetLength(0); i++)
            {
                for (int j = 0; j < A.GetLength(1); j++)
                {
                    if (A[i, j] == k)
                    {
                        spt++;
                    }
                }
            }
            return spt;
        }
            static void Main(string[] args)
        {
            int[,] A = NhapMaTran();
            XuatMaTran(A);
            Console.WriteLine("Nhap vao hang k:");
            Double kq = TimPhanTuLonNhatTrenhangK(A,int.Parse(Console.ReadLine())-1);
            Console.WriteLine($"Ket qua la: {kq}");

            /*int[] A = Hamnhapmang();
            Xuatmang(A);
            Double kq = Tinhtbcsnt(A);
            Console.WriteLine($"Ket qua la: {kq:0.00}.");
            /*int i = demsongto(A);
            if (i == 0)
            {
                Console.WriteLine("Mang khong co so nguyen to");
            }
            else
            {
                int Kq = timsongtonhonhat(A);
                Console.WriteLine($"Ket qua la: {Kq}.");
            }
            
            
            
            /*if (Kientramangtangdan(A))
            {
                Console.WriteLine("Mang A la Mang tang dan");

            }
            else
            {
                Console.WriteLine("Mang A khong phai la Mang tang dan");
            }

            
            
            /*bool lamangtangdan = true;
            for (int i = 0; i < (A.Length-1); i++)
            {
                if (A[i] > A[i + 1])
                {
                    lamangtangdan = false;
                    break;
                }
            }
            if (lamangtangdan)
            {
                Console.WriteLine("Mang A la mang tang dan");
            }
            else
            {
                Console.WriteLine("Mang A khong phai la mang tang dan");
            }
            /*Console.WriteLine($"Mang A gom cac so:");
            for (int i=0; i < A.Length; i++)
            {
                Console.Write($"A[{i}]= {A[i]} ");
            }
            int min = A[0];
            for (int i = 0; i < A.Length; i++)
            {
                if (A[i] < min)
                {
                    min = A[i];
                }
            }
            Console.WriteLine();
            Console.WriteLine($"Va gia tri nho nhat cua mang la: {min}.");

            /* Console.WriteLine("Nhap vao so nguyen N:");
            int N = int.Parse(Console.ReadLine());
            if(KiemtraSoNgTo (N))
            {
                Console.WriteLine($"So {N} la so nguyen to.");
            }
            else { Console.WriteLine($"So {N} khong phai la so nguyen to."); }
           
            /*int[] A;
            Console.WriteLine("Nhap so luong phan tu mang A");
            int N = int.Parse(Console.ReadLine());
            A = new int[N];
            for (int i = 0; i < A.Length; i++)
            {
                Console.WriteLine($"Nhap vao gia tri cua A[{i}]");
                A[i] = int.Parse(Console.ReadLine());
            }
            Console.Write("Mang A la: ");
            for (int i = 0; i < A.Length; i++)
            {
                Console.Write($"A[{i}]={A[i]}; ");
            }
            */
            Console.ReadLine();
        }
    }
}
