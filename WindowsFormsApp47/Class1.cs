using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace WindowsFormsApp47
{
   public class cMath
    {
        public int x;
        public int y;

        public void swap()
        {
            int temp = x;
            x = y;
            y = temp;
        }

        public double cal(char c)
        {
            switch (c)
            {
                case '+':
                    return x + y;
                case '-':
                    return x - y;
                case '*':
                    return x * y;
                case '/':
                    return (double)x / y;
                default:
                    return 0;
            }
        }
    }
}
