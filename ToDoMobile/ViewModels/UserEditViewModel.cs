// ALLOWOVERWRITE-E788F129AFB0EE612512E0B6F2456089

using System;
using System.ComponentModel;
using System.Runtime.CompilerServices;
using System.Threading.Tasks;
using System.Windows.Input;
using ToDo.Transactions;
using ToDo.Transactions.Model;
using ToDo.Views;
using ToDo.Views.Model;
using ToDoMobile.Annotations;
using ToDoMobile.Views.User;
using Xamarin.Forms;

namespace ToDoMobile.ViewModels
{

    public class UserEditViewModel : INotifyPropertyChanged
    {


        public UserEditViewModel()
        {
            SaveCommand=new Command( async () => await Save());
            CancelCommand = new Command(async () => await Cancel());
           	
           	ViewTasksCommand = new Command(async () => await ViewTasks());
           	
            
        }

      

        public ICommand SaveCommand { get; private set; }

        public ICommand CancelCommand { get; private set; }


           	
           	
        public ICommand ViewTasksCommand { get; private set; }
         
        public async Task ViewTasks()
        {           
                var tasks = new TaskIndexViewModel();
                await tasks.GetTasksForUser(UserId);
                MessagingCenter.Send<UserEditViewModel, TaskIndexViewModel>(this, "ShowTasks", tasks);
        }
           	


        public async Task Cancel()
        {
            if (UserView.UserId> 0)
                await Load(UserView.UserId);
            else
                UserView=new UserView();
        }

        public async Task Load(int userId)
        {
            var uv=new UserViews();

            this.UserView = await uv.Get(userId);
        }



        public async Task Save()
        {
        	try
        	{
	            var uv = new UserTransactions();
	
	            if (UserView.UserId > 0)
	            {
	                UserView = await uv.UserUpdate(this.GetUserUpdate());
	            }
	            else
	            {
	                UserView = await uv.UserAdd(this.GetUserAdd());
	            }
            }
            catch (Exception ex)
            {
            	 MessagingCenter.Send(this, "Save error");
            }
          
        }


        public event PropertyChangedEventHandler PropertyChanged;

        [NotifyPropertyChangedInvocator]
        protected virtual void OnPropertyChanged([CallerMemberName] string propertyName = null)
        {
            PropertyChanged?.Invoke(this, new PropertyChangedEventArgs(propertyName));
        }


        private UserView _userView = new UserView();

        public UserView UserView
        {
            get
            {
                return _userView;
            }

            set
            {
                this._userView = value;
                OnPropertyChanged("Email");
                OnPropertyChanged("FirstName");
                OnPropertyChanged("MobileNumber");
                OnPropertyChanged("Surname");
                OnPropertyChanged("Title");
                OnPropertyChanged("UserId");
                              
            }
        }

		
       	 
        /// <summary>
        /// 
        /// </summary>	
        public string  Email 
        {
            set
            {
                if (UserView.Email != value)
                {
                    UserView.Email = value;
                    OnPropertyChanged("Email");
                }
            }
            get
            {
                return UserView.Email;
            } 
        } 	    	
	    	
       	 
        /// <summary>
        /// 
        /// </summary>	
        public string  FirstName 
        {
            set
            {
                if (UserView.FirstName != value)
                {
                    UserView.FirstName = value;
                    OnPropertyChanged("FirstName");
                }
            }
            get
            {
                return UserView.FirstName;
            } 
        } 	    	
	    	
       	 
        /// <summary>
        /// 
        /// </summary>	
        public string  MobileNumber 
        {
            set
            {
                if (UserView.MobileNumber != value)
                {
                    UserView.MobileNumber = value;
                    OnPropertyChanged("MobileNumber");
                }
            }
            get
            {
                return UserView.MobileNumber;
            } 
        } 	    	
	    	
       	 
        /// <summary>
        /// 
        /// </summary>	
        public string  Surname 
        {
            set
            {
                if (UserView.Surname != value)
                {
                    UserView.Surname = value;
                    OnPropertyChanged("Surname");
                }
            }
            get
            {
                return UserView.Surname;
            } 
        } 	    	
	    	
       	 
        /// <summary>
        /// 
        /// </summary>	
        public string  Title 
        {
            set
            {
                if (UserView.Title != value)
                {
                    UserView.Title = value;
                    OnPropertyChanged("Title");
                }
            }
            get
            {
                return UserView.Title;
            } 
        } 	    	
	    	
       	 
        /// <summary>
        /// 
        /// </summary>	
        public int  UserId 
        {
            set
            {
                if (UserView.UserId != value)
                {
                    UserView.UserId = value;
                    OnPropertyChanged("UserId");
                }
            }
            get
            {
                return UserView.UserId;
            } 
        } 	    	
	    	
	    	
	    	
	    	

      

        public UserUpdate GetUserUpdate()
        {
            var result = new UserUpdate();

			result.Email = UserView.Email;
			result.FirstName = UserView.FirstName;
			result.MobileNumber = UserView.MobileNumber;
			result.Surname = UserView.Surname;
			result.Title = UserView.Title;
			result.UserId = UserView.UserId;
            return result;
        }

        public UserAdd GetUserAdd()
        {
            var result = new UserAdd();

			result.Email = UserView.Email;
			result.FirstName = UserView.FirstName;
			result.MobileNumber = UserView.MobileNumber;
			result.Surname = UserView.Surname;
			result.Title = UserView.Title;
			result.UserId = UserView.UserId;
                       return result;
        }




        public static explicit operator UserEditViewModel(UserView item)
    	{
       	    var result=new UserEditViewModel();
    	 
			 result.Email = item.Email;
			 result.FirstName = item.FirstName;
			 result.MobileNumber = item.MobileNumber;
			 result.Surname = item.Surname;
			 result.Title = item.Title;
			 result.UserId = item.UserId;
	    	
        	return result;
       }

     
    }
}




