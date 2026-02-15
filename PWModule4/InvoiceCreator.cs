using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PWModule4
{
    internal class InvoiceCreator : DocumentCreator
    {
        public override IDocument CreateDocument()
        {
            return new Invoice();
        }
    
    }
}
