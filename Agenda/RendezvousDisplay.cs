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
    public partial class RendezvousDisplay : Form
    {
        private bool editMode;
        private Rendezvous leRendezvous;
        private Account theAccount;
        private int dayClicked;
        private int theMonth;
        private int theYear;
        private Main mainWindow;

        public RendezvousDisplay(Main mainWindow, Rendezvous leRendezvous, Account theAccount)
        {
            InitializeComponent();
            editMode = true;
            theMonth = leRendezvous.StartDate.Month;
            theYear = leRendezvous.StartDate.Year;

            this.leRendezvous = leRendezvous;
            this.theAccount = theAccount;
            this.mainWindow = mainWindow;

            this.textBoxTitle.Text = leRendezvous.Title;
            this.startDateTimePicker.Value = leRendezvous.StartDate;
            this.endDateTimePicker.Value = leRendezvous.EndDate;
            this.textBoxComment.Text = leRendezvous.Comment;
        }

        public RendezvousDisplay(Main mainWindow, int dayClicked, Account theAccount, int theMonth, int theYear)
        {
            InitializeComponent();
            editMode = false;
            this.buttonDelete.Enabled = false;
            
            this.theAccount = theAccount;
            this.dayClicked = dayClicked;
            this.theMonth = theMonth;
            this.theYear = theYear;
            this.mainWindow = mainWindow;

            this.startDateTimePicker.Value = new DateTime(theYear, theMonth, dayClicked);
            this.endDateTimePicker.Value = this.startDateTimePicker.Value.AddDays(1);
        }



        private void buttonSubmit_Click(object sender, EventArgs e)
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

            bool isPossible = true;

            TimeSpan diff = this.endDateTimePicker.Value - this.startDateTimePicker.Value;
            int diffDays = (int)diff.TotalDays;
            List<DateTime> listDaysTaken = theAccount.TheCalendar.getListTakenDays();
            if (editMode)
            {
                foreach (DateTime dt in leRendezvous.getListDays())
                {
                    listDaysTaken.Remove(dt);
                }
            }


            for (int i = 0; i < diffDays; i++)
            {
                if (listDaysTaken.Contains(this.startDateTimePicker.Value.AddDays(i)))
                {
                    isPossible = false;
                }
            }


            if (this.textBoxTitle.Text.Equals(""))
            {
                MessageBox.Show("Veuillez mettre un intitulé.");
            }
            else if (!isPossible)
            {
                MessageBox.Show("Modification impossible, un autre rendez-vous est en conflit!");
            }
            else
            {
                if (editMode)
                {
                    leRendezvous.Title = this.textBoxTitle.Text;
                    leRendezvous.StartDate = this.startDateTimePicker.Value;
                    leRendezvous.EndDate = this.endDateTimePicker.Value;
                    leRendezvous.Comment = this.textBoxComment.Text;
                    leRendezvous.IsVacation = this.vacationCheckBox.Checked;
                }
                else
                {
                    theAccount.TheCalendar.createRendezvous(this.textBoxTitle.Text, this.startDateTimePicker.Value, this.endDateTimePicker.Value, this.textBoxComment.Text, this.vacationCheckBox.Checked);
                }
                mainWindow.clearCalendar();
                mainWindow.createCalendar(theMonth, theYear, 101, 74);
                this.Hide();

            }
            userlogs.Add(theAccount);
            Inscription.WriteXML(userlogs);
        }

        private void buttonDelete_Click(object sender, EventArgs e)
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
            this.Hide();

            theAccount.TheCalendar.TheRendezvous.Remove(leRendezvous);
            mainWindow.clearCalendar();
            mainWindow.createCalendar(theMonth, theYear, 101, 74);


            userlogs.Add(theAccount);
            Inscription.WriteXML(userlogs);
        }
    }
}
