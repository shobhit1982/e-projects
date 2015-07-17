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
        
        public IsDeleted Isdeleted { get; set; }
        public DateTime CreatedDt { get; set; }
        public DateTime UpdatedDt { get; set; }
    }

    public enum IsDeleted
    {
        DeletedYes=1,
        DeletedNo=0
    }
}
