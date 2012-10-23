using System.Collections.Generic;

namespace NTRsearch.web.Classes
{
    public interface IGoogleSearch
    {
        IEnumerable<string> Search(string strText);
    }
}