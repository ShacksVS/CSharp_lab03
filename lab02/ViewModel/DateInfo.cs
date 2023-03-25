﻿using System;
using System.Windows;
using System.ComponentModel;
using System.Windows.Input;
using System.Threading;
using System.Threading.Tasks;
using System.Runtime.CompilerServices;
using CSharp_lab02;
using System.Windows.Media.Animation;
using System.Text.RegularExpressions;
using System.Linq;

namespace lab02
{
    public class DateInfo : INotifyPropertyChanged, ILoaderOwner
    {
        #region Fields
        private Person _person = new Person();
        private DateTime selectedDateFromUser;
        private RelayCommand<object> _proceedCommand;
        private RelayCommand<object> _exitCommand;
        private bool _isAdult;
        private string _sunSign;
        private string _chinesseSign;
        private bool _isBirthday;
        private int _age;
        private string _email;
        private bool _isEnabled = true;
        private Visibility _loaderVisibility = Visibility.Collapsed;

        public bool IsEnabled
        {
            get
            {
                return _isEnabled;
            }
            set
            {
                _isEnabled = value;
                OnPropertyChanged();
            }
        }

        public Visibility LoaderVisibility
        {
            get
            {
                return _loaderVisibility;
            }
            set
            {
                _loaderVisibility = value;
                OnPropertyChanged();
            }
        }
#endregion
        public string FirstName
        {
            get
            {
                return _person.FirstName;
            }
            set
            {
                _person.FirstName = value;
                OnPropertyChanged();
            }
        }
        public string LastName
        {
            get
            {
                return _person.LastName;
            }
            set
            {
                _person.LastName = value;
                OnPropertyChanged();
            }
        }
        public string FullName
        {
            set
            {
                _person.FullName = value;
                OnPropertyChanged();
            }
            get
            {
                return _person.FullName;
            }
        }

        public DateTime DateBirth
        {
            get
            {
                return _person.DateBirth.Date;
            }
            set
            {
                _person.DateBirth = value;
                OnPropertyChanged();

            }
        }

        public bool IsAdult
        {
            get
            {
                return _age >= 18;
            }
            set
            {
                _isAdult = value;
            }
        }

        public bool IsBirthday
        {
            get
            {
                return _isBirthday;
            }
            set
            {
                _isBirthday = value;
            }
        }

        public string SunSign
        {
            get
            {
                return _sunSign;
            }
            set
            {
                _sunSign = value;
                OnPropertyChanged();
            }
        }

        public string ChineseSign
        {
            get
            {
                return _chinesseSign;
            }
            set
            {
                _chinesseSign = value;
                OnPropertyChanged();
            }
        }

        public string EmailAdress
        {
            get
            {
                return _person.EmailAdress;
            }
            set
            {
                _person.EmailAdress = value;
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

        public int Age
        {
            get
            {
                return _age;
            }
            set
            {
                _age = value;
                OnPropertyChanged();
            }
        }
        private bool CanExecute(object obj)
        {
            return !String.IsNullOrWhiteSpace(_person.FirstName) && !String.IsNullOrWhiteSpace(_person.LastName) && !String.IsNullOrWhiteSpace(_person.EmailAdress);
        }

        enum WestSigns
        {
            Aries = 1,
            Taurus,
            Gemini,
            Cancer,
            Leo,
            Virgo,
            Libra,
            Scorpio,
            Sagittarius,
            Capricorn,
            Aquarius,
            Pisces
        }

        enum EastSigns
        {
            Rat = 1,
            Ox,
            Tiger,
            Rabbit,
            Dragon,
            Snake,
            Horse,
            Goat,
            Monkey,
            Rooster,
            Dog,
            Pig
        }

        public DateTime SelectedDateFromUser
        {
            get
            {
                return selectedDateFromUser;
            }
            set
            {
                selectedDateFromUser = value;
            }
        }

        public void showEmail()
        {
            Thread.Sleep(1000);
            Email = _person.EmailAdress;
        }
        public void showDatebirth()
        {
            Thread.Sleep(1000);
            DateBirth = selectedDateFromUser.Date;
        }

        public void showFullName()
        {
            Thread.Sleep(1000);
            FullName = $"{_person.FirstName} {_person.LastName}";
        }
        public void countAgeOfUser()
        {
            Thread.Sleep(1000);
            DateTime? todayDate = DateTime.Today;
            int age = todayDate.Value.Year - selectedDateFromUser.Year;
            if ((todayDate.Value.Day < selectedDateFromUser.Day && todayDate.Value.Month == selectedDateFromUser.Month) || (todayDate.Value.Month < selectedDateFromUser.Month))
            {
                age--;
            }
            Age = age;
        }

        public void countWestAstroSign()
        {
            Thread.Sleep(1000);
            int month = SelectedDateFromUser.Month;
            int day = SelectedDateFromUser.Day;
            WestSigns astroSign;
            if ((month == 3 && day >= 21) || (month == 4 && day <= 20))
            {
                astroSign = WestSigns.Aries;
            }
            else if ((month == 4 && day >= 21) || (month == 5 && day <= 21))
            {
                astroSign = WestSigns.Taurus;
            }
            else if ((month == 5 && day >= 22) || (month == 6 && day <= 21))
            {
                astroSign = WestSigns.Gemini;
            }
            else if ((month == 6 && day >= 22) || (month == 7 && day <= 22))
            {
                astroSign = WestSigns.Cancer;
            }
            else if ((month == 7 && day >= 23) || (month == 8 && day <= 22))
            {
                astroSign = WestSigns.Leo;
            }
            else if ((month == 8 && day >= 23) || (month == 9 && day <= 22))
            {
                astroSign = WestSigns.Virgo;
            }
            else if ((month == 9 && day >= 23) || (month == 10 && day <= 22))
            {
                astroSign = WestSigns.Libra;
            }
            else if ((month == 10 && day >= 23) || (month == 11 && day <= 22))
            {
                astroSign = WestSigns.Scorpio;
            }
            else if ((month == 11 && day >= 23) || (month == 12 && day <= 21))
            {
                astroSign = WestSigns.Sagittarius;
            }
            else if ((month == 12 && day >= 22) || (month == 1 && day <= 19))
            {
                astroSign = WestSigns.Capricorn;
            }
            else if ((month == 1 && day >= 20) || (month == 2 && day <= 18))
            {
                astroSign = WestSigns.Aquarius;
            }
            else
            {
                astroSign = WestSigns.Pisces;
            }
            SunSign = astroSign.ToString();
        }

        public void countEastAstroSign()
        {
            Thread.Sleep(1000);
            int numOfSign = (SelectedDateFromUser.Year - 1900) % 12 + 1;
            EastSigns astroSign = (EastSigns)numOfSign;
            ChineseSign = astroSign.ToString();
        }

        public void isBirtDayToday()
        {
            Thread.Sleep(1000);
            DateTime todayDate = DateTime.Today;
            if (selectedDateFromUser.Day == todayDate.Day && selectedDateFromUser.Month == todayDate.Month)
            {
                MessageBox.Show("Happy Birthady! Be Happy and free!");
                IsBirthday = true;
                return;
            }
            else IsBirthday = false;
        }


        public bool dateValid()
        {
            DateTime todayDate = DateTime.Today;
            int difference = todayDate.Year - SelectedDateFromUser.Year;
            Regex regex = new Regex("^\\S+@\\S+\\.\\S+$");
            if (difference > 135)
            {
                throw new CSharp_lab02.Tools.Exceptions.DateFarInPast(difference);
            }
            else if (difference < 0)
            {
                throw new CSharp_lab02.Tools.Exceptions.DateInFuture(difference);
            }
            
            else if (_person.FirstName.Any(char.IsDigit) || _person.LastName.Any(char.IsDigit))
            {
                throw new CSharp_lab02.Tools.Exceptions.BadName(_person.EmailAdress);
            }
            else if (!regex.IsMatch(_person.EmailAdress))
            {
                throw new CSharp_lab02.Tools.Exceptions.WrongEmail(_person.EmailAdress);
            }

            return true;
        }

        private async void proceed()
        {
            bool flag = false;
            try
            {
                flag = dateValid();
            }
            catch (Exception ex)
            {
                if (ex is CSharp_lab02.Tools.Exceptions.DateFarInPast || ex is CSharp_lab02.Tools.Exceptions.DateInFuture || ex is CSharp_lab02.Tools.Exceptions.WrongEmail || ex is CSharp_lab02.Tools.Exceptions.BadName)
                {
                    MessageBox.Show($"Exception: {ex.Message}");
                }
            }
            
            if (flag)
            {
                try
                {
                    await Task.Run(() => countAgeOfUser());
                    await Task.Run(() => showDatebirth());
                    await Task.Run(() => showFullName());
                    await Task.Run(() => showEmail());
                    await Task.Run(() => countWestAstroSign());
                    await Task.Run(() => countEastAstroSign());
                    await Task.Run(() => isBirtDayToday());

                }
                catch (Exception ex)
                {
                    MessageBox.Show($"Something went wrong: {ex.Message}");
                    return;
                }
            }
        }

        public RelayCommand<object> ProceedCommand
        {
            get
            {
                return _proceedCommand ?? new RelayCommand<object>(_ => proceed(), CanExecute);
            }
        }

        public RelayCommand<object> ExitCommand
        {
            get
            {
                return _exitCommand ??= new RelayCommand<object>(_ => Environment.Exit(0));
            }
        }



        public event PropertyChangedEventHandler PropertyChanged;

        protected virtual void OnPropertyChanged([CallerMemberName] string propertyName = null)
        {
            PropertyChanged?.Invoke(this, new PropertyChangedEventArgs(propertyName));
        }


    }
}
