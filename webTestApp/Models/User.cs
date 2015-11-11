using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace webTestApp.Models
{
    public class User
    {
        private int _id;
        private string _name;
        private string _username;
        private string _phone_number;
        private string _email_address;
        public bool _valid = false;
        public List<Module> ModuleList;
            
        #region c'tor
        public User( int id, string username, string phoneNumber, string emailAddress,
            string password)
        {
            User_Login lg = new User_Login(emailAddress,password);
            if(ValidateLogin(lg))
            {
                _valid = true;
            }
            _id = id;
            _username = username;
            _phone_number = phoneNumber;
        }
        #endregion

        #region Class Methods
        private Boolean ValidateLogin(User_Login lg)
        {
            return lg.isValid();
        }
        public string getUsername()
        {
            return _username;
        }
        public void addModule(Module mdl)
        {
            ModuleList.Add(mdl);
        }
        #endregion

    }
}