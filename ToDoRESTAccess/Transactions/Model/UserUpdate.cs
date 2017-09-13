// ALLOWOVERWRITE-10544AB80985DA92535AE238E7BE4308

using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.Serialization;


namespace ToDo.Transactions.Model
{
	[DataContract]
    public class UserUpdate
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

