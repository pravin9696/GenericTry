using GenericTry.Generic_collection_example;
using System.Diagnostics.CodeAnalysis;

namespace GenericTry
{
    class Assignment
    {
        public T FindMax1<T>(T[]array)
        {
            int a = -1;
            T max = (dynamic)a;
            try
            {
                max = array[0];//first element copied into max variable
                foreach (dynamic i in array)
                {
                    if (i > max)
                    {
                        max = i;
                    }
                }
             
            }
            catch (Exception ex)
            {
                Console.WriteLine(ex.Message);
            }
              return max;
        }
        public int FindMax(int[]array)
        {
            if (array.Length==0)
            {
                return -1;
            }
            int max = array[0];//first element copied into max variable
            foreach (int i in array) 
            {
                if (i>max)
                {
                    max = i;
                }
            }
            return max;
        }
        public bool compare<T>(T a,T b)
        {
            dynamic a1 = a;
            dynamic b1 = b;
            if (a1==b1)
            {
                return true;
            }
            else
            {
                return false;
            }
        }
    }
   class class1
    {
        //public void swap(ref float a, ref float b)
        //{
        //    float c = a;
        //    a = b;
        //    b = c;
        //}
        //public void swap(ref int a,ref int b)
        //{
        //    int c = a;
        //    a = b;
        //    b= c;
        //}

        public void swap<T>(ref T a,ref T b)//generic method
        {
           T c = a;
            a = b;
            b = c;
        }
     
    }
   class ArithMeticOperation<T,W>// generic class
    {
        public T sum(T x,W y)
        {
            dynamic x1 = x;
            dynamic y1 = y;
            dynamic ans = x1 + y1;
            return ans;
        }
        public T multiplication(T a,W b)
        {
            return (dynamic) a*(dynamic) b;
        }
    }
    internal class Program
    {
        static void Main(string[] args)
        {
            // int x = 100;
            // int y = 200;
            // Console.WriteLine("x="+x+" y="+y);

            // class1 obj = new class1();
            // char ch = 'C';
            // obj.swap(ref x,ref y);//1 calling generic method
            // Console.WriteLine("x=" + x + " y=" + y);


            // float f1 = 3.14f;
            // float f2 = 9.8f;
            // Console.WriteLine(f1 + " " + f2);
            // obj.swap(ref f1, ref f2);//2 calling generic method
            // Console.WriteLine(f1 + " " + f2);

            // string s1 = "pune";
            // string s2 = "nagar";
            // Console.WriteLine(s1 + " " + s2);
            // obj.swap<string>(ref s1, ref s2);
            // Console.WriteLine(s1+" "+s2);
            // ////////////////////////////////////////////////
            // ///

            // ArithMeticOperation<float,int> amo = new ArithMeticOperation<float,int>();
            // float ans1=amo.sum(100, 200);

            //float ans2= amo.multiplication(100, 200);

            // Console.WriteLine(ans1);//300
            // Console.WriteLine(ans2);//20000

            // ArithMeticOperation<double, int> amo2 = new ArithMeticOperation<double, int>();
            // Console.WriteLine(amo2.sum(1.1f, 100));
            // Console.WriteLine(amo2.multiplication(100, 2));

            //ListDemo ld = new ListDemo();
            //// ld.metho1();
            //ld.SortedDictionaryDemo();
            //Assignment a1 = new Assignment();
            //bool result=a1.compare<float>(1.1f, 1.2f);
            //Console.WriteLine(result);

            double[] myArray = new double[] {1.1,5.5,6.6,2.2 };
            Assignment a2 = new Assignment();
            dynamic ans=a2.FindMax1(myArray);
            if (ans!=-1)
            {
                Console.WriteLine(ans);
            }
                
           
        }
    }
}
