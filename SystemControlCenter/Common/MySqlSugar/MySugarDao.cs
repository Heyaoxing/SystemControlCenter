using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MySqlSugar
{
    public class MySugarDao
    {
        private MySugarDao()
        {

        }
        public static SqlSugarClient GetInstance()
        {
            string connection = System.Configuration.ConfigurationManager.AppSettings[@"MySqlConnection"]; //这里可以动态根据cookies或session实现多库切换
            return new SqlSugarClient(connection);
        }
    }
}
