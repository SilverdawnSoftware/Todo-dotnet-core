// ALLOWOVERWRITE-180217C8F23A84D53AAC73D5A7B14E23

using System;
using System.Collections.Generic;
using System.Collections.ObjectModel;
using System.ComponentModel;
using System.Runtime.CompilerServices;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Input;
using ToDo.Views;
using ToDo.Views.Model;
using ToDo.Mobile.Annotations;

using Xamarin.Forms;

namespace ToDo.Mobile.ViewModels
{
    public class TaskIndexViewModel : INotifyPropertyChanged
    {


		 public ICommand AddTaskCommand { get; private set; }

        public TaskIndexViewModel()
        {
            AddTaskCommand = new Command(async () => await AddTask());
        }

        private async Task AddTask()
        {
            var task=new TaskEditViewModel();

 			task.UserUserId= UserUserId; 
            MessagingCenter.Send<TaskIndexViewModel, TaskEditViewModel>(this, "AddTask", task);
        }

 		public int UserUserId {get; set;} 


        public event PropertyChangedEventHandler PropertyChanged;

        [NotifyPropertyChangedInvocator]
        protected virtual void OnPropertyChanged([CallerMemberName] string propertyName = null)
        {
            PropertyChanged?.Invoke(this, new PropertyChangedEventArgs(propertyName));
        }

        public ObservableCollection<TaskView> TaskViews { get; set; } = new ObservableCollection<TaskView>();

		
        public async System.Threading.Tasks.Task GetTasksForUser(int userUserId)
        {
        	UserUserId=userUserId;
            var Tasks = new TaskViews();
            var temp = await Tasks.GetAllForUser(userUserId);
            TaskViews.Clear();
            foreach (var taskView in temp)
            {
                TaskViews.Add(taskView);
            }
        }
        
        
    }
}

