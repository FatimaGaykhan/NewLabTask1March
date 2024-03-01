using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace NewLabTask1March.Models
{
    internal class Student
    {
        public static int[] Gradies { get; set; }
        private static int[] PrivateGrades {
            get
            { 
                return Gradies;
            }
            set
            {
                int[] newArr = new int[0];

                foreach (var item in value)
                {
                    if (item % 2 == 0)
                    {
                        Array.Resize(ref newArr, newArr.Length + 1);
                        newArr[newArr.Length - 1]= item;
                    }
                }
                PrivateGrades = newArr;
               
            }
                }
    }
}
