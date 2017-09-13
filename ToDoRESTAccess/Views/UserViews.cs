// ALLOWOVERWRITE-9F3AF9003E71FC173D8EF75BF5155DF1

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
    public partial class UserViews
    {
        
    	public async Task<List<UserView>> GetAll()
        {
            var client = new HttpClient();
          
            var serializer = new DataContractJsonSerializer(typeof(List<UserView>),new DataContractJsonSerializerSettings()
            {
                DateTimeFormat = new DateTimeFormat("yyyy-MM-dd'T'HH:mm:ss")
            });

            var stream = await client.GetStreamAsync("http://test.silvadawn.co.uk:54501/api/user/all");

            var views = serializer.ReadObject(stream) as List<UserView>;
            
            return views;
        }
    
    
    	
    	public async Task<UserView> Get(int userId)
    	{
    	
    		var client = new HttpClient();

            var serializer = new DataContractJsonSerializer(typeof(UserView),new DataContractJsonSerializerSettings()
            {
                DateTimeFormat = new DateTimeFormat("yyyy-MM-dd'T'HH:mm:ss")
            });

            var stream = await client.GetStreamAsync($"http://test.silvadawn.co.uk:54501/api/user/{userId}");

            var view = serializer.ReadObject(stream) as UserView;

            return view;
    	
    	}
    	
    	
    	
    	
    	
    	
    }
}

