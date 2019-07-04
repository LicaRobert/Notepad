using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Text.RegularExpressions;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace OpenSaveTextBox
{
    class UndoRedoItem
    {
        public int x;
        public String text;
    }

    public class UndoRedoStack
    {
        private Stack<UndoRedoItem> undoStack = new Stack<UndoRedoItem>();
        private Stack<UndoRedoItem> redoStack = new Stack<UndoRedoItem>();

        private RichTextBox parent;

        public UndoRedoStack(RichTextBox parent)
        {
            this.parent = parent;
        }

        public void InsertText(String text, int position)
        {
            if (text.Length == 0)
            {
                return;
            }
            if (undoStack.Count > 0)
            {
                UndoRedoItem it = undoStack.Peek();
                if (it != null && it.x == position && it.text.Equals(text))
                {
                    return;
                }
            }
            UndoRedoItem item = new UndoRedoItem();
            item.x = position;
            item.text = text;
            undoStack.Push(item);
        }

        public void Undo()
        {
            if (undoStack.Count > 0)
            {
                List<string> allOperands = new List<string>();
                List<string> allOperandsWithoutSpaces = new List<string>();
                string sentence = parent.Text;
                int count = 0;
                string[] lineOperands = Regex.Split(sentence, @"\n");
                foreach (var operand in lineOperands)
                {
                    allOperands.AddRange(Regex.Split(operand, @" "));
                }

                allOperands.ForEach(a => a = a.Trim());
                foreach (var operand in allOperands)
                {
                    if (operand != "")
                    {
                        allOperandsWithoutSpaces.Add(operand);
                    }
                }
                foreach (string searchString in allOperandsWithoutSpaces)
                {
                    count++;
                    if (count == allOperandsWithoutSpaces.Count())
                    {
                        redoStack.Push(undoStack.First());
                        if (parent.Text == null)
                            return;
                        parent.Text = undoStack.ElementAt(searchString.Length + 1).text;
                        parent.SelectionStart = undoStack.Count();
                        parent.SelectionLength = 1;
                        for (int i = 1; i <= searchString.Count() + 1; i++)
                        {
                            undoStack.Pop();
                        }
                    }
                }
            }           
        }
        
        public void Redo()
        {
            if (redoStack.Count > 0)
            {
                var x = redoStack.Pop();
                parent.Text = x.text;
                parent.SelectionStart = x.text.Length;
            }
        }
    }
}
