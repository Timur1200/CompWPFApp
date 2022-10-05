using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ComputerWPFApp.Model
{
    partial class DatabaseComputerEntities
    {
        private static DatabaseComputerEntities context;
        public static DatabaseComputerEntities GetContext()
        {
            if (context == null) context = new DatabaseComputerEntities();
            return context;
        }
    }
}
