using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Elern.Model.Institute.Quiz
{
    class quizAnswer : BaseClass
    {
        public string choice { get; set; }
        public bool correctYN { get; set; }
        public virtual quizQustionMaster id { get; set; }
        public string image { get; set; }
        public string matched { get; set; }

    }
}
