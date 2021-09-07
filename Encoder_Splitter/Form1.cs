using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.IO;

namespace Encoder_Splitter
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void Form1_Load(object sender, EventArgs e)
        {

        }

        private void label2_Click(object sender, EventArgs e)
        {

        }

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void splitButton_Click(object sender, EventArgs e)
        {
            try
            {
                // Create an instance of streamreader to read from a file
                // The using statement also closes the streamreader
                string Path = browseInputBox.Text;
                string Path2 = writeInputBox.Text;

                string[] lines = File.ReadAllLines(Path);

                int i = 1;

                foreach (string line in lines)
                {
                    File.WriteAllText(Path2 + "/" + "/" + i + ".xml", line + "/");
                    i++;
                }

            }

            catch(Exception f)
            {
                // Let user know what went wrong
                Console.WriteLine("The file could not be read:");
                MessageBox.Show(f.Message);
            }

           
        }

        private void decodeButton_Click(object sender, EventArgs e)
        {
            string fileName = textBox1.Text +".txt";
            var rand = new Random();
            
                if (File.Exists(path: writeInputBox.Text + "\\" + fileName))
                {
                    fileName = textBox1.Text + "-(Copy).txt";

                    string text = File.ReadAllText(browseInputBox.Text);
                    text = text.Replace("&lt;", "<");
                    File.WriteAllText(writeInputBox.Text + "\\" + fileName, text);
                    text = text.Replace("&gt;", ">");
                    File.WriteAllText(writeInputBox.Text + "\\" + fileName, text);
                    text = text.Replace("&quot;", "\"");
                    File.WriteAllText(writeInputBox.Text + "\\" + fileName, text);

                System.Windows.Forms.MessageBox.Show("File already Existed, Created New Copy, Anymore copies will result in overwritten files!");
                }
                else
                {
                    string text = File.ReadAllText(browseInputBox.Text);
                    text = text.Replace("&lt;", "<");
                    File.WriteAllText(writeInputBox.Text + "\\" + fileName, text);
                    text = text.Replace("&gt;", ">");
                    File.WriteAllText(writeInputBox.Text + "\\" + fileName, text);
                    text = text.Replace("&quot;", "\"");
                    File.WriteAllText(writeInputBox.Text + "\\" + fileName, text);
                }
            
            
        }

        private void encodeButton_Click(object sender, EventArgs e)
        {
            string fileName = textBox1.Text + ".txt";
            
            if (File.Exists(path: writeInputBox.Text +"\\" + fileName))
            {
                fileName = textBox1.Text + "-(Copy).txt";

                string text = File.ReadAllText(browseInputBox.Text);
                text = text.Replace("<", "&lt;");
                File.WriteAllText(writeInputBox.Text + "\\" + fileName, text);
                text = text.Replace(">", "&gt;");
                File.WriteAllText(writeInputBox.Text + "\\" + fileName, text);
                text = text.Replace("\"", "&quot;");
                File.WriteAllText(writeInputBox.Text + "\\" + fileName, text);

                System.Windows.Forms.MessageBox.Show("File already Existed, Created New Copy, Anymore copies will result in overwritten files!");
            }
            else
            {
                string text = File.ReadAllText(browseInputBox.Text);
                text = text.Replace("<", "&lt;");
                File.WriteAllText(writeInputBox.Text + "\\" + fileName, text);
                text = text.Replace(">", "&gt;");
                File.WriteAllText(writeInputBox.Text + "\\" + fileName, text);
                text = text.Replace("\"", "&quot;");
                File.WriteAllText(writeInputBox.Text + "\\" + fileName, text);
            }
        }

        private void browseButton_Click(object sender, EventArgs e)
        {
            OpenFileDialog fdlg = new OpenFileDialog();
            fdlg.Title = "C# Corner Open File Dialog";
            fdlg.InitialDirectory = @"c:\";
            fdlg.Filter = "All files (*.*)|*.*|All files (*.*)|*.*";
            fdlg.FilterIndex = 2;
            fdlg.RestoreDirectory = true;
            if (fdlg.ShowDialog() == DialogResult.OK)
            {
                browseInputBox.Text = fdlg.FileName;
            }

        }

        private void writeInputBox_TextChanged(object sender, EventArgs e)
        {
            //OpenFileDialog fdlg = new OpenFileDialog();
            //writeInputBox.Text = fdlg.FileName;
        }

        private void browseInputBox_TextChanged(object sender, EventArgs e)
        {
            //OpenFileDialog fdlg = new OpenFileDialog();
            //browseInputBox.Text = fdlg.FileName;
        }

        private void closeButton_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            /*OpenFileDialog fdlg = new OpenFileDialog();
            fdlg.Title = "C# Corner Open File Dialog";
            fdlg.InitialDirectory = @"c:\";
            fdlg.Filter = "All files (*.*)|*.*|All files (*.*)|*.*";
            fdlg.FilterIndex = 2;
            fdlg.RestoreDirectory = true;
            if (fdlg.ShowDialog() == DialogResult.OK)
            {
                writeInputBox.Text = fdlg.FileName;
            }*/

            var fbd = new FolderBrowserDialog();
            DialogResult result = fbd.ShowDialog();
            if(result == DialogResult.OK && !string.IsNullOrEmpty(fbd.SelectedPath))
            {
                writeInputBox.Text = fbd.SelectedPath;
            }
        }

        private void textBox1_TextChanged(object sender, EventArgs e)
        {

        }
    }
}
