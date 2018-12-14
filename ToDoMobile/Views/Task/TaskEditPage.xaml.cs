// ALLOWOVERWRITE-F28FCA7D4027FDF30BA95EE7F14E8A2B

using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using ToDo.Mobile.ViewModels;

using Xamarin.Forms;
using Xamarin.Forms.Xaml;

namespace ToDo.Mobile.Views.Task
{
	[XamlCompilation(XamlCompilationOptions.Compile)]
	public partial class TaskEditPage : ContentPage
	{
		public TaskEditPage ()
		{
			InitializeComponent ();			
			MessagingCenter.Subscribe<TaskEditViewModel>(this, "Save error",model => DisplayAlert("Save error", "Unable to save changes.", "Close") );			 			 
		}
		
		
		
		
	}
}