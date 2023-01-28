using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace bookclass
{
    internal class Book
    {
        internal string name, Autname;
        internal int PubDate, PageCount;

        public override string ToString()
        {
            return $"{Autname} '{name}' {PubDate}";
        }
    }
}
