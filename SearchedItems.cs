using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace OpenSaveTextBox
{
    class SearchedItems
    {
        public int LineNumber { get; set; }
        public string LineText { get; set; }
        public bool findForm { get; set; }
        public override string ToString()
        {
            return "Line " + LineNumber + ": " + LineText + "\n";
        }
    }
}
