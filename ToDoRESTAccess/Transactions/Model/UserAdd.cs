// ALLOWOVERWRITE-3121E336335D1F3F7DFC2FA0DE100A9B

using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.Serialization;



namespace ToDo.Transactions.Model
{

	[DataContract]
    public class UserAdd
    {
	    		
	    		 /// <summary>
                  /// 
                  /// </summary>
				[DataMember(Name = "email")]                
	    		public string Email  { get; set; } 
	    		
	    		 /// <summary>
                  /// 
                  /// </summary>
				[DataMember(Name = "firstName")]                
	    		public string FirstName  { get; set; } 
	    		
	    		 /// <summary>
                  /// 
                  /// </summary>
				[DataMember(Name = "mobileNumber")]                
	    		public string MobileNumber  { get; set; } 
	    		
	    		 /// <summary>
                  /// 
                  /// </summary>
				[DataMember(Name = "surname")]                
	    		public string Surname  { get; set; } 
	    		
	    		 /// <summary>
                  /// 
                  /// </summary>
				[DataMember(Name = "title")]                
	    		public string Title  { get; set; } 
	    		
	    		 /// <summary>
                  /// 
                  /// </summary>
				[DataMember(Name = "userId")]                
	    		public int UserId  { get; set; } 
    	   	
    }    	    	
}



