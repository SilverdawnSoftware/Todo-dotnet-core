// ALLOWOVERWRITE-657B11CCBCEED467292F3C90F632A836

using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.Serialization;


namespace ToDo.Views.Model
{

	[DataContract]
    public class TaskView
    {
    
   
    
	    	
	    	
	    	/// <summary>
            /// 
            /// </summary>
			 [DataMember(Name = "completedDate")]            
	    	public DateTime  CompletedDate  { get; set; } 	    	
	    	
	    	
	    	/// <summary>
            /// 
            /// </summary>
			 [DataMember(Name = "dueDate")]            
	    	public DateTime  DueDate  { get; set; } 	    	
	    	
	    	
	    	/// <summary>
            /// 
            /// </summary>
			 [DataMember(Name = "name")]            
	    	public string  Name  { get; set; } 	    	
	    	
	    	
	    	/// <summary>
            /// 
            /// </summary>
			 [DataMember(Name = "startedDate")]            
	    	public DateTime  StartedDate  { get; set; } 	    	
	    	
	    	
	    	/// <summary>
            /// 
            /// </summary>
			 [DataMember(Name = "status")]            
	    	public int  Status  { get; set; } 	    	
	    	
	    	
	    	/// <summary>
            /// 
            /// </summary>
			 [DataMember(Name = "taskId")]            
	    	public int  TaskId  { get; set; } 	    	
    						  
					   /// <summary>
                      /// Reference of PrimaryKey for User
                      /// </summary>
                      [DataMember(Name = "userUserId")]
					  public  int UserUserId { get; set; }   
					  
					  /// <summary>
                      /// Reference to  User Email Property
                      /// </summary>
				      [DataMember(Name = "userEmail")]                      
					  public string UserEmail { get; set; }   
    	
    	
    	
    	
   
    }
}


