// ALLOWOVERWRITE-D51A3DF3B2F91804FA15CF494F509DF9

using System;
using System.Collections.Generic;
using System.Collections.ObjectModel;
using System.ComponentModel;
using System.Linq;
using System.Threading.Tasks;
using ToDo.Views.Model;
using ToDo.Views;
using ToDo.Mobile.ViewModels;
using Xamarin.Forms;
using Xamarin.Forms.Xaml;

namespace ToDo.Mobile.Views.User
{
    [XamlCompilation(XamlCompilationOptions.Compile)]
    public partial class UserIndexPage : ContentPage
    {
        public ObservableCollection<UserView> Items { get; set; }=new ObservableCollection<UserView>();

        public UserIndexPage()
        {
            InitializeComponent();
			MessagingCenter.Subscribe<UserIndexViewModel, UserEditViewModel>(this, "AddUser", async (sender, arg) => { await AddUsers(arg);});                   
        }
        
        
        private async System.Threading.Tasks.Task AddUsers(UserEditViewModel userEditViewModel)
        {

            var page = new UserEditPage();
            page.BindingContext = userEditViewModel;
            await Navigation.PushAsync(page);
            NavigationPage.SetHasBackButton(page, true);
        }
        
        

        async void Handle_ItemTapped(object sender, ItemTappedEventArgs e)
        {
            if (e.Item == null)
                return;

            //await DisplayAlert("Item Tapped", "An item was tapped.", "OK");
            var page = new UserEditPage();
            await Navigation.PushAsync(page);
            NavigationPage.SetHasBackButton(page, true);
			await ((UserEditViewModel)page.BindingContext).Load(((UserView) e.Item).UserId);
            //Deselect Item
            ((ListView)sender).SelectedItem = null;
        }


        
    }

}

