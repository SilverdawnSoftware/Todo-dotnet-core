// ALLOWOVERWRITE-86E244D71B61EE0A22FAE8F439148CB4

using System;
using System.Collections.Generic;
using Microsoft.EntityFrameworkCore;
using System.Linq;
using System.Threading.Tasks;

using ToDo.Views.Model;
using ToDo.Database;

namespace ToDo.Views
{
    public partial class UserViews
    {
    
    
    	public async Task<List<UserView>> GetAll()
        {
            using (var db = new ToDoDbContext())
            {
                var temp = await db.Users.ToListAsync();
                return temp.ConvertAll(user => (UserView) user);
            }
        }
    
    
    	
    	public async Task<UserView> Get(int userId)
    	{
    	
    	using (var db = new ToDoDbContext())
            {
            	if (await db.Users.AnyAsync(w=>w.UserId==userId))
                {
                	return (UserView)await db.Users.FirstAsync(w=>w.UserId==userId);
            	}
            }
    	
    		return null;
    	
    	}
    	
    	
    	
    }
}

