using System.Collections.Generic;

namespace AsgSearch.web.Classes
{
    public interface IGoogleSearch
    {
        IEnumerable<string> Search(string strText);
    }
}