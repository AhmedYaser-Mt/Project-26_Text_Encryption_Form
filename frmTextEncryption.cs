using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Project_26___Text_Encryption_Form__
{
    public partial class frmTextEncryption : Form
    {
        public frmTextEncryption()
        {
            InitializeComponent();
        }

        private byte SecurityKey = 1, MaxSecurityKey = 5, MinSecurityKey = 1;

        private bool IsMaxSecurityKey()
        {
            return (SecurityKey == MaxSecurityKey);
        }

        private bool IsMinSecurityKey()
        {
            return (SecurityKey == MinSecurityKey);
        }

        private bool IsInputTextboxEmpty()
        {
            return string.IsNullOrWhiteSpace(txtInput.Text);
        }

        private bool IsOutputTextboxEmpty()
        {
            return string.IsNullOrEmpty(txtOutput.Text);
        }

        private bool IsTextboxesEmpty()
        {
            return (IsInputTextboxEmpty() || IsOutputTextboxEmpty());
        }

        private void ResetTextboxes()
        {
            txtInput.Clear();
            txtOutput.Clear();
        }

        private void ResetLabels()
        {
            lblOutputStatus.Text = "Output";
            lblLength.Text = "Length :";
        }

        private void Clear()
        {
            ResetTextboxes();
            ResetLabels();
        }

        private void Encrypt()
        {
            lblOutputStatus.Text = "Encrypted\n Output";

            txtOutput.Text = EncryptText();
        }

        private void Decrypt()
        {
            lblOutputStatus.Text = "Decrypted\n Output";

            txtOutput.Text = DecryptText();
        }

        private void DecrementSecurityKey()
        {
            SecurityKey--;
            txtSecurityKey.Text = SecurityKey.ToString();
        }

        private void IncrementSecurityKey()
        {
            SecurityKey++;
            txtSecurityKey.Text = SecurityKey.ToString();
        }

        private void GetLength()
        {
            lblLength.Text = "Length : " + txtInput.Text.Length;
        }

        private string EncryptText()
        {
            string EncryptedText = "";

            for (byte i = 0; i < txtInput.Text.Length; i++)
            {
                EncryptedText += Convert.ToChar(txtInput.Text[i] + SecurityKey);
            }

            return EncryptedText;
        }

        private string DecryptText()
        {
            string DecryptedText = "";

            for (byte i = 0; i < txtInput.Text.Length; i++)
            {
                DecryptedText += Convert.ToChar(txtInput.Text[i] - SecurityKey);
            }

            return DecryptedText;
        }

        private void btnDecrementSecurityKey_Click(object sender, EventArgs e)
        {
            if (!IsMinSecurityKey())
            {
                DecrementSecurityKey();
            }
        }

        private void btnIncrementSecurityKey_Click(object sender, EventArgs e)
        {
            if (!IsMaxSecurityKey())
            {
                IncrementSecurityKey();
            }
        }

        private void btnCopyResult_Click(object sender, EventArgs e)
        {
            if (!IsOutputTextboxEmpty())
            {
                txtOutput.SelectAll();
                txtOutput.Copy();
            }
        }

        private void btnClear_Click(object sender, EventArgs e)
        {
            Clear();
        }

        private void btnSaveProcess_Click(object sender, EventArgs e)
        {
            if (!IsTextboxesEmpty())
            {
                txtHistoryLog.Text += "[ " + DateTime.Now.ToString() + " ] - ";
                txtHistoryLog.Text += "Input : " + txtInput.Text + ", ";
                txtHistoryLog.Text += lblOutputStatus.Text + " : " + txtOutput.Text + ", ";
                txtHistoryLog.Text += "Text " + lblLength.Text + Environment.NewLine;
            }
        }

        private void btnDeleteAll_Click(object sender, EventArgs e)
        {
            txtHistoryLog.Clear();
        }

        private void btnEncrypt_Click(object sender, EventArgs e)
        {
            if (!IsInputTextboxEmpty())
            {
                Encrypt();

                GetLength();
            }
        }

        private void btnDecrypt_Click(object sender, EventArgs e)
        {
            if (!IsInputTextboxEmpty())
            {
                Decrypt();

                GetLength();
            }
        }
    }
}
