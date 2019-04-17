using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace OpenSaveTextBox
{
    class GoToLineListBox
    {
        public int countLineNumber { get; set; }
        public string countLineText { get; set; }

        public override string ToString()
        {
            return "Line " + countLineNumber + ": " + countLineText + "\n";
        }
    }
}
