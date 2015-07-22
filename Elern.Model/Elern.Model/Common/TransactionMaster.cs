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
    // this is common table for all , Course ,Quiz ,saurvey master infomation
    class TransactionMaster : BaseClass
    {
        [Required]
        public string Title { get; set; }
        public string Description { get; set; }
        //which type student is trageted
        public string targetstudent { get; set; }

        public virtual PackageCategory id { get; set; }
        public virtual PackageSubCategory id { get; set;}
        public string logo {get; set;}

        public virtual Users id {get;set;}
        //this id is represent type(create Course/Quize etc)
        public virtual MainMenu menuTypeid {get;set;}
        public string Embbeded {get; set; }
        public string links {get; set;}
        
    }
}
