using Elern.Model;
using Elern.Model.Common;
using Elern.Model.User;
using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Elern.Model
{
    class PackageSubCategory :  BaseClass
    {
        
        [Required]
        [Display(Name = "Category")]
        public virtual PackageCategory Id { get; set; }
        [Required]
        [Display(Name = "Sub Category")]
        public string SubCategory { get; set; }


    }
}
