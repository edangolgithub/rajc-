using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
//hello
namespace raj2
{
    class Laptop
    { //gfhyf
        public int sizeofRAM;
        public double price;
        public string Model;
        public int sizeofHarddisk;

        public void TurnON()
        {
            Console.WriteLine("the size of RAM =" + sizeofRAM);

        }
        public void MoMomachine(int keema,int pitho,int masala)
        {
            p(keema + pitho / masala + " plates of momo can be created");
        }
        public void Restart()
        {
            Console.WriteLine("the size of Harddisk=" + sizeofHarddisk);

        }
        public void Repair()
        {
            Console.WriteLine("The price of Laptop is =" + price);

        }
        public void Shutdown()
        {
            Console.WriteLine("the Model of laptop is =" + Model);

        }

       public Laptop()
        {
            sizeofRAM = 2;
            sizeofHarddisk = 1000;
            price = 45000;
            Model = "Toshiba";
        }
        public Laptop(int x)
        {
            sizeofRAM = x;
        }
        public Laptop(string s, int a, int m, double price)
        {
            sizeofRAM = a;
            Model = s;
            sizeofHarddisk = m;
            this.price = price;
        }

        public static void p(object o)
        {
            Console.WriteLine(o);
        }

        //constructor
        // it is a function/ method 
        // it has no return type
        // it is invoked when we create an object of class
        // it can be parameterless or can take parameter
        // its main function is to initialize data members;

    }
}
