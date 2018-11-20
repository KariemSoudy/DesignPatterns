namespace AbstractFactory
{
    //abstract factory
    public interface IAuthProviderFactory
    {
        IUser GetUser();
        ICredentials GetCredentials();
        IData GetData();
    }
    //concrete factories
    public class WindowsProvider : IAuthProviderFactory
    {
        public ICredentials GetCredentials()
        {
            return new WindowsCredentials();
        }

        public IData GetData()
        {
            return new WindowsData();
        }

        public IUser GetUser()
        {
            return new WindowsUser();
        }
    }
    public class DBProvider : IAuthProviderFactory
    {
        public ICredentials GetCredentials()
        {
            return new DBCredentials();
        }

        public IData GetData()
        {
            return new DBData();
        }

        public IUser GetUser()
        {
            return new DBUser();
        }
    }
    public class OtherProvider : IAuthProviderFactory
    {
        public ICredentials GetCredentials()
        {
            return new OtherCredentials();
        }

        public IData GetData()
        {
            return new OtherData();
        }

        public IUser GetUser()
        {
            return new OtherUser();
        }
    }


    //abstract product
    public interface IUser
    {
        string GetFullName();
        string GetEmail();
    }
    //products
    public class WindowsUser : IUser
    {
        public string GetEmail()
        {
            return "Windows User Email";
        }

        public string GetFullName()
        {
            return "Windows User Full Name";
        }
    }
    public class DBUser : IUser
    {
        public string GetEmail()
        {
            return "DB User Email";
        }

        public string GetFullName()
        {
            return "DB User Full Name";
        }
    }
    public class OtherUser : IUser
    {
        public string GetEmail()
        {
            return "Other User Email";
        }

        public string GetFullName()
        {
            return "Other User Full Name";
        }
    }


    //abstract product
    public interface ICredentials
    {
        string GetUserName();
        string GetAccessToken();
    }
    //products
    public class WindowsCredentials : ICredentials
    {
        public string GetAccessToken()
        {
            return "Windows Credentials Token";
        }

        public string GetUserName()
        {
            return "Windows Credentials User Name";
        }
    }
    public class DBCredentials : ICredentials
    {
        public string GetAccessToken()
        {
            return "DB Credentials Token";
        }

        public string GetUserName()
        {
            return "DB Credentials User Name";
        }
    }
    public class OtherCredentials : ICredentials
    {
        public string GetAccessToken()
        {
            return "Other Credentials Token";
        }

        public string GetUserName()
        {
            return "Other Credentials User Name";
        }
    }


    //abstract product
    public interface IData
    {
        string GetData();
    }
    //products
    internal class WindowsData : IData
    {
        public string GetData()
        {
            return "Windows Data";
        }
    }
    internal class DBData : IData
    {
        public string GetData()
        {
            return "DB Data";
        }
    }
    internal class OtherData : IData
    {
        public string GetData()
        {
            return "Other Data";
        }
    }


    //client
    public class AuthClient
    {
        IUser user;
        ICredentials credentials;
        IData data;

        public AuthClient(IAuthProviderFactory _factory)
        {
            user = _factory.GetUser();
            credentials = _factory.GetCredentials();
            data = _factory.GetData();
        }


        public string GetUserEmail() { return user.GetEmail(); }
        public string GetUserFullName() { return user.GetFullName(); }

        public string GetCredentialsUserName() { return credentials.GetUserName(); }
        public string GetCredentialsAccessToken() { return credentials.GetAccessToken(); }

        public string GetDataData() { return data.GetData(); }
    }

}
