using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.IO;
using System.Text;
using System.Windows.Forms;

namespace LR1
{
    public partial class F1 : Form
    {
        string strInit = "", strRez = "";
        int key;
        int n = 0;
        string filename = "";
        public F1()
        {
            InitializeComponent();
        }

        private void getText()
        {
            try
            {
                using (FileStream fstream = File.OpenRead(filename))
                {
                    byte[] array = new byte[fstream.Length];
                    fstream.Read(array, 0, array.Length);
                    strInit = System.Text.Encoding.Default.GetString(array);
                }
                filename = "";
            }
            catch
            {
                MessageBox.Show("File not found.");
            }
        }

        private void crypt()
        {
            int a;
            strRez = "";
            for (int i = 0; i < strInit.Length; i++)
            {
                a = Convert.ToInt32(strInit[i]);
                if (key > 0 && a> 128)
                {
                   
                }
                else
                {
                    if (key < 0 && a > (128+key))
                    {
                        
                    }
                    else
                    {
                        a = (a + key) % 128;
                    }
                }
                strRez += Convert.ToChar(a);
            }
        }

        private void button2_Click(object sender, EventArgs e)
        {
            if (openFileDialog1.ShowDialog() == DialogResult.Cancel)
                return;
            filename = openFileDialog1.FileName;
        }

        private void button1_Click(object sender, EventArgs e)
        {
            if (filename.Length > 0)
                getText();
            else
                strInit = textInit.Text;

            textInit.Text = "";
            textRez.Text = "";

            if (strInit != "")
            {
                key = Convert.ToInt32(numericUpDown1.Value);
                if (!shifr.Checked)
                    key = key * (-1);
                crypt();
                
                textInit.Text = strInit;
                textRez.Text = strRez;
            }
            else
                MessageBox.Show("File not found.");
        }
    }
}