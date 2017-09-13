// ALLOWOVERWRITE-15D35655A512FC2F7B92C450234F5EE0

using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.Serialization;


namespace ToDo.Views.Model
{

	[DataContract]
    public class UserView
    {
    
   
    
	    	
	    	
	    	/// <summary>
            /// 
            /// </summary>
			 [DataMember(Name = "email")]            
	    	public string  Email  { get; set; } 	    	
	    	
	    	
	    	/// <summary>
            /// 
            /// </summary>
			 [DataMember(Name = "firstName")]            
	    	public string  FirstName  { get; set; } 	    	
	    	
	    	
	    	/// <summary>
            /// 
            /// </summary>
			 [DataMember(Name = "mobileNumber")]            
	    	public string  MobileNumber  { get; set; } 	    	
	    	
	    	
	    	/// <summary>
            /// 
            /// </summary>
			 [DataMember(Name = "surname")]            
	    	public string  Surname  { get; set; } 	    	
	    	
	    	
	    	/// <summary>
            /// 
            /// </summary>
			 [DataMember(Name = "title")]            
	    	public string  Title  { get; set; } 	    	
	    	
	    	
	    	/// <summary>
            /// 
            /// </summary>
			 [DataMember(Name = "userId")]            
	    	public int  UserId  { get; set; } 	    	
    	    	
    	
    	
    	
   
    }
}


