using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace classwork14_net
{
    public delegate void PersonDelegate();
    internal class Persson
    {
        public event PersonDelegate GoToWork;
        public event PersonDelegate GoToHome;
        public string Name { get; set; }
        public int Age { get; set; }
        public void GetDate(DateTime dt)
        {
            if (dt.Hour >= 6 && dt.Hour <= 8)
            {
                GoToWork?.Invoke();
            }
            else if (dt.Hour <= 6 && dt.Hour <= 8)
            { 
                GoToHome?.Invoke();
            }
        }
    }
}

