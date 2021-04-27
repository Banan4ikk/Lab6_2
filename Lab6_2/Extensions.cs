using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Lab6_2
{
    public static class Extensions
    {
        public static string RemoveRussians(this string s)
        {
            var newString = new string(s.Where(c => !((c > 'а' && c < 'я') || (c > 'А' && c < 'Я'))).ToArray());// выбираем буквы  a-я или A-Я
            return newString;
        }
    }
}
