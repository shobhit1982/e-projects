using Elern.Model.User;
using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Elern.Model
{
    class MainMenu : BaseClass
    {
        
        [Required]
        public string packageName { get; set; }
        public string logo { get; set; }
        public string links { get; set; }
    }

    // Package Name like  :- Course , Test , Polls ,sarvey
}
