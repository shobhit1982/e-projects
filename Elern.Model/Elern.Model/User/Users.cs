using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.ComponentModel.DataAnnotations;

namespace Elern.Model.User
{
    class Users : BaseClass
    {
        //common information
        [Key]
        public long UserId { get; set; }
        [Required]
        public string Name { get; set; }
        [Required]
        public DateTime DOB { get; set; }
        [Required]
        public Gender Gender { get; set; }
        public string Address { get; set; }
        public string City { get; set; }
        public string State { get; set; }
        public string Country { get; set; }
        public string Pin { get; set; }

        [Required]
        [Display(Name="Type")]
        public UserType usertype { get; set; }
        [Required]
        [Display(Name = "MemberShip")]
        public Membership MemberType { get; set; }
        [Required]
        public string Email { get; set; }
        public string PhoneNo { get; set; }
        [Required]
        public string MobileNo  { get; set; }

        // For student
        [Display(Name = "Highest Edu. Level")]
        public string htLevelEdu { get; set; }
        [Display(Name = "Field of Interest")]
        public string IntrestedIn { get; set; }


        //For Institute / Tutor
        public string FullName { get; set; }
        public string AboutSelf { get; set; }
        public string ExpertIn { get; set; }
        public string CoureOffered { get; set; }
        public string OurAchievement { get; set; }
        public string WhyWe { get; set; }


    }

    public enum Membership
    {
        Paid = 1,
        UnPaid = 2
    }

    public enum Gender
    {
        Male = 1,
        Female = 2
    }

    public enum UserType
    {
        Administrator = 1,
        Institute = 2,
        student = 3       
    }
}
