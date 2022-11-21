namespace DesignPatterns.Proxy
{
    internal class Program
    {
        static void Main(string[] args)
        {
            var client = new Client(new ProxyService());
            client.DoStuff();
        }
    }

    public class Client
    {
        private readonly IService _service;

        public Client(IService service)
        {
            _service = service;
        }

        public void DoStuff()
        {
            _service.DoWork();
        }
    }

    public interface IService
    {
        void DoWork();
    }

    public class RealService : IService
    {
        public void DoWork()
        {
            Console.WriteLine("RealService:DoWork");
        }
    }

    public class ProxyService : IService
    {
        private readonly RealService _realService;

        public ProxyService() : this(new RealService())
        {
        }

        public ProxyService(RealService realService)
        {
            _realService = realService;
        }

        public void DoWork()
        {
            _realService.DoWork();
            Console.WriteLine("ProxyService:DoWork");
        }
    }
}