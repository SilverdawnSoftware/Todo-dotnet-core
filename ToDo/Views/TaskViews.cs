// ALLOWOVERWRITE-5361ABE6C9A2411747A8A29FB50814F1

using System;
using System.Collections.Generic;
using Microsoft.EntityFrameworkCore;
using System.Linq;
using System.Threading.Tasks;
using Silverdawn.Exceptions;
using ToDo.Database.Views.Model;


namespace ToDo.Database.Views
{
    public partial class TaskViews
    {
    
    
    	public async Task<List<TaskView>> GetAll()
        {
        	try
            {
	            using (var db = new ToDoDbContext())
	            {
	                var temp = await db.Tasks.ToListAsync();
	                return temp.ConvertAll(user => (TaskView) user);
	            }
            }
            catch (Exception e)
            {
            	LogFactory.GetLogger().Log(LogLevel.Error,e);
                return null;             
            }            
        }
    
    
    	
    	public async Task<TaskView> Get(int taskId)
    	{
    		
    		try
            {
	    		using (var db = new ToDoDbContext())
	            {
	            	if (await db.Tasks.AnyAsync(w=>w.TaskId==taskId))
	                {
	                	return (TaskView)await db.Tasks.FirstAsync(w=>w.TaskId==taskId);
	            	}
	            }	    	
	    		return null;
    		 }
            catch (Exception e)
            {
            	LogFactory.GetLogger().Log(LogLevel.Error,e);
                return null;              
            }     		
    	}
    	
    	
		
		public async Task<List<TaskView>> GetTasksForUser(int userId)
    	{
    		try
            {
    	
	    		using (var db = new ToDoDbContext())
	            {
	            	var result= await db.Tasks.Where(w=>w.User.UserId ==userId).ToListAsync();
	            	return result.ConvertAll(user => (TaskView) user);
	               
	            }
	        }
            catch (Exception e)
            {
            	LogFactory.GetLogger().Log(LogLevel.Error,e);
                return null;
              
            }    
	            
    	}
    	
    	
    }
}

