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
	/// 实体-Rolepersonrelation 
	/// </summary>
	public partial class Rolepersonrelation : Entity    
	{	
		/// <summary>  
        /// id  
        /// </summary>
		public int id { get; set; }  

		/// <summary>  
        /// 人员表主键  
        /// </summary>
		public int? PersonId { get; set; }  

		/// <summary>  
        /// 角色_角色主键  
        /// </summary>
		public int? Rol_Id { get; set; }  

		
	}
}
	
