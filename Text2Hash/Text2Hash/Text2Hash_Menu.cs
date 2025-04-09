using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.IO;
using System.Windows.Forms;

namespace Text2Hash
{
    public partial class Text2Hash_Menu : Form
    {
        public Text2Hash_Menu()
        {
            InitializeComponent();
        }

        private void btn_Generate_Click(object sender, EventArgs e)
        {
            string text2 = txtString.Text.Trim();
            string md5Hash = MD5.GetMD5Hash(text2);

            if (chkbox.Checked)
            {
                txtRichText.Text = md5Hash.ToUpper();
            }
            else
            {
                txtRichText.Text = md5Hash.ToLower();
            }
        }

        private void chkbox_CheckedChanged(object sender, EventArgs e)
        {
            if (txtRichText.Text.Length == 32) // MD5 hash length is always 32 characters
            {
                if (chkbox.Checked)
                {
                    txtRichText.Text = txtRichText.Text.ToUpper();
                }
                else
                {
                    txtRichText.Text = txtRichText.Text.ToLower();

                }
            }
        }

        private void btnSave_Click(object sender, EventArgs e)
        {

            string text1 = txtString.Text.Trim();  
            string text2 = txtRichText.Text.Trim();
          
            if (string.IsNullOrEmpty(text1) || string.IsNullOrEmpty(text2))
            {
                MessageBox.Show("You need text to generate a hash in order to save.", "Missing Information", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return;
            }
            string filePath = Path.Combine(Application.StartupPath, "Text2Hash(MD5List).txt");

            try
            {
                using (StreamWriter writer = new StreamWriter(filePath, true))
                {
                    writer.WriteLine("***************************************");
                    writer.WriteLine("Text :");
                    writer.WriteLine(text1);
                    writer.WriteLine();
                    writer.WriteLine("MD5 Hash :");
                    writer.WriteLine(text2);
                    writer.WriteLine("***************************************");
                }

                // Show a message that the file has been saved successfully
                MessageBox.Show("File saved successfully!", "Success", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
            catch (Exception ex)
            {
                // Handle any errors that may occur
                MessageBox.Show("Error saving the file: " + ex.Message, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }
    }
}
