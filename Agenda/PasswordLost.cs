using System;
using System.Collections.Generic;
using System.Drawing;
using System.Windows.Forms;
using System.Net.Mail;

namespace Agenda
{
    public partial class PasswordLost : Form
    {
        public PasswordLost()
        {
            InitializeComponent();
            // Question by defined
            comboBoxQuestion.Items.Add("Quel est le nom de jeune fille de votre mère ?");
            comboBoxQuestion.Items.Add("Quel est le nom de votre premier animal ?");
            comboBoxQuestion.Items.Add("Quel est votre couleur favorite ?");
            comboBoxQuestion.Items.Add("Votre ville de naissance ?");
            comboBoxQuestion.SelectedItem = "Quel est le nom de jeune fille de votre mère ?";
        }

        private void buttonRecup_Click(object sender, EventArgs e)
        {
            SendMail(mailTextbox.Text, comboBoxQuestion.Text, textBoxReponse.Text);
        }

        private static void SendMail(string address, string question, string reponse)
        {
            List<Account> passlost = new List<Account>();
            passlost = Form1.ReadXML();

            foreach (Account c in passlost)
            {
                if (c.Mail == address)
                {
                    Account quest = passlost.Find(x => x.Mail == c.Mail);
                    if (quest.SecretQuestion == question)
                    {
                        if(quest.SecretAnswer == reponse)
                        {
                            MailMessage mail = new MailMessage();
                            mail.From = new MailAddress("teamoAgenda@gmail.com");
                            mail.To.Add(new MailAddress(c.Mail)); // Mail client
                            mail.Subject = "Récupération mot de passe Teamo";
                            mail.Body = "Bonjour, voici votre mot de passe : "+ quest.Password;
                            SmtpClient SmtpServer = new SmtpClient("smtp.gmail.com", 587);
                            SmtpServer.Credentials = new System.Net.NetworkCredential("teamoAgenda@gmail.com", "Teamoteam");
                            SmtpServer.EnableSsl = true;
                            try
                            {
                                SmtpServer.Send(mail);
                                MessageBox.Show("Votre mot de passe vous a été envoyé sur votre boite mail", "Mail envoyé", MessageBoxButtons.OK, MessageBoxIcon.Information);
                            }
                            catch (Exception ex)
                            {
                                MessageBox.Show("Impossible d'envoyer le mail", "Echec", MessageBoxButtons.OK, MessageBoxIcon.Stop);
                                Console.WriteLine("Error message: " + ex.Message);
                            }
                        }
                    }
                }
                else
                {
                    MessageBox.Show("Adresse mail introuvable", "Echec", MessageBoxButtons.OK, MessageBoxIcon.Stop);
                }
                break;
            }
        }

        private void mailTextbox_Enter(object sender, EventArgs e)
        {
            if (mailTextbox.Text == "name@exemple.com")
            {
                mailTextbox.Text = "";
                mailTextbox.ForeColor = Color.Black;
            }
        }

        private void mailTextbox_Leave(object sender, EventArgs e)
        {
            if (mailTextbox.Text == "")
            {
                mailTextbox.Text = "name@exemple.com";
                mailTextbox.ForeColor = Color.Silver;
            }
        }
    }
}