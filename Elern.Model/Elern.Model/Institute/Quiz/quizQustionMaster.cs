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
        public string required { get; set; }
        public int sequence { get; set; }
        public long quizid { get; set; }


    }
}
