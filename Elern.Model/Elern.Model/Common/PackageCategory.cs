using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Elern.Model.User;
using System.ComponentModel.DataAnnotations;

namespace Elern.Model.Common
{
    class PackageCategory: BaseClass
    {
        [Key]
        public long CategoryId { get; set; }
        [Required]
        [Display(Name = "Category")]
    }
}
