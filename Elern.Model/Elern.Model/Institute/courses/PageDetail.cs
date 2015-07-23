using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Elern.Model
{
    class PageDetail :BaseClass
    {
        public virtual chapter id { get; set; }
        public long PageNo{ get; set; }
        public string  PageTitle{ get; set; }
        public string  PageContent{ get; set; }
        //this field use for only text page with image
        public string ImagePath { get; set; }
        public string UploadFilePath { get; set; }
        public string uploadType{ get; set; }

        public virtual quizMaster id { get; set; }


    }
}
