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
	/// 实体-Departmentinfo 
	/// </summary>
	public partial class Departmentinfo : Entity    
	{	
		/// <summary>  
        /// 部门表主键  
        /// </summary>
		public int DepartmentId { get; set; }  

		/// <summary>  
        /// 父级部门  
        /// </summary>
		public int ParentId { get; set; }  

		/// <summary>  
        /// 名称  
        /// </summary>
		public string Name { get; set; }  

		/// <summary>  
        /// 部门地址  
        /// </summary>
		public string Address { get; set; }  

		/// <summary>  
        /// 排序  
        /// </summary>
		public int Sort { get; set; }  

		/// <summary>  
        /// 备注  
        /// </summary>
		public string Remark { get; set; }  

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
	
