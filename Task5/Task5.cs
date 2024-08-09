using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace m2w1d4.Task5
{
    public class Task5
    {
        public void DateTimeShow()
        {
            DateTime today = DateTime.Now;
            string formatDate = today.ToString("dd/MM/yyyy");
            Console.WriteLine(formatDate);
        }
    }
}
