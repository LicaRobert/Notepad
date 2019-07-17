using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace OpenSaveTextBox
{
    public partial class CharacterPanel : Form
    {
        DataTable dataTable = new DataTable();
        TabControl tabFile;
        RichTextBox richTextBox;
        RichTextBox richTextBox2;

        public CharacterPanel(TabControl R1, RichTextBox richTextBox)
        {
            dataTable.Columns.Add("Value", typeof(int));
            dataTable.Columns.Add("Hex", typeof(string));
            dataTable.Columns.Add("Character", typeof(string));
            InitializeComponent();
            dataGridView1.DataSource = dataTable;
            for (int i = 0; i <= 255; i++)
            {
                string hex = Convert.ToString(i, 16);
                if (i <= 15)
                {
                    hex = "0" + Convert.ToString(i, 16);
                }
                char special = Convert.ToChar(i);
                if (i == 32)
                {
                    string x = "Space";
                    dataTable.Rows.Add(i, hex, x);

                }
                if (i == 9)
                {
                    string x = "Tab";
                    dataTable.Rows.Add(i, hex, x);

                }
                if (i == 10)
                {
                    string x = "LF";
                    dataTable.Rows.Add(i, hex, x);

                }

                if (i > 32 && (i < 127 || i > 160))

                {
                    dataTable.Rows.Add(i, hex, special);

                }

            }
            Show();
            tabFile = R1;
            richTextBox2 = richTextBox;

        }

        private void DataGridView1_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            bool visited = false;
            richTextBox = tabFile.SelectedTab.Controls[0] as RichTextBox;


            int p = richTextBox.SelectionStart;
            var element = dataTable.Rows[e.RowIndex]["Character"].ToString();
            int l = dataTable.Rows[e.RowIndex]["Character"].ToString().Length;
            if (element.Equals("Tab"))
            {
                richTextBox.Text = richTextBox.Text.Insert(richTextBox.SelectionStart, "  ");
                richTextBox.SelectionStart = p + 2;
                richTextBox.ScrollToCaret();
                richTextBox.Focus();
                visited = true;
            }
            if (element.Equals("LF"))
            {
                richTextBox.AppendText("\r\n");
                visited = true;
                richTextBox.ScrollToCaret();
                richTextBox.Focus();

            }
            if (element.Equals("Space"))
            {
                richTextBox.Text = richTextBox.Text.Insert(richTextBox.SelectionStart, " ");
                richTextBox.SelectionStart = p + 1;
                richTextBox.ScrollToCaret();
                richTextBox.Focus();
                visited = true;
            }
            if (!visited)
            {
                richTextBox.Text = richTextBox.Text.Insert(richTextBox.SelectionStart, dataTable.Rows[e.RowIndex]["Character"].ToString());
                richTextBox.SelectionStart = p + l;
                richTextBox.SelectionLength = 1;
            }
        }
    }
}

