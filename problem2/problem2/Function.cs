using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace problem2
{
    class Function
    {
        public bool check(char x)
        {
            if(x=='a' || x=='A')
            {
                return true;
            }
            else
            {
                return false;
            }
        }
        
        public int checkChar(string s1)
        {
            int cnt = 0;
           
            foreach(Char x in s1)
            {
                if(x == 'a' || x == 'A')
                {
                    cnt++;
                }
            }
            
        
            return cnt;
        }


    }
}
