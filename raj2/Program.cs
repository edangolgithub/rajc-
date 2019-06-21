using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace raj2
{
    class Program
    {
       // static void add()
        //{
        //    print("hello");
        //}

        //static void add1(int a)
        //{
        //    print(a*a);
        //}

        //static int add2()
        //{

        //    return 10;
        //}

        //  static int add3(int x, int y, int z, int abc)
        //    {
        //    return x + y + z + abc;
        //    }

        // functions 4 types
        // 1 no return type  no parameter   void
        // 2 no return type parameter
        // 3 return type no parameter
        // 4 return type parameter

        public static void Main()
        {
            //Mobile M = new Mobile();
            //Console.WriteLine(M.Name);
            //Console.WriteLine(M.Model);
            //Console.WriteLine(M.Price);

            //Mobile A=new Mobile ("dell", 5300, 15000 );
            //Console.WriteLine(M.Model);
            //Console.WriteLine(M.Price);
            //Console.WriteLine(M.Name);

            //Mobile M = new Mobile("Dell");
            //Console.WriteLine(M.Name);
            Calculator C = new Calculator();
            C.x = 10;
            C.y = 20;
            Console.WriteLine(C.mul());

         
            

         
            //Laptop L = new Laptop();
            //Console.WriteLine(L.Model);
            //Console.WriteLine(L.sizeofRAM);
            //Laptop C = new Laptop(8);
            //Console.WriteLine(C.sizeofRAM);
            //C.Model = "Dell";
            //Console.WriteLine(C.Model);


            //Laptop L = new Laptop("sony", 4, 1000, 45000);
            //Console.WriteLine(L.Model);
            //Console.WriteLine(L.sizeofHarddisk);
            //Console.WriteLine(L.price);

            //Maths m = new Maths();
            //m.fn = 6;
            //m.sn = 6;
            //m.fibonacciseries(10);


        }



        //public static void dMain()
        //{
        //    add();
        //    // 1 2 3 4 5 6 7 8
        //    int[] arr = { 23, 4, 1, 6, 83, 9 };
        //    for (int i = 0; i < 6; i++)
        //    {
        //      //  print(arr[i]);
        //    }

        //    // 1 2 3
        //    // 4 5 6
        //    // 7 8 9

        //    //int arr[][3]
        //    int[,] ar1 = { { 1, 2, 3 }, { 4, 5, 6 }, { 7, 8, 9 } };
        //    for (int row = 0; row < 3; row++)
        //    {
        //        for (int col = 0; col < 3; col++)
        //        {
        //            Console.Write(ar1[row,col]);
        //        }
        //        Console.WriteLine();
        //    }



        //}
        //static void cMain()
        //{
        //    // operators
        //    // arithematic + - * / %
        //    // relational  < > <= >= == !=
        //    // logical  || && !
        //    // assignment  = += -= *= /= %= 
        //    // unary  ++ -- postfix prefix
        //    // ternary concat bitwise 

        //    // 5   10  5<10 5!=6  6==6


        //    //if(!(5<6) && 7!=2)
        //    //{
        //    //    Console.WriteLine("if");
        //    //}
        //    //else
        //    //{
        //    //    Console.WriteLine("else");
        //    //}

        //    //if(4==10)
        //    // {
        //    //     print("if");
        //    // }
        //    // else if (4 == 4)
        //    // {
        //    //     print("else if2");
        //    // }
        //    // else if(6<1000)
        //    // {
        //    //     print("else if1");
        //    // }

        //    // else
        //    // {
        //    //     print("else");
        //    // }

        //    //loop 

        //    // for do while

        //    // initialaization  condition  increment/ decrement

        //    //for(int i=71;i>51;i=i-10)
        //    //{
        //    //    print(i);
        //    //}

        //    int i = 71;

        //    while(i>51)
        //    {
        //        print(i);
        //        i = i - 10;
        //    }

            
        //    int j = 71;

        //    do
        //    {
        //        print(j);
        //        j = j - 10;
        //    } while (j > 51);


        //}

        //private static void print(object x)
        //{
        //    Console.WriteLine(x);
        //}
    }
}
