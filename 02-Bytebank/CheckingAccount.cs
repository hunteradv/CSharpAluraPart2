using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _02_Bytebank
{
    public class CheckingAccount
    {
        public string Holder { get; set; }
        public int Agency { get; set; }
        public int Number { get; set; }
        public double Balance { get; set; } = 200;
    }
}
