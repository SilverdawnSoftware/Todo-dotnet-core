// ALLOWOVERWRITE-5518085A435C7BBE2AE8FBE13E252AFC

using System;
using System.Collections.Generic;
using System.Linq;



namespace ToDo.Database
{
    public class User
    {
	    		
	    		/// <summary>  </summary>	 
	    		
	    		public int UserId  { get; set; }     	
	    		
	    		/// <summary>  </summary>	 
	    		
	    		public string FirstName  { get; set; }     	
	    		
	    		/// <summary>  </summary>	 
	    		
	    		public string Surname  { get; set; }     	
	    		
	    		/// <summary>  </summary>	 
	    		
	    		public string Email  { get; set; }     	
	    		
	    		/// <summary>  </summary>	 
	    		
	    		public string MobileNumber  { get; set; }     	
	    		
	    		/// <summary>  </summary>	 
	    		
	    		public string Title  { get; set; }     	
    	
    	
    	
    	
    	/// <summary>
        /// List of Tasks
        /// </summary>	
    	public virtual List<Task> Tasks { get; set; } 
    	
    	
    	
    	
    }
    
    
}



























