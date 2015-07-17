using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

using Elern.Model.User;
using System.ComponentModel.DataAnnotations;

namespace Elern.Model.Institute
{
    class Subjects : BaseClass
    {
        [Key]
        public long subjectid { get; set; }
        [Required]
        [Display(Name = "Package")]
        public virtual Package Packageid { get; set; }
        [Required]
        public string Subject { get; set; }
        public string Introduction { get; set; }
        public int sequence { get; set; }

    }
}
