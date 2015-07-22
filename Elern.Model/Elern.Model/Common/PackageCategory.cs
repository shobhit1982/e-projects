using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Elern.Model.User;
using System.ComponentModel.DataAnnotations;

namespace Elern.Model.Common
{
    class PackageCategory
    {
        [Required]
        [Display(Name = "Category")]
        public long CategoryName { get; set; }

        // Acdmices,Comptition,Profesional
    }
}
