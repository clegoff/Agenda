using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Agenda
{
    [Serializable()]
    public class Rendezvous
    {
        private String title;
        public string Title { get => title; set => title = value; }

        private DateTime startDate;
        public DateTime StartDate { get => startDate; set => startDate = value; }

        private DateTime endDate;
        public DateTime EndDate { get => endDate; set => endDate = value; }

        private String comment;
        public string Comment { get => comment; set => comment = value; }

        private bool isVacation;
        public bool IsVacation { get => isVacation; set => isVacation = value; }

        public Rendezvous()
        {

        }

        public Rendezvous(String title, DateTime startDate, DateTime endDate, String comment, bool isVacation)
        {
            this.title = title;
            this.startDate = startDate;
            this.endDate = endDate;
            this.comment = comment;
            this.isVacation = isVacation;
        }

        public List<DateTime> getListDays()
        {
            List<DateTime> ret = new List<DateTime>();
            TimeSpan diff = endDate - startDate;
            int diffDays = (int)diff.TotalDays;
            for (int i = 0; i <= diffDays; i++)
            {
                ret.Add(startDate.AddDays(i));
            }

            return ret;
        }

        public override string ToString()
        {
            return title + " : " + startDate + " : " + endDate + " : " + comment;
        }
    }
}