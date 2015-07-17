using Elern.Model.Common;
using Elern.Model.User;
using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Elern.Model.Institute
{
    class Package : BaseClass
    {
        [Key]
        public long Packageid { get; set; }          // eg 1
        [Required]
        public string PackageName { get; set; }      // 

        // User Can be Tutor or Institute --- Student Cann't make Pakages
        [Required]
        public virtual Users UserId { get; set; }
        
        // For search
        [Required]
        [Display(Name = "Category")]
        public virtual PackageCategory CategoryId { get; set; }
        [Required]
        [Display(Name = "Sub Category")]
        public virtual PackageSubCategory SubCategoryId { get; set; }

        // Package Details
        [Display(Name="Description")]
        public string packdesp { get; set; }
        [Display(Name = "Picture/Logo")]
        public string Photo { get; set; }
        [Display(Name = "Level")]
        public Level level { get; set; }
        public double fee { get; set; }
        [Display(Name="Time To Completion")]
        public string Ttf { get; set; }
        [Display(Name = "Per day Effort")]
        public string Effort { set; get; }

        // Package Details
        [Display(Name = "About Package")]
        public string aboutPackage { get; set; }
        [Display(Name = "Advantages Of Package")]
        public string Advantages { get; set; }
        [Display(Name = "Kay Features")]
        public string KeyFeatures {get;set;}
        [Display(Name = "Prapared For Exam.")]
        public string preparedfor { get; set; }
        public string FQA { get; set; }


    }

    public enum Level
    {
        Beginner = 1,
        Intermediate = 2,
        Advanced=3
    }
        
}
