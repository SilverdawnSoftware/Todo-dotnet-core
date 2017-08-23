// ALLOWOVERWRITE-2519C76DE54C603A578D0ED550A29AD3

using System;
using System.Collections.Generic;
using System.Linq;



namespace ToDo.Views.Model
{

    public class UserView
    {
    
   
    
	    	
	    	
	    	/// <summary>
            /// 
            /// </summary>	
	    	public string  Email  { get; set; } 	    	
	    	
	    	
	    	/// <summary>
            /// 
            /// </summary>	
	    	public string  FirstName  { get; set; } 	    	
	    	
	    	
	    	/// <summary>
            /// 
            /// </summary>	
	    	public string  MobileNumber  { get; set; } 	    	
	    	
	    	
	    	/// <summary>
            /// 
            /// </summary>	
	    	public string  Surname  { get; set; } 	    	
	    	
	    	
	    	/// <summary>
            /// 
            /// </summary>	
	    	public string  Title  { get; set; } 	    	
	    	
	    	
	    	/// <summary>
            /// 
            /// </summary>	
	    	public int  UserId  { get; set; } 	    	
    	    	
    	
    	
    	public static explicit operator UserView(Database.User item)
    	{
    	 var result=new UserView();
    	 
	    	result.Email = item.Email;     
	    	result.FirstName = item.FirstName;     
	    	result.MobileNumber = item.MobileNumber;     
	    	result.Surname = item.Surname;     
	    	result.Title = item.Title;     
	    	result.UserId = item.UserId;     
    	
    	
    	
    	return result;
     }   
   
    }
}


