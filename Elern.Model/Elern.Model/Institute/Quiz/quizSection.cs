using Elern.Model.User;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Elern.Model.Institute.Quiz
{
    class quizSection : BaseClass
    {
        public virtual quizMaster id { get; set; }
        public String  sectionDetail { get; set; }
        public String image { get; set; }
        public int NoOfQuestion { get; set; }
        public int sequence { get; set; }

    }
}
