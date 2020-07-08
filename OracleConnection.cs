using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DBConnectionExercise
{
    class OracleConnection : DbConnection
    {
        public OracleConnection(string connectStr)
            : base(connectStr)
        {

        }
        public override void Open()
        {
            Console.WriteLine("Opening the Oracle DB Connection...");
        }

        public override void Close()
        {
            Console.WriteLine("Closing the Oracle DB Connection");
        }
    }
}
