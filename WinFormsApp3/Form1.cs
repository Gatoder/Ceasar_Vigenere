using System;
using System.Linq;
using System.Text;
using System.Windows.Forms;
namespace WinFormsApp3
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
            InitializeEncryptionMethods();
        }


        private void InitializeEncryptionMethods()
        {
            PP.Items.Add("Caesar");
            PP.Items.Add("Vigenère");
            PP.SelectedIndex = 0;
        }
        private void M_Click(object sender, EventArgs e)
        {
            string plainText = T.Text;
            string encryptionMethod = PP.SelectedItem.ToString();
            string key = KEY.Text;

            string encryptedText = Encrypt(plainText, encryptionMethod, key);

            K.Text = encryptedText;
        }

        private void G_Click(object sender, EventArgs e)
        {
            string encryptedText = T.Text;
            string encryptionMethod = PP.SelectedItem.ToString();
            string key = KEY.Text;

            string decryptedText = Decrypt(encryptedText, encryptionMethod, key);

            K.Text = decryptedText;

        }

        private string Encrypt(string plainText, string encryptionMethod, string key)
        {
            switch (encryptionMethod)
            {
                case "Caesar":
                    return EncryptCaesar(plainText, key);
                case "Vigenère":
                    return EncryptVigenere(plainText, key);
                default:
                    return "";
            }
        }

        private string Decrypt(string encryptedText, string encryptionMethod, string key)
        {
            switch (encryptionMethod)
            {
                case "Caesar":
                    return DecryptCaesar(encryptedText, key);
                case "Vigenère":
                    return DecryptVigenere(encryptedText, key);
                default:
                    return "";
            }
        }

        private string EncryptCaesar(string plainText, string shift)
        {
            int shiftValue;
            if (!int.TryParse(shift, out shiftValue))
            {
                MessageBox.Show("Shift value must be an integer.");
                return "";
            }

            StringBuilder encryptedText = new StringBuilder();

            foreach (char c in plainText)
            {
                char encryptedChar = c;

                if (char.IsLetter(c))
                {
                    char baseChar = char.IsUpper(c) ? 'A' : 'a';
                    encryptedChar = (char)((c - baseChar + shiftValue) % 26 + baseChar);
                }
                else if (char.IsDigit(c))
                {
                    encryptedChar = (char)((c - '0' + shiftValue) % 10 + '0');
                }

                encryptedText.Append(encryptedChar);
            }

            return encryptedText.ToString();
        }

        private string DecryptCaesar(string encryptedText, string shift)
        {
            int shiftValue;
            if (!int.TryParse(shift, out shiftValue))
            {
                MessageBox.Show("Shift value must be an integer.");
                return "";
            }

            StringBuilder decryptedText = new StringBuilder();

            foreach (char c in encryptedText)
            {
                char decryptedChar = c;

                if (char.IsLetter(c))
                {
                    char baseChar = char.IsUpper(c) ? 'A' : 'a';
                    decryptedChar = (char)((c - baseChar - shiftValue + 26) % 26 + baseChar);
                }
                else if (char.IsDigit(c))
                {
                    decryptedChar = (char)((c - '0' - shiftValue + 10) % 10 + '0');
                }

                decryptedText.Append(decryptedChar);
            }

            return decryptedText.ToString();
        }

        private string EncryptVigenere(string plainText, string key)
        {
            StringBuilder encryptedText = new StringBuilder();

            int keyIndex = 0;

            foreach (char c in plainText)
            {
                char encryptedChar = c;

                if (char.IsLetter(c))
                {
                    char baseChar = char.IsUpper(c) ? 'A' : 'a';
                    char keyChar = char.IsUpper(key[keyIndex % key.Length]) ? 'A' : 'a';

                    encryptedChar = (char)((c - baseChar + key[keyIndex % key.Length] - keyChar) % 26 + baseChar);

                    keyIndex++;
                }
                else if (char.IsDigit(c))
                {
                    encryptedChar = (char)((c - '0' + key[keyIndex % key.Length] - '0') % 10 + '0');

                    keyIndex++;
                }

                encryptedText.Append(encryptedChar);
            }

            return encryptedText.ToString();
        }

        private string DecryptVigenere(string encryptedText, string key)
        {
            StringBuilder decryptedText = new StringBuilder();

            int keyIndex = 0;

            foreach (char c in encryptedText)
            {
                char decryptedChar = c;

                if (char.IsLetter(c))
                {
                    char baseChar = char.IsUpper(c) ? 'A' : 'a';
                    char keyChar = char.IsUpper(key[keyIndex % key.Length]) ? 'A' : 'a';

                    decryptedChar = (char)((c - baseChar - (key[keyIndex % key.Length] - keyChar) + 26) % 26 + baseChar);

                    keyIndex++;
                }
                else if (char.IsDigit(c))
                {
                    decryptedChar = (char)((c - '0' - (key[keyIndex % key.Length] - '0') + 10) % 10 + '0');

                    keyIndex++;
                }

                decryptedText.Append(decryptedChar);
            }

            return decryptedText.ToString();
        }




        private void PP_SelectedIndexChanged(object sender, EventArgs e)
        {
          
        }
    }
}