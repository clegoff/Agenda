using System;
using System.Collections.Generic;

namespace Agenda
{
    [Serializable()]
    public class Account
    {
        private String mail;
        public String Mail { get => mail; set => mail = value; }

        private String password;
        public String Password { get => password; set => password = value; }

        private String name;
        public String Name { get => name; set => name = value; }

        private String firstName;
        public String FirstName { get => firstName; set => firstName = value; }
        
        private String phone_pro;
        public String Phone_pro { get => phone_pro; set => phone_pro = value; }

        private String service;
        public String Service { get => service; set => service = value; }

        private String secretQuestion;
        public String SecretQuestion { get => secretQuestion; set => secretQuestion = value; }

        private String secretAnswer;
        public String SecretAnswer { get => secretAnswer; set => secretAnswer = value; }

        private String pictureProfil;
        public String PictureProfil { get => pictureProfil; set => pictureProfil = value; }

        private Calendar theCalendar;
        public Calendar TheCalendar { get => theCalendar; set => theCalendar = value; }

        private List<Account> theContacts;
        public List<Account> TheContacts { get => theContacts; set => theContacts = value; }

        public Account()
        {

        }

        public Account(string mail, string password, string name, string firstName, string phone_pro, string service, string secretQuestion, string secretAnswer, string pictureProfil, Calendar theCalendar, List<Account> theContacts)
        {
            this.mail = mail;
            this.password = password;
            this.name = name;
            this.firstName = firstName;
            this.phone_pro = phone_pro;
            this.service = service;
            this.secretQuestion = secretQuestion;
            this.secretAnswer = secretAnswer;
            this.pictureProfil = pictureProfil;
            this.theCalendar = theCalendar;
            this.theContacts = theContacts;
        }

        public void addContact(Account acc)
        {
            theContacts.Add(acc);
        }

        public void removeContact(Account theAccToDelete)
        {
            Account contactToRemove = null;
            foreach (Account acc in theContacts)
            {
                if (acc.Mail.Equals(theAccToDelete.Mail))
                {
                    contactToRemove = acc;
                }
            }
            theContacts.Remove(contactToRemove);
        }

        public override string ToString()
        {
            return this.mail + " : " + this.name + " : " + this.firstName;
        }
    }
}
