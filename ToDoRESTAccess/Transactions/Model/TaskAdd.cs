// ALLOWOVERWRITE-488257380DDA0800B4F98739F160B1BB

using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.Serialization;



namespace ToDo.Transactions.Model
{

	[DataContract]
    public class TaskAdd
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
    	   	
    	
    	/// <summary>
        /// 
        /// </summary>	
        [DataMember(Name = "userUserId")] 
    	public int UserUserId { get; set; } 
    }    	    	
}



