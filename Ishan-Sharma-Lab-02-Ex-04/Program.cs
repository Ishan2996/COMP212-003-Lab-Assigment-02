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
            Console.WriteLine("Event handled successfully");
        }
        static void Main(string[] args)
        {
            MyEvent evt = new MyEvent();

            evt.MyClick += new MyEventHandler(Handler_MyClick);
            
            evt.onMyClick(); //Excecutes the Event
            evt.onMyClick();
            evt.onMyClick();
        }
    }

}
