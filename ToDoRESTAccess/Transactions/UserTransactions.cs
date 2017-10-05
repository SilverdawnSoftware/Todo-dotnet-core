// ALLOWOVERWRITE-1CAA7B9A04E677AB56B448150817FB10

using System;
using System.Collections.Generic;
using System.IO;
using System.Net.Http;
using System.Runtime.Serialization.Json;
using System.Runtime.Serialization;
using System.Text;
using System.Threading.Tasks;
using ToDo.Transactions.Model;
using ToDo.Views.Model;

namespace ToDo.Transactions
{
    public  class UserTransactions
    {
        public async Task<UserView> UserAdd(UserAdd add)
        {
            string json = "";

            var client = new HttpClient();

            using (var ms = new MemoryStream())
            {
                var serializer = new DataContractJsonSerializer(typeof(UserAdd));
                serializer.WriteObject(ms, add);
                ms.Position = 0;
                StreamReader sr = new StreamReader(ms);
                json = sr.ReadToEnd();
            }

            var stream = await client.PostAsync("http://tododotnet.lan:9271/api/user", new StringContent(json, Encoding.UTF8, "application/json"));

            using (var ms = new MemoryStream())
            {
                var serializer = new DataContractJsonSerializer(typeof(UserView),new DataContractJsonSerializerSettings()
            	{
                	DateTimeFormat = new DateTimeFormat("yyyy-MM-dd'T'HH:mm:ss")
            	});
                await stream.Content.CopyToAsync(ms);
                ms.Position = 0;
                var view = serializer.ReadObject(ms) as UserView;
                return view;
            }
        }
 
        public async Task<UserView> UserUpdate(UserUpdate update)
        {
            string json = "";

            var client = new HttpClient();

            using (var ms = new MemoryStream())
            {
                var serializer = new DataContractJsonSerializer(typeof(UserUpdate),new DataContractJsonSerializerSettings()
            	{
                	DateTimeFormat = new DateTimeFormat("yyyy-MM-dd'T'HH:mm:ss")
            	});
                serializer.WriteObject(ms, update);
                ms.Position = 0;
                StreamReader sr = new StreamReader(ms);
                json = sr.ReadToEnd();
            }

            var stream = await client.PutAsync($"http://tododotnet.lan:9271/api/user/{update.UserId}", new StringContent(json, Encoding.UTF8, "application/json"));

            using (var ms = new MemoryStream())
            {
                var serializer = new DataContractJsonSerializer(typeof(UserView));
                await stream.Content.CopyToAsync(ms);
                ms.Position = 0;
                var view = serializer.ReadObject(ms) as UserView;
                return view;
            }
        }

    }
}

