using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DependencyInversionPrinciple
{
    public interface IDataBaseRepository
    {
        string GetUser();
    }
    public class DataBaseRepository: IDataBaseRepository
    {
        public string GetUser()
        {
            return "Sajad Bagherzadeh (DI) ";
        }
    }

    public class SqlRepository : IDataBaseRepository
    {
        public string GetUser()
        {
            return "Sajad Bagherzadeh (SQL) ";
        }
    }
    public class MongoRepository : IDataBaseRepository
    {
        public string GetUser()
        {
            return "Sajad Bagherzadeh (Mongo) ";
        }
    }

    public class Presentation
    {
        private IDataBaseRepository _dataBaseRepository;

        public Presentation(IDataBaseRepository dataBaseRepository)
        {
            _dataBaseRepository = dataBaseRepository;
        }

        public void ShowUser()
        {
            Console.WriteLine(_dataBaseRepository.GetUser());
        }
    }
}
