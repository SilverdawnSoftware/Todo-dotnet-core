// ALLOWOVERWRITE-89A110B504A10871D8673A57EB21F042

using System;
using System.Collections.Generic;
using System.Net.Http;
using System.Net.Http.Headers;
using System.Runtime.Serialization;
using System.Runtime.Serialization.Json;
using System.Text;
using System.Threading.Tasks;
using ToDo.Views.Model;

using ToDo.Views.Model;


namespace ToDo.Views
{
    public partial class TaskViews
    {
        
    	public async Task<List<TaskView>> GetAll()
        {
            var client = new HttpClient();
          
            var serializer = new DataContractJsonSerializer(typeof(List<TaskView>),new DataContractJsonSerializerSettings()
            {
                DateTimeFormat = new DateTimeFormat("yyyy-MM-dd'T'HH:mm:ss")
            });

            var stream = await client.GetStreamAsync("http://tododotnet.lan:9271/api/task/all");

            var views = serializer.ReadObject(stream) as List<TaskView>;
            
            return views;
        }
    
    
    	
    	public async Task<TaskView> Get(int taskId)
    	{
    	
    		var client = new HttpClient();

            var serializer = new DataContractJsonSerializer(typeof(TaskView),new DataContractJsonSerializerSettings()
            {
                DateTimeFormat = new DateTimeFormat("yyyy-MM-dd'T'HH:mm:ss")
            });

            var stream = await client.GetStreamAsync($"http://tododotnet.lan:9271/api/task/{taskId}");

            var view = serializer.ReadObject(stream) as TaskView;

            return view;
    	
    	}
    	
    	
    	
    	
    	
		
		 /// <summary>
        /// Find all Tasks for User
        /// </summary>
		
		public async Task<List<TaskView>> GetAllForUser(int userId)
        {
            var client = new HttpClient();
          
            var serializer = new DataContractJsonSerializer(typeof(List<TaskView>),new DataContractJsonSerializerSettings()
            {
                DateTimeFormat = new DateTimeFormat("yyyy-MM-dd'T'HH:mm:ss")
            });

            var stream = await client.GetStreamAsync($"http://tododotnet.lan:9271/api/user/{userId}/tasks");

            var views = serializer.ReadObject(stream) as List<TaskView>;
            
            return views;
        }
		    	
    	
    }
}

