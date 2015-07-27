using Elern.Model.User;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Elern.Model.Institute.Quiz
{
    class QustionBankMaster : BaseClass
    {
        public string QuestionDetail { get; set; }
        public string QuestionImage { get; set; }
        public virtual QuestionType Id { get; set; }  // Question format id eg : optionalid ,Truefalseid , Multiplechose 
        public string Grade { get; set; }
        public string required { get; set; }   // either this question is  compulsory or not       
        public virtual quizMaster id { get; set; }
        public string tag { get; set; }
        public int  AssignMarks { get; set; }
        public  LevelType level { get; set; }
        public virtual PackageSubCategory id { get; set; }
    }


    enum LevelType
    {
        Beigniner = 1,
        Intermitade=2,
        Aadvanced=3
    
    }
}
