using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace m2w1d4.Task6
{
    public class Task6
    {
        public void DateTimeShow()
        {
            DateTime today = DateTime.Now;
            DateTime AddDays = today.AddDays(10);
            string formatDate = AddDays.ToString("dd/MM/yyyy");
            Console.WriteLine(formatDate);
        }
    }
}
