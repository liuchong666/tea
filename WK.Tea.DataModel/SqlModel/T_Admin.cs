using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace WK.Tea.DataModel.SqlModel
{
    public partial class T_Admin
    {
        [Key]
        public string UserAccount { get; set; }
        public string UserPw { get; set; }
        public System.DateTime CTime { get; set; }
        public System.DateTime LTime { get; set; }
    }
}
