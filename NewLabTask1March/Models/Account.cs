using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace NewLabTask1March.Models
{
    internal class Account
    {
        public bool PasswordChecker(string password)
        {
            bool checked1 = true;
            bool checked2 = true;
            bool checked3 = true;
            bool checked4 = true;
            bool allChecked = true;
            if (password.Length>=8)
            {
                checked1 = true;
            }
            char[] chars = password.ToCharArray();
            foreach (char c in chars)
            {
                if (char.IsUpper(c))
                {
                    checked2 = true;
                    break;
                }
                else
                {
                    checked2 = false;
                    return false;
                }

                if (char.IsLower(c))
                {
                    checked3 = true;
                    break;
                }
                else
                {
                    checked3 = false;
                    break;
                }
                if (char.IsNumber(c))
                {
                    checked4 = true;
                }
                else
                {
                    checked4 = false;
                }
                

              
            }

            if (checked1&& checked2 && checked3  && checked4 )
            {
                return allChecked = true;
            }
            else
            {
                return allChecked = false;
            }
            return allChecked;
             
            


        }
    }
}
