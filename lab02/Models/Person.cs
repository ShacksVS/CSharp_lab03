using System;
using System.Collections.Generic;
using System.Text;

namespace lab02
{
    class Person
    {
        private string _firstName;
        private string _lastName;
        private string _fullName;
        private string _emailAdress;
        private DateTime _dateBirth;
        DateTime defaultDateBirth = new DateTime(2001, 01, 01);
        string defaultEmail = "empty@email.com";

        public string FirstName
        {
            get
            {
                return _firstName;
            }
            set
            {
                _firstName = value;
            }
        }

        public string LastName
        {
            get
            {
                return _lastName;
            }
            set
            {
                _lastName = value;
            }
        }

        public string FullName 
        {
            get
            {
                return _fullName;
            }
            set
            {
                _fullName = value;
            }

        }
        
        public string EmailAdress
        {
            get
            {
                return _emailAdress;
            }
            set
            {
                _emailAdress = value;
            }
        }
        public DateTime DateBirth
        {
            get
            {
                return _dateBirth.Date;
            }
            set
            {
                _dateBirth = value;
            }
        }

        public bool IsAdult
        {
            get
            {
                DateInfo di = new DateInfo();
                return di.IsAdult;
            }
        }

        public string ChineseSign
        {
            get
            {
                DateInfo di = new DateInfo();
                return di.ChineseSign;
                //return _chinesseSign;
            }
        }

        public string SunSign
        {
            get
            {
                DateInfo di = new DateInfo();
                return di.SunSign;
                //return _sunSign;
            }
        }

        public bool IsBirtday
        {
            get
            {
                DateInfo di = new DateInfo();
                return di.IsBirthday;
                //return _isBirthday;
            }
        }

        public Person()
        {

        }

        public Person(string firstName, string lastName, string emailAdress, DateTime dateBirth)
        {
            _firstName = firstName;
            _lastName = lastName;
            _emailAdress = emailAdress;
            _dateBirth = dateBirth;
        }

        public Person(string firstName, string lastName, string emailAdress)
        {
            _firstName = firstName;
            _lastName = lastName;
            _emailAdress = emailAdress;
            _dateBirth = defaultDateBirth;
        }

        public Person(string firstName, string lastName, DateTime dateBirth)
        {
            _firstName = firstName;
            _lastName = lastName;
            _emailAdress = defaultEmail;
            _dateBirth = dateBirth;
        }


    }
}