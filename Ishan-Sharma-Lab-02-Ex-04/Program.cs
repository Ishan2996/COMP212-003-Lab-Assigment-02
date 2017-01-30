using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Ishan_Sharma_Lab_02_Ex_04
{
    class Program
    {
        public static void Handler_MyClick()
        {
            Console.WriteLine("Event Handled SuccessFully");
        }
        static void Main(string[] args)
        {
            try
            {
                MyEvent test = new MyEvent();
                test.myClick += new myEventHandlder(Handler_MyClick);


                // Fire The Events
                test.onMyClick();

                //To delegate event after the Click
                test.myClick -= new myEventHandlder(Handler_MyClick);
                test.onMyClick();

                Console.ReadLine();
            }

            catch (Exception ex)
            {
                Console.WriteLine("Error:" + ex.Message);
            }
        }
    }
}
