using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Numerics;

namespace EncryptionRSA
{
    public partial class Form1 : Form
    {
        private RSA rsa = new RSA();
        private BigInteger EncryptNum;
        private BigInteger DecryptNum;
        public Form1()
        {
            InitializeComponent();
            
        }

        private void textBox1_TextChanged(object sender, EventArgs e)
        {
            
        }

        private void btn_enc_Click(object sender, EventArgs e)
        {
            if (textBox1.Text.Length != 0)
            {
                byte[] encoded = ASCIIEncoding.ASCII.GetBytes(textBox1.Text);
                BigInteger bigInt = new BigInteger(encoded);
                if (bigInt > rsa.n)
                    throw new Exception("Text is too larg!");
                EncryptNum = rsa.Encryption(bigInt);
                textBox2.Text += ("Encrypted : " + EncryptNum);
                textBox1.Clear();
            }
            else if (textBox2.Text.Length != 0)
            {

                DecryptNum = rsa.Decryption(EncryptNum);
                textBox1.Text = "Decrypted: " + DecryptNum;
                string decoded = ASCIIEncoding.ASCII.GetString(DecryptNum.ToByteArray());
                textBox1.Text += ("  \n  Orginal text="+ decoded);
                textBox2.Clear();
            }
        }


    }
}
