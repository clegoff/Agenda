using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;


namespace Agenda
{
    public partial class Contacts : Form
    {
        private Account theAccount;
        public Account TheAccount { get => theAccount; set => theAccount = value; }

        public Contacts(Account acc)
        {
            theAccount = acc;
            InitializeComponent();
        }

        public Contacts()
        {
            InitializeComponent();
            List<Account> acc = new List<Account>();
            acc = Form1.ReadXML();
            foreach (Account c in acc)
            {
                comboBox1.Items.Add(c.Mail);
            }
        }

        private void buttonSupprimer_Click(object sender, EventArgs e)
        {
            List<Account> userlogs = Form1.ReadXML();
            Account accountToDelete = null;
            foreach (Account acc in userlogs)
            {
                if (acc.Mail.Equals(theAccount.Mail))
                {
                    accountToDelete = acc;
                }
            }
            userlogs.Remove(accountToDelete);


            string mail = comboBox1.Text;
            
            foreach (Account acc in userlogs)
            {
                if (acc.ToString().Equals(mail))
                {
                    TheAccount.removeContact(acc);
                }
            }

            userlogs.Add(theAccount);
            Inscription.WriteXML(userlogs);
        }

        public Account searchAccount(bool isMail, String mail)
        {
            Account theNewContact = null;

            List<Account> userlogs = Form1.ReadXML();
            Account accountToDelete = null;
            foreach (Account acc in userlogs)
            {
                if (acc.Mail.Equals(theAccount.Mail))
                {
                    accountToDelete = acc;
                }
            }
            userlogs.Remove(accountToDelete);

            foreach (Account acc in userlogs)
            {
                if (acc.Mail.Equals(mail))
                {
                    theAccount.addContact(acc);
                    theNewContact = acc;
                }
            }

            userlogs.Add(theAccount);
            Inscription.WriteXML(userlogs);

            return theNewContact;
        }

        public Account searchAccount(String tel_pro)
        {
            Account theNewContact = null;
            List<Account> userlogs = Form1.ReadXML();
            Account accountToDelete = null;
            foreach (Account acc in userlogs)
            {
                if (acc.Mail.Equals(theAccount.Mail))
                {
                    accountToDelete = acc;
                }
            }
            userlogs.Remove(accountToDelete);

            foreach (Account acc in userlogs)
            {
                if (acc.Phone_pro.Equals(tel_pro))
                {
                    theAccount.addContact(acc);
                    theNewContact = acc;
                }
            }

            userlogs.Add(theAccount);
            Inscription.WriteXML(userlogs);

            return theNewContact;
        }

        private void buttonAjouter_Click(object sender, EventArgs e)
        {
            if (mailTextBox.Text.Equals("") && phoneTextBox.Text.Equals(""))
            {
                MessageBox.Show("Remplissez le champ mail ou téléphone.");
            }
            else if ((mailTextBox.Text.Equals("") && !phoneTextBox.Text.Equals("")))
            {
                if (this.searchAccount(phoneTextBox.Text) != null)
                {
                    MessageBox.Show("Ajout réussi!");
                    this.Hide();
                }
                else
                {
                    MessageBox.Show("Le contact n'a pas pu être trouvé.");
                }
            }
            else
            {
                if (this.searchAccount(true, mailTextBox.Text) != null)
                {
                    MessageBox.Show("Ajout réussi!");
                    this.Hide();
                }
                else
                {
                    MessageBox.Show("Le contact n'a pas pu être trouvé.");
                }
            }
        }
    }
}