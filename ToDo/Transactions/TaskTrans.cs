// ALLOWOVERWRITE-B9D5092DC91D2644C4896C2D08BE36C8

using System;
using System.Collections.Generic;
using Microsoft.EntityFrameworkCore;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using ToDo.Transactions.Model;
using ToDo.Views.Model;
using data = ToDo.Database;

namespace ToDo.Transactions
{
 public partial class TaskTransactions
 {
     
 
 		// Add Transaction Code
 		public async Task<TaskView> Add(TaskAdd add)
        {
            using (var db = new data.ToDoDbContext())
            {
                var result= await Add(db,add);
                await db.SaveChangesAsync();
                return (TaskView)result;
            }
        } 	
 	
 	
 	 public async Task<data.Task> Add(data.ToDoDbContext db, TaskAdd add)
        {
         try
            {
            
               var newTask=new data.Task();
	    	newTask.CompletedDate = add.CompletedDate;   	
	    	newTask.DueDate = add.DueDate;   	
	    	newTask.Name = add.Name;   	
	    	newTask.StartedDate = add.StartedDate;   	
	    	newTask.Status = add.Status;   	
    	
    		// Add references to parent Classes
    			var userLookup = await db.Users.FirstOrDefaultAsync(w => w.UserId == add.UserUserId);   
				if (userLookup !=null)    
				{ newTask.User=userLookup;}	
    	
    	
    		db.Tasks.Add(newTask);
    		
    		return newTask;
            }
            
             catch (Exception)
            {
                return null;
              
            }
        }



// Update Transaction Code
 		public async Task<TaskView> Update(TaskUpdate update)
        {
            using (var db = new data.ToDoDbContext())
            {
                var result= await Update(db,update);
                await db.SaveChangesAsync();
                return (TaskView)result;
            }
        } 	
 	
 	
 	 public async Task<data.Task> Update(data.ToDoDbContext db, TaskUpdate update)
        {
         try
            {
              var taskToUpdate = await db.Tasks.FirstOrDefaultAsync(w => w.TaskId == update.TaskId);

               
            	
taskToUpdate.CompletedDate = update.CompletedDate;   	
taskToUpdate.DueDate = update.DueDate;   	
taskToUpdate.Name = update.Name;   	
taskToUpdate.StartedDate = update.StartedDate;   	
taskToUpdate.Status = update.Status;   	
taskToUpdate.TaskId = update.TaskId;   	
            	
    	
    		
    		
    		return taskToUpdate;
            }
            
             catch (Exception)
            {
                return null;
              
            }
        }


	// Delete Transaction Code
 		public async Task Delete(TaskDelete delete)
        {
            using (var db = new data.ToDoDbContext())
            {
                await Delete(db,delete);
                await db.SaveChangesAsync();
                
            }
        } 	
 	
 	
 	 public async Task Delete(data.ToDoDbContext db, TaskDelete delete)
        {
         try
            {
            
              var taskToDelete = await db.Tasks.FirstOrDefaultAsync(w => w.TaskId == delete.TaskId);
            
             	db.Tasks.Remove(taskToDelete);    		
    		}
             catch (Exception)
            {
            }
        }
        

	}
 }
 
