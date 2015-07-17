using Elern.Model.User;
using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Elern.Model.Institute
{
    class SubjectContent : BaseClass
    {
        [Key]
        public long contentid { get; set; }
        [Display(Name="subject")]
        public virtual Subjects subjectid { get; set; }
        public int sequence { get; set; }
        public string content { get; set; }
        public string contentInto { get; set; }
        public string contentTextLink { get; set; }
        public string contentAudioLink { get; set; }
        public string contentVedio { get; set; }
        public string contentOther { get; set; }

    }
}
