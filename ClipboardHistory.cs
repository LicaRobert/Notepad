using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace OpenSaveTextBox
{
    class ClipboardHistory
    {
        internal int countLineNumber;

        public string countLineText { get; set; }
        public int LineNumber { get; set; }

        public override string ToString()
        {
            return countLineText;
        }
    }
}
