using Elern.Model.User;
using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Elern.Model
{
    class chapter : BaseClass
    {
        public string ChapterTitle { get; set; }
        public string ChapterDescription { get; set; }
       
        public string logo { get; set; }

        public virtual Users id { get; set; }
       
        public virtual TransactionMaster Id { get; set; }
        public string Embbeded { get; set; }
        public string links { get; set; }
        public int layputId { get; set; }
    }
}
