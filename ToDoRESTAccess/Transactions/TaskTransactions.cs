// ALLOWOVERWRITE-72F380E6EB3949BE27B47C8E61256665

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
    public  class TaskTransactions
    {
        public async Task<TaskView> TaskAdd(TaskAdd add)
        {
            string json = "";

            var client = new HttpClient();

            using (var ms = new MemoryStream())
            {
                var serializer = new DataContractJsonSerializer(typeof(TaskAdd));
                serializer.WriteObject(ms, add);
                ms.Position = 0;
                StreamReader sr = new StreamReader(ms);
                json = sr.ReadToEnd();
            }

            var stream = await client.PostAsync("http://test.silvadawn.co.uk:54501/api/task", new StringContent(json, Encoding.UTF8, "application/json"));

            using (var ms = new MemoryStream())
            {
                var serializer = new DataContractJsonSerializer(typeof(TaskView),new DataContractJsonSerializerSettings()
            	{
                	DateTimeFormat = new DateTimeFormat("yyyy-MM-dd'T'HH:mm:ss")
            	});
                await stream.Content.CopyToAsync(ms);
                ms.Position = 0;
                var view = serializer.ReadObject(ms) as TaskView;
                return view;
            }
        }
 
        public async Task<TaskView> TaskUpdate(TaskUpdate update)
        {
            string json = "";

            var client = new HttpClient();

            using (var ms = new MemoryStream())
            {
                var serializer = new DataContractJsonSerializer(typeof(TaskUpdate),new DataContractJsonSerializerSettings()
            	{
                	DateTimeFormat = new DateTimeFormat("yyyy-MM-dd'T'HH:mm:ss")
            	});
                serializer.WriteObject(ms, update);
                ms.Position = 0;
                StreamReader sr = new StreamReader(ms);
                json = sr.ReadToEnd();
            }

            var stream = await client.PutAsync($"http://test.silvadawn.co.uk:54501/api/task/{update.TaskId}", new StringContent(json, Encoding.UTF8, "application/json"));

            using (var ms = new MemoryStream())
            {
                var serializer = new DataContractJsonSerializer(typeof(TaskView));
                await stream.Content.CopyToAsync(ms);
                ms.Position = 0;
                var view = serializer.ReadObject(ms) as TaskView;
                return view;
            }
        }

    }
}
