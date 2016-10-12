using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace ElephantsP163C4
{
    class Elephant
    {
        public string Name;
        public int EarSize;


        public void WhoAmI()
        {
            MessageBox.Show("My ears are " + EarSize + " tall!", Name + " says...");
        }
        public Elephant Swap(Elephant t)
        {
            Elephant temp = t;
            t = this;
            return t;
        }

    }
}
