// ALLOWOVERWRITE-7DE3E00A23C0289D8D65959F8AC44EBC

using System;
using System.Collections.Generic;
using System.Linq;



namespace ToDo.Database
{
    public class Task
    {
	    		
	    		/// <summary>  </summary>	 
	    		
	    		public int TaskId  { get; set; }     	
	    		
	    		/// <summary>  </summary>	 
	    		
	    		public string Name  { get; set; }     	
	    		
	    		/// <summary>  </summary>	 
	    		
	    		public DateTime DueDate  { get; set; }     	
	    		
	    		/// <summary>  </summary>	 
	    		
	    		public DateTime StartedDate  { get; set; }     	
	    		
	    		/// <summary>  </summary>	 
	    		
	    		public int Status  { get; set; }     	
	    		
	    		/// <summary>  </summary>	 
	    		
	    		public DateTime CompletedDate  { get; set; }     	
    	
    	
    	
    	/// <summary>
        /// Reference to  User
        /// </summary>	
    	public virtual User User { get; set; } 
    	
    	
    	
    	
    	
    }
    
    
}



























