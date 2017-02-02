using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Ishan_Sharma_Lab_02_Ex_04
{
    public delegate void MyEventHandler();
    
    class MyEvent
    {
        public event MyEventHandler MyClick;

        public void onMyClick()
        {
            MyClick();
        }
    }
}
    
