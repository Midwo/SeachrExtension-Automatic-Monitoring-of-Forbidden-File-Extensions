using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Net.Mail;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace SearchExtension
{
    public partial class EmailConfigurations : Form
    {
        public EmailConfigurations()
        {
            InitializeComponent();

            Microsoft.Win32.RegistryKey key;
            key = Microsoft.Win32.Registry.CurrentUser.CreateSubKey("MD - SeachrExtension");
            try
            {
                if (key.GetValue("Name").ToString() != string.Empty || key.GetValue("Password").ToString() != string.Empty || key.GetValue("Signature").ToString() != string.Empty || key.GetValue("SMTP").ToString() != string.Empty || key.GetValue("Port").ToString() != string.Empty)
                {
                    tbNameAccount.Text = key.GetValue("Name").ToString();
                    mtbPassword.Text = key.GetValue("Password").ToString();
                    tbSignature.Text = key.GetValue("Signature").ToString();
                    tbSmtp.Text = key.GetValue("SMTP").ToString();
                    tbPort.Text = key.GetValue("Port").ToString();
                }
                else
                {
                    tbNameAccount.Text = "YourEmail@xyz.pl";
                    mtbPassword.Clear();
                    tbSignature.Text = "Your Signature";
                    tbSmtp.Text = "SMTP name";
                    tbPort.Text = "Port number";
                }

            }
            catch
            {
                tbNameAccount.Text = "YourEmail@xyz.pl";
                mtbPassword.Clear();
                tbSignature.Text = "Your Signature";
                tbSmtp.Text = "SMTP name";
                tbPort.Text = "Port number";
            }
            key.Close();

        }

        private void BTest_Click(object sender, EventArgs e)
        {
            System.Text.RegularExpressions.Regex rEmail = new System.Text.RegularExpressions.Regex(@"^[a-zA-Z][\w\.-]*[a-zA-Z0-9]@[a-zA-Z0-9][\w\.-]*[a-zA-Z0-9]\.[a-zA-Z][a-zA-Z\.]*[a-zA-Z]$");

            if (!rEmail.IsMatch(tbNameAccount.Text.Trim()))
            {
                MessageBox.Show("Błedny format adreseu e-mail!", "Uwaga błąd!", MessageBoxButtons.OK, MessageBoxIcon.Error);
                tbNameAccount.SelectAll();

            }
            else
            {
                //zapis danych do rejestru i poinfrowanie o poprawnym zapisuniu ich
                if (tbNameAccount.Text.Trim().Length > 0 && mtbPassword.Text.Trim().Length > 0 && tbSignature.Text.Trim().Length > 0 && tbSmtp.Text.Trim().Length > 0 && tbPort.Text.Trim().Length > 0)
                {
                    Microsoft.Win32.RegistryKey keyx;
                    keyx = Microsoft.Win32.Registry.CurrentUser.CreateSubKey("MD - SeachrExtension");
                    keyx.SetValue("Name", tbNameAccount.Text.Trim());
                    keyx.SetValue("Password", mtbPassword.Text.Trim());
                    keyx.SetValue("Signature", tbSignature.Text.Trim());
                    keyx.SetValue("SMTP", tbSmtp.Text.Trim());
                    keyx.SetValue("Port", tbPort.Text.Trim());
                    keyx.Close();

                    try
                    {
                        Microsoft.Win32.RegistryKey keyy;
                        keyy = Microsoft.Win32.Registry.CurrentUser.CreateSubKey("MD - SeachrExtension");

                        int port = Int32.Parse(keyy.GetValue("Port").ToString());
                        SmtpClient mailServer = new SmtpClient(keyy.GetValue("SMTP").ToString(), port);
                        mailServer.EnableSsl = true;

                        mailServer.Credentials = new System.Net.NetworkCredential(keyy.GetValue("Name").ToString(), keyy.GetValue("Password").ToString());

                        MailMessage msg = new MailMessage();
                        msg.From = new MailAddress(keyy.GetValue("Name").ToString(), keyy.GetValue("Signature").ToString());

                        msg.To.Add(keyy.GetValue("Name").ToString());

                        msg.Subject = "Ticket - testowa wiadomość";
                        msg.Body = "Jest to testowa wiadomość sprawdzenia konfiguracji e-mail";

                        mailServer.Send(msg);

                        MessageBox.Show("Wysłano poprawnie wiadomość - znajduje się ona już na adresie podanym w programie", "Informacja", MessageBoxButtons.OK, MessageBoxIcon.Information);

                    }
                    catch (Exception ex)
                    {
                        MessageBox.Show(ex.Message, "Uwaga błąd!", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    }

                }
                else
                {
                    MessageBox.Show("Musisz wypełnić wszystkie pola", "Uwaga błąd!", MessageBoxButtons.OK, MessageBoxIcon.Warning);

                }
            }
        }

        private void BSave_Click(object sender, EventArgs e)
        {
            System.Text.RegularExpressions.Regex rEmail = new System.Text.RegularExpressions.Regex(@"^[a-zA-Z][\w\.-]*[a-zA-Z0-9]@[a-zA-Z0-9][\w\.-]*[a-zA-Z0-9]\.[a-zA-Z][a-zA-Z\.]*[a-zA-Z]$");


            if (!rEmail.IsMatch(tbNameAccount.Text.Trim()))
            {
                MessageBox.Show("Błedny format adreseu e-mail!", "Uwaga błąd!", MessageBoxButtons.OK, MessageBoxIcon.Error);
                tbNameAccount.SelectAll();

            }
            else
            {

                if (tbNameAccount.Text.Trim().Length > 0 && mtbPassword.Text.Trim().Length > 0 && tbSignature.Text.Trim().Length > 0 && tbSmtp.Text.Trim().Length > 0 && tbPort.Text.Trim().Length > 0)
                {
                    Microsoft.Win32.RegistryKey key;
                    key = Microsoft.Win32.Registry.CurrentUser.CreateSubKey("MD - SeachrExtension");
                    key.SetValue("Name", tbNameAccount.Text.Trim());
                    key.SetValue("Password", mtbPassword.Text.Trim());
                    key.SetValue("Signature", tbSignature.Text.Trim());
                    key.SetValue("SMTP", tbSmtp.Text.Trim());
                    key.SetValue("Port", tbPort.Text.Trim());
                    key.Close();

                    MessageBox.Show("Zapisano poprawnie ustawienia", "Informacja", MessageBoxButtons.OK, MessageBoxIcon.Information);
                }
                else
                {
                    MessageBox.Show("Musisz wypełnić wszystkie pola", "Uwaga błąd!", MessageBoxButtons.OK, MessageBoxIcon.Warning);

                }
            }
        }

        private void OptionsToolStripMenuItem_Click(object sender, EventArgs e)
        {
            tbPort.Text = "587";
            tbSmtp.Text = "smtp.gmail.com";
        }
    }
   
}
