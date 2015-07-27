using Elern.Model.User;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;


namespace Elern.Model.Institute.Quiz
{
    class ResultType : BaseClass
    {
        public int typeid { get; set; }        // 1 : Pass or Fail   2:Letter Grading 3:Good or Excellent 4:Custom 
        public string typeText { get; set; }   // wright Grade : A , B , C, D,GOOD,EXCELLENT etc 
        public double MinMarks { get; set; }   // in %
        public double MaxMarks { get; set; }   // in %

    }
}
