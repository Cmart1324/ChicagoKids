using DataLayer;

namespace LogicLayer
{
    public class Logic
    {
        DataL loginData = new DataL();

        #region validations
        public bool IsVaildLogin(string username, string password)
        {
            string outPut = "";
            outPut= IsPasswordVaild(password);
            outPut += IsUserNameVaild(username);

            if (outPut != "") return false;

            var userandPassword = CheckLogin(username);
            return userandPassword[0] == username && userandPassword[1]== password;
        }
      
        public string IsVaild(string firstName, string lastName,
                      string phoneNumber)
        {
            string badValationString = IsFirstNameVaild(firstName);
            badValationString += IsLastNameVaild(lastName);
            badValationString += IsPhoneNumberVaild(phoneNumber);

            return badValationString;
        }
     

        public string IsVaild(string firstName, string lastName,
                              string phoneNumber, string ageGroup,
                              string userName, string password,
                              string partentFirstName, string partentLastName,
                              string partentPhoneNumber, string signature)
        {
            string badValationString = IsFirstNameVaild(partentFirstName);
            badValationString += IsLastNameVaild(partentLastName);
            badValationString += IsPhoneNumberVaild(partentPhoneNumber);


            if (badValationString != "") return badValationString;

                badValationString = AddRegistor(firstName, lastName,
                phoneNumber, ageGroup,
                userName, password,
                partentFirstName, partentLastName,
                partentPhoneNumber, true);

            return badValationString;

        }
        public string IsVaild(string firstName, string lastName,
                           string phoneNumber, string ageGroup,
                           string userName, string password, string signature)
        {
            string badValationString = IsSignatureValid(signature);

            if (badValationString != "") return badValationString;

                badValationString = AddRegistor(firstName, lastName,
                phoneNumber, ageGroup,
                userName, password, true);

            return badValationString;
        }


        public string IsVaild(string firstName, string lastName, 
                              string phoneNumber, string ageGroup,
                              string userName, string password)
        {
            string badValationString = "";
            badValationString = IsFirstNameVaild(firstName);
            badValationString += IsLastNameVaild(lastName);
            badValationString += IsPhoneNumberVaild(phoneNumber);
            badValationString += IsUserNameVaild(userName);
            badValationString += IsPasswordVaild(password);

            if (badValationString != "") return badValationString;

            badValationString = !NeedParentInfo(ageGroup) ? "Now please Sign out waver" : "We need your parent information";

            return badValationString;
        }

        private string IsFirstNameVaild(string firstName)
        {
            return firstName == "" ? "Please enter a vaild first name /n" : "";
        }
       
        private string IsLastNameVaild(string lastName)
        {
            return lastName == "" ? "Please enter a vaild last name /n" : "";
        }

        private string IsPhoneNumberVaild(string PhoneNumber)
        {
            int lenghtOfPhone = PhoneNumber.Length;

            return lenghtOfPhone < 10 ? "Please enter a 10 degit phone number/n" : "";
        }

        private string IsUserNameVaild(string userName)
        {
            return userName == "" ? "Please enter a user name/n" : "";
        }

        private string IsPasswordVaild(string passWord)
        {
            return passWord == "" ? "Please enter a password/n" : "";
        } 

        private bool NeedParentInfo(string ageGroup)
        {
            return ageGroup.Contains("-");
        }

        private string IsSignatureValid(string signature)
        {
            return signature == "" ? "Please sign the signature text box." : "";
        }
        #endregion

        private string AddRegistor(string firstName, string lastName,
                                   string PhoneNumber, string ageGroup,
                                   string userName, string password, bool WaiverSigned)
        {
            string DidAddRegistor = "";

            return DidAddRegistor;
        }

        private string AddRegistor(string firstName, string lastName,
                    string PhoneNumber, string ageGroup,
                    string userName, string password, 
                    string PartentFirstName, string PartentLastName,
                    string PartentPhoneNumber,    bool WaiverSigned)
        {

            string DidAddRegistor = "";

            return DidAddRegistor;
        }

        private string[] CheckLogin(string theUserName)
        {
            string[] loginInfo;
            return loginInfo = loginData.CheckLogin(theUserName);
        }

        private void AddUser(string[] theUserLogin)
        {
            loginData.AddUserLogin(theUserLogin);
        }

        private void DeleteUserLogin(string theUserName)
        {
            loginData.RemoveUserLogin(theUserName);
        }

        private void ModifyUserLogin(string[] theUserLogin)
        {
            loginData.UpdateUserLogin(theUserLogin);
        }
    }
}
