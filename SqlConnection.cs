using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DBConnectionExercise
{
    class SqlConnection : DbConnection
    {
        public SqlConnection(string connectStr)
            : base(connectStr)
        {
            
        }
        public override void Open()
        {
            Console.WriteLine("Opening the SQL DB Connection...");
        }

        public override void Close()
        {
            Console.WriteLine("Closing the SQL DB Connection");
        }
    }
}
