using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace webTestApp.Models
{
    public class Customer
    {
        private int _id;
        private string _name;
        private string _phoneNumber;
        private string _emailAddress;
        private string _password;
        public bool _valid;
        public List<SensorModule> SensorModule;
            
        #region c'tor
        public Customer( int id, string name, string phoneNumber, string emailAddress,
            string password)
        {
            _id = id;
            _name = name;
            _phoneNumber = phoneNumber;
            _emailAddress = emailAddress;
            if (ValidatePassword(password))
            {
                _password = password;
            }
        }
        #endregion

        #region Class Methods

        static bool ValidatePassword(string password)
        {
            const int MIN_LENGTH = 8;
            const int MAX_LENGTH = 15;

            if (password == null) throw new ArgumentNullException();

            bool meetsLengthRequirements = password.Length >= MIN_LENGTH && password.Length <= MAX_LENGTH;
            bool hasUpperCaseLetter = false;
            bool hasLowerCaseLetter = false;
            bool hasDecimalDigit = false;

            if (meetsLengthRequirements)
            {
                foreach (char c in password)
                {
                    if (char.IsUpper(c)) hasUpperCaseLetter = true;
                    else if (char.IsLower(c)) hasLowerCaseLetter = true;
                    else if (char.IsDigit(c)) hasDecimalDigit = true;
                }
            }

            bool isValid = meetsLengthRequirements
                        && hasUpperCaseLetter
                        && hasLowerCaseLetter
                        && hasDecimalDigit
                        ;
            return isValid;

        }

        #endregion

    }
}