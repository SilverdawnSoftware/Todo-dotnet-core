// ALLOWOVERWRITE-E1851D765CAE879BBE8CDE4AD4779B4A

using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.Serialization;


namespace ToDo.Transactions.Model
{
	[DataContract]
    public class UserDelete
    {
    	
    	
    	/// <summary>
        /// 
        /// </summary>
		 [DataMember(Name = "userId")]         
    	public int  UserId  { get; set; } 
    	
    }
}