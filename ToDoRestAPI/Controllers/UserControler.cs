// ALLOWOVERWRITE-F1E727484972A4B9221D871ABE8EC0C7

using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using transModel =ToDo.Transactions.Model;
using trans =ToDo.Transactions;
using viewModel =ToDo.Views.Model;
using views =ToDo.Views;
using database = ToDo.Database;

namespace ToDoRestAPI
{

	
    public partial class UserAPIController : Controller
    {
    
        /// <summary>
        /// Get All Objects for User
        /// </summary>	
        [Route("api/User/All")]
        [HttpGet]
        public async Task<List<viewModel.UserView>> All()
        {
            var views = new views.UserViews();
            return await views.GetAll();
        }
    
      
    	 /// <summary>
        /// Get User By UserId
        /// </summary>	
    	//Get User View Model
    	[Route("api/User/{userId}")]
    	[HttpGet]
        public async Task<viewModel.UserView> Get([FromRoute]int userId)
        {
            var view=new views.UserViews();            
            return await view.Get(userId);            
        }
    
        
    	 /// <summary>
        /// Add New User
        /// </summary>	
    
    	//Add New User
    	[Route("api/User")]
    	[HttpPost]
        public async Task<viewModel.UserView> Add([FromBody]transModel.UserAdd add)
        {
            var addTrans=new trans.UserTransactions(); 
            var result=await addTrans.Add(add);
            return (viewModel.UserView) result;
        }
        
      
         /// <summary>
        /// Update User By UserId
        /// </summary>	
       
        
        //Update  User
    	[Route("api/User/{userId}")]
    	[HttpPut]
        public async Task<viewModel.UserView> Update([FromRoute]int userId,[FromBody]transModel.UserUpdate update)
        {
        	update.UserId = userId;
            var updateTrans=new trans.UserTransactions();
            var result=await updateTrans.Update(update);
            return (viewModel.UserView) result;
                     
        }
        
         /// <summary>
        /// Delete User By UserId
        /// </summary>
         //Delete  User
    	[Route("api/User/{userId}")]
    	[HttpDelete]
        public async Task Delete([FromRoute]int userId)
        {
            var deleteTrans=new trans.UserTransactions();
			var  userDelete=new transModel.UserDelete(){UserId=userId };			
            await deleteTrans.Delete(userDelete);            
        }
        
        
        
        
    }
}

