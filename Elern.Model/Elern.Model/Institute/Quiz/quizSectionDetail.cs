using Elern.Model.User;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Elern.Model.Institute.Quiz
{
    class quizSectionDetail : BaseClass
    {
        public virtual quizMaster id { get; set; }
        public virtual quizSection  id { get; set; }
        public virtual QustionBankMaster id { get; set; }
        public QuizGenratorType quizgenrationType { get; set; }
    }

    enum QuizGenratorType{
        Random=1,
        Selective=2,
        AlogrithemType=3
    }
}
