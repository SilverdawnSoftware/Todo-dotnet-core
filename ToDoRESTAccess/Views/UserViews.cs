// ALLOWOVERWRITE-D85000844BAA35B1F95A8D426F096428

using System;
using System.Collections.Generic;
using System.Net.Http;
using System.Net.Http.Headers;
using System.Runtime.Serialization;
using System.Runtime.Serialization.Json;
using System.Text;
using System.Threading.Tasks;
using SilverdawnSoftware.Exceptions;
using Database.Views.Model;


namespace Database.Views
{
    public partial class UserViews
    {
        
    	public async Task<List<UserView>> GetAll()
        {
        	try
            {       
	            var client = new HttpClient();
	          
	            var serializer = new DataContractJsonSerializer(typeof(List<UserView>),new DataContractJsonSerializerSettings()
	            {
	                DateTimeFormat = new DateTimeFormat("yyyy-MM-dd'T'HH:mm:ss")
	            });
	
	            var stream = await client.GetStreamAsync("http://tododotnet.lan:9271/api/user/all");
	
	            var views = serializer.ReadObject(stream) as List<UserView>;
	            
	            return views;
            }
            catch (Exception e)
            {
            	LogFactory.GetLogger().Log(LogLevel.Error,e);
                return null;              
            }    
        }
    
    
    	
    	public async Task<UserView> Get(int userId)
    	{
    		try
            {
	    		var client = new HttpClient();
	
	            var serializer = new DataContractJsonSerializer(typeof(UserView),new DataContractJsonSerializerSettings()
	            {
	                DateTimeFormat = new DateTimeFormat("yyyy-MM-dd'T'HH:mm:ss")
	            });
	
	            var stream = await client.GetStreamAsync($"http://tododotnet.lan:9271/api/user/{userId}");
	
	            var view = serializer.ReadObject(stream) as UserView;
	
	            return view;
            }
            catch (Exception e)
            {
            	LogFactory.GetLogger().Log(LogLevel.Error,e);
                return null;              
            }    
    	
    	}
    	
    	
    	
    	
    	
    	
    }
}

