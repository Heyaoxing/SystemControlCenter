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
	/// 实体-Roleinfo 
	/// </summary>
	public partial class Roleinfo : Entity    
	{	
		/// <summary>  
        /// 角色主键  
        /// </summary>
		public int Id { get; set; }  

		/// <summary>  
        /// 应用表主键  
        /// </summary>
		public int? ApplicationId { get; set; }  

		/// <summary>  
        /// 菜单角色主键  
        /// </summary>
		public int? MenuRoleId { get; set; }  

		/// <summary>  
        /// 名称  
        /// </summary>
		public string Name { get; set; }  

		/// <summary>  
        /// 状态 0:禁用 1:启用  
        /// </summary>
		public bool Status { get; set; }  

		/// <summary>  
        /// 描述  
        /// </summary>
		public string Description { get; set; }  

		/// <summary>  
        /// 创建时间  
        /// </summary>
		public DateTime CreatedOn { get; set; }  

		/// <summary>  
        /// 创建人  
        /// </summary>
		public string CreatedBy { get; set; }  

		/// <summary>  
        /// 编辑时间  
        /// </summary>
		public DateTime UpdatedOn { get; set; }  

		/// <summary>  
        /// 编辑人  
        /// </summary>
		public string UpdatedBy { get; set; }  

		
	}
}
	
