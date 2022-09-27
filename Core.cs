using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Taxi
{
    public static class Core
    {
        public static MainWindow mainWindow;
        public static Пользователь currentUser;
        public static Сотрудник currentSotr;
        public static TaxDBEntities DB = new TaxDBEntities();
    }
}
