using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DependencyInversionPrinciple
{
    class Program
    {
        static void Main(string[] args)
        {
            UI ui = new UI();
            ui.ShowUser();

            Presentation presentation = new Presentation(new SqlRepository());
            presentation.ShowUser();
            Presentation presentation2 = new Presentation(new DataBaseRepository());
            presentation2.ShowUser();
            Presentation presentation3 = new Presentation(new MongoRepository());
            presentation3.ShowUser();
        }
    }
}
