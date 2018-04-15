using System;
using System.Collections.Generic;
using System.Drawing;
using System.Windows.Forms;

namespace Agenda
{
    public partial class Form1 : Form
    {
        static String path = System.IO.Directory.GetParent(System.IO.Directory.GetParent(System.IO.Path.GetDirectoryName(Application.ExecutablePath)).FullName).FullName + "\\data\\ids.xml";

        public Form1()
        {
            InitializeComponent();
            Password.PasswordChar = '*'; // Hides the password
            Password.MaxLength = 15; // Maximum password length is 15 characters
        }

        // User verification
        private void Connexion_Button_Click(object sender, EventArgs e)
        {
            bool checkUser = true;
            List<Account> user = ReadXML();
            foreach (Account c in user)
            {
                if(c.Mail == Login.Text)
                {
                    Account ps = user.Find(x => x.Mail == c.Mail);
                    if (ps.Password == Password.Text)
                    {
                        checkUser = false;
                        Main m = new Main(c);
                        m.Show();
                        this.Hide(); // Hide the identification page
                        break;
                    }
                }
            }
            if (checkUser == true)
            {
                MessageBox.Show("Login ou mot de passe incorrecte", "Echec connexion", MessageBoxButtons.OK, MessageBoxIcon.Error);
                Password.Clear();
            }
        }

        public static List<Account> ReadXML()
        {
            System.Xml.Serialization.XmlSerializer reader = new System.Xml.Serialization.XmlSerializer(typeof(List<Account>));
            System.IO.StreamReader file = new System.IO.StreamReader(path);
            List<Account> userlogs = (List<Account>)reader.Deserialize(file);
            file.Close();
            return userlogs;
        }

        // Registration
        private void linkLabel1_LinkClicked(object sender, LinkLabelLinkClickedEventArgs e)
        {
            Inscription isc = new Inscription();
            isc.Show();
        }

        // Forgot your password
        private void PasswordLost_LinkClicked(object sender, LinkLabelLinkClickedEventArgs e)
        {
            PasswordLost psl = new PasswordLost();
            psl.Show();
        }

        private void Login_Enter(object sender, EventArgs e)
        {
            if (Login.Text == "name@exemple.com")
            {
                Login.Text = "";
                Login.ForeColor = Color.Black;
            }
        }

        private void Login_Leave(object sender, EventArgs e)
        {
            if (Login.Text == "")
            {
                Login.Text = "name@exemple.com";
                Login.ForeColor = Color.Silver;
            }
        }

        private void Password_KeyDown(object sender, KeyEventArgs e)
        {
            if (e.KeyCode == Keys.Enter)
            {
                Connexion_Button.PerformClick();
                e.Handled = true;
            }
        }
    }
}