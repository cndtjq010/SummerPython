using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace WindowBank
{
    class Shelves
    {
        WaitNumber people = new WaitNumber();
        public void call()
        {
            people.wait_number--;
        }

    }
}
