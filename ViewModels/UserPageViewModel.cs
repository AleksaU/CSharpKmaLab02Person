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

        private readonly bool _isAdult;
        private readonly string _sunSign;
        private readonly string _chineseSign;
        private readonly bool _isBirthday;

       
        private RelayCommand<object> _proceedCommand;


        public string Name
        {
            get
            {
                return _name;
            }
            private set
            {
                _name = value;
                OnPropertyChanged();
            }
        }

        public string SurName
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
        public string BirthDate
        {
            get
            {
                return ("birth " + _birthDate);
            }
            set
            {
                _birthDate = Convert.ToDateTime(value);
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
                                                           $"First name: {person.Name}\n" +
                                                           $"Last name: {person.Surname}\n" +
                                                           $"Email: {person.Email}\n" +
                                                           $"Date of birth: {person.BirthDate}\n" +
                                                           $"Adult: {person.IsAdult}\n" +
                                                           $"Our Sign: {person.SunSign}\n" +
                                                           $"Chinese Sign: {person.ChineseSign}\n" +
                                                           $"{person}"
                                                       );

                           }, o => CanExecuteCommand()));
            }
        }

        private bool CanExecuteCommand()
        {
            return !string.IsNullOrWhiteSpace(_name) && !string.IsNullOrWhiteSpace(_surName) && !string.IsNullOrWhiteSpace(_email);
        }



        public event PropertyChangedEventHandler PropertyChanged;

        protected virtual void OnPropertyChanged([CallerMemberName] string propertyName = null)
        {
            PropertyChanged?.Invoke(this, new PropertyChangedEventArgs(propertyName));
        }



    }
}
