using System;

namespace AbstractFactory
{
    class Program
    {
        static void Main(string[] args)
        {
            IContractFactory schoolFactory = new SchoolContractFactory();
            ContractClient client = new ContractClient(schoolFactory);

            Console.WriteLine(client.GetContractNumber());
            Console.WriteLine(client.GetPaperTitle());


            IContractFactory carFactory = new CarContractFactory();
            client = new ContractClient(carFactory);

            Console.WriteLine(client.GetContractNumber());
            Console.WriteLine(client.GetPaperTitle());


            //////////////////////////////////////////////////////////////////////////////////////////

            IAuthProviderFactory windowsFactory = new WindowsProvider();
            AuthClient aClient = new AuthClient(windowsFactory);

            Console.WriteLine(aClient.GetUserEmail());
            Console.WriteLine(aClient.GetUserFullName());
            Console.WriteLine(aClient.GetCredentialsUserName());
            Console.WriteLine(aClient.GetCredentialsAccessToken());
            Console.WriteLine(aClient.GetDataData());



            IAuthProviderFactory dbFactory = new DBProvider();
            aClient = new AuthClient(dbFactory);

            Console.WriteLine(aClient.GetUserEmail());
            Console.WriteLine(aClient.GetUserFullName());
            Console.WriteLine(aClient.GetCredentialsUserName());
            Console.WriteLine(aClient.GetCredentialsAccessToken());
            Console.WriteLine(aClient.GetDataData());




            IAuthProviderFactory otherFactory = new OtherProvider();
            aClient = new AuthClient(otherFactory);

            Console.WriteLine(aClient.GetUserEmail());
            Console.WriteLine(aClient.GetUserFullName());
            Console.WriteLine(aClient.GetCredentialsUserName());
            Console.WriteLine(aClient.GetCredentialsAccessToken());
            Console.WriteLine(aClient.GetDataData());
        }
    }
}



