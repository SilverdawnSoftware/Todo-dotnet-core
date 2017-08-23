// ALLOWOVERWRITE-C59D1C66199B289AFD5AEC48D06134C2

using System;
using System.Collections.Generic;
using System.Linq;
using ToDo.Database;


namespace ToDo.Transactions.Model
{
    public class TaskAdd
    {
	    		
	    		 /// <summary>
                  /// 
                  /// </summary>	    		
	    		public DateTime CompletedDate  { get; set; } =new DateTime();
	    		
	    		 /// <summary>
                  /// 
                  /// </summary>	    		
	    		public DateTime DueDate  { get; set; } = new DateTime();

        /// <summary>
        /// 
        /// </summary>	    		
        public string Name  { get; set; } 
	    		
	    		 /// <summary>
                  /// 
                  /// </summary>	    		
	    		public DateTime StartedDate  { get; set; } = new DateTime();

        /// <summary>
        /// 
        /// </summary>	    		
        public int Status  { get; set; }
	    		
	    		 /// <summary>
                  /// 
                  /// </summary>	    		
	    		public int TaskId  { get; set; } 
    	   	
    	
    	/// <summary>
        /// 
        /// </summary>	
       
    	public int UserUserId { get; set; } 
    }    	    	
}



