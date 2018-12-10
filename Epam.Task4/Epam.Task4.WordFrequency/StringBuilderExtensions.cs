using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Epam.Task4.WordFrequency
{
    public static class StringBuilderExtensions
    {
        public static string SubString(this StringBuilder sb, int indexStart, int indexFinish)
        {
            var newSb = new StringBuilder();
            for (int i = indexStart; i < indexFinish; i++)
            {
                newSb.Append(sb[i]);
            }
            return newSb.ToString();
        }
    }
}
