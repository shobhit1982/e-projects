using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Elern.Model
{
    class Layout : BaseClass
    {
        public string LayoutName{ get; set; }
        public string  Embbed { get; set; }
        public virtual PageType Id{ get; set; }//PageType Id like(Text Page/DocomentPage/Video/Audio) 
        public string LayoutType  { get; set; }//Chapter/Page Lavel
    }
}
