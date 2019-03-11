using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace BankingNet
{
    public class BbanStructure
    {
        public string Pattern { get; private set; }

        internal BbanStructure(string pattern)
        {
            this.Pattern = pattern;
        }
    }
}
