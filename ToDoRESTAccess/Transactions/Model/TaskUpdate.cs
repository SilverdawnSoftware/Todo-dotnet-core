// ALLOWOVERWRITE-3D04B17B60439A09C24DF5BD0E05FF54

using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.Serialization;


namespace ToDo.Transactions.Model
{
	[DataContract]
    public class TaskUpdate
    {
	    		
	    		/// <summary>
                /// 
                /// </summary>
				 [DataMember(Name = "completedDate")]                 
	    		public DateTime CompletedDate  { get; set; } 
	    		
	    		/// <summary>
                /// 
                /// </summary>
				 [DataMember(Name = "dueDate")]                 
	    		public DateTime DueDate  { get; set; } 
	    		
	    		/// <summary>
                /// 
                /// </summary>
				 [DataMember(Name = "name")]                 
	    		public string Name  { get; set; } 
	    		
	    		/// <summary>
                /// 
                /// </summary>
				 [DataMember(Name = "startedDate")]                 
	    		public DateTime StartedDate  { get; set; } 
	    		
	    		/// <summary>
                /// 
                /// </summary>
				 [DataMember(Name = "status")]                 
	    		public int Status  { get; set; } 
	    		
	    		/// <summary>
                /// 
                /// </summary>
				 [DataMember(Name = "taskId")]                 
	    		public int TaskId  { get; set; } 
    	
    }
}

