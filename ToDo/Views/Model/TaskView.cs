// ALLOWOVERWRITE-F90ED823CCF9DD0A462D79DEEAD53F06

using System;
using System.Collections.Generic;
using System.Linq;



namespace ToDo.Views.Model
{

    public class TaskView
    {
    
   
    
	    	
	    	
	    	/// <summary>
            /// 
            /// </summary>	
	    	public DateTime  CompletedDate  { get; set; } 	    	
	    	
	    	
	    	/// <summary>
            /// 
            /// </summary>	
	    	public DateTime  DueDate  { get; set; } 	    	
	    	
	    	
	    	/// <summary>
            /// 
            /// </summary>	
	    	public string  Name  { get; set; } 	    	
	    	
	    	
	    	/// <summary>
            /// 
            /// </summary>	
	    	public DateTime  StartedDate  { get; set; } 	    	
	    	
	    	
	    	/// <summary>
            /// 
            /// </summary>	
	    	public int  Status  { get; set; } 	    	
	    	
	    	
	    	/// <summary>
            /// 
            /// </summary>	
	    	public int  TaskId  { get; set; } 	    	
    						  
					   /// <summary>
                      /// Reference of PrimaryKey for User
                      /// </summary>
					  public  int UserUserId { get; set; }   
					  
					  /// <summary>
                      /// Reference to  User Email Property
                      /// </summary>	
					  public string UserEmail { get; set; }   
    	
    	
    	
    	public static explicit operator TaskView(Database.Task item)
    	{
    	 var result=new TaskView();
    	 
	    	result.CompletedDate = item.CompletedDate;     
	    	result.DueDate = item.DueDate;     
	    	result.Name = item.Name;     
	    	result.StartedDate = item.StartedDate;     
	    	result.Status = item.Status;     
	    	result.TaskId = item.TaskId;     
    	
if (item.User != null) 
			    			{   
		    		   result.UserUserId=item.User.UserId;
		    		   } 
		    		if (item.User != null) 
			    			{   	
		    			result.UserEmail=item.User.Email; 
		    			} 
    	
    	
    	return result;
     }   
   
    }
}


