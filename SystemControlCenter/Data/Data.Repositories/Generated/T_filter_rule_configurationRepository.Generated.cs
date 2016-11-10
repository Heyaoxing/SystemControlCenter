//------------------------------------------------------------------------------
// 警告:
//     该代码由T4工具根据模板自动生成,直接在该代码上进行任何修改都将在重新生成后丢失!
//     如有需要应使用partial class或是继承该类进行自定义扩展。
//------------------------------------------------------------------------------
using System;
using  Common.Repository;
using  Common.DataEntity;
using MySqlSugar;
using MySql.Data.MySqlClient;
using Data.Entities;
	
namespace Data.Repositories
{   
	public partial class T_filter_rule_configurationRepository : Repository<T_filter_rule_configuration>, IT_filter_rule_configurationRepository
	{		
		public T_filter_rule_configurationRepository() : base(MySugarDao.GetInstance())
	    {
	    }
	}
}
	
