using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PWModule4
{
    internal class Report : IDocument
    {
        public void Open()
        {
            Console.WriteLine("Report opened.");
        }
    }
}
