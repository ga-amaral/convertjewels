using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Price.Entities
{
    class Calc
    {
        public double KBless { get; set; }
        public int Bless { get; set; }

        public Calc()
        {
        }

        public Calc(double kBless, int bless)
        {
            KBless = kBless;
            Bless = bless;
        }
        public double BlessValue()
        {
            return (KBless / 1000);
        }
        public double PayPal()
        {
            return (KBless / 1000) * Bless;
        }
        public double TotalValue()
        {
            return ((KBless / 1000) * Bless / 0.92) + 0.30;
        }
        public double Tax()
        {
            return (((KBless / 1000) * Bless / 0.92) + 0.30) - (KBless / 1000) * Bless;
        }

    }
}
