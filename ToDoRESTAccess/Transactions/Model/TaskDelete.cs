// ALLOWOVERWRITE-22551366DF98A9E4DD5EE21B5E3A0E92

using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.Serialization;


namespace ToDo.Transactions.Model
{
	[DataContract]
    public class TaskDelete
    {
    	
    	
    	/// <summary>
        /// 
        /// </summary>
		 [DataMember(Name = "taskId")]         
    	public int  TaskId  { get; set; } 
    	
    }
}