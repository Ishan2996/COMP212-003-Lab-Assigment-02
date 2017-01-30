using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Ishan_Sharma_Lab_02_Ex_04
{    
        public delegate void myEventHandlder();

    class MyEvent
        {
        

            public event myEventHandlder myClick; // Event Object


            public void onMyClick()
            {
                if (myClick != null)
                    myClick();

            }
        }
    }
