using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Hospital.Data.CustomDataAnnotations
{
    public class DateRange : ValidationAttribute
    {
        private string StartDate { get; set; }
        private string EndDate { get; set; }

        public DateRange()
        {
            this.StartDate = DateTime.MinValue.ToShortDateString();
            this.EndDate = DateTime.Today.ToShortDateString();
        }

        public DateRange(string startDate)
        {
            this.StartDate = startDate;
            this.EndDate = DateTime.Today.ToShortDateString();
        }

        public DateRange(string startDate, string endDate)
        {
            this.StartDate = startDate;
            this.EndDate = endDate;
        }

        public override bool IsValid(object value)
        {
            DateTime dateTime;

            if (DateTime.TryParse(value.ToString(), out dateTime))
            {
                return (dateTime <= DateTime.Now);
            }

            return false;
        }
}
}
