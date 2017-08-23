// ALLOWOVERWRITE-0723AFA6F3634BD708880B725FDC96C9

using System;
using System.Collections.Generic;
using Microsoft.EntityFrameworkCore;
using System.Linq;
using System.Threading.Tasks;

using ToDo.Views.Model;
using ToDo.Database;

namespace ToDo.Views
{
    public partial class TaskViews
    {
    
    
    	public async Task<List<TaskView>> GetAll()
        {
            using (var db = new ToDoDbContext())
            {
                var temp = await db.Tasks.ToListAsync();
                return temp.ConvertAll(user => (TaskView) user);
            }
        }
    
    
    	
    	public async Task<TaskView> Get(int taskId)
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
    	
    	
		
		public async Task<List<TaskView>> GetTasksForUser(int userId)
    	{
    	
    	using (var db = new ToDoDbContext())
            {
            	var result= await db.Tasks.Where(w=>w.User.UserId ==userId).ToListAsync();
            	return result.ConvertAll(user => (TaskView) user);
               
            }
    	}
    	
    	
    }
}

