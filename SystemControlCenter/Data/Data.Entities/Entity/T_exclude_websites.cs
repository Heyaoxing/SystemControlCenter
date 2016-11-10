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
	/// 实体-T_exclude_websites 
	/// </summary>
	
	public partial class T_exclude_websites : Entity    
	{	
		/// <summary>  
        ///   
        /// </summary>

		public long ID { get; set; }  
		/// <summary>  
        /// 资源平台名字  
        /// </summary>

		public string WebSite_Name { get; set; }  
		/// <summary>  
        /// 主域网址  
        /// </summary>

		public string WebSite_Url { get; set; }  
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
	
