//------------------------------------------------------------------------------
// 警告:
//     该代码由T4工具根据模板自动生成,直接在该代码上进行任何修改都将在重新生成后丢失!
//     如有需要应使用partial class或是继承该类进行自定义扩展。
//------------------------------------------------------------------------------
using System;
using System.Collections.Generic;
using  Common.DataEntity;

namespace Data.Entities
{	
	/// <summary>
	/// 实体-T_filter_rule_configuration 
	/// </summary>
	
	public partial class T_filter_rule_configuration : Entity    
	{	
		/// <summary>  
        ///   
        /// </summary>

		public long ID { get; set; }  
		/// <summary>  
        /// 关键字  
        /// </summary>

		public string Filter_KeyWord { get; set; }  
		/// <summary>  
        /// 筛选类型: 100:包含 200:开头 300:结尾  
        /// </summary>

		public int Filter_Type { get; set; }  
		/// <summary>  
        /// 筛选位置: 100:网站标题 200:网站链接  
        /// </summary>

		public int Filter_Position { get; set; }  
		/// <summary>  
        /// 创建时间  
        /// </summary>

		public DateTime create_time { get; set; }  
		/// <summary>  
        ///   
        /// </summary>

		public int is_erased { get; set; }  
		
	}
}
	
