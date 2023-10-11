using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace classwork14_net
{
    public class ButtonEventArgs: EventArgs
    {
        
    public DateTime ClickTime { get; set; }

        public ButtonEventArgs(DateTime clickTime)
        {
            ClickTime = clickTime;
        }
    }
}

