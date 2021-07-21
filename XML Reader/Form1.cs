using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;
using System.IO;
namespace XML_Reader
{
    public partial class Form1 : Form
    {
        string line = string.Empty;
        int line_number = 1;
        int line_to_edit = 5;
        public Form1()
        {
         InitializeComponent();
        }
        private void cddvvToolStripMenuItem_Click(object sender, EventArgs e)
        {
            FileStream fs = new FileStream(@"D:\programing\XML Reader\XML Reader\Refined_RNA EF.XML.txt", FileMode.Open);
            StreamWriter writer = new StreamWriter(@"D:\programing\XML Reader\XML Reader\Refined_RNA EF.XML.txt");
            while (line  != null)
            {
                if (line_number == line_to_edit)
                {
                    writer.WriteLine(line);

                }

                line_number++;
            }

            // var lineCount = File.ReadLines(@"D:\programing\XML Reader\XML Reader\Refined_RNA EF.XML 1.txt").Count();
           // richTextBox1.Text =Convert.ToString( lineCount);
        }
        private void dsdsvToolStripMenuItem_Click(object sender, EventArgs e)
        {
            listBox1.Items.Clear();        
        }
        private void vToolStripMenuItem_Click(object sender, EventArgs e)
        {
            this.Close();
        }
      }
}
