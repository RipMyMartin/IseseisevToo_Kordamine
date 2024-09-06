using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace IseseisevToo_Kordamine.Variant7
{
    internal class BoolTextFunc
    {
        /*Определите, присутствует ли в тексте, 
        заданном в виде строки, некоторое слово 
        (различие регистра игнорируйте).*/
        public static bool IsAttend(String str, string wrd)
        {
            wrd = wrd.ToLower();
            str= str.ToLower();
            return str.Contains(wrd) ? true : false;
        }
    }
}
    