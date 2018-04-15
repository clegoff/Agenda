using System;
using System.Collections.Generic;
using System.Drawing;
using System.IO;
using System.Windows.Forms;
using System.Net.Mail;
using System.Xml.Serialization;

namespace Agenda
{
    public partial class Inscription : Form
    {
        static String path = Directory.GetParent(Directory.GetParent(Path.GetDirectoryName(Application.ExecutablePath)).FullName).FullName + "\\data\\ids.xml";

        public Inscription()
        {
            InitializeComponent();
            password_new.PasswordChar = '*'; // Hides the password
            password_new.MaxLength = 15; // Maximum password length is 15 characters
            telPro_new.MaxLength = 10; // Maximum phone length is 10 characters
            // Question près défini
            comboBox_question.Items.Add("Quel est le nom de jeune fille de votre mère ?");
            comboBox_question.Items.Add("Quel est le nom de votre premier animal ?");
            comboBox_question.Items.Add("Quel est votre couleur favorite ?");
            comboBox_question.Items.Add("Votre ville de naissance ?");
            comboBox_question.SelectedItem = "Quel est le nom de jeune fille de votre mère ?";
        }

        private void button1_Click(object sender, EventArgs e)
        {
            if (mail_new.Text == "" || password_new.Text == "" || name_new.Text == "" || firstName_new.Text == "" || telPro_new.Text == "" || comboBox_question.Text == "" || reponseCle.Text == "")
            {
                MessageBox.Show("Veuillez remplir tous les champs obligatoires (marqués d'un *)", "Erreur", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
            else  
            {
                List<Account> userlogs = new List<Account>(); // Apply changes to user accounts
                userlogs = Form1.ReadXML();
                userlogs.Add(new Account(mail_new.Text, password_new.Text, name_new.Text, firstName_new.Text, telPro_new.Text, serviceText.Text, comboBox_question.Text, reponseCle.Text, "", new Calendar(), new List<Account>()));
                WriteXML(userlogs);
                confirEmail(mail_new.Text, password_new.Text, name_new.Text, firstName_new.Text);
                this.Hide();
            }
            
        }

        public static void WriteXML(List<Account> myList)
        {
            FileStream file = null;
            try
            {
                XmlSerializer writer = new XmlSerializer(typeof(List<Account>));
                file = File.Create(path);
                writer.Serialize(file, myList);
                file.Close();
            }
            catch (Exception e)
            {
                Console.Write(e.Message);
            }

        }

        // Confirmation d'incription par mail
        private static void confirEmail(string email, string password, string name, string firstname)
        {
            MailMessage mail = new MailMessage();
            mail.From = new MailAddress("teamoAgenda@gmail.com");
            mail.To.Add(new MailAddress(email)); // Mail client
            mail.Subject = "Teamo Inscription";
            mail.Body = " Bonjour " + name + " " + firstname 
                + ", \n\n Merci de vous êtes inscrit sur Teamo. \n Identifiant : " + email + "\n Mot de passe : " + password 
                + "\n\n Cordialement \n L'équipe Teamo";
            SmtpClient SmtpServer = new SmtpClient("smtp.gmail.com", 587);
            SmtpServer.Credentials = new System.Net.NetworkCredential("teamoAgenda@gmail.com", "Teamoteam");
            SmtpServer.EnableSsl = true;
            try
            {
                SmtpServer.Send(mail);
                MessageBox.Show("Inscription réussite", "Inscription", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
            catch (Exception ex)
            {
                MessageBox.Show("Impossible d'envoyer le mail", "Echec", MessageBoxButtons.OK, MessageBoxIcon.Stop);
                Console.WriteLine("Error message: " + ex.Message);
            }
        }

        private void tel_new_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (!char.IsControl(e.KeyChar) && !char.IsDigit(e.KeyChar)) e.Handled = true;
        }

        private void telPro_new_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (!char.IsControl(e.KeyChar) && !char.IsDigit(e.KeyChar)) e.Handled = true;
        }

        private void mail_new_Enter(object sender, EventArgs e)
        {
            if (mail_new.Text == "name@exemple.com")
            {
                mail_new.Text = "";
                mail_new.ForeColor = Color.Black;
            }
        }

        private void mail_new_Leave(object sender, EventArgs e)
        {
            if (mail_new.Text == "")
            {
                mail_new.Text = "name@exemple.com";
                mail_new.ForeColor = Color.Silver;
            }
        }
    }  
}
