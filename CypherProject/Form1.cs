using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
namespace CypherProject
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        //subsitution encryption
        private void button1_Click(object sender, EventArgs e)
        {
            String plainText = this.textBox1.Text.ToLower();
            String cipherText = "";
            if ((int)numericUpDown1.Value > 26 || (int)numericUpDown1.Value < 0)
            {
                textBox2.Text = "put a key from 0 to 26";
            }
            else
            {
                for (int x = 0; x <= plainText.Length - 1; x++)
                {
                    char c = plainText[x];
                    if (((int)c >= 97 && (int)c < 97 + 26))
                    {
                        int i = ((int)c) - 97;
                        cipherText += ((char)(65 + ((i + (int)this.numericUpDown1.Value) % 26))).ToString();
                    }
                    else
                    {
                        cipherText += c.ToString();
                    }
                }
                this.textBox2.Text = cipherText.ToLower();
            }

        }
        //subsitution decryption
        private void button2_Click(object sender, EventArgs e)
        {
            String plainText = "";
            String cipherText = this.textBox2.Text;
            for (int x = 0; x <= cipherText.Length - 1; x++)
            {
                char c = cipherText[x];
                if (((int)c >= 97 && (int)c < 97 + 26))
                {
                    int i = ((int)c) - 97;
                    plainText += ((char)(97 + ((26 + i - (int)this.numericUpDown1.Value) % 26))).ToString();
                }
                else
                {
                    plainText += c.ToString();
                }
            }
            this.textBox1.Text = plainText;
        }

        private void Form1_Load(object sender, EventArgs e)
        {

        }
        //transposition
        private void transpositionEncrypt_Click(object sender, EventArgs e)
        {
            string key = transpostionKey.Text.ToLower();
            int charactesNumber = transpostionEncrypted.Text.Length;
            int numberOfColumns = key.Length;
            int numberOfRows = charactesNumber / numberOfColumns;
            string decrypted = "";
            if (charactesNumber % numberOfColumns != 0)
                numberOfRows += 1;
            List<int> arrkey = new List<int>();
            for (int i = 0; i < key.Length; i++)
            {
                int k = 1;
                for (int j = 0; j < key.Length; j++)
                {
                    if (i == j) { }
                    else
                    {
                        if (key[i] > key[j])
                        {
                            k++;
                        }
                    }
                }
                arrkey.Add(k);
            }
            char[,] arr = new char[numberOfRows, numberOfColumns];
            string Text = transpostionEncrypted.Text;
            int x = 0;
            for (int i = 0; i < numberOfRows; i++)
            {
                for (int j = 0; j < transpostionKey.Text.Length; j++)
                {
                    arr[i, j] = Text[x];
                    x++;
                    if (x >= charactesNumber) { break; }
                }
                if (x >= charactesNumber) { break; }
            }
            for (int i = 1; i < numberOfColumns + 1; i++)
            {
                for (int j = 0; j < numberOfColumns; j++)
                {
                    if (arrkey[j] == i)
                    {
                        for (int v = 0; v < numberOfRows; v++)
                        {
                            if (arr[v, j] == '\0')
                            {
                                decrypted += '_';
                            }
                            else
                            {
                                decrypted += arr[v, j];
                            }

                        }

                    }
                }
            }
            transpositionDecrypted.Text = decrypted;
        }

        private void transpositionDecrypt_Click(object sender, EventArgs e)
        {
            string key = transpostionKey.Text.ToLower();
            int charactesNumber = transpositionDecrypted.Text.Length;
            int numberOfColumns = key.Length;
            int numberOfRows = charactesNumber / transpostionKey.Text.Length;
            string encrypted = "";
            if (charactesNumber % numberOfColumns != 0) numberOfRows += 1;
            List<int> arrkey = new List<int>();
            for (int i = 0; i < key.Length; i++)
            {
                int k = 1;
                for (int j = 0; j < key.Length; j++)
                {
                    if (i == j) { }
                    else
                    {
                        if (key[i] > key[j])
                        {
                            k++;
                        }
                    }
                }
                arrkey.Add(k);
            }
            char[,] arr = new char[numberOfRows, numberOfColumns];
            char[,] arr2 = new char[numberOfRows, numberOfColumns];
            string Text = transpositionDecrypted.Text;
            int x = 0;
            for (int i = 0; i < transpostionKey.Text.Length; i++)
            {
                for (int j = 0; j < numberOfRows; j++)
                {
                    arr[j, i] = Text[x];
                    x += 1;
                    if (x >= charactesNumber) { break; }

                }
                if (x >= charactesNumber) { break; }
            }
            for (int i = 0; i < numberOfColumns; i++)
            {
                int m = arrkey[i] - 1;
                for (int k = 0; k < numberOfRows; k++)
                {
                    arr2[k, i] = arr[k, m];
                }

            }
            for (int i = 0; i < numberOfRows; i++)
            {
                for (int j = 0; j < numberOfColumns; j++)
                {
                    if (arr2[i, j] == '_')
                    {

                    }
                    else
                        encrypted += arr2[i, j];
                }
            }
            transpostionEncrypted.Text = encrypted;
        }
        private bool isPrime(int n)
        {
            // Corner case
            if (n <= 1)
                return false;

            // Check from 2 to n-1
            for (int i = 2; i < n; i++)
                if (n % i == 0)
                    return false;

            return true;
        }
        private void RSAEncrypt_Click(object sender, EventArgs e1)
        {
            if (!isPrime((int)RSAp.Value) || !isPrime((int)RSAq.Value))
            {
                RSADecrypted.Text = "enter a prime numbers";
            }
            else
            {
                int p = (int)RSAp.Value;
                int q = (int)RSAq.Value;
                int n = p * q; //first part of public key
                int e = 3; //second part of public key
                int phi = (p - 1) * (q - 1);
                int k = 2;//any value
                int d = (k * phi + 1) / e;//private key
                string text = RSAEncryped.Text.ToLower();
                string msg = "";
                for(int i = 0; i < text.Length; i++)
                {
                    int v = (int)text[i] - 96;
                    msg += v;
                }
                int message = int.Parse(msg);
                double c = Math.Pow(message, e);
                c = c % n;
                RSADecrypted.Text = c.ToString();
            }
        }

        private void RSADecrypt_Click(object sender, EventArgs e1)
        {
            if (!isPrime((int)RSAp.Value) || !isPrime((int)RSAq.Value))
            {
                RSADecrypted.Text = "enter a prime numbers";
            }
            else
            {
                int p = (int)RSAp.Value;
                int q = (int)RSAq.Value;
                int n = p * q; //first part of public key
                int e = 2; //second part of public key
                int phi = (p - 1) * (q - 1);
                int k = 2;//any value
                int d = (k * phi + 1) / e;//private key
                string text = RSAEncryped.Text.ToLower();
                string msg = "";
                for (int i = 0; i < text.Length; i++)
                {
                    int v = (int)text[i] - 96;
                    msg += v;
                }
                int message = int.Parse(msg);
                double c = Math.Pow(message, e);
                c = c % n;
                double m = Math.Pow(c, d);
                m = m%n;
                msg = m.ToString();
                for(int i = 0; i < msg.Length; i++)
                {
                    string x = "";
                    x += msg[i];
                    char v = (char)(int.Parse(x)+96);
                    msg += v;
                }
                RSAEncryped.Text = msg;
            }
        }

        private void FairPlayEncrypt_Click(object sender, EventArgs e)
        {
            char[,] arr = new char[5, 5];
            char[,] arr2 = new char[5, 5];
            int c = 97;
            for (int i = 0; i < 5; i++)
            {
                for(int j = 0; j < 5; j++)
                {
                    if ((char)c != 'j')
                    {
                        arr[i, j] = (char)c;
                    }
                    else { j--; }
                    c++;
                }
            }
            string key = FairPlayKey.Text;
            FairPlayDecrypted.Text = "";
            c = 0;
            for(int i = 0; i < 5; i++)
            {
                for(int j = 0; j < 5; j++)
                {
                    if (c < key.Length)
                    {
                        bool check = false;
                        for (int k = 0; k < 5; k++)
                        {
                            for (int l = 0; l < 5; l++)
                            {
                                if (arr2[k, l] == key[c])
                                {
                                    check = true;
                                }
                            }
                        }
                        if (!check)
                        {
                            arr2[i, j] = key[c];
                        }
                        else
                        {
                            if (j == 0) { i--; j = 4; }
                            else { j--; }
                        }
                        c++;
                    }
                    else
                    {
                        for(int k = 4; k >=0; k--)
                        {
                            for(int l = 4; l >=0; l--)
                            {
                                bool check = false;
                                char test = arr[k, l];
                                for(int w = 0; w < 5; w++)
                                {
                                    for (int v = 0; v < 5; v++)
                                    {
                                        if (test == arr2[w, v])
                                        {
                                            check = true;
                                        }
                                    }
                                }
                                if (check == false)
                                {
                                    arr2[i, j] = test;
                                }
                            }
                        }
                        
                    }
                }
            }

            string decryptedText = FairPlayEncrypted.Text;
            if (decryptedText.Length % 2 == 1)
            {
                decryptedText += 'z';
            }
            int x1, y1, x2, y2;
            x1 = 0;
            x2 = 0;
            y1 = 0;
            y2 = 0;
            for (int i = 0; i < decryptedText.Length; i += 2)
            {
                char c1 = decryptedText[i];
                char c2 = decryptedText[i + 1];
                
                for(int k = 0; k < 5; k++)
                {
                    for(int l = 0; l < 5; l++)
                    {
                        if (arr2[k, l] == c1)
                        {
                            x1 = k;
                            y1 = l;
                        }
                        if (arr2[k, l] == c2)
                        {
                            x2 = k;
                            y2 = l;
                        }
                    }
                }
                if (x1 == x2)
                {
                    y1++;
                    y2++;
                    if (y1 == 5)
                    {
                        y1 = 0;
                    }
                    if (y2 == 5)
                    {
                        y2 = 0;
                    }
                }
                if (y1 == y2)
                {
                    x1++;
                    x2++;
                    if (x1 ==5)
                    {
                        x1 = 0;
                    }
                    if (x2 == 5)
                    {
                        x2 = 0;
                    }
                }
                if(x1!=x2 && y1 != y2)
                {
                    int tempx1 = x1 ;
                    int tempx2 = x2;
                    int tempy1 = y2;
                    int tempy2 = y1;
                    x1 = tempx1;
                    x2 = tempx2;
                    y1 = tempy1;
                    y2 = tempy2;
                }
                FairPlayDecrypted.Text += arr2[x1, y1];
                FairPlayDecrypted.Text += arr2[x2, y2];
            }
        }

        private void FairPlayDecrypt_Click(object sender, EventArgs e)
        {
            char[,] arr = new char[5, 5];
            char[,] arr2 = new char[5, 5];
            int c = 97;
            for (int i = 0; i < 5; i++)
            {
                for (int j = 0; j < 5; j++)
                {
                    if ((char)c != 'j')
                    {
                        arr[i, j] = (char)c;
                    }
                    else { j--; }
                    c++;
                }
            }
            string key = FairPlayKey.Text;
            c = 0;
            for (int i = 0; i < 5; i++)
            {
                for (int j = 0; j < 5; j++)
                {
                    if (c < key.Length)
                    {
                        bool check = false;
                        for (int k = 0; k < 5; k++)
                        {
                            for (int l = 0; l < 5; l++)
                            {
                                if (arr2[k, l] == key[c])
                                {
                                    check = true;
                                }
                            }
                        }
                        if (!check)
                        {
                            arr2[i, j] = key[c];
                        }
                        else
                        {
                            if (j == 0) { i--; j = 4; }
                            else { j--; }
                        }
                        c++;
                    }
                    else
                    {
                        for (int k = 4; k >= 0; k--)
                        {
                            for (int l = 4; l >= 0; l--)
                            {
                                bool check = false;
                                char test = arr[k, l];
                                for (int w = 0; w < 5; w++)
                                {
                                    for (int v = 0; v < 5; v++)
                                    {
                                        if (test == arr2[w, v])
                                        {
                                            check = true;
                                        }
                                    }
                                }
                                if (check == false)
                                {
                                    arr2[i, j] = test;
                                }
                            }
                        }

                    }
                }
            }

            string encryptedText = FairPlayDecrypted.Text;
            FairPlayEncrypted.Text = "";
            int x1, y1, x2, y2;
            x1 = 0;
            x2 = 0;
            y1 = 0;
            y2 = 0;
            for (int i = 0; i < encryptedText.Length; i += 2)
            {
                char c1 = encryptedText[i];
                char c2 = encryptedText[i + 1];
                
                for(int k = 0; k < 5; k++)
                {
                    for(int l = 0; l < 5; l++)
                    {
                        if (arr2[k, l] == c1)
                        {
                            x1 = k;
                            y1 = l;
                        }
                        if (arr2[k, l] == c2)
                        {
                            x2 = k;
                            y2 = l;
                        }
                    }
                }
                if (x1 == x2)
                {
                    y1--;
                    y2--;
                    if (y1 == -1)
                    {
                        y1 = 4;
                    }
                    if (y2 == -1)
                    {
                        y2 = 4;
                    }
                }
                if (y1 == y2)
                {
                    x1--;
                    x2--;
                    if (x1 ==-1)
                    {
                        x1 = 4;
                    }
                    if (x2 == -1)
                    {
                        x2 = 4;
                    }
                }
                if(x1!=x2 && y1 != y2)
                {
                    int tempx1 = x1 ;
                    int tempx2 = x2;
                    int tempy1 = y2;
                    int tempy2 = y1;
                    x1 = tempx1;
                    x2 = tempx2;
                    y1 = tempy1;
                    y2 = tempy2;
                }
                FairPlayEncrypted.Text += arr2[x1, y1];
                FairPlayEncrypted.Text += arr2[x2, y2];
            }
        }
    }
}
