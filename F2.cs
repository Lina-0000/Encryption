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
    public partial class F2 : Form
    {
        string strInit = "", strRez = "";
        string key;
        int n = 0;

        string filename = "";

        public F2()
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

        private void getKey()
        {
            try
            {
                using (FileStream fstream = File.OpenRead("key.txt"))
                {
                    byte[] array = new byte[fstream.Length];
                    fstream.Read(array, 0, array.Length);
                    key = System.Text.Encoding.Default.GetString(array);
                }
            }
            catch
            {
                MessageBox.Show("Key-file not found.");
            }
        }

        private void crypt()
        {
            strRez = "";
            getKey();

            // step 1
            int m, n;
            n = key.Length;
            m = strInit.Length / n;
            if (strInit.Length % n != 0)
                m++;

            int sum = (m * n) - strInit.Length;
            while (sum > 0)
            {
                strInit += " ";
                sum--;
            }

            // step 2
            string[] str = new string[n];
            int k = 0;
            for (int j = 0; j < n; j++)
                for (int i = 0; i< m; i++)
                {
                    str[j] += strInit[k];
                    k++;
                }

            string l = "";
            for (int i = 0; i < n; i++)
            {
                l += (i + 1).ToString() + "-th column:" + str[i] + "\n\r";
                string nRez = "t1.txt"; ;
                File.WriteAllText(nRez, l);
            }

            // step 3
            int[] sort = new int[n];
            for (int i = 0; i < n; i++)
            {
                sort[i] = Convert.ToInt32(key[i]);
            }
            for (int i = 0; i< n; i++)
                for (int j = 0; j < n; j++)
                {
                    if (sort[i] < sort[j])
                    {
                        int tmp = sort[i];
                        sort[i] = sort[j];
                        sort[j] = tmp;
                    }
                }

            char[] sortChar = new char[n];
            for (int i = 0; i < n; i++)
                sortChar[i] = Convert.ToChar(sort[i]);

            for (int i = 0; i < n;i++)
            {
                for (int j = 0; j < n; j++)
                {
                    if (key[j] == sortChar[i])
                        sort[i] = j;
                }
            }

            // step 4
            string[] rez = new string[n];
            for (int i = 0; i < n; i++)
                rez[i] += str[sort[i]];

            l = "";
            for (int i = 0; i < n; i++)
            {
                l += (i + 1).ToString() + "-th column:" + rez[i] + "\n\r";
                string nRez = "t2.txt"; ;
                File.WriteAllText(nRez, l);
            }

            for (int j = 0; j < m; j ++)
                for (int i = 0; i < n; i++)
                {
                    strRez += rez[i][j];
                }
        }

        private void decrypt()
        {
            strRez = "";
            getKey();

            // step 1
            int m, n;
            n = key.Length;
            m = strInit.Length / n;
            if (strInit.Length % n != 0)
                m++;

            int sum = strInit.Length - (m * n);
            while (sum > 0)
            {
                strInit += " ";
                sum--;
            }

            // step 2
            string[] str = new string[n];
            int k = 0; // !!!
            for (int j = 0; j < m; j++)
            {
                for (int i = 0; i < n; i++)
                {
                    
                    str[i] += strInit[k];
                    k++;
                }
            }
            string l = "";
            for (int i = 0; i < n; i++)
            {
                l += (i + 1).ToString() + "-th column:" + str[i] + "\n\r";
                string nRez = "t1.txt"; ;
                File.WriteAllText(nRez, l);
            }

            // step 3
            int[] sort = new int[n];
            for (int i = 0; i < n; i++)
            {
                sort[i] = Convert.ToInt32(key[i]);
            }
            for (int i = 0; i < n; i++)
                for (int j = 0; j < n; j++)
                {
                    if (sort[i] < sort[j])
                    {
                        int tmp = sort[i];
                        sort[i] = sort[j];
                        sort[j] = tmp;
                    }
                }

            char[] sortChar = new char[n];
            for (int i = 0; i < n; i++)
                sortChar[i] = Convert.ToChar(sort[i]);

            for (int i = 0; i < n; i++)
            {
                for (int j = 0; j < n; j++)
                {
                    if (key[j] == sortChar[i])
                        sort[j] = i;
                }
            }


            // step 4
            string[] rez = new string[n];
            for (int i = 0; i < n; i++)
                rez[i] = str[sort[i]];

            l = "";
            for (int i = 0; i < n; i++)
            {
                l += (i + 1).ToString() + "-th column:" + rez[i] + "\n\r";
                string nRez = "t2.txt"; ;
                File.WriteAllText(nRez, l);
            }

            for (int i = 0; i < n; i++)
                for (int j = 0; j < m; j++)
                {
                    strRez += rez[i][j];
                }
        }

        private void button2_Click(object sender, EventArgs e)
        {
            if (openFileDialog1.ShowDialog() == DialogResult.Cancel)
                return;
            filename = openFileDialog1.FileName;
        }

        private void button1_Click_1(object sender, EventArgs e)
        {
            if (filename.Length > 0)
                getText();
            else
                strInit = textInit.Text;

            textInit.Text = "";
            textRez.Text = "";

            if (strInit != "")
            {
                if (shifr.Checked)
                    crypt();
                else
                    decrypt();

                textInit.Text = strInit;
                textRez.Text = strRez;
            }
            else
                MessageBox.Show("File not found.");
        }
    }
}
