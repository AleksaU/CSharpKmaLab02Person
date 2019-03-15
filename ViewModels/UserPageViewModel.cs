using Lab02Utkina.Models;
using Lab02Utkina.Tools;
using System;
using System.ComponentModel;
using System.Runtime.CompilerServices;
using System.Windows;

namespace Lab02Utkina.ViewModels
{
    internal class UserPageViewModel : INotifyPropertyChanged
    {

        private string _name;
        private string _surName;
        private string _email;
        private DateTime _birthDate;

        private bool _isAdult;
        private string _sunSign;
        private string _chineseSign;
        private bool _isBirthday;


        private RelayCommand<object> _proceedCommand;


        public string Name
        {
            get
            {
                return _name;
            }
           set
            {
                _name = value;
                OnPropertyChanged();
            }
        }

        public string Surname
        {
            get
            {
                return _surName;
            }
            set
            {
                _surName = value;
                OnPropertyChanged();
            }
        }
        public string Email
        {
            get
            {
                return _email;
            }
            set
            {
                _email = value;
                OnPropertyChanged();
            }
        }
        public DateTime BirthDate
        {
            get
            {
                return (_birthDate);
            }
            set
            {
                _birthDate = value;
                OnPropertyChanged();
            }
        }



        public RelayCommand<Object> ProceedCommand
        {
            get
            {
                return _proceedCommand ?? (_proceedCommand = new RelayCommand<object>(
                           o =>
                           {
                               Person person = new Person(_name, _surName, _email, _birthDate);
                               
                               MessageBox.Show(
                                                                   $"Your First name is: {person.Name}\n" +
                                                                   $"Your Surname is: {person.Surname}\n" +
                                                                   $"Your Email is: {person.Email}\n" +
                                                                   $"Your Date of birth is: {person.BirthDate}\n" +
                                                                   $"Are you an Adult: {person.IsAdult}\n" +
                                                                   $"Your SunSign is: {person.SunSign}\n" +
                                                                   $"Your Chinese Sign is: {person.ChineseSign}\n" +
                                                                   $"{person}"
                                                               );

                              
                               
           
                               if (_birthDate.Day == DateTime.Today.Day && _birthDate.Month == DateTime.Today.Month)
                                   MessageBox.Show("Happy b-day to you!");


                           }, o => CanExecuteCommand()));
            }
        }

        private bool CanExecuteCommand()
        {
         return  !string.IsNullOrWhiteSpace(_name) && !string.IsNullOrWhiteSpace(_surName) && !string.IsNullOrWhiteSpace(_email)  ;


        }



        public event PropertyChangedEventHandler PropertyChanged;

        protected virtual void OnPropertyChanged([CallerMemberName] string propertyName = null)
        {
            PropertyChanged?.Invoke(this, new PropertyChangedEventArgs(propertyName));
        }



    }
}

