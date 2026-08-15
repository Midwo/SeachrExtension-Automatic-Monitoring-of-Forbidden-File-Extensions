using System;
using System.Collections;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.IO;
using System.Linq;
using System.Net.Mail;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using static SearchExtension.Program;

namespace SearchExtension
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
            RefleshDataGrid();

            timer1.Start();

            Microsoft.Win32.RegistryKey key;
            key = Microsoft.Win32.Registry.CurrentUser.CreateSubKey("MD - SeachrExtension");
            if (key.GetValue("Path") == null)
            {
                tBPath.Text = "";
            }
            else
            {
                tBPath.Text = key.GetValue("Path").ToString();
                string[] files = Directory.GetFiles(key.GetValue("Path").ToString());
                string[] dirs = Directory.GetDirectories(key.GetValue("Path").ToString());

                foreach (string item2 in dirs)
                {

                    FileInfo fileInfo = new FileInfo(item2);

                    DirectoryInfo dir = new DirectoryInfo(item2);

                    var x = dir.EnumerateFiles("*.*", SearchOption.AllDirectories).Sum(file => file.Length);


                    listBox1.Items.Add(fileInfo.Name + " waga: " + x / 1024 / 1024 + "MB");

                    RefleshDataGrid();

                    if (key.GetValue("Hour") != null && key.GetValue("Minute") != null && key.GetValue("Second") != null)
                    {
                        cBHour.SelectedItem = key.GetValue("Hour");
                        cBMinute.SelectedItem = key.GetValue("Minute");
                        cBSecond.SelectedItem = key.GetValue("Second");
                    }
                    if (key.GetValue("NumericMinute") != null)
                    {
                        nUDCoIlePeriod.Value = Convert.ToDecimal(key.GetValue("NumericMinute"));
                    }
                }
                
            }
            key.Close();
        }

        string StringExtension;
        int BookEmails;
        int Extensions;
        bool TimerActiveButton = false;
        string mergeCombobox;
        DateTime DateMonit;
        DateTime Reflesh;

        public static string[] GetFiles(string path, string searchPattern, SearchOption searchOption)
        {
            string[] searchPatterns = searchPattern.Split('|');
            List<string> files = new List<string>();
            foreach (string sp in searchPatterns)
                files.AddRange(System.IO.Directory.GetFiles(path, sp, searchOption));
            files.Sort();
            return files.ToArray();

        }

        private void ListOfMsgRecipientsToolStripMenuItem_Click(object sender, EventArgs e)
        {
            BookEmails m = new BookEmails();
            m.Show();
        }

        private void ConfigurationAccountEmailToolStripMenuItem_Click(object sender, EventArgs e)
        {
            EmailConfigurations m = new EmailConfigurations();
            m.Show();
        }
        
        private void AuthorInfoToolStripMenuItem_Click(object sender, EventArgs e)
        {
            if (MessageBox.Show("Dane kontaktowe i informacje o autorze znajdziesz na stronie www.mdwojak.pl. Czy odwiedzić teraz tę stronę?", "Informacja - autor", MessageBoxButtons.YesNo, MessageBoxIcon.Asterisk) == DialogResult.Yes)
            {
                System.Diagnostics.Process.Start("www.mdwojak.pl");
            }
        }

        private void GraphicInProjectToolStripMenuItem_Click(object sender, EventArgs e)
        {
            if (MessageBox.Show("Elementy graficzne należą do www.icons8.com i oparte są na licencji: Creative Commons Attribution-NoDerivs 3.0 Unported. Czy chcesz wejść na stronę icons8.com?", "Informacja - grafika", MessageBoxButtons.YesNo, MessageBoxIcon.Asterisk) == DialogResult.Yes)
            {
                System.Diagnostics.Process.Start("https://icons8.com");
            }
        }
        private void BLoadPath_Click(object sender, EventArgs e)
        {
            listBox1.Items.Clear();
            FolderBrowserDialog fbd = new FolderBrowserDialog();
            DialogResult result = fbd.ShowDialog();

            if (result == DialogResult.OK)
            {

                tBPath.Text = fbd.SelectedPath;
                string[] files = Directory.GetFiles(fbd.SelectedPath);
                string[] dirs = Directory.GetDirectories(fbd.SelectedPath);

                foreach (string item2 in dirs)
                {

                    FileInfo fileInfo = new FileInfo(item2);


                    DirectoryInfo dir = new DirectoryInfo(item2);

                    var x = dir.EnumerateFiles("*.*", SearchOption.AllDirectories).Sum(file => file.Length);


                    listBox1.Items.Add(fileInfo.Name + " waga: " + x / 1024 / 1024 + "MB");
                    //using (var db = new UsersContext())
                    //{

                    //    var query = from c in db.UserInformation
                    //                where c.Name == f.Name
                    //                select new { c.Name, c.Email, c.UsersInformationsId };

                    //    if (query.ToList().Count < 1)
                    //    {
                    //        var UserFolderSave = new UsersInformations { Name = f.Name };

                    //        db.UserInformation.Add(UserFolderSave);
                    //        db.SaveChanges();
                    //    }
                    //    else
                    //    {
                    //        // rekords exist
                    //    }


                    //}

                }
                //   MessageBox.Show("" + fbd.SelectedPath + "");

                Microsoft.Win32.RegistryKey key;
                key = Microsoft.Win32.Registry.CurrentUser.CreateSubKey("MD - SeachrExtension");
                key.SetValue("Path", "" + fbd.SelectedPath + "");
                key.Close();

                // wypisanie plików
                //foreach (string item in files)
                //{
                //    FileInfo fileInfo = new FileInfo(item);

                //    listBox1.Items.Add(fileInfo.Name + "i waży plik:" +fileInfo.Length/1024/1024 + " MB");

                //}
            }
            else
            {
                MessageBox.Show("Musisz wskazać ścieżkę - nie wolno anulować", "Uwaga", MessageBoxButtons.OK, MessageBoxIcon.Warning);
            }
        }

        private void CbChoicePeriod_SelectedIndexChanged(object sender, EventArgs e)
        {
            if (cbChoicePeriod.SelectedIndex == 0)
            {
                cBHour.Enabled = true;
                cBMinute.Enabled = true;
                cBSecond.Enabled = true;
                label6.Enabled = true;
                label7.Enabled = true;
                label8.Enabled = true;
                nUDCoIlePeriod.Enabled = false;
                lPeriod.Enabled = false;
                lMinutes.Enabled = false;

            }
            else if (cbChoicePeriod.SelectedIndex == 1)
            {
                cBHour.Enabled = false;
                cBMinute.Enabled = false;
                cBSecond.Enabled = false;
                nUDCoIlePeriod.Enabled = true;
                lPeriod.Enabled = true;
                lMinutes.Enabled = true;
                label6.Enabled = false;
                label7.Enabled = false;
                label8.Enabled = false;
            }
        }
        private void BAddExt_Click(object sender, EventArgs e)
        {
            using (var db = new ExtensionContext())
            {
                var Record = new ListExtension.List { Extension = tBAddExt.Text.Trim() };
                db.ExtensionDB.Add(Record);
                db.SaveChanges();
            }
            RefleshDataGrid();
        }

        public void RefleshDataGrid()
        {
            using (var db = new ExtensionContext())
            {
                var query = from c in db.ExtensionDB

                            select new { Id = c.ListId, c.Extension };

                var results = query.OrderByDescending(h => h.Id).ToList();

                dataGridView1.DataSource = results;
                this.dataGridView1.Columns[0].AutoSizeMode = DataGridViewAutoSizeColumnMode.DisplayedCells;
                this.dataGridView1.Columns[1].AutoSizeMode = DataGridViewAutoSizeColumnMode.Fill;

            }
        }

        private void BDeleteRecords_Click(object sender, EventArgs e)
        {
            tBExtId.Clear();
            tBEditExt.Clear();

            using (var db = new ExtensionContext())
            {

                var query = from c in db.ExtensionDB

                            select new { c.ListId };

                if (query.ToList().Count >= 1)
                {
                    foreach (var item in query)
                    {
                        using (var dbx = new ExtensionContext())
                        {
                            int x = Convert.ToInt32(item.ListId.ToString());
                            var delete = new ListExtension.List { ListId = x };
                            dbx.ExtensionDB.Attach(delete);
                            dbx.ExtensionDB.Remove(delete);
                            dbx.SaveChanges();
                        }
                    }
                }
                RefleshDataGrid();
            }
        }

        private void RRun_Click(object sender, EventArgs e)
        {

            using (var db = new ExtensionContext())
            {

                var query = from c in db.ExtensionDB
                           
                            select new {c.Extension };

                Extensions = query.Count();
            }
            using (var db = new ExtensionContext())
            {

                var query = from c in db.ListEmailsDB

                            select new { c.AdresseEmail };

                BookEmails = query.Count();
            }
            Microsoft.Win32.RegistryKey key;
            key = Microsoft.Win32.Registry.CurrentUser.CreateSubKey("MD - SeachrExtension");
            object o = key.GetValue("Password");
            key.Close();

            if (o == null)
            {
                MessageBox.Show("Musisz skonfigurować ustawienia konta email wysyłającego wiadomości", "Uwaga", MessageBoxButtons.OK, MessageBoxIcon.Warning);

            }

            else if (Extensions < 1)
            {
                MessageBox.Show("Musisz wprowadzić listę rozszerzeń, którą zamierzasz szukać", "Uwaga", MessageBoxButtons.OK, MessageBoxIcon.Warning);

            }

            else if (BookEmails < 1)
            {
                MessageBox.Show("Musisz wprowadzić listę osób odbierających wiadomość - użyj menu", "Uwaga", MessageBoxButtons.OK, MessageBoxIcon.Warning);

            }
            else if (cbChoicePeriod.SelectedIndex == -1)
            {
                MessageBox.Show("Musisz wybrać combobox 'Opcje - czas sprawdzania'", "Uwaga", MessageBoxButtons.OK, MessageBoxIcon.Warning);
            }
            else if (cbChoicePeriod.SelectedIndex == 0)
            {

                if (cBHour.SelectedItem == null || cBMinute.SelectedItem == null
                   || cBSecond.SelectedItem == null)

                {
                    MessageBox.Show("Uzupełnij czas sprawdzenia - 'Opcje - czas sprawdzania'", "Uwaga", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                }
                else
                {
                    TimerActiveButton = true;
                    DateMonit = DateTime.Now.AddSeconds(Convert.ToDouble(nUDCoIlePeriod.Value));
                    bRun.Text = "Uruchomiony";
                    mergeCombobox = cBHour.SelectedItem + ":" + cBMinute.SelectedItem + ":" + cBSecond.SelectedItem;

                    Microsoft.Win32.RegistryKey keyx;
                    keyx = Microsoft.Win32.Registry.CurrentUser.CreateSubKey("MD - SeachrExtension");
                    keyx.SetValue("Hour", cBHour.SelectedItem);
                    keyx.SetValue("Minute", cBMinute.SelectedItem);
                    keyx.SetValue("Second", cBSecond.SelectedItem);
                    keyx.SetValue("NumericMinute", nUDCoIlePeriod.Value);
                    keyx.Close();
                    toolStripStatusLabel1.Text = "Status: Uruchomiony";
                }
            }
            else if (cbChoicePeriod.SelectedIndex == 1)
            {
                TimerActiveButton = true;
                DateMonit = DateTime.Now.AddSeconds(Convert.ToDouble(nUDCoIlePeriod.Value));
                bRun.Text = "Uruchomiony";

                //Microsoft.Win32.RegistryKey keyx;
                //keyx = Microsoft.Win32.Registry.CurrentUser.CreateSubKey("MD - SeachrExtension");
                //keyx.SetValue("Hour", cBHour.SelectedItem);
                //keyx.SetValue("Minute", cBMinute.SelectedItem);
                //keyx.SetValue("Second", cBSecond.SelectedItem);
                //keyx.SetValue("NumericMinute", nUDCoIlePeriod.Value);
                //keyx.Close();
                toolStripStatusLabel1.Text = "Status: Uruchomiony";
            }

            //try
            //{
            //    // Only get files that begin with the letter "c."
            //    string[] dirs = Directory.GetFiles(@"C:\Users\micsha\Downloads", "*.mp4|*.jpg");
            //    string x = String.Format("The number of files starting with c is {0}.", dirs.Length);
            //    MessageBox.Show(x);
            //    foreach (string dir in dirs)
            //    {
            //        MessageBox.Show(dir);
            //    }
            //}
            //catch (Exception x)
            //{
            //    string y = String.Format("The process failed: {0}", x.ToString());
            //    MessageBox.Show(y);
            //}

        }

        private void TBAddExt_TextChanged(object sender, EventArgs e)
        {
            tBAddExt.Clear();
        }

        private void TBAddExt_KeyDown(object sender, KeyEventArgs e)
        {
            if (e.KeyCode == Keys.Enter)
            {
                BAddExt_Click(sender, e);
            }
        }

        private void TBAddExt_TextChanged_1(object sender, EventArgs e)
        {
            tBAddExt.Clear();
        }

        private void TBAddExt_Click(object sender, EventArgs e)
        {
            tBAddExt.Clear();
        }

        private void BEditExt_Click(object sender, EventArgs e)
        {
            if (tBEditExt.Text.Trim() != string.Empty || tBEditExt.Text.Trim() != "")
            {
                int id = Convert.ToInt32(tBExtId.Text);
                string text = tBEditExt.Text.Trim();

                using (var db = new ExtensionContext())
                {
                    var result = db.ExtensionDB.SingleOrDefault(b => b.ListId == id);
                    if (result != null)
                    {
                        result.Extension = text;
                        db.SaveChanges();
                    }
                }
            }

            RefleshDataGrid();
            
        }

        private void DataGridView1_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
            try
            {
                tBEditExt.Enabled = true;
                tBExtId.Text = dataGridView1.Rows[dataGridView1.CurrentRow.Index].Cells[0].Value.ToString();
                tBEditExt.Text = dataGridView1.Rows[dataGridView1.CurrentRow.Index].Cells[1].Value.ToString();
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
            tBAddExt.Enabled = true;
        }

        private void TBEditExt_KeyDown(object sender, KeyEventArgs e)
        {
            if (e.KeyCode == Keys.Enter)
            {
                BEditExt_Click(sender, e);
            }
        }

        private void Timer1_Tick(object sender, EventArgs e)
        {
            lTime.Text = DateTime.Now.ToLongTimeString();

            if (TimerActiveButton == true)
            {
                if (DateTime.Now > Reflesh)
                {
                    Reflesh = DateTime.Now.AddSeconds(30);
                    listBox1.Items.Clear();
                    string[] files = Directory.GetFiles(tBPath.Text);
                    string[] dirs = Directory.GetDirectories(tBPath.Text);

                    foreach (string item2 in dirs)
                    {

                        FileInfo fileInfo = new FileInfo(item2);


                        DirectoryInfo dir = new DirectoryInfo(item2);

                        var x = dir.EnumerateFiles("*.*", SearchOption.AllDirectories).Sum(file => file.Length);


                        listBox1.Items.Add(fileInfo.Name + " waga: " + x / 1024 / 1024 + "MB");

                        RefleshDataGrid();

                    }
                }



                var startData = DateTime.Now.ToString("hh.mm.ss.ffffff");

                if (cbChoicePeriod.SelectedIndex == 0)
                {

                    DateTime changeCombine = DateTime.Parse((DateMonit.ToString("yyyy/MM/dd") + " " + mergeCombobox));

                    if (changeCombine <= DateTime.Now)
                    {

                        DateMonit = DateTime.Parse((DateTime.Now.AddDays(1).ToString("yyyy/MM/dd") + " " + mergeCombobox));



                        StringExtension = string.Empty;

                        string path = tBPath.Text;

                        using (var db = new ExtensionContext())
                        {
                            var query = from c in db.ExtensionDB

                                        select new { c.Extension };

                            foreach (var item in query)
                            {
                                StringExtension += "|*." + item.Extension + "";
                            }
                        }

                        StringExtension = StringExtension.Substring(1, StringExtension.Length - 1);
                        Array files = GetFiles(@"" + path + "", "" + StringExtension + "", SearchOption.AllDirectories);
                        int quantityFileWithExt = files.Length;


                        if (quantityFileWithExt > 0)
                        {

                            Microsoft.Win32.RegistryKey key;
                            key = Microsoft.Win32.Registry.CurrentUser.CreateSubKey("MD - SeachrExtension");
                            try
                            {

                                int port = Int32.Parse(key.GetValue("Port").ToString());
                                SmtpClient mailServer = new SmtpClient(key.GetValue("SMTP").ToString(), port);
                                mailServer.EnableSsl = true;

                                mailServer.Credentials = new System.Net.NetworkCredential(key.GetValue("Name").ToString(), key.GetValue("Password").ToString());

                                MailMessage msg = new MailMessage();
                                msg.From = new MailAddress(key.GetValue("Name").ToString(), key.GetValue("Signature").ToString());


                                using (var db = new ExtensionContext())
                                {

                                    var query = from c in db.ListEmailsDB
                                                select new { c.AdresseEmail };

                                    foreach (var item in query)
                                    {

                                        msg.To.Add(item.AdresseEmail);
                                    }

                                }
                                msg.IsBodyHtml = true;

                                msg.Subject = "Ticket - Wykryto, pliki spełniające kryteria, data: " + DateTime.Now.ToString() + "";
                                msg.Body = "Wykryto pliki spełniające kryteria wyszukiwania po rozszerzeniach w ilości: " + quantityFileWithExt + ", w lokalizacjach:  <br><br>";
                                foreach (var item in files)
                                {
                                    msg.Body += item.ToString() + "<br>";
                                }

                                mailServer.Send(msg);
                                toolStripStatusLabel1.Text = "Status: Uruchomiony - wykonano sprawdzenie: " + DateTime.Now.ToString() + "";
                            }
                            catch (Exception ex)
                            {
                                MessageBox.Show(ex.Message, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                            }
                            key.Close();
                        }


                    }
                }
                else if (cbChoicePeriod.SelectedIndex == 1)
                {

                    if (DateMonit <= DateTime.Now)
                    {
                        DateMonit = DateTime.Now.AddMinutes(Convert.ToDouble(nUDCoIlePeriod.Value));


                        StringExtension = string.Empty;

                        string path = tBPath.Text;

                        using (var db = new ExtensionContext())
                        {
                            var query = from c in db.ExtensionDB

                                        select new { c.Extension };

                            foreach (var item in query)
                            {
                                StringExtension += "|*." + item.Extension + "";
                            }
                        }

                        StringExtension = StringExtension.Substring(1, StringExtension.Length - 1);
                        Array files = GetFiles(@"" + path + "", "" + StringExtension + "", SearchOption.AllDirectories);
                        int quantityFileWithExt = files.Length;


                        if (quantityFileWithExt > 0)
                        {

                            Microsoft.Win32.RegistryKey key;
                            key = Microsoft.Win32.Registry.CurrentUser.CreateSubKey("MD - SeachrExtension");
                            try
                            {

                                int port = Int32.Parse(key.GetValue("Port").ToString());
                                SmtpClient mailServer = new SmtpClient(key.GetValue("SMTP").ToString(), port);
                                mailServer.EnableSsl = true;

                                mailServer.Credentials = new System.Net.NetworkCredential(key.GetValue("Name").ToString(), key.GetValue("Password").ToString());

                                MailMessage msg = new MailMessage();
                                msg.From = new MailAddress(key.GetValue("Name").ToString(), key.GetValue("Signature").ToString());


                                using (var db = new ExtensionContext())
                                {

                                    var query = from c in db.ListEmailsDB
                                                select new { c.AdresseEmail };

                                    foreach (var item in query)
                                    {

                                        msg.To.Add(item.AdresseEmail);
                                    }

                                }
                                msg.IsBodyHtml = true;

                                msg.Subject = "Ticket - Wykryto, pliki spełniające kryteria, data: " + DateTime.Now.ToString() + "";
                                msg.Body = "Wykryto pliki spełniające kryteria wyszukiwania po rozszerzeniach w ilości: " + quantityFileWithExt + ", w lokalizacjach:  <br><br>";
                                foreach (var item in files)
                                {
                                    msg.Body += item.ToString() + "<br>";
                                }

                                mailServer.Send(msg);
                                toolStripStatusLabel1.Text = "Status: Uruchomiony - wykonano sprawdzenie: " + DateTime.Now.ToString() +"";
                            }
                            catch (Exception ex)
                            {
                                MessageBox.Show(ex.Message, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                            }
                            key.Close();
                        }

                    }
                }
            }



        }
    }
}
