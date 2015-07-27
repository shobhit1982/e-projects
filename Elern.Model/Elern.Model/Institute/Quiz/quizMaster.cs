using Elern.Model.Common;
using Elern.Model;
using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Elern.Model.User;

namespace Elern.Model
{
    // this is common table for all , Course ,Quiz ,saurvey master infomation
    class quizMaster : BaseClass
    {
        [Required]
        public string Title { get; set; }
        public string Description { get; set; }
        //which type student is trageted
        public string targetstudent { get; set; }

        //public virtual PackageCategory id { get; set; }
       // public virtual PackageSubCategory id { get; set;}
                

        public string logo {get; set;}

        public virtual Users id {get;set;}
        //this id is represent type(create Course/Quize etc)
        //public virtual MainMenu menuTypeid {get;set;}
        public string Embbeded {get; set; }
        public string links {get; set;}

        // Details
        // public bool quitResume { get; set; }     // if False means you cannot not quit the exam onces enter OR True then you can leave the exam(save the progess) and resume from the same.
        //public Boolean TimeBase { get; set; }
       // public int timeInhour { get; set; }
        //public int timeInMinute { get; set; }
        public string InstructionFirst { get; set; }
        public string InstructionSecond { get; set; }
        //public int setNo { get; set; }
        //public string SeriesNo { get; set; }
        
    }
}
