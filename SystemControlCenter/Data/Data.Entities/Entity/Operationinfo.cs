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
	/// 实体-Operationinfo 
	/// </summary>
	public partial class Operationinfo : Entity    
	{	
		/// <summary>  
        /// 操作主键  
        /// </summary>
		public int OperationId { get; set; }  

		/// <summary>  
        /// 名称  
        /// </summary>
		public string Name { get; set; }  

		/// <summary>  
        /// 控制器名称  
        /// </summary>
		public string ControllerName { get; set; }  

		/// <summary>  
        /// 方法名称  
        /// </summary>
		public string Function { get; set; }  

		/// <summary>  
        /// 备注  
        /// </summary>
		public string Remark { get; set; }  

		/// <summary>  
        /// 状态 0:禁用 1:启用  
        /// </summary>
		public bool Status { get; set; }  

		/// <summary>  
        /// 创建时间  
        /// </summary>
		public DateTime CreatedOn { get; set; }  

		/// <summary>  
        /// 创建人  
        /// </summary>
		public string CreatedBy { get; set; }  

		
	}
}
	
