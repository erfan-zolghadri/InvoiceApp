using System.Collections.Generic;

namespace InvoiceApp.BLL
{
    public class DateTimeFormatter
    {
        public string GetDateFormat(string year,
            string month,
            string day)
        {
            return string.Format("{0}/{1}/{2}", year, month, day);
        }

        public string GetTimeFormat(string hour, string minute)
        {
            return string.Format("{0}:{1}", hour, minute);
        }

        public string[] GetDateComponents(string date)
        {
            var dateComponents = date.Split('/');

            return dateComponents;
        }
        
        public string[] GetTimeComponents(string time)
        {
            var timeComponents = time.Split(':');

            return timeComponents;
        }
    }
}
