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
	/// 实体-Personinfo 
	/// </summary>
	public partial class Personinfo : Entity    
	{	
		/// <summary>  
        /// 人员表主键  
        /// </summary>
		public int PersonId { get; set; }  

		/// <summary>  
        /// 部门表主键  
        /// </summary>
		public int? DepartmentId { get; set; }  

		/// <summary>  
        /// 帐号  
        /// </summary>
		public string Account { get; set; }  

		/// <summary>  
        /// 昵称  
        /// </summary>
		public string nickname { get; set; }  

		/// <summary>  
        /// 姓名  
        /// </summary>
		public string Name { get; set; }  

		/// <summary>  
        /// 密码  
        /// </summary>
		public string Password { get; set; }  

		/// <summary>  
        /// 性别  
        /// </summary>
		public bool? Sex { get; set; }  

		/// <summary>  
        /// 职位  
        /// </summary>
		public string Position { get; set; }  

		/// <summary>  
        /// 手机号码  
        /// </summary>
		public string MobilePhoneNumber { get; set; }  

		/// <summary>  
        /// 办公电话  
        /// </summary>
		public string PhoneNumber { get; set; }  

		/// <summary>  
        /// 省  
        /// </summary>
		public string Province { get; set; }  

		/// <summary>  
        /// 市  
        /// </summary>
		public string City { get; set; }  

		/// <summary>  
        /// 县  
        /// </summary>
		public string Village { get; set; }  

		/// <summary>  
        /// 联系地址  
        /// </summary>
		public string Address { get; set; }  

		/// <summary>  
        /// 邮箱  
        /// </summary>
		public string EmailAddress { get; set; }  

		/// <summary>  
        /// 备注  
        /// </summary>
		public string Remark { get; set; }  

		/// <summary>  
        /// 状态 100:禁用 200:启用  
        /// </summary>
		public int? Status { get; set; }  

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

		/// <summary>  
        /// 头像  
        /// </summary>
		public string HDpic { get; set; }  

		
	}
}
	
