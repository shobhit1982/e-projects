using Elern.Model.User;
using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Elern.Model.Common
{
    class PackageSubCategory :  BaseClass
    {
        [Key]
        public long SubCategoryId { get; set; }
        [Required]
        [Display(Name = "Category")]
        public virtual PackageCategory CategoryId { get; set; }
        [Required]
        [Display(Name = "Sub Category")]
        public string SubCategory { get; set; }
    }
}
