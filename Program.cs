using System;

namespace ddzz09
{
    static class ArrayHelper
    {
   public static string Pop (ref string[] a)
        {
            string  b=a[a.Length-1];
         Array.Resize(ref a,a.Length-1);
         
            return b;
        }
        public static int Pop (ref int[] a)
        {
            int b=a[a.Length-1];
         Array.Resize(ref a,a.Length-1);
         
            return b;
        }
        public static double Pop (ref double[] a)
        {
            double  b=a[a.Length-1];
         Array.Resize(ref a,a.Length-1);
         
            return b;
        }
        public static decimal Pop (ref decimal[] a)
        {
            decimal b=a[a.Length-1];
         Array.Resize(ref a,a.Length-1);
         
            return b;
        }
        public static float Pop (ref float[] a)
        {
            float b=a[a.Length-1];
         Array.Resize(ref a,a.Length-1);
         
            return b;
        }
        public static void Push(ref string[] a,string b)
        {
            Array.Resize(ref a,a.Length+1);
            a[a.Length-1]=b;
        }
          public static void Push(ref int[] a,int b)
        {
            Array.Resize(ref a,a.Length+1);
            a[a.Length-1]=b;
        }
          public static void Push(ref double[] a,double b)
        {
            Array.Resize(ref a,a.Length+1);
            a[a.Length-1]=b;
        }
          public static void Push(ref float[] a,float b)
        {
            Array.Resize(ref a,a.Length+1);
            a[a.Length-1]=b;
        }
          public static void Push(ref decimal[] a,decimal b)
        {
            Array.Resize(ref a,a.Length+1);
            a[a.Length-1]=b;
        }

        public static string Shift( ref string[] a)
        {
            string b=a[0];
            for(int i=0;i<a.Length-1;i++)
            {
                a[i]=a[i+1];
            }
            Array.Resize(ref a,a.Length-1);
            return b;
        }
         public static int Shift( ref int[] a)
        {
            int b=a[0];
            for(int i=0;i<a.Length-1;i++)
            {
                a[i]=a[i+1];
            }
            Array.Resize(ref a,a.Length-1);
            return b;
        }
         public static double Shift( ref double [] a)
        {
            double b=a[0];
            for(int i=0;i<a.Length-1;i++)
            {
                a[i]=a[i+1];
            }
            Array.Resize(ref a,a.Length-1);
            return b;
        }
         public static float Shift( ref float[] a)
        {
            float b=a[0];
            for(int i=0;i<a.Length-1;i++)
            {
                a[i]=a[i+1];
            }
            Array.Resize(ref a,a.Length-1);
            return b;
        }
         public static decimal Shift( ref decimal[] a)
        {
            decimal b=a[0];
            for(int i=0;i<a.Length-1;i++)
            {
                a[i]=a[i+1];
            }
            Array.Resize(ref a,a.Length-1);
            return b;
        }
        public static void UnShift(ref string[] a,string b)
        {
             Array.Resize(ref a,a.Length+1);
             for(int i=a.Length-1;i>0;i--)
             {
                 a[i]=a[i-1];
             }
            a[0]=b;
         
        }
                public static void UnShift(ref int [] a,int b)
        {
             Array.Resize(ref a,a.Length+1);
             for(int i=a.Length-1;i>0;i--)
             {
                 a[i]=a[i-1];
             }
            a[0]=b;
         
        }
                public static void UnShift(ref double [] a,double b)
        {
             Array.Resize(ref a,a.Length+1);
             for(int i=a.Length-1;i>0;i--)
             {
                 a[i]=a[i-1];
             }
            a[0]=b;
         
        }
                public static void UnShift(ref float[] a,float b)
        {
             Array.Resize(ref a,a.Length+1);
             for(int i=a.Length-1;i>0;i--)
             {
                 a[i]=a[i-1];
             }
            a[0]=b;
         
        }
                public static void UnShift(ref decimal [] a,decimal b)
        {
             Array.Resize(ref a,a.Length+1);
             for(int i=a.Length-1;i>0;i--)
             {
                 a[i]=a[i-1];
             }
            a[0]=b;
         
        }

    }
    class Program
    {
        static void Main(string[] args)
        {
            string [] a={"Крокодил","Миньон","Шарик","Улыбка"};
            string b="Воздух";
            Console.Write("массив:");
            for(int i=0;i<a.Length;i++)
            {
                Console.Write($"{a[i]}, ");
            }
            Console.Write("\nудалим:");
           Console.WriteLine(ArrayHelper.Pop(ref a));
           Console.Write("осталось:");
             for(int i=0;i<a.Length;i++)
            {
                Console.Write($"{a[i]},");
            }
            Console.WriteLine("\nметод Push");
            Console.Write("добавляем:");
            Console.WriteLine(b);
           ArrayHelper.Push(ref a,b);
           Console.WriteLine("новый массив:");
           for(int i=0;i<a.Length;i++)
          {
              Console.Write($"{a[i]},  ");
          }
           Console.WriteLine("\nметод Shift");
            Console.Write("удалим:");
            Console.WriteLine(ArrayHelper.Shift(ref a));
            Console.WriteLine("новый массив:");
             for(int i=0;i<a.Length;i++)
            {
                Console.Write($"{a[i]},");
            }
            Console.WriteLine("\nметод UnShift");
            Console.WriteLine("добавляем:");
            string c="Стул";
            Console.WriteLine(c);
            ArrayHelper.UnShift(ref a,c);
            Console.WriteLine("новый массив:");
             for(int i=0;i<a.Length;i++)
            {
                Console.Write($"{a[i]},");
            }

             int [] a1={3,5,7,9};
             int b1=6;
            Console.Write("\nмассив:");
            for(int i=0;i<a1.Length;i++)
            {
                Console.Write($"{a1[i]}, ");
            }
            Console.Write("\nудалим:");
           Console.WriteLine(ArrayHelper.Pop(ref a1));
           Console.Write("осталось:");
             for(int i=0;i<a1.Length;i++)
            {
                Console.Write($"{a1[i]},");
            }
             Console.WriteLine("\nметод Push");
            Console.Write("добавляем:");
            Console.WriteLine(b1);
           ArrayHelper.Push(ref a1,b1);
           Console.WriteLine("новый массив:");
           for(int i=0;i<a1.Length;i++)
          {
              Console.Write($"{a1[i]},  ");
          }
           Console.WriteLine("\nметод Shift");
            Console.Write("удалим:");
            Console.WriteLine(ArrayHelper.Shift(ref a1));
            Console.WriteLine("новый массив:");
             for(int i=0;i<a1.Length;i++)
            {
                Console.Write($"{a1[i]},");
            }
            Console.WriteLine("\nметод UnShift");
            Console.WriteLine("добавляем:");
            int c1=0;
            Console.WriteLine(c1);
            ArrayHelper.UnShift(ref a1,c1);
            Console.WriteLine("новый массив:");
             for(int i=0;i<a1.Length;i++)
            {
                Console.Write($"{a1[i]},");
            }
            
             double [] a2={3.8,4.5,9.7,6.02};
             double b2=7.444;
            Console.Write("\nмассив:");
            for(int i=0;i<a2.Length;i++)
            {
                Console.Write($"{a2[i]},  ");
            }
            Console.Write("\nудалим:");
           Console.WriteLine(ArrayHelper.Pop(ref a2));
           Console.Write("осталось:");
             for(int i=0;i<a2.Length;i++)
            {
                Console.Write($"{a2[i]},  ");
            }
             Console.WriteLine("\nметод Push");
            Console.Write("добавляем:");
            Console.WriteLine(b2);
           ArrayHelper.Push(ref a2,b2);
           Console.WriteLine("новый массив:");
           for(int i=0;i<a2.Length;i++)
          {
              Console.Write($"{a2[i]},  ");
          }
           Console.WriteLine("\nметод Shift");
            Console.Write("удалим:");
            Console.WriteLine(ArrayHelper.Shift(ref a2));
            Console.WriteLine("новый массив:");
             for(int i=0;i<a2.Length;i++)
            {
                Console.Write($"{a2[i]},");
            }
            Console.WriteLine("\nметод UnShift");
            Console.WriteLine("добавляем:");
            double c2=33.33;
            Console.WriteLine(c2);
            ArrayHelper.UnShift(ref a2,c2);
            Console.WriteLine("новый массив:");
             for(int i=0;i<a2.Length;i++)
            {
                Console.Write($"{a2[i]},");
            }
             decimal [] a3={4m,7.675m,5.9850m,12.48360m};
             decimal b3=555m;
            Console.Write("\nмассив:");
            for(int i=0;i<a3.Length;i++)
            {
                Console.Write($"{a3[i]},  ");
            }
            Console.Write("\nудалим:");
           Console.WriteLine(ArrayHelper.Pop(ref a3));
           Console.Write("осталось:");
             for(int i=0;i<a3.Length;i++)
            {
                Console.Write($"{a3[i]},  ");
            }
             Console.WriteLine("\nметод Push");
            Console.Write("добавляем:");
            Console.WriteLine(b3);
           ArrayHelper.Push(ref a3,b3);
           Console.WriteLine("новый массив:");
           for(int i=0;i<a3.Length;i++)
          {
              Console.Write($"{a3[i]},  ");
          }
           Console.WriteLine("\nметод Shift");
            Console.Write("удалим:");
            Console.WriteLine(ArrayHelper.Shift(ref a3));
            Console.WriteLine("новый массив:");
             for(int i=0;i<a3.Length;i++)
            {
                Console.Write($"{a3[i]},");
            }
            Console.WriteLine("\nметод UnShift");
            Console.WriteLine("добавляем:");
            decimal c3=654.678m;
            Console.WriteLine(c3);
            ArrayHelper.UnShift(ref a3,c3);
            Console.WriteLine("новый массив:");
             for(int i=0;i<a3.Length;i++)
            {
                Console.Write($"{a3[i]},");
            }
             float [] a4={2.345f,56.9845f,4.5678943f,9.000004f};
             float b4=44.55f;
            Console.Write("\nмассив:");
            for(int i=0;i<a4.Length;i++)
            {
                Console.Write($"{a4[i]},  ");
            }
            Console.Write("\nудалим:");
           Console.WriteLine(ArrayHelper.Pop(ref a4));
           Console.Write("осталось:");
             for(int i=0;i<a4.Length;i++)
            {
                Console.Write($"{a4[i]},  ");
            }
             Console.WriteLine("\nметод Push");
            Console.Write("добавляем:");
            Console.WriteLine(b4);
           ArrayHelper.Push(ref a4,b4);
           Console.WriteLine("новый массив:");
           for(int i=0;i<a.Length;i++)
          {
              Console.Write($"{a4[i]},  ");
          }
           Console.WriteLine("\nметод Shift");
            Console.Write("удалим:");
            Console.WriteLine(ArrayHelper.Shift(ref a4));
            Console.WriteLine("новый массив:");
             for(int i=0;i<a4.Length;i++)
            {
                Console.Write($"{a4[i]},");
            }
            Console.WriteLine("\nметод UnShift");
            Console.WriteLine("добавляем:");
            float c4=66.77f;
            Console.WriteLine(c4);
            ArrayHelper.UnShift(ref a4,c4);
            Console.WriteLine("новый массив:");
             for(int i=0;i<a4.Length;i++)
            {
                Console.Write($"{a4[i]},");
            }
        }
    }
}
