using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Agenda
{
    [Serializable()]
    public class Calendar
    {
        private Account theAccount;
        public Account TheAccount { get => theAccount; set => theAccount = value; }

        private List<Rendezvous> theRendezvous;
        public List<Rendezvous> TheRendezvous { get => theRendezvous; set => theRendezvous = value; }

        public Calendar()
        {

        }

        public Calendar(Account theAccount, List<Rendezvous> theRendezvous)
        {
            this.theAccount = theAccount;
            this.theRendezvous = theRendezvous;
        }

        public void createRendezvous(String title, DateTime start, DateTime end, String comment, bool isVacation)
        {
            theRendezvous.Add(new Rendezvous(title, start, end, comment, isVacation));
        }

        public Rendezvous getARendezvous(DateTime theDate)
        {
            foreach (Rendezvous rv in theRendezvous)
            {
                if (theDate.Ticks >= rv.StartDate.Ticks && theDate.Ticks <= rv.EndDate.Ticks)
                {
                    return rv;
                }
            }
            return null;
        }

        public bool testIfDayIsTaken(DateTime theDate)
        {
            foreach (Rendezvous rv in theRendezvous)
            {
                if (theDate.Ticks >= rv.StartDate.Ticks && theDate.Ticks <= rv.EndDate.Ticks)
                {
                    return true;
                }
            }
            return false;
        }

        public override string ToString()
        {
            String ret = "";
            foreach (Rendezvous rv in theRendezvous)
            {
                ret += rv + "\n";
            }
            return ret;
        }

        public List<DateTime> getListTakenDays()
        {
            List<DateTime> ret = new List<DateTime>();

            foreach (Rendezvous rv in theRendezvous)
            {
                TimeSpan diff = rv.EndDate - rv.StartDate;
                int diffDays = (int)diff.TotalDays;
                for (int i = 0; i <= diffDays; i++)
                {
                    ret.Add(rv.StartDate.AddDays(i));
                }
            }

            return ret;
        }
    }
}