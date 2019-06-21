using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace raj2
{
    class Maths
    {
        public int fn;
        public int sn;

        public int add()
        {
            return fn + sn;
        }
        public int sub()
        {
            return fn - sn;
        }
        public int multiply()
        {
            return fn * sn;
        }
        public int divide()
        {
            return fn / sn;
        }
        public int modulo()
        {
            return fn % sn;
        }
        public int naturalsum(int n)
        {
            int sum = 0;
            for (int i = 1; i <= n; i++)
            {
                sum += i;
            }
            return sum;
        }
        public int factorial(int num)
        {
            int sum = 1;
            for (int i = 1; i <= num; i++)
            {
                sum *= i;
            }
            return sum;
        }
        public void fibonacciseries(int limit)
        {
            int a = 0;
            int b = 1;
            int c;
            for (int i = 1; i <=limit; i++)
            {
                string x = i!=limit?",":""; // ternary op   ++   a+b 

                //string y = "";
                //if(i!=limit)
                //{
                //    y = ",";
                //}
                //else
                //{
                //    y = "";
                //}

                Console.Write(a+x);
                c = a + b;
                a = b;
                b = c;
            }
        }
    }
}
