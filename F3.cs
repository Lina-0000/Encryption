using System;
using System.Drawing;
using System.IO;
using System.Windows.Forms;

//Зашифровать и расшифровать русскоязычное сообщение со знаками препинания 
//с помощью шифра Тритемия (длина алфавита равна 35). Ключом является алфавит 
//замены, формируемый по ключевому слову

namespace LR1
{
    public partial class F3 : Form
    {
        string strInit = "", strRez = "";
        string key;
        int n = 0;

        string filename = "";
        public F3()
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

            string ABC = "абвгдеёжзийклмнопрстуфхцчшщъыьэюя ,.";
            int size = strInit.Length;
            
            string[] table = new string[size];
            table[0] = key;

            for (int i = 0; i < key.Length; i++)
                ABC = ABC.Replace(key[i].ToString(), "");

            table[0] += ABC;
            for (int i = 1; i< size; i++)
            {
                string tmpBegin = table[0].Substring(0, i%35);
                string tmpEnd = table[0].Substring(i%35);
                table[i] = tmpEnd + tmpBegin;
            }

            string strABC = "";
            for (int i = 0; i < size; i++)
                strABC += table[i] + "\n";
            File.WriteAllText("t3_ABC.txt", strABC);

            int j;
            if (shifr.Checked)
            {
                for (int i = 0; i < size - 1; i++)
                {
                    // определяем индекс нужной буквы в строке алфавита,
                    // соответствующий номеру этой буквы в шифруемой строке
                    j = table[i].IndexOf(strInit[i]);
                    strRez += table[i + 1][j];
                }
                j = table[0].IndexOf(strInit[size - 1]);
                strRez += table[0][j];
            }
            else
            {
                for (int i = 1; i < size; i++)
                {
                    j = table[i].IndexOf(strInit[i-1]);
                    strRez += table[i-1][j];
                }
                j = table[0].IndexOf(strInit[size - 1]);
                strRez += table[0][j];
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
                crypt();

                textInit.Text = strInit;
                textRez.Text = strRez;
            }
            else
                MessageBox.Show("File not found.");
        }
    }
}