using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace raj2
{
    public class vehicle
    {
        // properties 
        // methods
      public int numofwheels;
      public  double price;
      public  string country;

      public  void start()
        {
            Console.WriteLine(" the "+numofwheels +" wheels of my vehicle is slowly rotating ....." );
            Console.WriteLine("  my vehicle has started .....");
        }
      public  void brake()
        {
            Console.WriteLine("  i nearly hit a dog in street i braked .....");
        }
      public  void stop()
        {
            Console.WriteLine("  my vehicle  has stopped.....");
        }
       public void display()
        {
            Console.WriteLine(" the vehicle has " + numofwheels + " wheels");
            Console.WriteLine(" the vehicle price is Rs " +price);
            Console.WriteLine(" the vehicle is from " + country);
        }
    }
}
