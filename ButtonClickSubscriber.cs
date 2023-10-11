using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace classwork14_net
{

    public class ButtonClickSubscriber
    {
        
        public void OnButtonClick(object sender, ButtonEventArgs e)
        {
            Console.WriteLine($"Button was clicked at {e.ClickTime} by {sender.GetType().Name}");
        }
    }
}
