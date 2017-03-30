using System;

namespace AbstractFactory
{
    class Program
    {
        static void Main(string[] args)
        {
            string database = "sqlserver";

            IRepository<Order> repository = null;

            switch (database)
            {
                case "sqlserver":
                    repository = new SQLServerRepository<Order>();
                    break;
                case "mongodb":
                    repository = new MongoDBRepository<Order>();
                    break;
                default:
                    throw new NotImplementedException();
            }

            repository.Add(new Order());
        }
    }
}
