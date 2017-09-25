// ALLOWOVERWRITE-4C1AEBFB1E4FA0E495CD991248AE3504

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
                /// The users email address
                /// </summary>
				 [DataMember(Name = "email")]                 
	    		public string Email  { get; set; } 
	    		
	    		/// <summary>
                /// The users first name
                /// </summary>
				 [DataMember(Name = "firstName")]                 
	    		public string FirstName  { get; set; } 
	    		
	    		/// <summary>
                /// The users mobile number
                /// </summary>
				 [DataMember(Name = "mobileNumber")]                 
	    		public string MobileNumber  { get; set; } 
	    		
	    		/// <summary>
                /// The users surname
                /// </summary>
				 [DataMember(Name = "surname")]                 
	    		public string Surname  { get; set; } 
	    		
	    		/// <summary>
                /// The title of the user e.g. Mrs,Mr
                /// </summary>
				 [DataMember(Name = "title")]                 
	    		public string Title  { get; set; } 
	    		
	    		/// <summary>
                /// Unique identifier for user
                /// </summary>
				 [DataMember(Name = "userId")]                 
	    		public int UserId  { get; set; } 
    	
    }
}

