using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Elern.Model.User
{
    class BaseClass
    {
        [Key]
        public long Id { get; set; }
        public bool Isdeleted { get; set; }
        public DateTime CreatedDt { get; set; }
        public DateTime UpdatedDt { get; set; }
        public virtual Users id { get; set; }
    }

    
}
