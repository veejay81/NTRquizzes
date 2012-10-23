using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Text;

namespace NTRsearch.DAL
{
    [Table("queries")]
    public class Query
    {
        [Key]
        public int ID { get; set; }
        public virtual string QueryText { get; set; }
        public virtual DateTime Time { get; set; }

        // HINT: For step 2 you'll need  to uncomment this
        //public virtual string FirstResult { get; set; }

    }
    
}
