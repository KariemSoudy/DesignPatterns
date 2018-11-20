namespace AbstractFactory
{
    //abstract factory
    public interface IContractFactory
    {
        IContract CreateContract();
        IPaper CreatePaper();
    }
    //concrete factories
    public class SchoolContractFactory : IContractFactory
    {
        public IContract CreateContract()
        {
            return new SchoolContract();
        }

        public IPaper CreatePaper()
        {
            return new SchoolPaper();
        }
    }
    public class CarContractFactory : IContractFactory
    {
        public IContract CreateContract()
        {
            return new CarContract();
        }

        public IPaper CreatePaper()
        {
            return new CarPaper();
        }
    }


    //abstract product
    public interface IContract
    {
        string GetContractNumber();
    }
    //products
    public class SchoolContract : IContract
    {
        public string GetContractNumber()
        {
            return "School Contract";
        }
    }
    public class CarContract : IContract
    {
        public string GetContractNumber()
        {
            return "Car Contract";
        }
    }


    //abstract product
    public interface IPaper
    {
        string GetPaperTitle();
    }
    //products
    public class SchoolPaper : IPaper
    {
        public string GetPaperTitle()
        {
            return "School Paper";
        }
    }
    public class CarPaper : IPaper
    {
        public string GetPaperTitle()
        {
            return "Car Paper";
        }
    }


    public class ContractClient
    {
        IContract contract;
        IPaper paper;

        public ContractClient(IContractFactory factory)
        {
            contract = factory.CreateContract();
            paper = factory.CreatePaper();
        }

        public string GetContractNumber()
        {
            return contract.GetContractNumber();
        }

        public string GetPaperTitle()
        {
            return paper.GetPaperTitle();
        }
    }
}
