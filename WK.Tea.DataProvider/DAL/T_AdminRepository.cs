using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using WK.Tea.DataModel.SqlModel;
using WK.Tea.DataProvider.IDAL;

namespace WK.Tea.DataProvider.DAL
{
    public class T_AdminRepository : BaseRepository<TeaDbContext, T_Admin>, IT_Admin
    {
        public bool CheckUserAndPwd(string account, string pwd)
        {
            return context.T_Admin.Any(o => o.UserAccount == account && o.UserPw == pwd);
        }
    }
}
