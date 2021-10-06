using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DependencyInversionPrinciple
{
    public class DAL
    {
        public string GetUser(int id)
        {
            return "Sajad Bagherzadeh";
        }
    }

    class Ora
    {
        public string GetUser(int id)
        {
            return "Sajad Bagherzadeh";
        }
    }
    public class BLL
    {
        private Ora _dal;

        public BLL()
        {
            _dal = new Ora();
        }

        public string GetUserBLL()
        {
            return _dal.GetUser(1);
        }
    }
    public class UI
    {
        private BLL _bll;

        public UI()
        {
            _bll = new BLL();
        }

        public void ShowUser()
        {
            Console.WriteLine(_bll.GetUserBLL());
        }
    }
}
