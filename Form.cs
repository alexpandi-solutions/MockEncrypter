using System;
using System.Security.Cryptography;
using System.Text;
using System.Windows.Forms;

namespace Encrypter
{
    public partial class Form : System.Windows.Forms.Form
    {
        UnicodeEncoding ByteConverter = new UnicodeEncoding();
        RSACryptoServiceProvider rsa = new RSACryptoServiceProvider();
        byte[] plaintext;
        byte[] encryptedtext;

        Algorithms.RSA rsaAlg = new Algorithms.RSA();
        Algorithms.AES aesAlg = new Algorithms.AES();
        Algorithms.Alice alice = new Algorithms.Alice();
        Algorithms.RC4 rc4Alg = new Algorithms.RC4();

        public Form()
        {
            InitializeComponent();
        }

        private bool ValidateUserEntry(string input, string mess)
        {
            // Checks the value of the text.
            if (string.IsNullOrEmpty(input) || string.IsNullOrWhiteSpace(input))
            {
                // Initializes the variables to pass to the MessageBox.Show method.
                string message = mess;
                string caption = "Input Error";
                MessageBoxButtons buttons = MessageBoxButtons.OK;
                DialogResult result;

                // Displays the MessageBox.
                result = MessageBox.Show(message, caption, buttons);
                return true;
            }
            else
                return false;
        }

        private void RSAEncryptExecutor()
        {
            bool missingPlaintext = ValidateUserEntry(plaintextInput.Text, "Plaintext is missing!");
            
            plaintext = ByteConverter.GetBytes(plaintextInput.Text);
            keyInput.Text = Encoding.ASCII.GetString(rsa.ExportParameters(false).Modulus);
            encryptedtext = rsaAlg.Encryption(plaintext, rsa.ExportParameters(false), false);
            cyphertextResult.Text = Encoding.ASCII.GetString(encryptedtext);

            if (missingPlaintext)
            {
                keyInput.ResetText();
                cyphertextResult.ResetText();
            }
        }

        private void RSADecryptExecutor()
        {
            bool missingCypher = ValidateUserEntry(cyphertextResult.Text, "Cypher is missing!");
            bool missingKey = ValidateUserEntry(keyInput.Text, "Key is missing!");
            
            byte[] decryptedtex = rsaAlg.Decryption(encryptedtext, rsa.ExportParameters(true), false);
            plaintextInput.Text = ByteConverter.GetString(decryptedtex);

            if (missingCypher || missingKey)
            {
                cyphertextResult.ResetText();
                keyInput.ResetText();
                plaintextInput.ResetText();
            }
        }

        private void DHEncryptExecutor()
        {
            bool missingPlaintext = ValidateUserEntry(plaintextInput.Text, "Plaintext is missing!");
            
            alice.ImportMessage(plaintextInput.Text);
            alice.Encrypt();
            keyInput.Text = alice.key;
            cyphertextResult.Text = alice.crypt;

            if (missingPlaintext)
            {
                keyInput.ResetText();
                cyphertextResult.ResetText();
            }
        }

        private void DHDecryptExecutor()
        {
            bool missingCypher = ValidateUserEntry(cyphertextResult.Text, "Cypher is missing!");
            bool missingKey = ValidateUserEntry(keyInput.Text, "Key is missing!");
            
            plaintextInput.Text = alice.mess;

            if (missingCypher || missingKey)
            {
                cyphertextResult.ResetText();
                keyInput.ResetText();
                plaintextInput.ResetText();
            }
        }

        private void RC4EncryptExecutor()
        {
            bool missingPlaintext = ValidateUserEntry(plaintextInput.Text, "Plaintext is missing!");
            bool missingKey = ValidateUserEntry(keyInput.Text, "Key is missing!");
            
            rc4Alg.ImportKey(keyInput.Text);
            cyphertextResult.Text = rc4Alg.Encrypt(plaintextInput.Text);

            if (missingPlaintext || missingKey)
            {
                keyInput.ResetText();
                cyphertextResult.ResetText();
            }
        }

        private void RC4DecryptExecutor()
        {
            bool missingCypher = ValidateUserEntry(cyphertextResult.Text, "Cypher is missing!");
            bool missingKey = ValidateUserEntry(keyInput.Text, "Key is missing!");
            
            plaintextInput.Text = rc4Alg.Decrypt(cyphertextResult.Text);

            if (missingCypher || missingKey)
            {
                cyphertextResult.ResetText();
                keyInput.ResetText();
                plaintextInput.ResetText();
            }
        }

        private void AESEncryptExecutor()
        {
            bool missingPlaintext = ValidateUserEntry(plaintextInput.Text, "Plaintext is missing!");
            bool missingKey = ValidateUserEntry(keyInput.Text, "Key is missing!");
            
            cyphertextResult.Text = aesAlg.Encrypt(plaintextInput.Text, keyInput.Text);

            if (missingPlaintext || missingKey)
            {
                keyInput.ResetText();
                cyphertextResult.ResetText();
            }
        }

        private void AESDecryptExecutor()
        {
            bool missingCypher = ValidateUserEntry(cyphertextResult.Text, "Cypher is missing!");
            bool missingKey = ValidateUserEntry(keyInput.Text, "Key is missing!");
            
            plaintextInput.Text = aesAlg.Decrypt(cyphertextResult.Text, keyInput.Text);

            if (missingCypher || missingKey)
            {
                cyphertextResult.ResetText();
                keyInput.ResetText();
                plaintextInput.ResetText();
            }
        }

        private void button1_Click(object sender, EventArgs e)
        {
            if (algSelectOpt.SelectedIndex == 0)
                RSAEncryptExecutor();
            if (algSelectOpt.SelectedIndex == 1)
                DHEncryptExecutor();
            if (algSelectOpt.SelectedIndex == 2)
                AESEncryptExecutor();
            if (algSelectOpt.SelectedIndex == 3)
                RC4EncryptExecutor();
        }

        private void button2_Click_1(object sender, EventArgs e)
        {
            if (algSelectOpt.SelectedIndex == 0)
                RSADecryptExecutor();
            if (algSelectOpt.SelectedIndex == 1)  
                DHDecryptExecutor();
            if (algSelectOpt.SelectedIndex == 2)
                AESDecryptExecutor();
            if (algSelectOpt.SelectedIndex == 3)
                RC4DecryptExecutor();
        }

        private void button3_Click(object sender, EventArgs e)
        {
            algSelectOpt.SelectedIndex = -1;
            plaintextInput.ResetText();
            keyInput.ResetText();
            cyphertextResult.ResetText();
        }

        private void button4_Click(object sender, EventArgs e)
        {
            plaintextInput.ResetText();
        }

        private void button5_Click(object sender, EventArgs e)
        {
            cyphertextResult.ResetText();
        }

        private void button6_Click(object sender, EventArgs e)
        {
            keyInput.ResetText();
        }

        private void algSelectOpt_SelectedIndexChanged(object sender, EventArgs e)
        {
            plaintextInput.ResetText();
            keyInput.ResetText();
            cyphertextResult.ResetText();
        }
    }
}
