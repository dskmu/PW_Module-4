using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PWModule4
{
    internal abstract class DocumentCreator
    {
        public abstract IDocument CreateDocument();
        public void OpenDocument()
        {
            var document = CreateDocument();
            document.Open();
        }
    }
}
