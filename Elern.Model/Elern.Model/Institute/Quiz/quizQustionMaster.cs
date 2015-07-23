using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Elern.Model.Institute.Quiz
{
    class quizQustionMaster : BaseClass
    {
        public string QuestionDetail { get; set; }
        public string QuestionImage { get; set; }
        public string typeId { get; set; }  // Question format id eg : optionalid ,Truefalseid , Multiplechose 
        public string Grade { get; set; }
        public string required { get; set; }   // either this question is  compulsory or not
        public int sequence { get; set; }
        public virtual quizMaster id { get; set; }
        public string tag { get; set; }

    }
}
