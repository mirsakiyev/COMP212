using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Text.RegularExpressions;
using System.Threading.Tasks;

namespace COMP212_Week11
{
    public static class StringExtension
    {
        public static string CapitalizeFirstCharacter(this string strPara)
        {
            StringBuilder capitalizedString = new StringBuilder();

            string[] allWords = strPara.Split(null);
            foreach (string item in allWords)
            {
                capitalizedString.Append(Regex.Replace(item, @"^\w", m => m.Value.ToUpper()) + " ");
            }
            return capitalizedString.ToString();
        }
    }
}
