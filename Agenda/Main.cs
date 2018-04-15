using System;
using System.Collections.Generic;
using System.Drawing;
using System.IO;
using System.Windows.Forms;
using System.Xml;
using System.Xml.XPath;

namespace Agenda
{
    public partial class Main : Form
    {
        private Account theAccount;
        public Account TheAccount { get => theAccount; set => theAccount = value; }

        static String pathSource = Directory.GetParent(Directory.GetParent(Path.GetDirectoryName(Application.ExecutablePath)).FullName).FullName + "\\data\\ids.xml";

        Image imageFile;

        public Main(Account acc)
        {
            this.TheAccount = acc;
            InitializeComponent();

            prevMonth.Click += prevMonth_Click;
            folMonth.Click += folMonth_Click;
            prevYear.Click += prevYear_Click;
            folYear.Click += folYear_Click;

            buttonImporter.Click += buttonImporter_CLick;
            buttonExporter.Click += buttonExporter_Click;
            buttonContact.Click += buttonContact_Click;
            buttonPicture.Click += buttonPicture_Click;
            buttonSave.Click += buttonSave_Click;
        }

        protected override void OnFormClosing(FormClosingEventArgs e)
        {
            Environment.Exit(0);
        }

        // Calendrier
        private void prevMonth_Click(object sender, EventArgs e)
        {
            clearCalendar();
            this.monthCalendar--;
            if (monthCalendar == 0)
            {
                monthCalendar = 12;
                yearCalendar--;
            }
            createCalendar(monthCalendar, yearCalendar, 101, 74);
        }

        private void folMonth_Click(object sender, EventArgs e)
        {
            clearCalendar();
            this.monthCalendar++;
            if (monthCalendar == 13)
            {
                monthCalendar = 1;
                yearCalendar++;
            }
            createCalendar(monthCalendar, yearCalendar, 101, 74);
        }

        private void prevYear_Click(object sender, EventArgs e)
        {
            clearCalendar();
            this.yearCalendar--;
            createCalendar(monthCalendar, yearCalendar, 101, 74);
        }

        private void folYear_Click(object sender, EventArgs e)
        {
            clearCalendar();
            this.yearCalendar++;
            createCalendar(monthCalendar, yearCalendar, 101, 74);
        }

        private void GBRendezVous_Click(object sender, EventArgs e)
        {
            GroupBoxDays theGroupBox = (GroupBoxDays)sender;
            int dayClicked = Int32.Parse(theGroupBox.Text.Trim());
            RendezvousDisplay rdvd = new RendezvousDisplay(this, TheAccount.TheCalendar.getARendezvous(new DateTime(this.yearCalendar, this.monthCalendar, dayClicked)), theAccount);
            rdvd.Show();
        }

        private void GBFreeDay_Click(object sender, EventArgs e)
        {
            GroupBoxDays theGroupBox = (GroupBoxDays)sender;
            int dayClicked = Int32.Parse(theGroupBox.Text.Trim());
            RendezvousDisplay rdvd = new RendezvousDisplay(this, dayClicked, theAccount, this.monthCalendar, this.yearCalendar);
            rdvd.Show();
        }

        // Rendezvous
        private void buttonSaveRdv_Click(object sender, EventArgs e)
        {
            int n = datagridviewRDV.Rows.Add();
            datagridviewRDV.Rows[n].Cells[0].Value = dgvColumnDate.ValueType;
            datagridviewRDV.Rows[n].Cells[1].Value = dgvColumnContributor.ToString();
            datagridviewRDV.Rows[n].Cells[2].Value = dgvColumnCommentaries.ToString();
        }

        /* cette méthode permet d'éviter que lorsque l'utilisateur rentre son commentaire
         * d'ajouter automatiquement des données dans le dataGridView tant qu'il n'a pas 
         * valider via le bouton buttonSaveRdv
         * */
        private void textBoxCommentaries_TextChanged(object sender, EventArgs e)
        {
            if (TextBoxComentaries is null)
            {
                String userEnter = TextBoxComentaries.ToString();
            }
        }

        public void CreateMyMultilineTextBox()
        {
            TextBox textBox = new TextBox();
            TextBoxComentaries.Multiline = true;
            TextBoxComentaries.ScrollBars = ScrollBars.Vertical;
            TextBoxComentaries.AcceptsReturn = true;
            TextBoxComentaries.AcceptsTab = true;
            TextBoxComentaries.WordWrap = true;
            TextBoxComentaries.Text = "Vous pouvez écrire des notes ici.";
        }

        // Paramètres
        // Paramètres
        private void buttonImporter_CLick(object sender, EventArgs e)
        {
            OpenFileDialog ofp = new OpenFileDialog();
            ofp.Filter = "xml files (*.xml)|*.xml";
            ofp.CheckPathExists = true;
            ofp.CheckFileExists = true;
            if (ofp.ShowDialog() == DialogResult.OK)
            {
                File.Copy(ofp.FileName, pathSource, true);
            }
        }

        private void buttonExporter_Click(object sender, EventArgs e)
        {
            SaveFileDialog saveFile = new SaveFileDialog();
            saveFile.Filter = "xml files (*.xml)|*.xml";
            saveFile.FilterIndex = 2;
            saveFile.RestoreDirectory = true;
            if (saveFile.ShowDialog() == DialogResult.OK)
            {
                File.Copy(pathSource, saveFile.FileName, true);
            }
        }

        private void buttonContact_Click(object sender, EventArgs e)
        {
            string mail = TheAccount.Mail;
            Contacts ac = new Contacts(theAccount);
            ac.Show();
        }

        private void buttonPicture_Click(object sender, EventArgs e)
        {
            OpenFileDialog ofp = new OpenFileDialog();
            ofp.CheckPathExists = true;
            ofp.CheckFileExists = true;
            if (ofp.ShowDialog() == DialogResult.OK)
            {
                textboxPicture.Text = ofp.FileName;
                imageFile = Image.FromFile(ofp.FileName);
                pictureboxPicture.BackgroundImage = imageFile;
            }
        }

        private void buttonSave_Click(object sender, EventArgs e)
        {
            List<Account> userFile = new List<Account>();
            userFile = Form1.ReadXML();
            foreach (Account c in userFile)
            {
                if (c.Mail == TheAccount.Mail)
                {
                    if (textboxNewPassword.Text != "" && textboxNewPassword.Text == textboxConfNewPassword.Text)
                    {
                        MessageBox.Show("Mot de passe modifier", "Mot de passe", MessageBoxButtons.OK, MessageBoxIcon.Information);
                        XmlDocument xmlDoc = new XmlDocument();
                        string file = pathSource;
                        xmlDoc.Load(file);
                        xmlDoc.SelectSingleNode("//Account//Password").InnerText = textboxNewPassword.Text;
                        xmlDoc.Save(file);
                    }
                    else if (textboxNewPassword.Text == "" && textboxConfNewPassword.Text != "")
                    {
                        MessageBox.Show("Veuillez confirmé votre mot de passe", "Mot de passe", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    }
                    else if (textboxNewPassword.Text != "" && textboxConfNewPassword.Text == "")
                    {
                        MessageBox.Show("Veuillez confirmé votre mot de passe", "Mot de passe", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
                    }

                    if (textboxPhone.Text != "")
                    {
                        MessageBox.Show("Téléphone professionnel modifié", "Téléphone Professionnel", MessageBoxButtons.OK, MessageBoxIcon.Information);
                        XmlDocument xmlDoc = new XmlDocument();
                        string file = pathSource;
                        xmlDoc.Load(file);
                        xmlDoc.SelectSingleNode("//Account//Phone_pro").InnerText = textboxPhone.Text;
                        xmlDoc.Save(file);
                    }

                    if (textboxService.Text != "")
                    {
                        MessageBox.Show("Service modifié", "Service", MessageBoxButtons.OK, MessageBoxIcon.Information);
                        XmlDocument xmlDoc = new XmlDocument();
                        string file = pathSource;
                        xmlDoc.Load(file);
                        xmlDoc.SelectSingleNode("//Account//Service").InnerText = textboxService.Text;
                        xmlDoc.Save(file);
                    }

                    if (textboxPicture.Text != "")
                    {
                        MessageBox.Show("Photo de profil modifiée", "Photo de profil", MessageBoxButtons.OK, MessageBoxIcon.Information);
                        XmlDocument xmlDoc = new XmlDocument();
                        string file = pathSource;
                        xmlDoc.Load(file);
                        xmlDoc.SelectSingleNode("//Account//PictureProfil").InnerText = textboxPicture.Text;
                        xmlDoc.Save(file);
                    }

                }
            }
        }
    }
}

// Ouvrir un fichier
/*private void ouvrirUnFichierToolStripMenuItem_Click(object sender, EventArgs e)
{
    DialogResult result;
    result = openFile.ShowDialog();
    if (result.ToString().ToUpper() == "OK")
    {
        Process.Start(openFile.FileName);
    }
}*/
