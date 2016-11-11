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
	/// 实体-Menuoperationrelation 
	/// </summary>
	public partial class Menuoperationrelation : Entity    
	{	
		/// <summary>  
        /// 主键  
        /// </summary>
		public int id { get; set; }  

		/// <summary>  
        /// 操作主键  
        /// </summary>
		public int? OperationId { get; set; }  

		/// <summary>  
        /// 菜单主键  
        /// </summary>
		public int? MenuId { get; set; }  

		
	}
}
	
