using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace m2w1d4.Task4
{
    public class Task4
    {
        public void Methodstring() 
        {
            string text1 = "HelloWorld";
            Console.WriteLine(text1);
            string text2="J"+text1.Substring(1);
            Console.WriteLine(text2);
        }
        public void MethodStringBuilder()
        {
            StringBuilder sb = new StringBuilder("HelloWorld");
            sb[0] = 'J';
            Console.WriteLine(sb.ToString());
        }
    }
}
