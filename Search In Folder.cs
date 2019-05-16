using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace OpenSaveTextBox
{
    public partial class Form2 : Form
    {
        int totalMatches = 0;
        string[] files;
        ListBox listBox;
        int count;

        public Form2(ListBox l)
        {
            this.Show();
            InitializeComponent();
            listBox = l;
        }

        private void searchBtn_Click(object sender, EventArgs e)
        {
            if(searchTextBox.Text == "")
            {
                MessageBox.Show("The search field cannot be empty.");
            }
            count = 0;

            foreach (string file in files)
            {
                listBox.Items.Add("Path: " + file.ToString());
                string[] lines = File.ReadAllLines(file);
                foreach (var line in lines)
                {
                    count++;
                    if (line.Contains(searchTextBox.Text))
                    {
                        totalMatches++;
                        SearchedItems searched = new SearchedItems();
                        searched.LineNumber = count;
                        searched.LineText = line;
                        searched.findForm = false;
                        listBox.Items.Add(searched);
                        listBox.Visible = true;
                    }
                }

                count = 0;
            }

           listBox.Items.Add("Total Matches : " + totalMatches);
           Close();
        }

        private void openFileDialogBtn_Click(object sender, EventArgs e)
        {
            using (var folderBrowser = new FolderBrowserDialog())
            {
                DialogResult result = folderBrowser.ShowDialog();

                if (result == DialogResult.OK && !string.IsNullOrWhiteSpace(folderBrowser.SelectedPath))
                {
                    files = System.IO.Directory.GetFiles(folderBrowser.SelectedPath);
                    folderTextBox.Text = folderBrowser.SelectedPath;
                }
            }
        }
    }
}
