using MvvmCross.Commands;
using MvvmCross.ViewModels;
using Practica.Core.Models;
using Practica.Core.Services;
using System;
using System.Collections.ObjectModel;
using System.Threading.Tasks;
using System.Windows.Input;

namespace Practica.Core.ViewModels
{
    public class FormViewModel : MvxViewModel
    {
        private readonly IApiService _apiService;
        private bool _isEnabled;
        private UserRequest1 _user;
        private ObservableCollection<Group> _groups;
        public Group _addGroup;
        private MvxCommand _getCommand;
        private MvxCommand _sendCommand;
        private string _problem;

        public FormViewModel(
            IApiService apiService)
        {
            _apiService = apiService;
            IsEnabled = true;
            User = new UserRequest1();
            GroupsAdd();
        }

        public ICommand SendCommand
        {
            get
            {
                _sendCommand = _sendCommand ?? new MvxCommand(SendProblemAsync);
                return _sendCommand;
            }
        }

        public ICommand GetCommand
        {
            get
            {
                _getCommand = _getCommand ?? new MvxCommand(GetProblemAsync);
                return _getCommand;
            }
        }

        public UserRequest1 User
        {
            get => _user;
            set => SetProperty(ref _user, value);
        }

        public bool IsEnabled
        {
            get => _isEnabled;
            set => SetProperty(ref _isEnabled, value);
        }

        public string Problem
        {
            get => _problem;
            set => SetProperty(ref _problem, value);
        }

        public ObservableCollection<Group> Groups
        {
            get => _groups;
            set => SetProperty(ref _groups, value);
        }

        public Group AddGroup
        {
            get => _addGroup;
            set => SetProperty(ref _addGroup, value);
        }

        public void GroupsAdd()
        {
            Groups = new ObservableCollection<Group>
            {
               new Group
               {
                   Id=1,
                   Name="Group 1"

               }, new Group
               {
                   Id=2,
                   Name="Group 2"

               }, new Group
               {
                   Id=3,
                   Name="Group 3"

               }, new Group
               {
                   Id=4,
                   Name="Group 4"

               }
            };
        }

        private async Task<bool> ValidateDataAsync()
        {
            if (string.IsNullOrEmpty(User.Document))
            {
                return false;
            }

            if (string.IsNullOrEmpty(User.FirstName))
            {
                return false;
            }

            if (string.IsNullOrEmpty(User.LastName))
            {
                return false;
            }

            if (string.IsNullOrEmpty(User.Username))
            {
                return false;
            }

            if (string.IsNullOrEmpty(User.Phone))
            {
                return false;
            }
            return true;
        }

        private void SendProblemAsync()
        {
            throw new NotImplementedException();
        }

        private async void GetProblemAsync()
        {
            bool isValid = await ValidateDataAsync();
            if (!isValid)
            {
                return;
            }

            string url = "https://zulutest.azurewebsites.net/";

            User.Group = AddGroup.Id;
            Response response = await _apiService.GetProblemAsync(url, "/Account/GetProblem", User);

            if (!response.IsSuccess)
            {
                return;
            }
            UserResponse UserResponse = (UserResponse)response.Result;
            Problem = UserResponse.Problem;

        }
    }
}
